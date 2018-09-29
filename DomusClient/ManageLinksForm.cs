using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using DomusSharedClasses;
using MetroFramework;

namespace DomusClient
{
    public partial class ManageLinksForm : MetroForm
    {
        private Thread _workerThread;
        private LinkDeviceForm _linkDeviceForm;

        public ManageLinksForm()
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;
        }

        private void ManageLinksForm_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            _workerThread = new Thread(PopulateGridThread);
            _workerThread.Start();

            StartSpinner();
        }

        private void PopulateGridThread()
        {
            List<Service> services;

            SetSpinnerValue(1);

            try
            {
                ServerHandler.ServerWrite(ServerHandler.Stream, "ListServices");

                services = (List<Service>)ServerHandler.ServerReadSerilized(ServerHandler.Stream, 30000);

                Invoke(new Action(() =>
                {
                    dtg_services.DataSource = services;

                    //modifica o nome das colunas
                    dtg_services.Columns[0].HeaderText = "Id";
                    dtg_services.Columns[1].HeaderText = "Serviço";
                    dtg_services.Columns[2].HeaderText = "Sensor?";
                    dtg_services.Columns[3].HeaderText = "Id do Dispositivo";
                    dtg_services.Columns[4].HeaderText = "Porta do Dispositivo";

                    dtg_services.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
                }));

            }
            catch (Exception exception)
            {
                MetroMessageBox.Show(this, "Não foi possivel recuperar os dados.\r\n" + exception.Message,
                    "Domus Client - Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    150);
            }

            ResetSpinner();
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
                    bt_configLink.Enabled = false;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = true;
                pb_spinner.Enabled = true;
                bt_configLink.Enabled = false;
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
                    bt_configLink.Enabled = true;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = false;
                pb_spinner.Enabled = false;
                bt_configLink.Enabled = true;
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

        private void bt_configLink_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<LinkDeviceForm>().Any())//verifica se ja existe uma aba aberta
            {
                _linkDeviceForm = new LinkDeviceForm(dtg_services.CurrentRow.DataBoundItem as Service);//cria o form
                int x = this.Left + (this.Width / 2) - (_linkDeviceForm.Width / 2);
                int y = this.Top + (this.Height / 2) - (_linkDeviceForm.Height / 2);

                _linkDeviceForm.Location = new Point(x, y);//seta a posição do formulario filho

                _linkDeviceForm.Show();//mostra o formulario
            }
            else
            {
                MetroMessageBox.Show(this, "Só é possivel realizar uma configuração por vez.",
                    "Domus Client - Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    150);

                _linkDeviceForm.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }
    }
}
