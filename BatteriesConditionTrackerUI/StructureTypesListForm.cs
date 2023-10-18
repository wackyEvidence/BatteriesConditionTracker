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
    public partial class StructureTypesListForm : Form
    {
        public StructureTypesListForm()
        {
            InitializeComponent();
        }

        private void addStructureTypeButton_Click(object sender, EventArgs e)
        {
            var structureTypeAddingForm = new StructureTypeForm(); 
            structureTypeAddingForm.ShowDialog();
        }

        private void editStructureTypeButton_Click(object sender, EventArgs e)
        {
            var structureTypeEditingForm = new StructureTypeForm();
            structureTypeEditingForm.ShowDialog();
        }
    }
}
