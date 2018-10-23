using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using DomusSharedClasses;
using MetroFramework;
using MetroFramework.Components;

namespace DomusClient
{
    public partial class MainForm : MetroForm
    {
        private LoginForm _loginForm;
        private ManageUsersForm _manageUsersForm;
        private ManageDevicesForm _manageDevicesForm;
        private ConfigForm _configForm;
        private CisternConfigForm _cisternConfigForm;
        private WaterConsumeForm _waterConsumeForm;
        private IrrigationConfigForm _irrigationConfigForm;
        private Thread _worker;
        public User User;
        private WeatherData _weather;

        public MainForm()
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                //inicializa a classe de conexão com o servidor
                ServerHandler.Initialize();
            }
            catch (SocketException exception)
            {
                MetroMessageBox.Show(this,
                    "Não foi possivel conectar ao servidor.\r\n" + exception.SocketErrorCode + " - " +
                    exception.Message,
                    "Domus Client - Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    150);

                this.Close();
            }
            catch (Exception exception)
            {
                MetroMessageBox.Show(this,
                    "Não foi possivel conectar ao servidor.\r\n" + exception.Message,
                    "Domus Client - Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    150);

                this.Close();
            }

            _loginForm = new LoginForm();

            _loginForm.ShowDialog();

            _loginForm.Dispose();

            if (User == null) //se o login falhar encerra o programa
            {
                this.Close();
            }
            else
            {
                _worker = new Thread(GetWeatherThread);
                _worker.IsBackground = true;
                _worker.Start();
            }

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                ServerHandler.ServerWrite(ServerHandler.Stream, "<exit>");
                ServerHandler.Dispose();
            }
            catch
            {

            }

        }

        private void GetWeatherThread()
        {
            StartSpinner();

            SetSpinnerValue(1);

            try
            {
                ServerHandler.ServerWrite(ServerHandler.Stream, "GetWeather");

                _weather = (WeatherData) ServerHandler.ServerReadSerilized(ServerHandler.Stream, 60000);

                Invoke(new Action(() =>
                    {
                        lb_forecastLocation.Text = _weather.LocationCity + "," + _weather.LocationCountry;
                        lb_forecastMaxValue.Text = _weather.MaxTemperature + " °C";
                        lb_forecastMinValue.Text = _weather.MinTemperature + " °C";
                        lb_humidityValue.Text = _weather.Humidity + " %";
                        lb_ImageDescription.Text = _weather.IconDescription;
                        lb_temperatureValue.Text = _weather.Temperature + " °C";

                        pb_forecast.Load("http://openweathermap.org/img/w/" + _weather.IconValue + ".png");

                    }));

                SetSpinnerValue(4);
            }
            catch
            {
                Invoke(new Action(() =>
                {
                    pb_warning.Visible = true;

                    MetroToolTip toolTip = new MetroToolTip();

                    toolTip.AutoPopDelay = 5000;
                    toolTip.InitialDelay = 1000;
                    toolTip.ReshowDelay = 500;

                    toolTip.ShowAlways = true;

                    toolTip.SetToolTip(pb_warning, "Falha ao obter condições meteorológicas.\r\nClique para tentar novamente.");
                }));
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

                    bt_cistern.Enabled = false;
                    bt_devices.Enabled = false;
                    bt_energy.Enabled = false;
                    bt_irrigation.Enabled = false;
                    bt_plugs.Enabled = false;
                    bt_settings.Enabled = false;
                    bt_users.Enabled = false;
                    bt_wather.Enabled = false;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = true;
                pb_spinner.Enabled = true;

                bt_cistern.Enabled = false;
                bt_devices.Enabled = false;
                bt_energy.Enabled = false;
                bt_irrigation.Enabled = false;
                bt_plugs.Enabled = false;
                bt_settings.Enabled = false;
                bt_users.Enabled = false;
                bt_wather.Enabled = false;
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


                    if (User.IsAdmin)
                    {
                        bt_users.Enabled = true;
                        bt_cistern.Enabled = true;
                        bt_devices.Enabled = true;
                        bt_irrigation.Enabled = true;

                    }

                    bt_energy.Enabled = true;
                    bt_plugs.Enabled = true;
                    bt_settings.Enabled = true;
                    bt_wather.Enabled = true;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = false;
                pb_spinner.Enabled = false;

                if (User.IsAdmin)
                {
                    bt_users.Enabled = true;
                    bt_cistern.Enabled = true;
                    bt_devices.Enabled = true;
                    bt_irrigation.Enabled = true;
                }

                bt_energy.Enabled = true;
                bt_plugs.Enabled = true;
                bt_settings.Enabled = true;
                bt_wather.Enabled = true;
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

        private void bt_devices_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<ManageDevicesForm>().Any())//verifica se ja existe uma aba aberta
            {
                _manageDevicesForm = new ManageDevicesForm();//cria o form
                int x = this.Left + (this.Width / 2) - (_manageDevicesForm.Width / 2);
                int y = this.Top + (this.Height / 2) - (_manageDevicesForm.Height / 2);

                _manageDevicesForm.Location = new Point(x, y);//seta a posição do formulario filho

                _manageDevicesForm.Show();//mostra o formulario
            }
            else
            {
                _manageDevicesForm.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_users_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<ManageUsersForm>().Any())//verifica se ja existe uma aba aberta
            {
                _manageUsersForm = new ManageUsersForm();//cria o form
                int x = this.Left + (this.Width / 2) - (_manageUsersForm.Width / 2);
                int y = this.Top + (this.Height / 2) - (_manageUsersForm.Height / 2);

                _manageUsersForm.Location = new Point(x, y);//seta a posição do formulario filho

                _manageUsersForm.Show();//mostra o formulario
            }
            else
            {
                _manageUsersForm.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }

        private void bt_settings_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<ConfigForm>().Any())//verifica se ja existe uma aba aberta
            {
                _configForm = new ConfigForm();//cria o form
                int x = this.Left + (this.Width / 2) - (_configForm.Width / 2);
                int y = this.Top + (this.Height / 2) - (_configForm.Height / 2);

                _configForm.Location = new Point(x, y);//seta a posição do formulario filho

                _configForm.Show();//mostra o formulario
            }
            else
            {
                _configForm.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }

