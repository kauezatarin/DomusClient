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
    public partial class ManageDevicesForm : MetroForm
    {
        private Thread _workerThread;
        private EditDevicesForm _editDevicesForm;
        private ConfigureDeviceForm _configureDeviceForm;
        private ManageLinksForm _manageLinksForm;

        public ManageDevicesForm()
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;
        }

        private void ManageDevicesForm_Load(object sender, EventArgs e)
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
            List<Device> devices;

            SetSpinnerValue(1);

            try
            {
                ServerHandler.ServerWrite(ServerHandler.Stream, "ListDevices");

                devices = (List<Device>)ServerHandler.ServerReadSerilized(ServerHandler.Stream, 30000);

                Invoke(new Action(() =>
                {
                    dtg_devices.DataSource = devices;

                    //modifica o nome das colunas
                    dtg_devices.Columns[0].HeaderText = "UID";
                    dtg_devices.Columns[1].HeaderText = "Nome";
                    dtg_devices.Columns[2].HeaderText = "Tipo";
                    dtg_devices.Columns[3].HeaderText = "Criado em";
                    dtg_devices.Columns[4].HeaderText = "Ultimo Login";
                    dtg_devices.Columns[5].HeaderText = "Dado 1";
                    dtg_devices.Columns[6].HeaderText = "Dado 1";
                    dtg_devices.Columns[7].HeaderText = "Dado 3";
                    dtg_devices.Columns[8].HeaderText = "Dado 4";
                    dtg_devices.Columns[9].HeaderText = "Dado 1 ativo?";
                    dtg_devices.Columns[10].HeaderText = "Dado 2 ativo?";
                    dtg_devices.Columns[11].HeaderText = "Dado 3 ativo?";
                    dtg_devices.Columns[12].HeaderText = "Dado 4 ativo?";

                    dtg_devices.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
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

        private void DeleteDeviceThread()
        {
            try
            {
                StartSpinner();
                SetSpinnerValue(1);

                Device temp = dtg_devices.CurrentRow.DataBoundItem as Device;
                DialogResult result = MetroMessageBox.Show(this, "Gostaria de deletar o dispositivo " + temp.DeviceId + "?\r\nNão será possivel reverter a alteração.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 150);

                if (result == DialogResult.No)
                {
                    ResetSpinner();
                    return;
                }

                ServerHandler.ServerWrite(ServerHandler.Stream, "DeleteDevice;" + temp.DeviceId, 3000);

                string response = ServerHandler.ServerRead(ServerHandler.Stream, 10000);

                if (response == "DeviceDeleted")
                    MetroMessageBox.Show(this, "Dispositivo deletado com sucesso.", "Sucesso", MessageBoxButtons.OK,
                        MessageBoxIcon.Question, 150);
                else if (response == "FailToDelete")
                    MetroMessageBox.Show(this, "Erro ao deletar dispositivo.", "Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, 150);
                else
                {
                    MetroMessageBox.Show(this, "Erro inesperado.", "Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, 150);
                }

                ResetSpinner();

                PopulateGrid();
            }
            catch (Exception e)
            {
                ResetSpinner();

                MetroMessageBox.Show(this, "Erro ao aplicar alterações. \r\n" + e.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, 150);
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
                    bt_newDevice.Enabled = false;
                    bt_edit.Enabled = false;
                    bt_delet.Enabled = false;
                    bt_configDevice.Enabled = false;
                    bt_link.Enabled = false;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = true;
                pb_spinner.Enabled = true;
                bt_newDevice.Enabled = false;
                bt_edit.Enabled = false;
                bt_delet.Enabled = false;
                bt_configDevice.Enabled = false;
                bt_link.Enabled = false;
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
                    bt_newDevice.Enabled = true;
                    bt_edit.Enabled = true;
                    bt_delet.Enabled = true;
                    bt_configDevice.Enabled = true;
                    bt_link.Enabled = true;
                }));
            }
            else
            {
                pb_spinner.Value = 0;
                pb_spinner.Visible = false;
                pb_spinner.Enabled = false;
                bt_newDevice.Enabled = true;
                bt_edit.Enabled = true;
                bt_delet.Enabled = true;
                bt_configDevice.Enabled = true;
                bt_link.Enabled = true;
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

        private void bt_delet_Click(object sender, EventArgs e)
        {
            _workerThread = new Thread(DeleteDeviceThread);
            _workerThread.Start();

            StartSpinner();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Application.OpenForms.OfType<EditDevicesForm>().Any()) //verifica se ja existe uma aba aberta
                {
                    _editDevicesForm = new EditDevicesForm(dtg_devices.CurrentRow.DataBoundItem as Device); //cria o form
                    int x = this.Left + (this.Width / 2) - (_editDevicesForm.Width / 2);
                    int y = this.Top + (this.Height / 2) - (_editDevicesForm.Height / 2);

                    _editDevicesForm.Location = new Point(x, y); //seta a posição do formulario filho

                    _editDevicesForm.Show(); //mostra o formulario
                }
                else
                {
                    MetroMessageBox.Show(this, "Só é possivel realizar uma operação por vez.",
                        "Domus Client - Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        150);

                    _editDevicesForm.Focus(); //caso a janela ja esteja aberta, foca na mesma
                }
            }
            catch (Exception exception)
            {
                MetroMessageBox.Show(this, "Erro ao editar.\r\n" + exception.Message,
                    "Domus Client - Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    150);
            }
        }

        private void bt_newDevice_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<EditDevicesForm>().Any())//verifica se ja existe uma aba aberta
            {
                _editDevicesForm = new EditDevicesForm();//cria o form
                int x = this.Left + (this.Width / 2) - (_editDevicesForm.Width / 2);
                int y = this.Top + (this.Height / 2) - (_editDevicesForm.Height / 2);

                _editDevicesForm.Location = new Point(x, y);//seta a posição do formulario filho

                _editDevicesForm.Show();//mostra o formulario
            }
            else
            {
                MetroMessageBox.Show(this, "Só é possivel realizar uma operação por vez.",
                    "Domus Client - Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    150);

                _editDevicesForm.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }

        private void bt_configDevice_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<ConfigureDeviceForm>().Any())//verifica se ja existe uma aba aberta
            {
                _configureDeviceForm = new ConfigureDeviceForm(dtg_devices.CurrentRow.DataBoundItem as Device);//cria o form
                int x = this.Left + (this.Width / 2) - (_configureDeviceForm.Width / 2);
                int y = this.Top + (this.Height / 2) - (_configureDeviceForm.Height / 2);

                _configureDeviceForm.Location = new Point(x, y);//seta a posição do formulario filho

                _configureDeviceForm.Show();//mostra o formulario
            }
            else
            {
                MetroMessageBox.Show(this, "Só é possivel realizar uma configuração por vez.",
                    "Domus Client - Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    150);

                _configureDeviceForm.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }

        private void bt_link_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<LinkDeviceForm>().Any())//verifica se ja existe uma aba aberta
            {
                _manageLinksForm = new ManageLinksForm();//cria o form
                int x = this.Left + (this.Width / 2) - (_manageLinksForm.Width / 2);
                int y = this.Top + (this.Height / 2) - (_manageLinksForm.Height / 2);

                _manageLinksForm.Location = new Point(x, y);//seta a posição do formulario filho

                _manageLinksForm.Show();//mostra o formulario
            }
            else
            {
                _manageLinksForm.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }
    }
}
