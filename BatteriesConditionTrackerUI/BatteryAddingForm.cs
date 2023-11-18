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
        private List<BatteryModel> availableBatteryModels = new List<BatteryModel>();
        private List<BatteryExploitationStatus> availableExploitationStatuses = new List<BatteryExploitationStatus>();
        private List<BatteryReplacementStatus> availableReplacementStatuses = new List<BatteryReplacementStatus>();
        private List<Structure> availableStructures = new List<Structure>();
        private List<BatterySubsystem> availableBatterySubsystems = new List<BatterySubsystem>();
        private List<User> availableEmployees = new List<User>();

        public BatteryAddingForm()
        {
            InitializeComponent();
        }
    }
}
