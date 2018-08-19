using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using DomusSharedClasses;

namespace DomusClient
{
    public partial class ConfigureDeviceForm : MetroForm
    {
        private Device device;

        public ConfigureDeviceForm(Device device)
        {
            InitializeComponent();

            this.device = device;
        }
    }
}
