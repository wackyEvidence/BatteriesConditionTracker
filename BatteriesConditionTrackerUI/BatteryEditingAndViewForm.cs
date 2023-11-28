using BatteriesConditionTrackerLib;
using BatteriesConditionTrackerLib.Models;
using BatteriesConditionTrackerLib.Validation;
using BatteriesConditionTrackerUI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteriesConditionTrackerUI
{
    public partial class BatteryEditingAndViewForm : Form, IValidatable
    {
        private List<BatteryExploitationStatus> availableExploitationStatuses = GlobalConfig.Connection.GetBatteryExploitationStatus_All();
        private List<BatteryReplacementStatus> availableReplacementStatuses = GlobalConfig.Connection.GetBatteryReplacementStatus_All();
        private BindingList<Structure> availableStructures = GlobalConfig.Connection.GetStructure_All();
        private BindingList<BatterySubsystem> availableSubsystems = GlobalConfig.Connection.GetBatterySubsystem_All();
        private BindingList<User> availableEmployees = GlobalConfig.Connection.GetUser_All();
        private BindingList<BatterySoHMeasure> availableSoHMeasures;

        private FormMode mode;
        private IModelRequester<ConcreteBattery> callingForm;
        private ConcreteBattery inputedConcreteBattery;

        private const string AdditionalNotesPlaceholder = "Место установки, особенности эксплуатации АКБ и т.п.";

        public BatteryEditingAndViewForm(IModelRequester<ConcreteBattery> caller, ConcreteBattery concreteBatteryModel, FormMode mode)
        {
            InitializeComponent();
            this.mode = mode;
            callingForm = caller;
            inputedConcreteBattery = concreteBatteryModel;
            availableSoHMeasures = GlobalConfig.Connection.GetBatterySoHMeasure_ById(concreteBatteryModel.Id);
            WireUpLists();
            FillFormFields();
            AdjustDataGridView();

            if (mode == FormMode.Watching)
            {
                actionButton.Visible = false;
                cancelButton.Visible = false;
                addSoHMeasure.Visible = false;
                editSoHMeasure.Visible = false;
                deleteSoHMeasure.Visible = false;
                headerLabel.Text = "Просмотр аккумулятора";
            }
        }

        public Dictionary<string, string> ValidateForm()
        {
            var errors = new Dictionary<string, string>();

            FieldValidator.ValidateComboBox(errors, exploitationStatusValue, "Статус эксплуатации");
            FieldValidator.ValidateComboBox(errors, replacementStatusValue, "Статус замены");
            FieldValidator.ValidateComboBox(errors, structureValue, "Объект");
            FieldValidator.ValidateComboBox(errors, subsystemValue, "Подсистема");
            FieldValidator.ValidateComboBox(errors, responsibleEmployeeValue, "Ответственный сотрудник");

            return errors;
        }

        private Dictionary<string, string> ValidateSoHMeasure()
        {
            var errors = new Dictionary<string, string>();

            FieldValidator.ValidateComboBox(errors, performingEmployeeValue, "Сотрудник, проводивший замер");
            FieldValidator.ValidatePositiveIntParameter(errors, "Значение SoH(%)", sohValue.Text);

            return errors;
        }

        private void FillFormFields()
        {
            FillMainInfo();
            FillExtraInfo();

            void FillExtraInfo()
            {
                exploitationStatusValue.SelectedItem = availableExploitationStatuses.Where(es => es.Id == inputedConcreteBattery.ExploitationStatus.Id).First();
                replacementStatusValue.SelectedItem = availableReplacementStatuses.Where(es => es.Id == inputedConcreteBattery.ReplacementStatus.Id).First();
                exploitationStartValue.Value = inputedConcreteBattery.ExploitationStart;
                var exploitationStatus = (BatteryExploitationStatus)exploitationStatusValue.SelectedItem;

                if (exploitationStatus.Name == "Эксплуатируется")
                    exploitationEndValue.Enabled = false;
                else
                    exploitationEndValue.Value = (DateTime)inputedConcreteBattery.ExploitationEnd;

                structureValue.SelectedItem = availableStructures.Where(s => s.Id == inputedConcreteBattery.InstallationStructure.Id).First();
                subsystemValue.SelectedItem = availableSubsystems.Where(s => s.Id == inputedConcreteBattery.Subsystem.Id).First();

                additionalNotesValue.Text = inputedConcreteBattery.AdditionalNotes != "" ?
                    inputedConcreteBattery.AdditionalNotes :
                    AdditionalNotesPlaceholder;

                responsibleEmployeeValue.SelectedItem = availableEmployees.Where(e => e.Id == inputedConcreteBattery.ResponsibleEmployee.Id).First();
            }

            void FillMainInfo()
            {
                var model = inputedConcreteBattery.Model;
                nameValue.Text = model.Name;
                nameValue.Enabled = false;
                lengthValue.Text = model.Length.ToString();
                lengthValue.Enabled = false;
                widthValue.Text = model.Width.ToString();
                widthValue.Enabled = false;
                heightValue.Text = model.Height.ToString();
                heightValue.Enabled = false;
                brandValue.Text = model.Brand;
                brandValue.Enabled = false;
                costValue.Text = model.Cost.ToString();
                costValue.Enabled = false;
                capacityValue.Text = model.Capacity.ToString();
                capacityValue.Enabled = false;
                voltageValue.Text = model.Voltage.ToString();
                voltageValue.Enabled = false;
                technologyValue.Text = model.Technology.Name;
                technologyValue.Enabled = false;
                clampTypeValue.Text = model.ClampType.Name;
                clampTypeValue.Enabled = false;
                bufferServiceTimeValue.Value = (decimal)model.BufferModeServiceTime;
                bufferServiceTimeValue.Enabled = false;
                sohThresholdValue.Text = model.SoHThreshold.ToString();
                sohThresholdValue.Enabled = false;
            }
        }

        private void WireUpLists()
        {
            exploitationStatusValue.DataSource = availableExploitationStatuses;
            exploitationStatusValue.DisplayMember = "Name";

            replacementStatusValue.DataSource = availableReplacementStatuses;
            replacementStatusValue.DisplayMember = "Name";

            structureValue.DataSource = availableStructures;
            structureValue.DisplayMember = "Name";

            subsystemValue.DataSource = availableSubsystems;
            subsystemValue.DisplayMember = "Name";

            responsibleEmployeeValue.DataSource = availableEmployees;
            responsibleEmployeeValue.DisplayMember = "FullName";

            performingEmployeeValue.DataSource = availableEmployees;
            performingEmployeeValue.DisplayMember = "FullName";

            dataGridView1.DataSource = availableSoHMeasures;
        }

        private void AdjustDataGridView()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[3].HeaderText = "Дата замера";
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].Visible = true;
            dataGridView1.Columns[4].HeaderText = "Значение SoH";
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void exploitationStatusValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentStatus = (BatteryExploitationStatus)exploitationStatusValue.SelectedItem;
            if (currentStatus.Name == "Не эксплуатируется")
                exploitationEndValue.Enabled = true;
            else
                exploitationEndValue.Enabled = false;
        }

        private void replacementStatusValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentStatus = (BatteryReplacementStatus)replacementStatusValue.SelectedItem;
            if (currentStatus.Name == "Заменен" || currentStatus.Name == "Заменён")
            {
                exploitationStatusValue.SelectedItem = availableExploitationStatuses.Where(s => s.Name == "Не эксплуатируется").First();
                exploitationStatusValue.Enabled = false;
            }
            else
                exploitationStatusValue.Enabled = true;

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

        private void addSoHMeasure_Click(object sender, EventArgs e)
        {
            var errors = ValidateSoHMeasure();
            if (errors.Count == 0)
            {
                var sohMeasure = new BatterySoHMeasure(
                    "0",
                    inputedConcreteBattery,
                    (User)performingEmployeeValue.SelectedItem,
                    measureDateValue.Value.ToShortDateString(),
                    sohValue.Text
                    );

                availableSoHMeasures.Add(sohMeasure);
                GlobalConfig.Connection.CreateBatterySoHMeasure(sohMeasure);

                // Введенное пользователем значение SoH меньше минимального требуемого 

                if (sohMeasure.SoH < inputedConcreteBattery.Model.SoHThreshold)
                {
                    inputedConcreteBattery.ReplacementStatus = availableReplacementStatuses.Where(s => s.Name == "Требует замены").First();
                    GlobalConfig.Connection.UpdateConcreteBattery(inputedConcreteBattery);
                    callingForm.ModelUpdated(inputedConcreteBattery);
                    Close();
                }
            }
            else
                ValidationErrorsDisplayer.DisplayErrors(errors);
        }

        private void editSoHMeasure_Click(object sender, EventArgs e)
        {
            var errors = ValidateSoHMeasure();
            if (errors.Count == 0)
            {
                var currentSoHMeasure = availableSoHMeasures[dataGridView1.CurrentRow.Index];
                currentSoHMeasure.Battery = inputedConcreteBattery;
                currentSoHMeasure.MeasureDate = measureDateValue.Value;
                currentSoHMeasure.SoH = int.Parse(sohValue.Text);
                currentSoHMeasure.PerformingEmployee = (User)performingEmployeeValue.SelectedItem;

                GlobalConfig.Connection.UpdateBatterySoHMeasure(currentSoHMeasure);
                dataGridView1.Refresh();
            }
            else
                ValidationErrorsDisplayer.DisplayErrors(errors);
        }

        private void deleteSoHMeasure_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.CurrentRow.Index;
            GlobalConfig.Connection.DeleteBatterySoHMeasure(availableSoHMeasures[index]);
            availableSoHMeasures.RemoveAt(index);
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            var errors = ValidateForm();

            if (errors.Count == 0)
            {
                #region ModelUpdate 
                inputedConcreteBattery.ExploitationStatus = (BatteryExploitationStatus)exploitationStatusValue.SelectedItem;
                inputedConcreteBattery.ReplacementStatus = (BatteryReplacementStatus)replacementStatusValue.SelectedItem;
                inputedConcreteBattery.ExploitationStart = exploitationStartValue.Value;
                inputedConcreteBattery.ExploitationEnd = exploitationEndValue.Enabled ? exploitationEndValue.Value : null;
                inputedConcreteBattery.InstallationStructure = (Structure)structureValue.SelectedItem;
                inputedConcreteBattery.Subsystem = (BatterySubsystem)subsystemValue.SelectedItem;
                inputedConcreteBattery.ResponsibleEmployee = (User)responsibleEmployeeValue.SelectedItem;
                inputedConcreteBattery.AdditionalNotes = additionalNotesValue.Text == AdditionalNotesPlaceholder ? "" : additionalNotesValue.Text;
                #endregion

                GlobalConfig.Connection.UpdateConcreteBattery(inputedConcreteBattery);
                callingForm.ModelUpdated(inputedConcreteBattery);
                Close();
            }
            else
                ValidationErrorsDisplayer.DisplayErrors(errors);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            sohValue.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            measureDateValue.Value = DateTime.Parse(dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString());
            var selectedEmployee = (User)dataGridView1[2, dataGridView1.CurrentRow.Index].Value;
            performingEmployeeValue.SelectedItem = availableEmployees.Where(e => e.Id == selectedEmployee.Id).FirstOrDefault();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0 || tabControl1.SelectedIndex == 2)
            {
                actionButton.Visible = false;
                cancelButton.Visible = false;
            }
            else
            {
                actionButton.Visible = true;
                cancelButton.Visible = true;
            }
        }
    }
}
