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
    public partial class PositionsListForm : Form
    {
        public PositionsListForm()
        {
            InitializeComponent();
        }

        private void addPositionButton_Click(object sender, EventArgs e)
        {
            var positionAddingForm = new PositionForm(); 
            positionAddingForm.ShowDialog();
        }

        private void editPositionButton_Click(object sender, EventArgs e)
        {
            var positionEditingForm = new PositionForm();
            positionEditingForm.ShowDialog();
        }
    }
}
