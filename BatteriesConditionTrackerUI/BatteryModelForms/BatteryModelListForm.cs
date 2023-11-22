using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatteriesConditionTrackerLib;
using BatteriesConditionTrackerLib.Models;

namespace BatteriesConditionTrackerUI
{
    public partial class BatteryModelListForm : Form
    {
        BindingList<BatteryModel> displayedBatteryModels = GlobalConfig.Connection.GetBatteryModel_All();
        public BatteryModelListForm()
        {
            InitializeComponent();
        }

        private void WireUpLists()
        {
            dataGridView1.DataSource = displayedBatteryModels;
        }

        private void addBatteryModelButton_Click(object sender, EventArgs e)
        {
            var addingForm = new BatteryModelForm(FormMode.Adding);
            addingForm.ShowDialog();
        }

        private void editBatteryModelButton_Click(object sender, EventArgs e)
        {
            var editingForm = new BatteryModelForm(FormMode.Editing);
            editingForm.ShowDialog();
        }
    }
}
