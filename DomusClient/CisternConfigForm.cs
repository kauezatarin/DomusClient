using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace DomusClient
{
    public partial class CisternConfigForm : MetroForm
    {
        public CisternConfigForm()
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;
        }

        private void trb_minLevel_ValueChanged(object sender, EventArgs e)
        {
            lb_levelValue.Text = ((MetroTrackBar) sender).Value + @"%";
        }

        private void CisternConfigForm_Load(object sender, EventArgs e)
        {
            lb_levelValue.Text = trb_minLevel.Value + @"%";
        }
    }
}
