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
    public partial class BatteryAddingForm : Form
    {
        private BindingList<BatteryModel> availableBatteryModels = GlobalConfig.Connection.GetBatteryModel_All();
        private List<BatteryExploitationStatus> availableExploitationStatuses = GlobalConfig.Connection.GetBatteryExploitationStatus_All();
        private List<BatteryReplacementStatus> availableReplacementStatuses = GlobalConfig.Connection.GetBatteryReplacementStatus_All();
        private BindingList<Structure> availableStructures = GlobalConfig.Connection.GetStructure_All();
        private BindingList<BatterySubsystem> availableBatterySubsystems = GlobalConfig.Connection.GetBatterySubsystem_All();
        private BindingList<User> availableEmployees = GlobalConfig.Connection.GetUser_All();

        public BatteryAddingForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            modelComboBox.DataSource = availableBatteryModels;
            modelComboBox.DisplayMember = "Name";

            exploitationStatusComboBox.DataSource = availableExploitationStatuses;
            exploitationStatusComboBox.DisplayMember = "Name";

            replacementStatusComboBox.DataSource = availableReplacementStatuses;
            replacementStatusComboBox.DisplayMember = "Name";

            structureComboBox.DataSource = availableStructures;
            structureComboBox.DisplayMember = "Name";

            subsystemComboBox.DataSource = availableBatterySubsystems;
            subsystemComboBox.DisplayMember = "Name";

            responsibleEmployeeComboBox.DataSource = availableEmployees;
            responsibleEmployeeComboBox.DisplayMember = "FullName";
        }
    }
}
