using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomusSharedClasses;
using MetroFramework.Forms;

namespace DomusClient
{
    public partial class EditIrrigationSchedule : MetroForm
    {
        private IrrigationSchedule _irrigationSchedule;
        private bool _isEditing = true;

        public EditIrrigationSchedule(IrrigationSchedule schedule = null)
        {
            InitializeComponent();

            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;

            if (schedule == null)
            {
                _irrigationSchedule = new IrrigationSchedule(-1, "default", DateTime.Now, 600, false, false, false,
                    false, false, false, false, true);

                _isEditing = false;
            }

            if (_isEditing)
            {

            }
        }

        private void EditIrrigationSchedule_Load(object sender, EventArgs e)
        {
            cb_timeScale.SelectedIndex = 1;
        }

    }
}
