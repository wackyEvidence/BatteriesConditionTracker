using BatteriesConditionTrackerLib;
using BatteriesConditionTrackerLib.Models;
using BatteriesConditionTrackerLib.Validation;
using BatteriesConditionTrackerUI.Interfaces;
using System.ComponentModel;
using System.Data;

namespace BatteriesConditionTrackerUI
{
    public partial class BatteryModelForm : Form, IValidatable, IModelRequester<BatteryTechnology>, IModelRequester<BatteryClampType>
    {
        private BindingList<BatteryTechnology> availableTechnologies = GlobalConfig.Connection.GetBatteryTechnology_All();
        private BindingList<BatteryClampType> availableClampTypes = GlobalConfig.Connection.GetBatteryClampType_All();

        private readonly FormMode mode;
        private readonly BatteryModel? inputedBatteryModel;
        private readonly IModelRequester<BatteryModel> callingForm;

        public BatteryModelForm(FormMode mode, IModelRequester<BatteryModel> caller, BatteryModel? batteryModel = null)
        {
            InitializeComponent();
            this.mode = mode;
            callingForm = caller;
            inputedBatteryModel = batteryModel;
            headerLabel.Text = mode == FormMode.Adding ? "Добавление модели" : "Изменение модели";
            WireUpLists();

            if (mode == FormMode.Editing)
                FillFormFields();
        }

        #region IRequester<BatteryTechnology>
        public void ModelCreated(BatteryTechnology model)
        {
            availableTechnologies.Add(model);
            technologyComboBox.SelectedItem = model;
        }

        public void ModelUpdated(BatteryTechnology model)
        {
            technologyComboBox.Refresh();
        }
        #endregion

        #region IRequester<BatteryClampType>
        public void ModelCreated(BatteryClampType model)
        {
            availableClampTypes.Add(model);
            clampTypeComboBox.SelectedItem = model;
        }

        public void ModelUpdated(BatteryClampType model)
        {
            clampTypeComboBox.Refresh();
        }
        #endregion

        private void WireUpLists()
        {
            technologyComboBox.DataSource = availableTechnologies;
            technologyComboBox.DisplayMember = "Name";
            clampTypeComboBox.DataSource = availableClampTypes;
            clampTypeComboBox.DisplayMember = "Name";
        }

        private void FillFormFields()
        {
            if (inputedBatteryModel != null)
            {
                nameValue.Text = inputedBatteryModel.Name;
                brandValue.Text = inputedBatteryModel.Brand;
                costValue.Text = inputedBatteryModel.Cost.ToString();
                capacityValue.Text = inputedBatteryModel.Capacity.ToString();
                voltageValue.Text = inputedBatteryModel.Voltage.ToString();
                technologyComboBox.SelectedItem = availableTechnologies.Where(t => t.Id == inputedBatteryModel.Technology.Id).First();
                clampTypeComboBox.SelectedItem = availableClampTypes.Where(ct => ct.Id == inputedBatteryModel.ClampType.Id).First();
                lengthValue.Text = inputedBatteryModel.Length.ToString();
                widthValue.Text = inputedBatteryModel.Width.ToString();
                heightValue.Text = inputedBatteryModel.Height.ToString();
                bufferServiceTimeValue.Value = decimal.Parse(inputedBatteryModel.BufferModeServiceTime.ToString());
                minSoHValue.Text = inputedBatteryModel.SoHThreshold.ToString();
            }
        }

        public Dictionary<string, string> ValidateForm()
        {
            var errors = new Dictionary<string, string>();

            var stringParams = new List<Parameter>
            {
                new Parameter(nameLabel.Text, nameValue.Text),
                new Parameter(brandLabel.Text, brandValue.Text)
            };
            var intParams = new List<Parameter>
            {
                new Parameter("Длина", lengthValue.Text),
                new Parameter("Ширина", widthValue.Text),
                new Parameter("Высота", heightValue.Text),
                new Parameter(costLabel.Text, costValue.Text),
                new Parameter(minSoHLabel.Text, minSoHValue.Text)
            };
            var doubleParams = new List<Parameter>
            {
                new Parameter(capacityLabel.Text, capacityValue.Text),
                new Parameter(voltageLabel.Text, voltageValue.Text),
                new Parameter(bufferServiceTimeLabel.Text, bufferServiceTimeValue.Text)
            };

            FieldValidator.ValidateStringEmptiness(errors, stringParams);
            FieldValidator.ValidatePositiveIntParameter(errors, intParams);
            FieldValidator.ValidatePositiveDoubleParameter(errors, doubleParams);

            return errors;
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            var errors = ValidateForm();

            if (errors.Count == 0)
            {
                if (mode == FormMode.Adding)
                {
                    #region ModelCreation 
                    var newBatteryModel = new BatteryModel(
                    "0",
                    nameValue.Text,
                    brandValue.Text,
                    capacityValue.Text.Replace('.', ','),
                    voltageValue.Text.Replace('.', ','),
                    lengthValue.Text,
                    heightValue.Text,
                    widthValue.Text,
                    (BatteryTechnology)technologyComboBox.SelectedItem,
                    (BatteryClampType)clampTypeComboBox.SelectedItem,
                    costValue.Text,
                    bufferServiceTimeValue.Text,
                    minSoHValue.Text
                    );
                    #endregion

                    GlobalConfig.Connection.CreateBatteryModel(newBatteryModel);
                    callingForm.ModelCreated(newBatteryModel);
                    Close();
                }
                else
                {
                    #region ModelUpdate
                    inputedBatteryModel.Name = nameValue.Text;
                    inputedBatteryModel.Brand = brandValue.Text;
                    inputedBatteryModel.Cost = int.Parse(costValue.Text);
                    inputedBatteryModel.Technology = (BatteryTechnology)technologyComboBox.SelectedItem;
                    inputedBatteryModel.ClampType = (BatteryClampType)clampTypeComboBox.SelectedItem;
                    inputedBatteryModel.Capacity = double.Parse(capacityValue.Text.Replace('.', ','));
                    inputedBatteryModel.Voltage = double.Parse(voltageValue.Text.Replace('.', ','));
                    inputedBatteryModel.Length = int.Parse(lengthValue.Text);
                    inputedBatteryModel.Width = int.Parse(widthValue.Text);
                    inputedBatteryModel.Height = int.Parse(heightValue.Text);
                    inputedBatteryModel.BufferModeServiceTime = double.Parse(bufferServiceTimeValue.Value.ToString());
                    inputedBatteryModel.SoHThreshold = int.Parse(minSoHValue.Text);
                    #endregion

                    GlobalConfig.Connection.UpdateBatteryModel(inputedBatteryModel);
                    callingForm.ModelUpdated(inputedBatteryModel);
                    Close();
                }
            }
            else
                ValidationErrorsDisplayer.DisplayErrors(errors);
        }

        private void addBatteryTechnologyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var technologyAddingForm = new BatteryTechnologyForm(FormMode.Adding, this);
            technologyAddingForm.ShowDialog();
        }

        private void addClampTypeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var clampTypeAddingForm = new BatteryClampTypeForm(FormMode.Adding, this);
            clampTypeAddingForm.ShowDialog();
        }
    }
}