        private void bt_cistern_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<ConfigForm>().Any())//verifica se ja existe uma aba aberta
            {
                _cisternConfigForm = new CisternConfigForm();//cria o form
                int x = this.Left + (this.Width / 2) - (_cisternConfigForm.Width / 2);
                int y = this.Top + (this.Height / 2) - (_cisternConfigForm.Height / 2);

                _cisternConfigForm.Location = new Point(x, y);//seta a posição do formulario filho

                _cisternConfigForm.Show();//mostra o formulario
            }
            else
            {
                _cisternConfigForm.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }

        private void bt_irrigation_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<IrrigationConfigForm>().Any())//verifica se ja existe uma aba aberta
            {
                _irrigationConfigForm = new IrrigationConfigForm();//cria o form
                int x = this.Left + (this.Width / 2) - (_irrigationConfigForm.Width / 2);
                int y = this.Top + (this.Height / 2) - (_irrigationConfigForm.Height / 2);

                _irrigationConfigForm.Location = new Point(x, y);//seta a posição do formulario filho

                _irrigationConfigForm.Show();//mostra o formulario
            }
            else
            {
                _irrigationConfigForm.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }

        private void bt_wather_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<WaterConsumeForm>().Any())//verifica se ja existe uma aba aberta
            {
                _waterConsumeForm = new WaterConsumeForm();//cria o form
                int x = this.Left + (this.Width / 2) - (_waterConsumeForm.Width / 2);
                int y = this.Top + (this.Height / 2) - (_waterConsumeForm.Height / 2);

                _waterConsumeForm.Location = new Point(x, y);//seta a posição do formulario filho

                _waterConsumeForm.Show();//mostra o formulario
            }
            else
            {
                _waterConsumeForm.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }

        private void llb_about_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Desenvolvido por Kauê S. Zatarin\r\nTCC - Ciências da Computação\r\nEscola de Engenharia de Piracicaba - EEP", 
                "Domus Client", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information,
                180);
        }

        private void pb_warning_Click(object sender, EventArgs e)
        {
            pb_warning.Visible = false;
            _worker = new Thread(GetWeatherThread);
            _worker.IsBackground = true;
            _worker.Start();
        }
    }
}
