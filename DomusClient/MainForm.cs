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
        private LoginForm loginForm;
        private ManageUsersForm manageUsersForm;
        private ManageDevicesForm manageDevicesForm;
        private ConfigForm configForm;
        private Thread worker;
        public User user;
        private WeatherData weather;


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

            loginForm = new LoginForm();

            loginForm.ShowDialog();

            loginForm.Dispose();

            if (user == null) //se o login falhar encerra o programa
            {
                this.Close();
            }
            else
            {
                worker = new Thread(GetWeatherThread);
                worker.IsBackground = true;
                worker.Start();
            }

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                ServerHandler.ServerWrite(ServerHandler.stream, "<exit>");
                ServerHandler.Dispose();
            }
            catch
            {

            }

        }

        private void GetWeatherThread()
        {
            startSpinner();

            setSpinnerValue(1);

            try
            {
                ServerHandler.ServerWrite(ServerHandler.stream, "GetWeather");

                weather = (WeatherData) ServerHandler.ServerReadSerilized(ServerHandler.stream, 60000);

                Invoke(new Action(() =>
                    {
                        lb_forecastLocation.Text = weather.LocationCity + "," + weather.LocationCountry;
                        lb_forecastMaxValue.Text = weather.MaxTemperature + " °C";
                        lb_forecastMinValue.Text = weather.MinTemperature + " °C";
                        lb_humidityValue.Text = weather.Humidity + " %";
                        lb_ImageDescription.Text = weather.IconDescription;
                        lb_temperatureValue.Text = weather.Temperature + " °C";

                        pb_forecast.Load("http://openweathermap.org/img/w/" + weather.IconValue + ".png");

                    }));

                setSpinnerValue(4);
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

                /*MetroMessageBox.Show(this,
                    "Não foi possivel resgatar a previsão do tempo.\r\n" + exception.Message,
                    "Domus Client - Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    150);*/
            }

            resetSpinner();
        }

        private void startSpinner()
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

        private void resetSpinner()
        {
            if (pb_spinner.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    pb_spinner.Value = 0;
                    pb_spinner.Visible = false;
                    pb_spinner.Enabled = false;


                    if (user.isAdmin)
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

                if (user.isAdmin)
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

        private void setSpinnerValue(int value)
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
            if (Application.OpenForms.OfType<ManageDevicesForm>().Count() == 0)//verifica se ja existe uma aba aberta
            {
                manageDevicesForm = new ManageDevicesForm();//cria o form
                int x = this.Left + (this.Width / 2) - (manageDevicesForm.Width / 2);
                int y = this.Top + (this.Height / 2) - (manageDevicesForm.Height / 2);

                manageDevicesForm.Location = new Point(x, y);//seta a posição do formulario filho

                manageDevicesForm.Show();//mostra o formulario
            }
            else
            {
                manageDevicesForm.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_users_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ManageUsersForm>().Count() == 0)//verifica se ja existe uma aba aberta
            {
                manageUsersForm = new ManageUsersForm();//cria o form
                int x = this.Left + (this.Width / 2) - (manageUsersForm.Width / 2);
                int y = this.Top + (this.Height / 2) - (manageUsersForm.Height / 2);

                manageUsersForm.Location = new Point(x, y);//seta a posição do formulario filho

                manageUsersForm.Show();//mostra o formulario
            }
            else
            {
                manageUsersForm.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }

        private void bt_settings_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ConfigForm>().Count() == 0)//verifica se ja existe uma aba aberta
            {
                configForm = new ConfigForm();//cria o form
                int x = this.Left + (this.Width / 2) - (configForm.Width / 2);
                int y = this.Top + (this.Height / 2) - (configForm.Height / 2);

                configForm.Location = new Point(x, y);//seta a posição do formulario filho

                configForm.Show();//mostra o formulario
            }
            else
            {
                configForm.Focus();//caso a janela ja esteja aberta, foca na mesma
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
            worker = new Thread(GetWeatherThread);
            worker.IsBackground = true;
            worker.Start();
        }
    }
}
