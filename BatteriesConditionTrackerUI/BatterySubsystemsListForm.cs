using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteriesConditionTrackerUI
{
    public partial class BatterySubsystemsListForm : Form
    {
        public BatterySubsystemsListForm()
        {
            InitializeComponent();
        }

        private void addSubsystemButton_Click(object sender, EventArgs e)
        {
            var subsystemAddingForm = new BatterySubsystemForm(); 
            subsystemAddingForm.ShowDialog();
        }

        private void editSubsystemButton_Click(object sender, EventArgs e)
        {
            var subsystemEditingForm = new BatterySubsystemForm();
            subsystemEditingForm.ShowDialog();
        }
    }
}
