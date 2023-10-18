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
    public partial class StructuresListForm : Form
    {
        public StructuresListForm()
        {
            InitializeComponent();
        }

        private void addStructureButton_Click(object sender, EventArgs e)
        {
            var structureAddingForm = new StructureForm(); 
            structureAddingForm.ShowDialog();
        }

        private void editStructureButton_Click(object sender, EventArgs e)
        {
            var structureEditingForm = new StructureForm();
            structureEditingForm.ShowDialog();
        }
    }
}
