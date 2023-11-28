using BatteriesConditionTrackerLib.Models;
using BatteriesConditionTrackerLib;
using BatteriesConditionTrackerLib.Validation;
using BatteriesConditionTrackerUI.Interfaces;

namespace BatteriesConditionTrackerUI
{
    public partial class StructureTypeForm : Form, IValidatable
    {
        private FormMode mode;
        private StructureType? inputedStructureTypeModel;
        private IModelRequester<StructureType> callingForm;

        public StructureTypeForm(FormMode mode, IModelRequester<StructureType> caller, StructureType? structureTypeModel = null)
        {
            InitializeComponent();
            this.mode = mode;
            callingForm = caller;
            inputedStructureTypeModel = structureTypeModel;
            headerLabel.Text = mode == FormMode.Adding ? "Добавление типа объекта" : "Изменение типа объекта";
            structureTypeNameValue.Text = mode == FormMode.Adding ? string.Empty : structureTypeModel.Name;
        }

        public Dictionary<string, string> ValidateForm()
        {
            var errors = new Dictionary<string, string>();
            FieldValidator.ValidateStringEmptiness(errors, structureTypeNameLabel.Text, structureTypeNameValue.Text);
            return errors;
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            var errors = ValidateForm();

            if (errors.Count == 0)
            {
                if (mode == FormMode.Adding)
                {
                    var structureTypeModel = new StructureType() { Name = structureTypeNameValue.Text };

                    GlobalConfig.Connection.CreateStructureType(structureTypeModel);
                    callingForm.ModelCreated(structureTypeModel);
                    Close();
                }
                else
                {
                    inputedStructureTypeModel.Name = structureTypeNameValue.Text;
                    GlobalConfig.Connection.UpdateStructureType(inputedStructureTypeModel);
                    callingForm.ModelUpdated(inputedStructureTypeModel);
                    Close();
                }
            }
            else
                ValidationErrorsDisplayer.DisplayErrors(errors);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
