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
    public partial class BatteryTechnologiesListForm : Form
    {
        public BatteryTechnologiesListForm()
        {
            InitializeComponent();
        }

        private void addBatteryTechnologyButton_Click(object sender, EventArgs e)
        {
            var batteryTechnologyAddingForm = new BatteryTechnologyForm();
            batteryTechnologyAddingForm.ShowDialog(); 
        }

        private void editBatteryTechnologyButton_Click(object sender, EventArgs e)
        {
            var batteryTechnologyEditingForm = new BatteryTechnologyForm();
            batteryTechnologyEditingForm.ShowDialog();
        }
    }
}
