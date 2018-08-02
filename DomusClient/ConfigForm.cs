using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace DomusClient
{
    public partial class ConfigForm : MetroForm
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            tb_serverIp.Text = Properties.Settings.Default.serverIp;
            tb_serverPort.Text = Properties.Settings.Default.serverPort.ToString();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (ValidateIPv4(tb_serverIp.Text) && (Convert.ToInt32(tb_serverPort.Text) <= 65535) && (Convert.ToInt32(tb_serverPort.Text) >= 0))
            {
                Properties.Settings.Default.serverIp = tb_serverIp.Text;
                Properties.Settings.Default.serverPort = Convert.ToInt32(tb_serverPort.Text);

                MetroMessageBox.Show(this, "Configurações salvas.",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question, 150);

                this.Close();
            }
            else
            {
                MetroMessageBox.Show(this,"Endereço IP ou porta incorretos.\r\nVerifique os campos e tente novamente.", 
                    "Inválido", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning, 150);
            }
        }


        private bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }
    }
}
