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
using DomusSharedClasses;
using MetroFramework.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using MetroFramework;

namespace DomusClient
{
    public partial class WaterConsumeForm : MetroForm
    {
        private Thread _workerThread;

        public WaterConsumeForm()
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;

        }

        private void WaterConsumeForm_Load(object sender, EventArgs e)
        {
            np_year.Text = DateTime.Now.Year.ToString();

            _workerThread = new Thread(() => PopulateThread(DateTime.Now.Year));
            _workerThread.Start();

            StartSpinner();
        }

        private void PopulateThread(int year)
        {
            SetSpinnerValue(1);
            List<WaterConsumeData> waterConsumeDatas;

            try
            {
                Invoke(new Action(() => { year = Convert.ToInt32(np_year.Text); }));

                ServerHandler.ServerWrite(ServerHandler.Stream, "GetWaterConsume;"+ year);

                waterConsumeDatas = (List<WaterConsumeData>)ServerHandler.ServerReadSerilized(ServerHandler.Stream, 30000);

                Invoke(new Action(() => { InitializeChart(waterConsumeDatas); }));

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

        private void InitializeChart(List<WaterConsumeData> values)
        {
            List<string> months = new List<string>(){ "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};

            WaterConsumeChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Consumo",
                    Values = new ChartValues<double>()
                }
            };

            WaterConsumeChart.AxisX.Clear();

            WaterConsumeChart.AxisX.Add(new Axis
            {
                Title = "Mês",
                Labels = new List<string>()
            });

            WaterConsumeChart.AxisY.Clear();

            WaterConsumeChart.AxisY.Add(new Axis
            {
                Title = "Litros",
                LabelFormatter = value => value.ToString("C")
            });

            foreach (WaterConsumeData value in values)
            {
                WaterConsumeChart.Series[0].Values.Add(value.Value);
                WaterConsumeChart.AxisX[0].Labels.Add(months[value.Month - 1]);
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
                    bt_applyDate.Enabled = false;
                    np_year.Enabled = false;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = true;
                pb_spinner.Enabled = true;
                bt_applyDate.Enabled = false;
                np_year.Enabled = false;
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
                    bt_applyDate.Enabled = true;
                    np_year.Enabled = true;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = false;
                pb_spinner.Enabled = false;
                bt_applyDate.Enabled = true;
                np_year.Enabled = true;
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

        private void bt_applyDate_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(np_year.Text);

            _workerThread = new Thread(() => PopulateThread(year));
            _workerThread.Start();

            StartSpinner();
        }
    }
}
