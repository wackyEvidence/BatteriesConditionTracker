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
    public partial class BatteryClampTypeForm : Form
    {
        private FormMode formMode;
        private BatteryClampType? inputedClampTypeModel;

        public BatteryClampTypeForm(FormMode mode)
        {
            InitializeComponent();
            formMode = mode;
            headerLabel.Text = "Добавление типа клемм";
        }

        public BatteryClampTypeForm(FormMode mode, BatteryClampType clampTypeModel)
        {
            InitializeComponent();
            formMode = mode;
            inputedClampTypeModel = clampTypeModel;
            headerLabel.Text = "Редактирование типа клемм";
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(formMode == FormMode.Adding)
            {
                var createdClampTypeModel = new BatteryClampType() { Name = clampTypeNameValue.Text };
                GlobalConfig.Connection.CreateBatteryClampType(createdClampTypeModel);
            }
            else
            {
                inputedClampTypeModel.Name = clampTypeNameValue.Text;
                GlobalConfig.Connection.UpdateBatteryClampType(inputedClampTypeModel);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
