using BatteriesConditionTrackerLib;
using BatteriesConditionTrackerLib.Models;
using BatteriesConditionTrackerUI.Interfaces;
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
    public partial class WorkersListForm : Form, IModelRequester<User>
    {
        private BindingList<User> displayedUsers = GlobalConfig.Connection.GetUser_All();

        public WorkersListForm()
        {
            InitializeComponent();
            WireUpLists();
            AdjustDataGridView();
        }

        #region IRequester<User>
        public void ModelCreated(User model)
        {
            displayedUsers.Add(model);
        }

        public void ModelUpdated(User model)
        {
            Refresh();
        }
        #endregion

        private void WorkersListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
        private void WireUpLists()
        {
            dataGridView1.DataSource = displayedUsers;
        }

        private void AdjustDataGridView()
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                dataGridView1.Columns[i].Visible = false;

            dataGridView1.Columns[dataGridView1.ColumnCount - 1].Visible = true;
            dataGridView1.Columns[dataGridView1.ColumnCount - 1].HeaderText = "ФИО";
            dataGridView1.Columns[dataGridView1.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void addWorkerButton_Click(object sender, EventArgs e)
        {
            var workerAddingForm = new UserForm(FormMode.Adding, this);
            workerAddingForm.ShowDialog();
        }

        private void editWorkerButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var userModel = displayedUsers[dataGridView1.CurrentRow.Index];
                var userEditingForm = new UserForm(FormMode.Editing, this, userModel);
                userEditingForm.ShowDialog();
            }
            else
                MessageBox.Show("Выберите строку таблицы для редактирования", "Ошибка редактирования", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteWorkerButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var userModel = displayedUsers[dataGridView1.CurrentRow.Index];
                GlobalConfig.Connection.DeleteUser(userModel);
                displayedUsers.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            else
                MessageBox.Show("Выберите строку таблицы для удаления", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
