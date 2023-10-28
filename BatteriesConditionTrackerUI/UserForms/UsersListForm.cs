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
    public partial class WorkersListForm : Form
    {
        public WorkersListForm()
        {
            InitializeComponent();
        }

        private void addWorkerButton_Click(object sender, EventArgs e)
        {
            var workerAddingForm = new UserForm(); 
            workerAddingForm.ShowDialog(); 
        }

        private void editWorkerButton_Click(object sender, EventArgs e)
        {
            var workerEditingForm = new UserForm();
            workerEditingForm.ShowDialog();
        }
    }
}
