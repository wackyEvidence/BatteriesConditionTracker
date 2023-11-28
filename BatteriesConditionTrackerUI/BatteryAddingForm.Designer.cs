namespace BatteriesConditionTrackerUI
{
    partial class BatteryAddingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatteryAddingForm));
            headerLabel = new Label();
            modelComboBox = new ComboBox();
            modelLabel = new Label();
            addBatteryModel = new LinkLabel();
            exploitationEndValue = new DateTimePicker();
            exploitationStartValue = new DateTimePicker();
            replacementStatusComboBox = new ComboBox();
            responsibleEmployeeComboBox = new ComboBox();
            replacementStatusLabel = new Label();
            responsibleEmployeeLabel = new Label();
            exploitationStatusComboBox = new ComboBox();
            additionalNotesValue = new RichTextBox();
            exploitationStatusLabel = new Label();
            additionalNotesLabel = new Label();
            structureComboBox = new ComboBox();
            subsystemComboBox = new ComboBox();
            subsystemLabel = new Label();
            structureLabel = new Label();
            exploitationStartLabel = new Label();
            exploitationEndLabel = new Label();
            actionButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(15, 9);
            headerLabel.Margin = new Padding(6, 0, 6, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(525, 60);
            headerLabel.TabIndex = 9;
            headerLabel.Text = "Добавление аккумулятора";
            // 
            // modelComboBox
            // 
            modelComboBox.FormattingEnabled = true;
            modelComboBox.Location = new Point(15, 130);
            modelComboBox.Name = "modelComboBox";
            modelComboBox.Size = new Size(369, 45);
            modelComboBox.TabIndex = 0;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            modelLabel.Location = new Point(15, 89);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(117, 38);
            modelLabel.TabIndex = 12;
            modelLabel.Text = "Модель";
            // 
            // addBatteryModel
            // 
            addBatteryModel.AutoSize = true;
            addBatteryModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addBatteryModel.Location = new Point(212, 99);
            addBatteryModel.Name = "addBatteryModel";
            addBatteryModel.Size = new Size(172, 28);
            addBatteryModel.TabIndex = 13;
            addBatteryModel.TabStop = true;
            addBatteryModel.Text = "Добавить новую ";
            addBatteryModel.LinkClicked += addBatteryModel_LinkClicked;
            // 
            // exploitationEndValue
            // 
            exploitationEndValue.Location = new Point(322, 308);
            exploitationEndValue.Name = "exploitationEndValue";
            exploitationEndValue.Size = new Size(287, 43);
            exploitationEndValue.TabIndex = 4;
            // 
            // exploitationStartValue
            // 
            exploitationStartValue.Location = new Point(15, 308);
            exploitationStartValue.Name = "exploitationStartValue";
            exploitationStartValue.Size = new Size(287, 43);
            exploitationStartValue.TabIndex = 3;
            // 
            // replacementStatusComboBox
            // 
            replacementStatusComboBox.FormattingEnabled = true;
            replacementStatusComboBox.Location = new Point(322, 219);
            replacementStatusComboBox.Name = "replacementStatusComboBox";
            replacementStatusComboBox.Size = new Size(300, 45);
            replacementStatusComboBox.TabIndex = 2;
            // 
            // responsibleEmployeeComboBox
            // 
            responsibleEmployeeComboBox.FormattingEnabled = true;
            responsibleEmployeeComboBox.Location = new Point(15, 650);
            responsibleEmployeeComboBox.Name = "responsibleEmployeeComboBox";
            responsibleEmployeeComboBox.Size = new Size(610, 45);
            responsibleEmployeeComboBox.TabIndex = 8;
            // 
            // replacementStatusLabel
            // 
            replacementStatusLabel.AutoSize = true;
            replacementStatusLabel.Location = new Point(322, 178);
            replacementStatusLabel.Name = "replacementStatusLabel";
            replacementStatusLabel.Size = new Size(202, 38);
            replacementStatusLabel.TabIndex = 56;
            replacementStatusLabel.Text = "Статус замены";
            // 
            // responsibleEmployeeLabel
            // 
            responsibleEmployeeLabel.AutoSize = true;
            responsibleEmployeeLabel.Location = new Point(15, 609);
            responsibleEmployeeLabel.Name = "responsibleEmployeeLabel";
            responsibleEmployeeLabel.Size = new Size(339, 38);
            responsibleEmployeeLabel.TabIndex = 57;
            responsibleEmployeeLabel.Text = "Ответственный работник";
            // 
            // exploitationStatusComboBox
            // 
            exploitationStatusComboBox.FormattingEnabled = true;
            exploitationStatusComboBox.Location = new Point(15, 219);
            exploitationStatusComboBox.Name = "exploitationStatusComboBox";
            exploitationStatusComboBox.Size = new Size(287, 45);
            exploitationStatusComboBox.TabIndex = 1;
            exploitationStatusComboBox.SelectedIndexChanged += exploitationStatusComboBox_SelectedIndexChanged;
            // 
            // additionalNotesValue
            // 
            additionalNotesValue.ForeColor = Color.Gray;
            additionalNotesValue.Location = new Point(15, 484);
            additionalNotesValue.Name = "additionalNotesValue";
            additionalNotesValue.Size = new Size(553, 122);
            additionalNotesValue.TabIndex = 7;
            additionalNotesValue.Text = "Место установки, особенности эксплуатации АКБ и т.п.";
            additionalNotesValue.Enter += additionalNotesValue_Enter;
            additionalNotesValue.Leave += additionalNotesValue_Leave;
            // 
            // exploitationStatusLabel
            // 
            exploitationStatusLabel.AutoSize = true;
            exploitationStatusLabel.Location = new Point(12, 178);
            exploitationStatusLabel.Name = "exploitationStatusLabel";
            exploitationStatusLabel.Size = new Size(278, 38);
            exploitationStatusLabel.TabIndex = 52;
            exploitationStatusLabel.Text = "Статус эксплуатации";
            // 
            // additionalNotesLabel
            // 
            additionalNotesLabel.AutoSize = true;
            additionalNotesLabel.Location = new Point(15, 443);
            additionalNotesLabel.Name = "additionalNotesLabel";
            additionalNotesLabel.Size = new Size(180, 38);
            additionalNotesLabel.TabIndex = 53;
            additionalNotesLabel.Text = "Примечания";
            // 
            // structureComboBox
            // 
            structureComboBox.FormattingEnabled = true;
            structureComboBox.Location = new Point(15, 395);
            structureComboBox.Name = "structureComboBox";
            structureComboBox.Size = new Size(307, 45);
            structureComboBox.TabIndex = 5;
            // 
            // subsystemComboBox
            // 
            subsystemComboBox.FormattingEnabled = true;
            subsystemComboBox.Location = new Point(344, 395);
            subsystemComboBox.Name = "subsystemComboBox";
            subsystemComboBox.Size = new Size(280, 45);
            subsystemComboBox.TabIndex = 6;
            // 
            // subsystemLabel
            // 
            subsystemLabel.AutoSize = true;
            subsystemLabel.Location = new Point(342, 354);
            subsystemLabel.Name = "subsystemLabel";
            subsystemLabel.Size = new Size(170, 38);
            subsystemLabel.TabIndex = 49;
            subsystemLabel.Text = "Подсистема";
            // 
            // structureLabel
            // 
            structureLabel.AutoSize = true;
            structureLabel.Location = new Point(15, 354);
            structureLabel.Name = "structureLabel";
            structureLabel.Size = new Size(111, 38);
            structureLabel.TabIndex = 48;
            structureLabel.Text = "Объект";
            // 
            // exploitationStartLabel
            // 
            exploitationStartLabel.AutoSize = true;
            exploitationStartLabel.Location = new Point(15, 267);
            exploitationStartLabel.Name = "exploitationStartLabel";
            exploitationStartLabel.Size = new Size(293, 38);
            exploitationStartLabel.TabIndex = 46;
            exploitationStartLabel.Text = "Начало эксплуатации";
            // 
            // exploitationEndLabel
            // 
            exploitationEndLabel.AutoSize = true;
            exploitationEndLabel.Location = new Point(322, 267);
            exploitationEndLabel.Name = "exploitationEndLabel";
            exploitationEndLabel.Size = new Size(342, 38);
            exploitationEndLabel.TabIndex = 47;
            exploitationEndLabel.Text = "Окончание эксплуатации";
            // 
            // actionButton
            // 
            actionButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            actionButton.ForeColor = Color.FromArgb(0, 121, 194);
            actionButton.Location = new Point(496, 701);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(129, 55);
            actionButton.TabIndex = 29;
            actionButton.Text = "ОК";
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.FromArgb(0, 121, 194);
            cancelButton.Location = new Point(361, 701);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(129, 55);
            cancelButton.TabIndex = 69;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // BatteryAddingForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(667, 763);
            Controls.Add(cancelButton);
            Controls.Add(actionButton);
            Controls.Add(exploitationEndValue);
            Controls.Add(exploitationStartValue);
            Controls.Add(replacementStatusComboBox);
            Controls.Add(responsibleEmployeeComboBox);
            Controls.Add(replacementStatusLabel);
            Controls.Add(responsibleEmployeeLabel);
            Controls.Add(exploitationStatusComboBox);
            Controls.Add(additionalNotesValue);
            Controls.Add(exploitationStatusLabel);
            Controls.Add(additionalNotesLabel);
            Controls.Add(structureComboBox);
            Controls.Add(subsystemComboBox);
            Controls.Add(subsystemLabel);
            Controls.Add(structureLabel);
            Controls.Add(exploitationStartLabel);
            Controls.Add(exploitationEndLabel);
            Controls.Add(addBatteryModel);
            Controls.Add(modelLabel);
            Controls.Add(headerLabel);
            Controls.Add(modelComboBox);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "BatteryAddingForm";
            Text = "Аккумулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ComboBox modelComboBox;
        private Label modelLabel;
        private LinkLabel addBatteryModel;
        private DateTimePicker exploitationEndValue;
        private DateTimePicker exploitationStartValue;
        private ComboBox replacementStatusComboBox;
        private ComboBox responsibleEmployeeComboBox;
        private Label replacementStatusLabel;
        private Label responsibleEmployeeLabel;
        private ComboBox exploitationStatusComboBox;
        private RichTextBox additionalNotesValue;
        private Label exploitationStatusLabel;
        private Label additionalNotesLabel;
        private ComboBox structureComboBox;
        private ComboBox subsystemComboBox;
        private Label subsystemLabel;
        private Label structureLabel;
        private Label exploitationStartLabel;
        private Label exploitationEndLabel;
        private Button actionButton;
        private Button cancelButton;
    }
}