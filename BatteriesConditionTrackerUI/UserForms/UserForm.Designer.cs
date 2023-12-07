namespace BatteriesConditionTrackerUI
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            headerLabel = new Label();
            nameValue = new TextBox();
            nameLabel = new Label();
            surnameValue = new TextBox();
            surnameLabel = new Label();
            patronymicValue = new TextBox();
            patronymicLabel = new Label();
            mailValue = new TextBox();
            mailLabel = new Label();
            phoneNumberLabel = new Label();
            phoneNumberValue = new MaskedTextBox();
            cancelButton = new Button();
            actionButton = new Button();
            isAdminValue = new CheckBox();
            passwordGroupBox = new GroupBox();
            secondPasswordValue = new TextBox();
            fistPasswordValue = new TextBox();
            positionValue = new ComboBox();
            positionLabel = new Label();
            passwordGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 24F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(2, 9);
            headerLabel.Margin = new Padding(6, 0, 6, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(290, 54);
            headerLabel.TabIndex = 11;
            headerLabel.Text = "headerLabelText";
            // 
            // nameValue
            // 
            nameValue.Location = new Point(271, 115);
            nameValue.Name = "nameValue";
            nameValue.PlaceholderText = "Иван";
            nameValue.Size = new Size(230, 43);
            nameValue.TabIndex = 18;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(271, 74);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(72, 38);
            nameLabel.TabIndex = 17;
            nameLabel.Text = "Имя";
            // 
            // surnameValue
            // 
            surnameValue.Location = new Point(19, 115);
            surnameValue.Name = "surnameValue";
            surnameValue.PlaceholderText = "Иванов";
            surnameValue.Size = new Size(230, 43);
            surnameValue.TabIndex = 16;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(19, 74);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(132, 38);
            surnameLabel.TabIndex = 15;
            surnameLabel.Text = "Фамилия";
            // 
            // patronymicValue
            // 
            patronymicValue.Location = new Point(523, 115);
            patronymicValue.Name = "patronymicValue";
            patronymicValue.PlaceholderText = "Иванович";
            patronymicValue.Size = new Size(243, 43);
            patronymicValue.TabIndex = 20;
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Location = new Point(523, 74);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new Size(135, 38);
            patronymicLabel.TabIndex = 19;
            patronymicLabel.Text = "Отчество";
            // 
            // mailValue
            // 
            mailValue.Location = new Point(19, 288);
            mailValue.Name = "mailValue";
            mailValue.PlaceholderText = "mailaddress@mail.ru";
            mailValue.Size = new Size(333, 43);
            mailValue.TabIndex = 22;
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new Point(19, 247);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(94, 38);
            mailLabel.TabIndex = 21;
            mailLabel.Text = "Почта";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(19, 334);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(233, 38);
            phoneNumberLabel.TabIndex = 23;
            phoneNumberLabel.Text = "Номер телефона";
            // 
            // phoneNumberValue
            // 
            phoneNumberValue.Location = new Point(19, 375);
            phoneNumberValue.Mask = "+7(000)000-00-00";
            phoneNumberValue.Name = "phoneNumberValue";
            phoneNumberValue.Size = new Size(237, 43);
            phoneNumberValue.TabIndex = 25;
            // 
            // cancelButton
            // 
            cancelButton.FlatAppearance.BorderColor = Color.Silver;
            cancelButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            cancelButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.FromArgb(0, 121, 194);
            cancelButton.Location = new Point(502, 447);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(129, 55);
            cancelButton.TabIndex = 73;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // actionButton
            // 
            actionButton.FlatAppearance.BorderColor = Color.Silver;
            actionButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            actionButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            actionButton.FlatStyle = FlatStyle.Flat;
            actionButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            actionButton.ForeColor = Color.FromArgb(0, 121, 194);
            actionButton.Location = new Point(637, 447);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(129, 55);
            actionButton.TabIndex = 72;
            actionButton.Text = "ОК";
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
            // 
            // isAdminValue
            // 
            isAdminValue.AutoSize = true;
            isAdminValue.Location = new Point(15, 424);
            isAdminValue.Name = "isAdminValue";
            isAdminValue.Size = new Size(237, 42);
            isAdminValue.TabIndex = 75;
            isAdminValue.Text = "Администратор";
            isAdminValue.UseVisualStyleBackColor = true;
            // 
            // passwordGroupBox
            // 
            passwordGroupBox.Controls.Add(secondPasswordValue);
            passwordGroupBox.Controls.Add(fistPasswordValue);
            passwordGroupBox.ForeColor = Color.FromArgb(0, 121, 194);
            passwordGroupBox.Location = new Point(439, 181);
            passwordGroupBox.Name = "passwordGroupBox";
            passwordGroupBox.Size = new Size(325, 150);
            passwordGroupBox.TabIndex = 76;
            passwordGroupBox.TabStop = false;
            passwordGroupBox.Text = "Пароль";
            // 
            // secondPasswordValue
            // 
            secondPasswordValue.Location = new Point(6, 91);
            secondPasswordValue.Name = "secondPasswordValue";
            secondPasswordValue.PlaceholderText = "Новый пароль еще раз";
            secondPasswordValue.Size = new Size(313, 43);
            secondPasswordValue.TabIndex = 1;
            secondPasswordValue.UseSystemPasswordChar = true;
            // 
            // fistPasswordValue
            // 
            fistPasswordValue.Location = new Point(6, 42);
            fistPasswordValue.Name = "fistPasswordValue";
            fistPasswordValue.PlaceholderText = "Введите новый пароль";
            fistPasswordValue.Size = new Size(313, 43);
            fistPasswordValue.TabIndex = 0;
            fistPasswordValue.UseSystemPasswordChar = true;
            // 
            // positionValue
            // 
            positionValue.DropDownStyle = ComboBoxStyle.DropDownList;
            positionValue.FormattingEnabled = true;
            positionValue.Location = new Point(19, 199);
            positionValue.Name = "positionValue";
            positionValue.Size = new Size(333, 45);
            positionValue.TabIndex = 77;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new Point(12, 158);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(158, 38);
            positionLabel.TabIndex = 78;
            positionLabel.Text = "Должность";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(776, 514);
            Controls.Add(positionLabel);
            Controls.Add(positionValue);
            Controls.Add(passwordGroupBox);
            Controls.Add(isAdminValue);
            Controls.Add(cancelButton);
            Controls.Add(actionButton);
            Controls.Add(phoneNumberValue);
            Controls.Add(phoneNumberLabel);
            Controls.Add(mailValue);
            Controls.Add(mailLabel);
            Controls.Add(patronymicValue);
            Controls.Add(patronymicLabel);
            Controls.Add(nameValue);
            Controls.Add(nameLabel);
            Controls.Add(surnameValue);
            Controls.Add(surnameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сотрудник";
            passwordGroupBox.ResumeLayout(false);
            passwordGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox nameValue;
        private Label nameLabel;
        private TextBox surnameValue;
        private Label surnameLabel;
        private TextBox patronymicValue;
        private Label patronymicLabel;
        private TextBox mailValue;
        private Label mailLabel;
        private Label phoneNumberLabel;
        private MaskedTextBox phoneNumberValue;
        private Button cancelButton;
        private Button actionButton;
        private CheckBox isAdminValue;
        private GroupBox passwordGroupBox;
        private TextBox secondPasswordValue;
        private TextBox fistPasswordValue;
        private ComboBox positionValue;
        private Label positionLabel;
    }
}