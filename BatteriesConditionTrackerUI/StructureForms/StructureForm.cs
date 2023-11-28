using BatteriesConditionTrackerLib;
using BatteriesConditionTrackerLib.Models;
using BatteriesConditionTrackerLib.Validation;
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
    public partial class StructureForm : Form, IValidatable, IModelRequester<StructureType>
    {
        private BindingList<StructureType> displayedStructureTypes = GlobalConfig.Connection.GetStructureType_All();
        private FormMode mode;
        private Structure? inputedStructureModel;
        private IModelRequester<Structure> callingForm;

        public StructureForm(FormMode mode, IModelRequester<Structure> caller, Structure? structureModel = null)
        {
            InitializeComponent();
            this.mode = mode;
            inputedStructureModel = structureModel;
            callingForm = caller;
            headerLabel.Text = mode == FormMode.Adding ? "Добавление объекта" : "Изменение объекта";
            WireUpLists();
            if(mode == FormMode.Editing)
                FillFormFields(); 
        }

        private void FillFormFields()
        {
            structureNameValue.Text = inputedStructureModel.Name;
            structureTypeValue.SelectedItem = displayedStructureTypes.Where(t => t.Id == inputedStructureModel.Type.Id).First(); 
        }

        private void WireUpLists()
        {
            structureTypeValue.DataSource = displayedStructureTypes;
            structureTypeValue.DisplayMember = "Name";
        }

        public Dictionary<string, string> ValidateForm()
        {
            var errors = new Dictionary<string, string>();
            FieldValidator.ValidateStringEmptiness(errors, structureNameLabel.Text, structureNameValue.Text);
            return errors;
        }

        #region IRequester<StructureType>
        public void ModelCreated(StructureType model)
        {
            displayedStructureTypes.Add(model);
        }

        public void ModelUpdated(StructureType model)
        {
            Refresh();
        }
        #endregion

        private void actionButton_Click(object sender, EventArgs e)
        {
            var errors = ValidateForm();

            if (errors.Count == 0)
            {
                if (mode == FormMode.Adding)
                {
                    var structureModel = new Structure() { Name = structureNameValue.Text, Type = (StructureType)structureTypeValue.SelectedItem };

                    GlobalConfig.Connection.CreateStructure(structureModel);
                    callingForm.ModelCreated(structureModel);
                    Close();
                }
                else
                {
                    inputedStructureModel.Name = structureNameValue.Text;
                    inputedStructureModel.Type = (StructureType)structureTypeValue.SelectedItem;
                    GlobalConfig.Connection.UpdateStructure(inputedStructureModel);
                    callingForm.ModelUpdated(inputedStructureModel);
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

        private void addStructureTypeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var structureTypeAddingForm = new StructureTypeForm(FormMode.Adding, this);
            structureTypeAddingForm.ShowDialog();
        }
    }
}
