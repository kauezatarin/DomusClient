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
        private Thread workerThread;
        private EditDevicesForm editDevicesForm;

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
            workerThread = new Thread(PopulateGridThread);
            workerThread.Start();

            startSpinner();
        }

        private void PopulateGridThread()
        {
            List<Device> devices;

            setSpinnerValue(1);

            try
            {
                ServerHandler.ServerWrite(ServerHandler.stream, "listDevices");

                devices = (List<Device>)ServerHandler.ServerReadSerilized(ServerHandler.stream, 30000);

                Invoke(new Action(() =>
                {
                    dtg_devices.DataSource = devices;

                    dtg_devices.Columns[9].Visible = false;//oculta a coluna de senha

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

            resetSpinner();
        }

        private void DeleteDeviceThread()
        {
            try
            {
                startSpinner();
                setSpinnerValue(1);

                Device temp = dtg_devices.CurrentRow.DataBoundItem as Device;
                DialogResult result = MetroMessageBox.Show(this, "Gostaria de deletar o dispositivo " + temp.deviceId + "?\r\nNão será possivel reverter a alteração.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 150);

                if (result == DialogResult.No)
                {
                    resetSpinner();
                    return;
                }

                ServerHandler.ServerWrite(ServerHandler.stream, "DeleteDevice;" + temp.deviceId, 3000);

                string response = ServerHandler.ServerRead(ServerHandler.stream, 10000);

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

                resetSpinner();

                PopulateGrid();
            }
            catch (Exception e)
            {
                resetSpinner();

                MetroMessageBox.Show(this, "Erro ao aplicar alterações. \r\n" + e.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, 150);
            }
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
                    bt_newDevice.Enabled = false;
                    bt_edit.Enabled = false;
                    bt_delet.Enabled = false;
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
                    bt_newDevice.Enabled = true;
                    bt_edit.Enabled = true;
                    bt_delet.Enabled = true;
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

        private void bt_delet_Click(object sender, EventArgs e)
        {
            workerThread = new Thread(DeleteDeviceThread);
            workerThread.Start();

            startSpinner();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<EditDevicesForm>().Count() == 0) //verifica se ja existe uma aba aberta
                {
                    editDevicesForm = new EditDevicesForm(dtg_devices.CurrentRow.DataBoundItem as Device); //cria o form
                    int x = this.Left + (this.Width / 2) - (editDevicesForm.Width / 2);
                    int y = this.Top + (this.Height / 2) - (editDevicesForm.Height / 2);

                    editDevicesForm.Location = new Point(x, y); //seta a posição do formulario filho

                    editDevicesForm.Show(); //mostra o formulario
                }
                else
                {
                    MetroMessageBox.Show(this, "Só é possivel realizar uma operação por vez.",
                        "Domus Client - Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        150);

                    editDevicesForm.Focus(); //caso a janela ja esteja aberta, foca na mesma
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
            if (Application.OpenForms.OfType<EditDevicesForm>().Count() == 0)//verifica se ja existe uma aba aberta
            {
                editDevicesForm = new EditDevicesForm();//cria o form
                int x = this.Left + (this.Width / 2) - (editDevicesForm.Width / 2);
                int y = this.Top + (this.Height / 2) - (editDevicesForm.Height / 2);

                editDevicesForm.Location = new Point(x, y);//seta a posição do formulario filho

                editDevicesForm.Show();//mostra o formulario
            }
            else
            {
                MetroMessageBox.Show(this, "Só é possivel realizar uma operação por vez.",
                    "Domus Client - Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    150);

                editDevicesForm.Focus();//caso a janela ja esteja aberta, foca na mesma
            }
        }
    }
}
