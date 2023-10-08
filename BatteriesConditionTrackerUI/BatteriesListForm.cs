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
    public partial class BatteriesListForm : Form
    {
        public BatteriesListForm()
        {
            InitializeComponent();
        }

        private void addUserFilterButton_Click(object sender, EventArgs e)
        {
            var userFilterForm = new UserFilterForm();
            userFilterForm.ShowDialog();
        }

        private void sortSettingsButton_Click(object sender, EventArgs e)
        {
            var userSortForm = new SortForm();
            userSortForm.ShowDialog();
        }
    }
}
