namespace BatteriesConditionTrackerUI
{
    partial class BatteryModelForm
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
            nameLabel = new Label();
            nameValue = new TextBox();
            brandValue = new TextBox();
            brandLabel = new Label();
            capacityValue = new TextBox();
            capacityLabel = new Label();
            voltageValue = new TextBox();
            voltageLabel = new Label();
            sizesMaskedTextBox = new MaskedTextBox();
            sizesLabel = new Label();
            clampTypeComboBox = new ComboBox();
            clampTypeLabel = new Label();
            technologyComboBox = new ComboBox();
            technologyLabel = new Label();
            serviceTimeGroupBox = new GroupBox();
            bufferServiceTimeValue = new NumericUpDown();
            minSoHLabel = new Label();
            minSoHValue = new TextBox();
            bufferServiceTimeLabel = new Label();
            batteryPhotosGroupBox = new GroupBox();
            pictureBox = new PictureBox();
            previousPhotoButton = new Button();
            nextPhotoButton = new Button();
            addPhotoButton = new Button();
            deletePhotoButton = new Button();
            addBatteryTechnologyLinkLabel = new LinkLabel();
            addClampTypeLabel = new LinkLabel();
            cancelButton = new Button();
            OkButton = new Button();
            costValue = new TextBox();
            costLabel = new Label();
            serviceTimeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bufferServiceTimeValue).BeginInit();
            batteryPhotosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
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
            headerLabel.TabIndex = 10;
            headerLabel.Text = "headerLabelText";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(15, 92);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(139, 38);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Название";
            // 
            // nameValue
            // 
            nameValue.Location = new Point(18, 133);
            nameValue.Name = "nameValue";
            nameValue.Size = new Size(502, 43);
            nameValue.TabIndex = 12;
            // 
            // brandValue
            // 
            brandValue.Location = new Point(15, 220);
            brandValue.Name = "brandValue";
            brandValue.Size = new Size(230, 43);
            brandValue.TabIndex = 14;
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new Point(12, 179);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(95, 38);
            brandLabel.TabIndex = 13;
            brandLabel.Text = "Бренд";
            // 
            // capacityValue
            // 
            capacityValue.Location = new Point(15, 393);
            capacityValue.Name = "capacityValue";
            capacityValue.Size = new Size(230, 43);
            capacityValue.TabIndex = 16;
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Location = new Point(12, 352);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new Size(177, 38);
            capacityLabel.TabIndex = 15;
            capacityLabel.Text = "Емкость (Ач)";
            // 
            // voltageValue
            // 
            voltageValue.Location = new Point(290, 393);
            voltageValue.Name = "voltageValue";
            voltageValue.Size = new Size(230, 43);
            voltageValue.TabIndex = 18;
            // 
            // voltageLabel
            // 
            voltageLabel.AutoSize = true;
            voltageLabel.Location = new Point(286, 353);
            voltageLabel.Name = "voltageLabel";
            voltageLabel.Size = new Size(220, 38);
            voltageLabel.TabIndex = 17;
            voltageLabel.Text = "Напряжение (В)";
            // 
            // sizesMaskedTextBox
            // 
            sizesMaskedTextBox.Location = new Point(18, 481);
            sizesMaskedTextBox.Mask = "999x999x999";
            sizesMaskedTextBox.Name = "sizesMaskedTextBox";
            sizesMaskedTextBox.Size = new Size(227, 43);
            sizesMaskedTextBox.TabIndex = 30;
            // 
            // sizesLabel
            // 
            sizesLabel.AutoSize = true;
            sizesLabel.Location = new Point(12, 440);
            sizesLabel.Name = "sizesLabel";
            sizesLabel.Size = new Size(276, 38);
            sizesLabel.TabIndex = 29;
            sizesLabel.Text = "Размер (ДxШxВ, мм)";
            // 
            // clampTypeComboBox
            // 
            clampTypeComboBox.FormattingEnabled = true;
            clampTypeComboBox.Location = new Point(290, 305);
            clampTypeComboBox.Name = "clampTypeComboBox";
            clampTypeComboBox.Size = new Size(230, 45);
            clampTypeComboBox.TabIndex = 39;
            // 
            // clampTypeLabel
            // 
            clampTypeLabel.AutoSize = true;
            clampTypeLabel.Location = new Point(286, 266);
            clampTypeLabel.Name = "clampTypeLabel";
            clampTypeLabel.Size = new Size(156, 38);
            clampTypeLabel.TabIndex = 38;
            clampTypeLabel.Text = "Тип клемм";
            // 
            // technologyComboBox
            // 
            technologyComboBox.FormattingEnabled = true;
            technologyComboBox.Location = new Point(15, 304);
            technologyComboBox.Name = "technologyComboBox";
            technologyComboBox.Size = new Size(230, 45);
            technologyComboBox.TabIndex = 37;
            // 
            // technologyLabel
            // 
            technologyLabel.AutoSize = true;
            technologyLabel.Location = new Point(15, 266);
            technologyLabel.Name = "technologyLabel";
            technologyLabel.Size = new Size(164, 38);
            technologyLabel.TabIndex = 36;
            technologyLabel.Text = "Технология";
            // 
            // serviceTimeGroupBox
            // 
            serviceTimeGroupBox.BackColor = Color.Transparent;
            serviceTimeGroupBox.Controls.Add(bufferServiceTimeValue);
            serviceTimeGroupBox.Controls.Add(minSoHLabel);
            serviceTimeGroupBox.Controls.Add(minSoHValue);
            serviceTimeGroupBox.Controls.Add(bufferServiceTimeLabel);
            serviceTimeGroupBox.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            serviceTimeGroupBox.ForeColor = Color.FromArgb(0, 121, 194);
            serviceTimeGroupBox.Location = new Point(12, 530);
            serviceTimeGroupBox.Name = "serviceTimeGroupBox";
            serviceTimeGroupBox.Size = new Size(508, 169);
            serviceTimeGroupBox.TabIndex = 43;
            serviceTimeGroupBox.TabStop = false;
            serviceTimeGroupBox.Text = "Срок службы";
            // 
            // bufferServiceTimeValue
            // 
            bufferServiceTimeValue.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            bufferServiceTimeValue.Location = new Point(368, 34);
            bufferServiceTimeValue.Name = "bufferServiceTimeValue";
            bufferServiceTimeValue.Size = new Size(70, 43);
            bufferServiceTimeValue.TabIndex = 44;
            // 
            // minSoHLabel
            // 
            minSoHLabel.AutoSize = true;
            minSoHLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            minSoHLabel.Location = new Point(6, 80);
            minSoHLabel.Name = "minSoHLabel";
            minSoHLabel.Size = new Size(249, 76);
            minSoHLabel.TabIndex = 42;
            minSoHLabel.Text = "Минимальное\r\nзначение SoH (%):";
            // 
            // minSoHValue
            // 
            minSoHValue.Location = new Point(261, 113);
            minSoHValue.Name = "minSoHValue";
            minSoHValue.Size = new Size(92, 43);
            minSoHValue.TabIndex = 43;
            // 
            // bufferServiceTimeLabel
            // 
            bufferServiceTimeLabel.AutoSize = true;
            bufferServiceTimeLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            bufferServiceTimeLabel.Location = new Point(6, 39);
            bufferServiceTimeLabel.Name = "bufferServiceTimeLabel";
            bufferServiceTimeLabel.Size = new Size(355, 38);
            bufferServiceTimeLabel.TabIndex = 40;
            bufferServiceTimeLabel.Text = "В буферном режиме (лет):";
            // 
            // batteryPhotosGroupBox
            // 
            batteryPhotosGroupBox.Controls.Add(pictureBox);
            batteryPhotosGroupBox.Controls.Add(previousPhotoButton);
            batteryPhotosGroupBox.Controls.Add(nextPhotoButton);
            batteryPhotosGroupBox.Controls.Add(addPhotoButton);
            batteryPhotosGroupBox.Controls.Add(deletePhotoButton);
            batteryPhotosGroupBox.ForeColor = Color.FromArgb(0, 121, 194);
            batteryPhotosGroupBox.Location = new Point(528, 92);
            batteryPhotosGroupBox.Name = "batteryPhotosGroupBox";
            batteryPhotosGroupBox.Size = new Size(402, 607);
            batteryPhotosGroupBox.TabIndex = 68;
            batteryPhotosGroupBox.TabStop = false;
            batteryPhotosGroupBox.Text = "Фотографии";
            // 
            // pictureBox
            // 
            pictureBox.InitialImage = null;
            pictureBox.Location = new Point(6, 39);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(388, 442);
            pictureBox.TabIndex = 16;
            pictureBox.TabStop = false;
            // 
            // previousPhotoButton
            // 
            previousPhotoButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            previousPhotoButton.ForeColor = Color.FromArgb(0, 121, 194);
            previousPhotoButton.Location = new Point(6, 487);
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
            nextPhotoButton.Location = new Point(313, 486);
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
            addPhotoButton.Location = new Point(90, 487);
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
            deletePhotoButton.Location = new Point(90, 545);
            deletePhotoButton.Name = "deletePhotoButton";
            deletePhotoButton.Size = new Size(217, 55);
            deletePhotoButton.TabIndex = 26;
            deletePhotoButton.Text = "Удалить фото";
            deletePhotoButton.UseVisualStyleBackColor = true;
            // 
            // addBatteryTechnologyLinkLabel
            // 
            addBatteryTechnologyLinkLabel.AutoSize = true;
            addBatteryTechnologyLinkLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            addBatteryTechnologyLinkLabel.Location = new Point(179, 276);
            addBatteryTechnologyLinkLabel.Name = "addBatteryTechnologyLinkLabel";
            addBatteryTechnologyLinkLabel.Size = new Size(88, 25);
            addBatteryTechnologyLinkLabel.TabIndex = 69;
            addBatteryTechnologyLinkLabel.TabStop = true;
            addBatteryTechnologyLinkLabel.Text = "добавить";
            // 
            // addClampTypeLabel
            // 
            addClampTypeLabel.AutoSize = true;
            addClampTypeLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            addClampTypeLabel.Location = new Point(440, 276);
            addClampTypeLabel.Name = "addClampTypeLabel";
            addClampTypeLabel.Size = new Size(88, 25);
            addClampTypeLabel.TabIndex = 70;
            addClampTypeLabel.TabStop = true;
            addClampTypeLabel.Text = "добавить";
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.FromArgb(0, 121, 194);
            cancelButton.Location = new Point(666, 705);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(129, 55);
            cancelButton.TabIndex = 72;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            OkButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            OkButton.ForeColor = Color.FromArgb(0, 121, 194);
            OkButton.Location = new Point(801, 705);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(129, 55);
            OkButton.TabIndex = 71;
            OkButton.Text = "ОК";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // costValue
            // 
            costValue.Location = new Point(290, 220);
            costValue.Name = "costValue";
            costValue.Size = new Size(230, 43);
            costValue.TabIndex = 74;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(290, 179);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(221, 38);
            costLabel.TabIndex = 73;
            costLabel.Text = "Стоимость (руб)";
            // 
            // BatteryModelForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(936, 767);
            Controls.Add(costValue);
            Controls.Add(costLabel);
            Controls.Add(cancelButton);
            Controls.Add(OkButton);
            Controls.Add(addClampTypeLabel);
            Controls.Add(addBatteryTechnologyLinkLabel);
            Controls.Add(batteryPhotosGroupBox);
            Controls.Add(serviceTimeGroupBox);
            Controls.Add(clampTypeComboBox);
            Controls.Add(clampTypeLabel);
            Controls.Add(technologyComboBox);
            Controls.Add(technologyLabel);
            Controls.Add(sizesMaskedTextBox);
            Controls.Add(sizesLabel);
            Controls.Add(voltageValue);
            Controls.Add(voltageLabel);
            Controls.Add(capacityValue);
            Controls.Add(capacityLabel);
            Controls.Add(brandValue);
            Controls.Add(brandLabel);
            Controls.Add(nameValue);
            Controls.Add(nameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Margin = new Padding(6);
            Name = "BatteryModelForm";
            Text = "BatteryModelForm";
            serviceTimeGroupBox.ResumeLayout(false);
            serviceTimeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bufferServiceTimeValue).EndInit();
            batteryPhotosGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label nameLabel;
        private TextBox nameValue;
        private TextBox brandValue;
        private Label brandLabel;
        private TextBox capacityValue;
        private Label capacityLabel;
        private TextBox voltageValue;
        private Label voltageLabel;
        private MaskedTextBox sizesMaskedTextBox;
        private Label sizesLabel;
        private ComboBox clampTypeComboBox;
        private Label clampTypeLabel;
        private ComboBox technologyComboBox;
        private Label technologyLabel;
        private GroupBox serviceTimeGroupBox;
        private Label minSoHLabel;
        private TextBox minSoHValue;
        private Label bufferServiceTimeLabel;
        private GroupBox batteryPhotosGroupBox;
        private PictureBox pictureBox;
        private Button previousPhotoButton;
        private Button nextPhotoButton;
        private Button addPhotoButton;
        private Button deletePhotoButton;
        private LinkLabel addBatteryTechnologyLinkLabel;
        private LinkLabel addClampTypeLabel;
        private Button cancelButton;
        private Button OkButton;
        private TextBox costValue;
        private Label costLabel;
        private NumericUpDown bufferServiceTimeValue;
    }
}