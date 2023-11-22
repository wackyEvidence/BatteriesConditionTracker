using BatteriesConditionTrackerLib;
using BatteriesConditionTrackerLib.Models;
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
    public partial class BatteryClampTypesListForm : Form
    {
        private BindingList<BatteryClampType> displayedClampTypes = GlobalConfig.Connection.GetBatteryClampType_All();
        public BatteryClampTypesListForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = displayedClampTypes;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void addClampTypeButton_Click(object sender, EventArgs e)
        {
            var clampTypeAddingForm = new BatteryClampTypeForm(FormMode.Adding);
            clampTypeAddingForm.ShowDialog();

        }

        private void editClampTypeButton_Click(object sender, EventArgs e)
        {
            var clampTypeAddingForm = new BatteryClampTypeForm(FormMode.Editing);
        }

        private void deleteClampTypeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
