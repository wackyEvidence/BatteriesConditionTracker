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
            headerLabel = new Label();
            modelComboBox = new ComboBox();
            modelLabel = new Label();
            linkLabel1 = new LinkLabel();
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
            photosGroupBox = new GroupBox();
            pictureBox1 = new PictureBox();
            previousPhotoButton = new Button();
            nextPhotoButton = new Button();
            addPhotoButton = new Button();
            deletePhotoButton = new Button();
            addBatteryButton = new Button();
            cancelButton = new Button();
            photosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(15, 9);
            headerLabel.Margin = new Padding(6, 0, 6, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(345, 62);
            headerLabel.TabIndex = 9;
            headerLabel.Text = "headerLabelText";
            // 
            // modelComboBox
            // 
            modelComboBox.FormattingEnabled = true;
            modelComboBox.Location = new Point(15, 130);
            modelComboBox.Name = "modelComboBox";
            modelComboBox.Size = new Size(369, 45);
            modelComboBox.TabIndex = 11;
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
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(212, 99);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(172, 28);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Добавить новую ";
            // 
            // exploitationEndValue
            // 
            exploitationEndValue.Location = new Point(15, 395);
            exploitationEndValue.Name = "exploitationEndValue";
            exploitationEndValue.Size = new Size(250, 43);
            exploitationEndValue.TabIndex = 61;
            // 
            // exploitationStartValue
            // 
            exploitationStartValue.Location = new Point(15, 308);
            exploitationStartValue.Name = "exploitationStartValue";
            exploitationStartValue.Size = new Size(250, 43);
            exploitationStartValue.TabIndex = 60;
            // 
            // replacementStatusComboBox
            // 
            replacementStatusComboBox.FormattingEnabled = true;
            replacementStatusComboBox.Location = new Point(319, 219);
            replacementStatusComboBox.Name = "replacementStatusComboBox";
            replacementStatusComboBox.Size = new Size(249, 45);
            replacementStatusComboBox.TabIndex = 58;
            // 
            // responsibleEmployeeComboBox
            // 
            responsibleEmployeeComboBox.FormattingEnabled = true;
            responsibleEmployeeComboBox.Location = new Point(12, 737);
            responsibleEmployeeComboBox.Name = "responsibleEmployeeComboBox";
            responsibleEmployeeComboBox.Size = new Size(553, 45);
            responsibleEmployeeComboBox.TabIndex = 59;
            // 
            // replacementStatusLabel
            // 
            replacementStatusLabel.AutoSize = true;
            replacementStatusLabel.Location = new Point(319, 178);
            replacementStatusLabel.Name = "replacementStatusLabel";
            replacementStatusLabel.Size = new Size(202, 38);
            replacementStatusLabel.TabIndex = 56;
            replacementStatusLabel.Text = "Статус замены";
            // 
            // responsibleEmployeeLabel
            // 
            responsibleEmployeeLabel.AutoSize = true;
            responsibleEmployeeLabel.Location = new Point(12, 696);
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
            exploitationStatusComboBox.Size = new Size(278, 45);
            exploitationStatusComboBox.TabIndex = 54;
            // 
            // additionalNotesValue
            // 
            additionalNotesValue.ForeColor = Color.Gray;
            additionalNotesValue.Location = new Point(12, 571);
            additionalNotesValue.Name = "additionalNotesValue";
            additionalNotesValue.Size = new Size(553, 122);
            additionalNotesValue.TabIndex = 55;
            additionalNotesValue.Text = "Место установки, особенности эксплуатации АКБ и т.п.";
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
            additionalNotesLabel.Location = new Point(12, 530);
            additionalNotesLabel.Name = "additionalNotesLabel";
            additionalNotesLabel.Size = new Size(180, 38);
            additionalNotesLabel.TabIndex = 53;
            additionalNotesLabel.Text = "Примечания";
            // 
            // structureComboBox
            // 
            structureComboBox.FormattingEnabled = true;
            structureComboBox.Location = new Point(15, 482);
            structureComboBox.Name = "structureComboBox";
            structureComboBox.Size = new Size(283, 45);
            structureComboBox.TabIndex = 51;
            // 
            // subsystemComboBox
            // 
            subsystemComboBox.FormattingEnabled = true;
            subsystemComboBox.Location = new Point(319, 482);
            subsystemComboBox.Name = "subsystemComboBox";
            subsystemComboBox.Size = new Size(249, 45);
            subsystemComboBox.TabIndex = 50;
            // 
            // subsystemLabel
            // 
            subsystemLabel.AutoSize = true;
            subsystemLabel.Location = new Point(319, 441);
            subsystemLabel.Name = "subsystemLabel";
            subsystemLabel.Size = new Size(170, 38);
            subsystemLabel.TabIndex = 49;
            subsystemLabel.Text = "Подсистема";
            // 
            // structureLabel
            // 
            structureLabel.AutoSize = true;
            structureLabel.Location = new Point(15, 441);
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
            exploitationStartLabel.Size = new Size(353, 38);
            exploitationStartLabel.TabIndex = 46;
            exploitationStartLabel.Text = "Дата начала эксплуатации";
            // 
            // exploitationEndLabel
            // 
            exploitationEndLabel.AutoSize = true;
            exploitationEndLabel.Location = new Point(15, 354);
            exploitationEndLabel.Name = "exploitationEndLabel";
            exploitationEndLabel.Size = new Size(402, 38);
            exploitationEndLabel.TabIndex = 47;
            exploitationEndLabel.Text = "Дата окончания эксплуатации";
            // 
            // photosGroupBox
            // 
            photosGroupBox.Controls.Add(pictureBox1);
            photosGroupBox.Controls.Add(previousPhotoButton);
            photosGroupBox.Controls.Add(nextPhotoButton);
            photosGroupBox.Controls.Add(addPhotoButton);
            photosGroupBox.Controls.Add(deletePhotoButton);
            photosGroupBox.ForeColor = Color.FromArgb(0, 121, 194);
            photosGroupBox.Location = new Point(574, 107);
            photosGroupBox.Name = "photosGroupBox";
            photosGroupBox.Size = new Size(402, 604);
            photosGroupBox.TabIndex = 68;
            photosGroupBox.TabStop = false;
            photosGroupBox.Text = "Фотографии";
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(6, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 419);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // previousPhotoButton
            // 
            previousPhotoButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            previousPhotoButton.ForeColor = Color.FromArgb(0, 121, 194);
            previousPhotoButton.Location = new Point(6, 468);
            previousPhotoButton.Name = "previousPhotoButton";
            previousPhotoButton.Size = new Size(78, 55);
            previousPhotoButton.TabIndex = 27;
            previousPhotoButton.Text = "<";
            previousPhotoButton.UseVisualStyleBackColor = true;
            // 
            // nextPhotoButton
            // 
            nextPhotoButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            nextPhotoButton.ForeColor = Color.FromArgb(0, 121, 194);
            nextPhotoButton.Location = new Point(313, 467);
            nextPhotoButton.Name = "nextPhotoButton";
            nextPhotoButton.Size = new Size(81, 55);
            nextPhotoButton.TabIndex = 28;
            nextPhotoButton.Text = ">";
            nextPhotoButton.UseVisualStyleBackColor = true;
            // 
            // addPhotoButton
            // 
            addPhotoButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            addPhotoButton.ForeColor = Color.FromArgb(0, 121, 194);
            addPhotoButton.Location = new Point(90, 468);
            addPhotoButton.Name = "addPhotoButton";
            addPhotoButton.Size = new Size(217, 55);
            addPhotoButton.TabIndex = 25;
            addPhotoButton.Text = "Добавить фото";
            addPhotoButton.UseVisualStyleBackColor = true;
            // 
            // deletePhotoButton
            // 
            deletePhotoButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            deletePhotoButton.ForeColor = Color.FromArgb(0, 121, 194);
            deletePhotoButton.Location = new Point(90, 526);
            deletePhotoButton.Name = "deletePhotoButton";
            deletePhotoButton.Size = new Size(217, 55);
            deletePhotoButton.TabIndex = 26;
            deletePhotoButton.Text = "Удалить фото";
            deletePhotoButton.UseVisualStyleBackColor = true;
            // 
            // addBatteryButton
            // 
            addBatteryButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            addBatteryButton.ForeColor = Color.FromArgb(0, 121, 194);
            addBatteryButton.Location = new Point(847, 727);
            addBatteryButton.Name = "addBatteryButton";
            addBatteryButton.Size = new Size(129, 55);
            addBatteryButton.TabIndex = 29;
            addBatteryButton.Text = "ОК";
            addBatteryButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.FromArgb(0, 121, 194);
            cancelButton.Location = new Point(712, 727);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(129, 55);
            cancelButton.TabIndex = 69;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // BatteryAddingForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(987, 791);
            Controls.Add(cancelButton);
            Controls.Add(addBatteryButton);
            Controls.Add(photosGroupBox);
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
            Controls.Add(linkLabel1);
            Controls.Add(modelLabel);
            Controls.Add(headerLabel);
            Controls.Add(modelComboBox);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Margin = new Padding(6);
            Name = "BatteryAddingForm";
            Text = "BatteryAddingForm";
            photosGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ComboBox modelComboBox;
        private Label modelLabel;
        private LinkLabel linkLabel1;
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
        private GroupBox photosGroupBox;
        private PictureBox pictureBox1;
        private Button previousPhotoButton;
        private Button nextPhotoButton;
        private Button addPhotoButton;
        private Button deletePhotoButton;
        private Button addBatteryButton;
        private Button cancelButton;
    }
}