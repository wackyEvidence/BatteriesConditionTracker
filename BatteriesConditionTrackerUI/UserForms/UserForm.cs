using BatteriesConditionTrackerLib.Models;
using BatteriesConditionTrackerLib;
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
using System.Xml;

namespace BatteriesConditionTrackerUI
{
    public partial class UserForm : Form, IValidatable
    {
        private BindingList<Position> availablePositions = GlobalConfig.Connection.GetPosition_All();
        private FormMode mode;
        private User? inputedUserModel;
        private IModelRequester<User> callingForm;

        public UserForm(FormMode mode, IModelRequester<User> caller, User? userModel = null)
        {
            InitializeComponent();
            this.mode = mode;
            callingForm = caller;
            inputedUserModel = userModel;
            headerLabel.Text = mode == FormMode.Adding ? "Добавление пользователя" : "Изменение пользователя";
            fistPasswordValue.PlaceholderText = mode == FormMode.Adding ? "Введите пароль" : "Введите новый пароль";
            secondPasswordValue.PlaceholderText = mode == FormMode.Adding ? "Введите пароль еще раз" : "Новый пароль еще раз";
        
            WireUpLists();

            if (mode == FormMode.Editing)
                FillFormFields();
        }

        private void WireUpLists()
        {
            positionValue.DataSource = availablePositions;
            positionValue.DisplayMember = "Name";
        }

        private void FillFormFields()
        {
            if (inputedUserModel != null)
            {
                nameValue.Text = inputedUserModel.Name;
                surnameValue.Text = inputedUserModel.Surname;
                patronymicValue.Text = inputedUserModel.Patronymic;
                var userPosition = availablePositions.Where(p => p.Id == inputedUserModel.Position.Id).First();
                positionValue.SelectedItem = userPosition;
                mailValue.Text = inputedUserModel.Email;
                phoneNumberValue.Text = inputedUserModel.PhoneNumber;
                isAdminValue.Checked = inputedUserModel.IsAdmin;
            }
        }

        public Dictionary<string, string> ValidateForm()
        {
            var errors = new Dictionary<string, string>();

            var stringParams = new List<Parameter>
            {
                new Parameter(surnameLabel.Text, surnameValue.Text),
                new Parameter(nameLabel.Text, nameValue.Text),
                new Parameter(patronymicLabel.Text, patronymicValue.Text),
                new Parameter(mailLabel.Text, mailValue.Text)
            };

            var passwords = new List<Parameter>
            {
                new Parameter("Пароль", fistPasswordValue.Text),
                new Parameter("Пароль повторно", secondPasswordValue.Text)
            };

            FieldValidator.ValidateStringEmptiness(errors, stringParams);

            if (mode == FormMode.Adding)
                FieldValidator.ValidatePasswordMatch(errors, passwords);

            FieldValidator.ValidatePhoneNumber(errors, phoneNumberValue);

            return errors;
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            var errors = ValidateForm();

            if (errors.Count == 0)
            {
                if (mode == FormMode.Adding)
                {
                    var hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(fistPasswordValue.Text);

                    #region ModelCreation
                    var userModel = new User(
                        nameValue.Text,
                        surnameValue.Text,
                        patronymicValue.Text,
                        hashedPassword,
                        phoneNumberValue.Text,
                        mailValue.Text,
                        (Position)positionValue.SelectedItem,
                        isAdminValue.Checked
                    );
                    #endregion

                    GlobalConfig.Connection.CreateUser(userModel);
                    callingForm.ModelCreated(userModel);
                    Close();
                }
                else
                {
                    #region ModelUpdate
                    inputedUserModel.Name = nameValue.Text;
                    inputedUserModel.Surname = surnameValue.Text;
                    inputedUserModel.Password = patronymicValue.Text;
                    inputedUserModel.Position = (Position)positionValue.SelectedItem;
                    inputedUserModel.Email = mailValue.Text;
                    inputedUserModel.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(fistPasswordValue.Text);
                    inputedUserModel.PhoneNumber = phoneNumberValue.Text;
                    inputedUserModel.IsAdmin = isAdminValue.Checked;
                    #endregion

                    GlobalConfig.Connection.UpdateUser(inputedUserModel);
                    callingForm.ModelUpdated(inputedUserModel);
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
