using BatteriesConditionTrackerLib;
using BatteriesConditionTrackerLib.Models;
using BatteriesConditionTrackerLib.Validation;
using BatteriesConditionTrackerUI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BatteriesConditionTrackerUI
{
    public partial class BatteryAddingForm : Form, IValidatable, IModelRequester<BatteryModel>
    {
        private BindingList<BatteryModel> availableBatteryModels = GlobalConfig.Connection.GetBatteryModel_All();
        private List<BatteryExploitationStatus> availableExploitationStatuses = GlobalConfig.Connection.GetBatteryExploitationStatus_All();
        private List<BatteryReplacementStatus> availableReplacementStatuses = GlobalConfig.Connection.GetBatteryReplacementStatus_All();
        private BindingList<Structure> availableStructures = GlobalConfig.Connection.GetStructure_All();
        private BindingList<BatterySubsystem> availableBatterySubsystems = GlobalConfig.Connection.GetBatterySubsystem_All(); 
        private BindingList<User> availableEmployees = GlobalConfig.Connection.GetUser_All();

        private readonly IModelRequester<ConcreteBattery> callingForm;
        private const string AdditionalNotesPlaceholder = "Место установки, особенности эксплуатации АКБ и т.п.";

        public BatteryAddingForm(IModelRequester<ConcreteBattery> caller) 
        {
            callingForm = caller;
            InitializeComponent();
            WireUpLists();
        }

        #region IRequester<Model>
        public void ModelCreated(BatteryModel model)
        {
            availableBatteryModels.Add(model);
        }

        public void ModelUpdated(BatteryModel model)
        {
            modelComboBox.Refresh();
        }
        #endregion

        public Dictionary<string, string> ValidateForm()
        {
            var errors = new Dictionary<string, string>();

            FieldValidator.ValidateComboBox(errors, modelComboBox, "Модель аккумулятора");
            FieldValidator.ValidateComboBox(errors, structureComboBox, "Объект");
            FieldValidator.ValidateComboBox(errors, subsystemComboBox, "Подсистема");
            FieldValidator.ValidateComboBox(errors, responsibleEmployeeComboBox, "Ответственный работник");

            return errors;
        }

        private void WireUpLists()
        {
            modelComboBox.DataSource = availableBatteryModels;
            modelComboBox.DisplayMember = "Name";

            exploitationStatusComboBox.DataSource = availableExploitationStatuses;
            exploitationStatusComboBox.DisplayMember = "Name";
            exploitationStatusComboBox.SelectedItem = availableExploitationStatuses.Where(s => s.Name == "Эксплуатируется").First();
            exploitationEndValue.Enabled = false;

            replacementStatusComboBox.DataSource = availableReplacementStatuses;
            replacementStatusComboBox.DisplayMember = "Name";
            replacementStatusComboBox.SelectedItem = availableReplacementStatuses.Where(s => s.Name == "Не требует замены").First();

            structureComboBox.DataSource = availableStructures;
            structureComboBox.DisplayMember = "Name";

            subsystemComboBox.DataSource = availableBatterySubsystems;
            subsystemComboBox.DisplayMember = "Name";

            responsibleEmployeeComboBox.DataSource = availableEmployees;
            responsibleEmployeeComboBox.DisplayMember = "FullName";
        }

        private void exploitationStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentStatus = (BatteryExploitationStatus)exploitationStatusComboBox.SelectedItem;
            if (currentStatus.Name == "Не эксплуатируется")
                exploitationEndValue.Enabled = true;
            else
                exploitationEndValue.Enabled = false;
        }

        private void additionalNotesValue_Enter(object sender, EventArgs e)
        {
            if (additionalNotesValue.Text == AdditionalNotesPlaceholder)
                additionalNotesValue.Text = "";
        }

        private void additionalNotesValue_Leave(object sender, EventArgs e)
        {
            if (additionalNotesValue.Text == "")
                additionalNotesValue.Text = AdditionalNotesPlaceholder;
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            var errors = ValidateForm();

            if (errors.Count == 0)
            {
                #region ModelCreation 
                var concreteBattery = new ConcreteBattery(
                    "0",
                    (BatteryModel)modelComboBox.SelectedItem,
                    (BatteryExploitationStatus)exploitationStatusComboBox.SelectedItem,
                    (BatteryReplacementStatus)replacementStatusComboBox.SelectedItem,
                    exploitationStartValue.Value,
                    exploitationEndValue.Enabled ? exploitationEndValue.Value : null,
                    (Structure)structureComboBox.SelectedItem,
                    (BatterySubsystem)subsystemComboBox.SelectedItem,
                    (User)responsibleEmployeeComboBox.SelectedItem,
                    additionalNotesValue.Text == AdditionalNotesPlaceholder ? "" : additionalNotesValue.Text
                );
                #endregion

                GlobalConfig.Connection.CreateConcreteBattery(concreteBattery);
                callingForm.ModelCreated(concreteBattery);
                Close();

            }
            else
                ValidationErrorsDisplayer.DisplayErrors(errors);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBatteryModel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var batteryModelAddingForm = new BatteryModelForm(FormMode.Adding, this);
            batteryModelAddingForm.ShowDialog();
        }
    }
}
