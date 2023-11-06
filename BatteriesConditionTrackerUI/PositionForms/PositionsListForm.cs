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
    public partial class PositionsListForm : Form
    { 
        public PositionsListForm()
        {
            InitializeComponent();
        }

        private void addPositionButton_Click(object sender, EventArgs e)
        {
            var positionAddingForm = new PositionForm(FormMode.Adding); 
            positionAddingForm.ShowDialog();
        }

        private void editPositionButton_Click(object sender, EventArgs e)
        {
            // TO DO - добавить проверку на то, что выбрана строка 
            var currentRow = dataGridView1.CurrentRow; 
            var positionModel = new Position(currentRow.Cells[0].Value.ToString(), currentRow.Cells[1].Value.ToString());
            var positionEditingForm = new PositionForm(FormMode.Editing, positionModel);
            positionEditingForm.ShowDialog();
        }
    }
}
