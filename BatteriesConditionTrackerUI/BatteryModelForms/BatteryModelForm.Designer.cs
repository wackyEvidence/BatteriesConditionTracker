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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatteryModelForm));
            headerLabel = new Label();
            nameLabel = new Label();
            nameValue = new TextBox();
            brandValue = new TextBox();
            brandLabel = new Label();
            capacityValue = new TextBox();
            capacityLabel = new Label();
            voltageValue = new TextBox();
            voltageLabel = new Label();
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
            addBatteryTechnologyLinkLabel = new LinkLabel();
            addClampTypeLabel = new LinkLabel();
            cancelButton = new Button();
            actionButton = new Button();
            costValue = new TextBox();
            costLabel = new Label();
            lengthValue = new TextBox();
            widthValue = new TextBox();
            heightValue = new TextBox();
            xLabel1 = new Label();
            xLabel2 = new Label();
            serviceTimeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bufferServiceTimeValue).BeginInit();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(2, 0);
            headerLabel.Margin = new Padding(6, 0, 6, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(253, 60);
            headerLabel.TabIndex = 10;
            headerLabel.Text = "headerLabel";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(15, 66);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(139, 38);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Название";
            // 
            // nameValue
            // 
            nameValue.Location = new Point(18, 107);
            nameValue.Name = "nameValue";
            nameValue.Size = new Size(502, 43);
            nameValue.TabIndex = 12;
            // 
            // brandValue
            // 
            brandValue.Location = new Point(15, 194);
            brandValue.Name = "brandValue";
            brandValue.Size = new Size(230, 43);
            brandValue.TabIndex = 14;
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new Point(15, 153);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(95, 38);
            brandLabel.TabIndex = 13;
            brandLabel.Text = "Бренд";
            // 
            // capacityValue
            // 
            capacityValue.Location = new Point(15, 367);
            capacityValue.Name = "capacityValue";
            capacityValue.Size = new Size(230, 43);
            capacityValue.TabIndex = 16;
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Location = new Point(12, 326);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new Size(177, 38);
            capacityLabel.TabIndex = 15;
            capacityLabel.Text = "Емкость (Ач)";
            // 
            // voltageValue
            // 
            voltageValue.Location = new Point(290, 367);
            voltageValue.Name = "voltageValue";
            voltageValue.Size = new Size(230, 43);
            voltageValue.TabIndex = 18;
            // 
            // voltageLabel
            // 
            voltageLabel.AutoSize = true;
            voltageLabel.Location = new Point(286, 327);
            voltageLabel.Name = "voltageLabel";
            voltageLabel.Size = new Size(220, 38);
            voltageLabel.TabIndex = 17;
            voltageLabel.Text = "Напряжение (В)";
            // 
            // sizesLabel
            // 
            sizesLabel.AutoSize = true;
            sizesLabel.Location = new Point(12, 414);
            sizesLabel.Name = "sizesLabel";
            sizesLabel.Size = new Size(276, 38);
            sizesLabel.TabIndex = 29;
            sizesLabel.Text = "Размер (ДxШxВ, мм)";
            // 
            // clampTypeComboBox
            // 
            clampTypeComboBox.FormattingEnabled = true;
            clampTypeComboBox.Location = new Point(290, 279);
            clampTypeComboBox.Name = "clampTypeComboBox";
            clampTypeComboBox.Size = new Size(230, 45);
            clampTypeComboBox.TabIndex = 39;
            // 
            // clampTypeLabel
            // 
            clampTypeLabel.AutoSize = true;
            clampTypeLabel.Location = new Point(286, 240);
            clampTypeLabel.Name = "clampTypeLabel";
            clampTypeLabel.Size = new Size(156, 38);
            clampTypeLabel.TabIndex = 38;
            clampTypeLabel.Text = "Тип клемм";
            // 
            // technologyComboBox
            // 
            technologyComboBox.FormattingEnabled = true;
            technologyComboBox.Location = new Point(15, 278);
            technologyComboBox.Name = "technologyComboBox";
            technologyComboBox.Size = new Size(230, 45);
            technologyComboBox.TabIndex = 37;
            // 
            // technologyLabel
            // 
            technologyLabel.AutoSize = true;
            technologyLabel.Location = new Point(15, 240);
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
            serviceTimeGroupBox.Location = new Point(12, 504);
            serviceTimeGroupBox.Name = "serviceTimeGroupBox";
            serviceTimeGroupBox.Size = new Size(508, 169);
            serviceTimeGroupBox.TabIndex = 43;
            serviceTimeGroupBox.TabStop = false;
            serviceTimeGroupBox.Text = "Срок службы";
            // 
            // bufferServiceTimeValue
            // 
            bufferServiceTimeValue.DecimalPlaces = 1;
            bufferServiceTimeValue.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            bufferServiceTimeValue.Location = new Point(368, 34);
            bufferServiceTimeValue.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            bufferServiceTimeValue.Name = "bufferServiceTimeValue";
            bufferServiceTimeValue.Size = new Size(94, 43);
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
            // addBatteryTechnologyLinkLabel
            // 
            addBatteryTechnologyLinkLabel.AutoSize = true;
            addBatteryTechnologyLinkLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            addBatteryTechnologyLinkLabel.Location = new Point(179, 250);
            addBatteryTechnologyLinkLabel.Name = "addBatteryTechnologyLinkLabel";
            addBatteryTechnologyLinkLabel.Size = new Size(88, 25);
            addBatteryTechnologyLinkLabel.TabIndex = 69;
            addBatteryTechnologyLinkLabel.TabStop = true;
            addBatteryTechnologyLinkLabel.Text = "добавить";
            addBatteryTechnologyLinkLabel.LinkClicked += addBatteryTechnologyLinkLabel_LinkClicked;
            // 
            // addClampTypeLabel
            // 
            addClampTypeLabel.AutoSize = true;
            addClampTypeLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            addClampTypeLabel.Location = new Point(434, 250);
            addClampTypeLabel.Name = "addClampTypeLabel";
            addClampTypeLabel.Size = new Size(88, 25);
            addClampTypeLabel.TabIndex = 70;
            addClampTypeLabel.TabStop = true;
            addClampTypeLabel.Text = "добавить";
            addClampTypeLabel.LinkClicked += addClampTypeLabel_LinkClicked;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.FromArgb(0, 121, 194);
            cancelButton.Location = new Point(256, 679);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(129, 55);
            cancelButton.TabIndex = 72;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // actionButton
            // 
            actionButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            actionButton.ForeColor = Color.FromArgb(0, 121, 194);
            actionButton.Location = new Point(391, 679);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(129, 55);
            actionButton.TabIndex = 71;
            actionButton.Text = "ОК";
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
            // 
            // costValue
            // 
            costValue.Location = new Point(290, 194);
            costValue.Name = "costValue";
            costValue.Size = new Size(230, 43);
            costValue.TabIndex = 74;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(290, 153);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(221, 38);
            costLabel.TabIndex = 73;
            costLabel.Text = "Стоимость (руб)";
            // 
            // lengthValue
            // 
            lengthValue.Location = new Point(18, 460);
            lengthValue.Name = "lengthValue";
            lengthValue.Size = new Size(125, 43);
            lengthValue.TabIndex = 75;
            // 
            // widthValue
            // 
            widthValue.Location = new Point(167, 460);
            widthValue.Name = "widthValue";
            widthValue.Size = new Size(125, 43);
            widthValue.TabIndex = 76;
            // 
            // heightValue
            // 
            heightValue.Location = new Point(316, 460);
            heightValue.Name = "heightValue";
            heightValue.Size = new Size(125, 43);
            heightValue.TabIndex = 77;
            // 
            // xLabel1
            // 
            xLabel1.AutoSize = true;
            xLabel1.Location = new Point(141, 463);
            xLabel1.Name = "xLabel1";
            xLabel1.Size = new Size(30, 38);
            xLabel1.TabIndex = 78;
            xLabel1.Text = "x";
            // 
            // xLabel2
            // 
            xLabel2.AutoSize = true;
            xLabel2.Location = new Point(291, 463);
            xLabel2.Name = "xLabel2";
            xLabel2.Size = new Size(30, 38);
            xLabel2.TabIndex = 79;
            xLabel2.Text = "x";
            // 
            // BatteryModelForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(534, 741);
            Controls.Add(lengthValue);
            Controls.Add(widthValue);
            Controls.Add(heightValue);
            Controls.Add(xLabel2);
            Controls.Add(xLabel1);
            Controls.Add(costValue);
            Controls.Add(costLabel);
            Controls.Add(cancelButton);
            Controls.Add(actionButton);
            Controls.Add(addClampTypeLabel);
            Controls.Add(addBatteryTechnologyLinkLabel);
            Controls.Add(serviceTimeGroupBox);
            Controls.Add(clampTypeComboBox);
            Controls.Add(clampTypeLabel);
            Controls.Add(technologyComboBox);
            Controls.Add(technologyLabel);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "BatteryModelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Модель аккумулятора";
            serviceTimeGroupBox.ResumeLayout(false);
            serviceTimeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bufferServiceTimeValue).EndInit();
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
        private Label sizesLabel;
        private ComboBox clampTypeComboBox;
        private Label clampTypeLabel;
        private ComboBox technologyComboBox;
        private Label technologyLabel;
        private GroupBox serviceTimeGroupBox;
        private Label minSoHLabel;
        private TextBox minSoHValue;
        private Label bufferServiceTimeLabel;
        private LinkLabel addBatteryTechnologyLinkLabel;
        private LinkLabel addClampTypeLabel;
        private Button cancelButton;
        private Button actionButton;
        private TextBox costValue;
        private Label costLabel;
        private NumericUpDown bufferServiceTimeValue;
        private TextBox lengthValue;
        private TextBox widthValue;
        private TextBox heightValue;
        private Label xLabel1;
        private Label xLabel2;
    }
}