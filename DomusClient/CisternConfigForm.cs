﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using DomusSharedClasses;
using MetroFramework;

namespace DomusClient
{
    public partial class CisternConfigForm : MetroForm
    {
        private Thread _workerThread;
        private CisternConfig config;

        public CisternConfigForm()
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;
        }

        private void CisternConfigForm_Load(object sender, EventArgs e)
        {
            _workerThread = new Thread(LoadConfigsFromServer);
            _workerThread.Start();

            StartSpinner();
        }

        private void LoadConfigsFromServer()
        {
            try
            {
                SetSpinnerValue(2);

                ServerHandler.ServerWrite(ServerHandler.Stream, "GetCisternConfig");

                config = (CisternConfig)ServerHandler.ServerReadSerilized(ServerHandler.Stream, 10000);

                SetSpinnerValue(3);

                Invoke(new Action(() =>
                {
                    np_rainTime.Value = config.TimeOfRain;
                    trb_minLevel.Value = config.MinWaterLevel;
                    lb_levelValue.Text = trb_minLevel.Value + @"%";
                    listb_action.SelectedIndex = config.MinLevelAction;
                }));

                SetSpinnerValue(4);

                ResetSpinner();
            }
            catch
            {
                MetroMessageBox.Show(this, "Erro ao obter configurações do servidor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);

                Invoke(new Action(() =>
                {
                    Application.OpenForms.OfType<CisternConfigForm>().First().Close();
                }));
            }
        }

        private void StartSpinner()
        {
            if (pb_spinner.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    pb_spinner.Value = 0;
                    pb_spinner.Visible = true;
                    pb_spinner.Enabled = true;

                    bt_save.Enabled = false;
                    listb_action.Enabled = false;
                    trb_minLevel.Enabled = false;
                    np_rainTime.Enabled = false;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = true;
                pb_spinner.Enabled = true;

                bt_save.Enabled = false;
                listb_action.Enabled = false;
                trb_minLevel.Enabled = false;
                np_rainTime.Enabled = false;
            }
        }

        private void ResetSpinner()
        {
            if (pb_spinner.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    pb_spinner.Value = 0;
                    pb_spinner.Visible = false;
                    pb_spinner.Enabled = false;

                    bt_save.Enabled = true;
                    listb_action.Enabled = true;
                    trb_minLevel.Enabled = true;
                    np_rainTime.Enabled = true;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = false;
                pb_spinner.Enabled = false;

                bt_save.Enabled = true;
                listb_action.Enabled = true;
                trb_minLevel.Enabled = true;
                np_rainTime.Enabled = true;
            }
        }

        private void SetSpinnerValue(int value)
        {
            if (pb_spinner.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    pb_spinner.Value = value;
                }));
            }
            else
            {
                pb_spinner.Value = value;
            }
        }

        private void trb_minLevel_ValueChanged(object sender, EventArgs e)
        {
            lb_levelValue.Text = ((MetroTrackBar)sender).Value + @"%";
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {

        }
    }
}
