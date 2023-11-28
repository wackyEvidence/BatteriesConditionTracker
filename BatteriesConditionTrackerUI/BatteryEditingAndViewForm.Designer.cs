namespace BatteriesConditionTrackerUI
{
    partial class BatteryEditingAndViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatteryEditingAndViewForm));
            headerLabel = new Label();
            tabControl1 = new TabControl();
            tabPageMainInfo = new TabPage();
            lengthValue = new TextBox();
            widthValue = new TextBox();
            heightValue = new TextBox();
            xLabel2 = new Label();
            xLabel1 = new Label();
            sizesLabel = new Label();
            clampTypeValue = new TextBox();
            technologyValue = new TextBox();
            nameLabel = new Label();
            nameValue = new TextBox();
            costValue = new TextBox();
            technologyLabel = new Label();
            brandLabel = new Label();
            brandValue = new TextBox();
            clampTypeLabel = new Label();
            groupBox1 = new GroupBox();
            bufferServiceTimeValue = new NumericUpDown();
            sohThresholdLabel = new Label();
            sohThresholdValue = new TextBox();
            bufferModeServiceTimeLabel = new Label();
            costLabel = new Label();
            voltageValue = new TextBox();
            voltageLabel = new Label();
            capacityValue = new TextBox();
            capacityLabel = new Label();
            tabPageExtraInfo = new TabPage();
            replacementStatusValue = new ComboBox();
            replacementStatusLabel = new Label();
            exploitationEndValue = new DateTimePicker();
            exploitationStartValue = new DateTimePicker();
            responsibleEmployeeValue = new ComboBox();
            responsibleEmployeeLabel = new Label();
            exploitationStatusValue = new ComboBox();
            additionalNotesValue = new RichTextBox();
            exploitationStatusLabel = new Label();
            additionalNotesLabel = new Label();
            structureValue = new ComboBox();
            subsystemValue = new ComboBox();
            subsystemLabel = new Label();
            structureLabel = new Label();
            exploitationStartLabel = new Label();
            exploitationEndLabel = new Label();
            tabPageSoHMeasures = new TabPage();
            sohMeasureGroupBox = new GroupBox();
            performingEmployeeValue = new ComboBox();
            performingEmployeeLabel = new Label();
            measureDateValue = new DateTimePicker();
            measureDateLabel = new Label();
            sohValue = new TextBox();
            sohLabel = new Label();
            deleteSoHMeasure = new Button();
            editSoHMeasure = new Button();
            addSoHMeasure = new Button();
            dataGridView1 = new DataGridView();
            cancelButton = new Button();
            actionButton = new Button();
            tabControl1.SuspendLayout();
            tabPageMainInfo.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bufferServiceTimeValue).BeginInit();
            tabPageExtraInfo.SuspendLayout();
            tabPageSoHMeasures.SuspendLayout();
            sohMeasureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 24F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(2, 7);
            headerLabel.Margin = new Padding(6, 0, 6, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(470, 54);
            headerLabel.TabIndex = 8;
            headerLabel.Text = " Изменение аккумулятора";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageMainInfo);
            tabControl1.Controls.Add(tabPageExtraInfo);
            tabControl1.Controls.Add(tabPageSoHMeasures);
            tabControl1.Location = new Point(12, 66);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(590, 684);
            tabControl1.TabIndex = 24;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPageMainInfo
            // 
            tabPageMainInfo.Controls.Add(lengthValue);
            tabPageMainInfo.Controls.Add(widthValue);
            tabPageMainInfo.Controls.Add(heightValue);
            tabPageMainInfo.Controls.Add(xLabel2);
            tabPageMainInfo.Controls.Add(xLabel1);
            tabPageMainInfo.Controls.Add(sizesLabel);
            tabPageMainInfo.Controls.Add(clampTypeValue);
            tabPageMainInfo.Controls.Add(technologyValue);
            tabPageMainInfo.Controls.Add(nameLabel);
            tabPageMainInfo.Controls.Add(nameValue);
            tabPageMainInfo.Controls.Add(costValue);
            tabPageMainInfo.Controls.Add(technologyLabel);
            tabPageMainInfo.Controls.Add(brandLabel);
            tabPageMainInfo.Controls.Add(brandValue);
            tabPageMainInfo.Controls.Add(clampTypeLabel);
            tabPageMainInfo.Controls.Add(groupBox1);
            tabPageMainInfo.Controls.Add(costLabel);
            tabPageMainInfo.Controls.Add(voltageValue);
            tabPageMainInfo.Controls.Add(voltageLabel);
            tabPageMainInfo.Controls.Add(capacityValue);
            tabPageMainInfo.Controls.Add(capacityLabel);
            tabPageMainInfo.Location = new Point(4, 46);
            tabPageMainInfo.Name = "tabPageMainInfo";
            tabPageMainInfo.Padding = new Padding(3);
            tabPageMainInfo.Size = new Size(582, 634);
            tabPageMainInfo.TabIndex = 0;
            tabPageMainInfo.Text = "Основные";
            tabPageMainInfo.UseVisualStyleBackColor = true;
            // 
            // lengthValue
            // 
            lengthValue.Location = new Point(7, 133);
            lengthValue.Name = "lengthValue";
            lengthValue.Size = new Size(125, 43);
            lengthValue.TabIndex = 81;
            // 
            // widthValue
            // 
            widthValue.Location = new Point(156, 133);
            widthValue.Name = "widthValue";
            widthValue.Size = new Size(125, 43);
            widthValue.TabIndex = 82;
            // 
            // heightValue
            // 
            heightValue.Location = new Point(305, 133);
            heightValue.Name = "heightValue";
            heightValue.Size = new Size(125, 43);
            heightValue.TabIndex = 83;
            // 
            // xLabel2
            // 
            xLabel2.AutoSize = true;
            xLabel2.Location = new Point(280, 136);
            xLabel2.Name = "xLabel2";
            xLabel2.Size = new Size(30, 38);
            xLabel2.TabIndex = 85;
            xLabel2.Text = "x";
            // 
            // xLabel1
            // 
            xLabel1.AutoSize = true;
            xLabel1.Location = new Point(130, 136);
            xLabel1.Name = "xLabel1";
            xLabel1.Size = new Size(30, 38);
            xLabel1.TabIndex = 84;
            xLabel1.Text = "x";
            // 
            // sizesLabel
            // 
            sizesLabel.AutoSize = true;
            sizesLabel.Location = new Point(13, 92);
            sizesLabel.Name = "sizesLabel";
            sizesLabel.Size = new Size(276, 38);
            sizesLabel.TabIndex = 80;
            sizesLabel.Text = "Размер (ДxШxВ, мм)";
            // 
            // clampTypeValue
            // 
            clampTypeValue.Location = new Point(295, 394);
            clampTypeValue.Name = "clampTypeValue";
            clampTypeValue.Size = new Size(187, 43);
            clampTypeValue.TabIndex = 49;
            // 
            // technologyValue
            // 
            technologyValue.Location = new Point(6, 394);
            technologyValue.Name = "technologyValue";
            technologyValue.Size = new Size(249, 43);
            technologyValue.TabIndex = 48;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(6, 3);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(139, 38);
            nameLabel.TabIndex = 46;
            nameLabel.Text = "Название";
            // 
            // nameValue
            // 
            nameValue.Location = new Point(6, 44);
            nameValue.Name = "nameValue";
            nameValue.Size = new Size(553, 43);
            nameValue.TabIndex = 47;
            // 
            // costValue
            // 
            costValue.Location = new Point(294, 220);
            costValue.Name = "costValue";
            costValue.Size = new Size(249, 43);
            costValue.TabIndex = 43;
            // 
            // technologyLabel
            // 
            technologyLabel.AutoSize = true;
            technologyLabel.Location = new Point(7, 353);
            technologyLabel.Name = "technologyLabel";
            technologyLabel.Size = new Size(164, 38);
            technologyLabel.TabIndex = 29;
            technologyLabel.Text = "Технология";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new Point(13, 179);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(95, 38);
            brandLabel.TabIndex = 26;
            brandLabel.Text = "Бренд";
            // 
            // brandValue
            // 
            brandValue.Location = new Point(7, 220);
            brandValue.Name = "brandValue";
            brandValue.Size = new Size(249, 43);
            brandValue.TabIndex = 27;
            // 
            // clampTypeLabel
            // 
            clampTypeLabel.AutoSize = true;
            clampTypeLabel.Location = new Point(295, 353);
            clampTypeLabel.Name = "clampTypeLabel";
            clampTypeLabel.Size = new Size(156, 38);
            clampTypeLabel.TabIndex = 34;
            clampTypeLabel.Text = "Тип клемм";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(bufferServiceTimeValue);
            groupBox1.Controls.Add(sohThresholdLabel);
            groupBox1.Controls.Add(sohThresholdValue);
            groupBox1.Controls.Add(bufferModeServiceTimeLabel);
            groupBox1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox1.Location = new Point(7, 454);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 169);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            groupBox1.Text = "Срок службы";
            // 
            // bufferServiceTimeValue
            // 
            bufferServiceTimeValue.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            bufferServiceTimeValue.Location = new Point(367, 34);
            bufferServiceTimeValue.Name = "bufferServiceTimeValue";
            bufferServiceTimeValue.Size = new Size(70, 43);
            bufferServiceTimeValue.TabIndex = 45;
            // 
            // sohThresholdLabel
            // 
            sohThresholdLabel.AutoSize = true;
            sohThresholdLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            sohThresholdLabel.Location = new Point(6, 83);
            sohThresholdLabel.Name = "sohThresholdLabel";
            sohThresholdLabel.Size = new Size(249, 76);
            sohThresholdLabel.TabIndex = 42;
            sohThresholdLabel.Text = "Минимальное\r\nзначение SoH (%):\r\n";
            // 
            // sohThresholdValue
            // 
            sohThresholdValue.Location = new Point(261, 120);
            sohThresholdValue.Name = "sohThresholdValue";
            sohThresholdValue.Size = new Size(69, 43);
            sohThresholdValue.TabIndex = 43;
            // 
            // bufferModeServiceTimeLabel
            // 
            bufferModeServiceTimeLabel.AutoSize = true;
            bufferModeServiceTimeLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            bufferModeServiceTimeLabel.Location = new Point(6, 41);
            bufferModeServiceTimeLabel.Name = "bufferModeServiceTimeLabel";
            bufferModeServiceTimeLabel.Size = new Size(355, 38);
            bufferModeServiceTimeLabel.TabIndex = 40;
            bufferModeServiceTimeLabel.Text = "В буферном режиме (лет):";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(293, 179);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(221, 38);
            costLabel.TabIndex = 36;
            costLabel.Text = "Стоимость (руб)";
            // 
            // voltageValue
            // 
            voltageValue.Location = new Point(294, 307);
            voltageValue.Name = "voltageValue";
            voltageValue.Size = new Size(249, 43);
            voltageValue.TabIndex = 31;
            // 
            // voltageLabel
            // 
            voltageLabel.AutoSize = true;
            voltageLabel.Location = new Point(294, 266);
            voltageLabel.Name = "voltageLabel";
            voltageLabel.Size = new Size(220, 38);
            voltageLabel.TabIndex = 30;
            voltageLabel.Text = "Напряжение (В)";
            // 
            // capacityValue
            // 
            capacityValue.Location = new Point(6, 307);
            capacityValue.Name = "capacityValue";
            capacityValue.Size = new Size(249, 43);
            capacityValue.TabIndex = 29;
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Location = new Point(6, 266);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new Size(177, 38);
            capacityLabel.TabIndex = 28;
            capacityLabel.Text = "Емкость (Ач)";
            // 
            // tabPageExtraInfo
            // 
            tabPageExtraInfo.Controls.Add(replacementStatusValue);
            tabPageExtraInfo.Controls.Add(replacementStatusLabel);
            tabPageExtraInfo.Controls.Add(exploitationEndValue);
            tabPageExtraInfo.Controls.Add(exploitationStartValue);
            tabPageExtraInfo.Controls.Add(responsibleEmployeeValue);
            tabPageExtraInfo.Controls.Add(responsibleEmployeeLabel);
            tabPageExtraInfo.Controls.Add(exploitationStatusValue);
            tabPageExtraInfo.Controls.Add(additionalNotesValue);
            tabPageExtraInfo.Controls.Add(exploitationStatusLabel);
            tabPageExtraInfo.Controls.Add(additionalNotesLabel);
            tabPageExtraInfo.Controls.Add(structureValue);
            tabPageExtraInfo.Controls.Add(subsystemValue);
            tabPageExtraInfo.Controls.Add(subsystemLabel);
            tabPageExtraInfo.Controls.Add(structureLabel);
            tabPageExtraInfo.Controls.Add(exploitationStartLabel);
            tabPageExtraInfo.Controls.Add(exploitationEndLabel);
            tabPageExtraInfo.Location = new Point(4, 29);
            tabPageExtraInfo.Name = "tabPageExtraInfo";
            tabPageExtraInfo.Padding = new Padding(3);
            tabPageExtraInfo.Size = new Size(582, 651);
            tabPageExtraInfo.TabIndex = 1;
            tabPageExtraInfo.Text = "Дополнительно";
            tabPageExtraInfo.UseVisualStyleBackColor = true;
            // 
            // replacementStatusValue
            // 
            replacementStatusValue.FormattingEnabled = true;
            replacementStatusValue.Items.AddRange(new object[] { "требует замены", "не требует замены", "заменен" });
            replacementStatusValue.Location = new Point(304, 44);
            replacementStatusValue.Name = "replacementStatusValue";
            replacementStatusValue.Size = new Size(271, 45);
            replacementStatusValue.TabIndex = 47;
            replacementStatusValue.SelectedIndexChanged += replacementStatusValue_SelectedIndexChanged;
            // 
            // replacementStatusLabel
            // 
            replacementStatusLabel.AutoSize = true;
            replacementStatusLabel.Location = new Point(310, 3);
            replacementStatusLabel.Name = "replacementStatusLabel";
            replacementStatusLabel.Size = new Size(202, 38);
            replacementStatusLabel.TabIndex = 46;
            replacementStatusLabel.Text = "Статус замены";
            // 
            // exploitationEndValue
            // 
            exploitationEndValue.Location = new Point(6, 220);
            exploitationEndValue.Name = "exploitationEndValue";
            exploitationEndValue.Size = new Size(250, 43);
            exploitationEndValue.TabIndex = 45;
            // 
            // exploitationStartValue
            // 
            exploitationStartValue.Location = new Point(6, 133);
            exploitationStartValue.Name = "exploitationStartValue";
            exploitationStartValue.Size = new Size(250, 43);
            exploitationStartValue.TabIndex = 44;
            // 
            // responsibleEmployeeValue
            // 
            responsibleEmployeeValue.FormattingEnabled = true;
            responsibleEmployeeValue.Location = new Point(6, 572);
            responsibleEmployeeValue.Name = "responsibleEmployeeValue";
            responsibleEmployeeValue.Size = new Size(569, 45);
            responsibleEmployeeValue.TabIndex = 43;
            // 
            // responsibleEmployeeLabel
            // 
            responsibleEmployeeLabel.AutoSize = true;
            responsibleEmployeeLabel.Location = new Point(6, 531);
            responsibleEmployeeLabel.Name = "responsibleEmployeeLabel";
            responsibleEmployeeLabel.Size = new Size(351, 38);
            responsibleEmployeeLabel.TabIndex = 42;
            responsibleEmployeeLabel.Text = "Ответственный сотрудник";
            // 
            // exploitationStatusValue
            // 
            exploitationStatusValue.FormattingEnabled = true;
            exploitationStatusValue.Location = new Point(6, 44);
            exploitationStatusValue.Name = "exploitationStatusValue";
            exploitationStatusValue.Size = new Size(283, 45);
            exploitationStatusValue.TabIndex = 41;
            exploitationStatusValue.SelectedIndexChanged += exploitationStatusValue_SelectedIndexChanged;
            // 
            // additionalNotesValue
            // 
            additionalNotesValue.ForeColor = Color.Gray;
            additionalNotesValue.Location = new Point(6, 406);
            additionalNotesValue.Name = "additionalNotesValue";
            additionalNotesValue.Size = new Size(569, 122);
            additionalNotesValue.TabIndex = 41;
            additionalNotesValue.Text = "Место установки, особенности эксплуатации АКБ и т.д. и т.п.";
            additionalNotesValue.Enter += additionalNotesValue_Enter;
            additionalNotesValue.Leave += additionalNotesValue_Leave;
            // 
            // exploitationStatusLabel
            // 
            exploitationStatusLabel.AutoSize = true;
            exploitationStatusLabel.Location = new Point(6, 3);
            exploitationStatusLabel.Name = "exploitationStatusLabel";
            exploitationStatusLabel.Size = new Size(278, 38);
            exploitationStatusLabel.TabIndex = 40;
            exploitationStatusLabel.Text = "Статус эксплуатации";
            // 
            // additionalNotesLabel
            // 
            additionalNotesLabel.AutoSize = true;
            additionalNotesLabel.Location = new Point(6, 365);
            additionalNotesLabel.Name = "additionalNotesLabel";
            additionalNotesLabel.Size = new Size(180, 38);
            additionalNotesLabel.TabIndex = 40;
            additionalNotesLabel.Text = "Примечания";
            // 
            // structureValue
            // 
            structureValue.FormattingEnabled = true;
            structureValue.Location = new Point(6, 307);
            structureValue.Name = "structureValue";
            structureValue.Size = new Size(283, 45);
            structureValue.TabIndex = 39;
            // 
            // subsystemValue
            // 
            subsystemValue.FormattingEnabled = true;
            subsystemValue.Location = new Point(310, 307);
            subsystemValue.Name = "subsystemValue";
            subsystemValue.Size = new Size(265, 45);
            subsystemValue.TabIndex = 38;
            // 
            // subsystemLabel
            // 
            subsystemLabel.AutoSize = true;
            subsystemLabel.Location = new Point(310, 266);
            subsystemLabel.Name = "subsystemLabel";
            subsystemLabel.Size = new Size(170, 38);
            subsystemLabel.TabIndex = 36;
            subsystemLabel.Text = "Подсистема";
            // 
            // structureLabel
            // 
            structureLabel.AutoSize = true;
            structureLabel.Location = new Point(6, 266);
            structureLabel.Name = "structureLabel";
            structureLabel.Size = new Size(111, 38);
            structureLabel.TabIndex = 34;
            structureLabel.Text = "Объект";
            // 
            // exploitationStartLabel
            // 
            exploitationStartLabel.AutoSize = true;
            exploitationStartLabel.Location = new Point(6, 92);
            exploitationStartLabel.Name = "exploitationStartLabel";
            exploitationStartLabel.Size = new Size(353, 38);
            exploitationStartLabel.TabIndex = 30;
            exploitationStartLabel.Text = "Дата начала эксплуатации";
            // 
            // exploitationEndLabel
            // 
            exploitationEndLabel.AutoSize = true;
            exploitationEndLabel.Location = new Point(6, 179);
            exploitationEndLabel.Name = "exploitationEndLabel";
            exploitationEndLabel.Size = new Size(402, 38);
            exploitationEndLabel.TabIndex = 32;
            exploitationEndLabel.Text = "Дата окончания эксплуатации";
            // 
            // tabPageSoHMeasures
            // 
            tabPageSoHMeasures.Controls.Add(sohMeasureGroupBox);
            tabPageSoHMeasures.Controls.Add(deleteSoHMeasure);
            tabPageSoHMeasures.Controls.Add(editSoHMeasure);
            tabPageSoHMeasures.Controls.Add(addSoHMeasure);
            tabPageSoHMeasures.Controls.Add(dataGridView1);
            tabPageSoHMeasures.Location = new Point(4, 46);
            tabPageSoHMeasures.Name = "tabPageSoHMeasures";
            tabPageSoHMeasures.Size = new Size(582, 634);
            tabPageSoHMeasures.TabIndex = 2;
            tabPageSoHMeasures.Text = "Замеры SoH";
            tabPageSoHMeasures.UseVisualStyleBackColor = true;
            // 
            // sohMeasureGroupBox
            // 
            sohMeasureGroupBox.Controls.Add(performingEmployeeValue);
            sohMeasureGroupBox.Controls.Add(performingEmployeeLabel);
            sohMeasureGroupBox.Controls.Add(measureDateValue);
            sohMeasureGroupBox.Controls.Add(measureDateLabel);
            sohMeasureGroupBox.Controls.Add(sohValue);
            sohMeasureGroupBox.Controls.Add(sohLabel);
            sohMeasureGroupBox.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            sohMeasureGroupBox.ForeColor = Color.FromArgb(0, 121, 194);
            sohMeasureGroupBox.Location = new Point(12, 327);
            sohMeasureGroupBox.Name = "sohMeasureGroupBox";
            sohMeasureGroupBox.Size = new Size(559, 227);
            sohMeasureGroupBox.TabIndex = 4;
            sohMeasureGroupBox.TabStop = false;
            sohMeasureGroupBox.Text = "Замер емкости";
            // 
            // performingEmployeeValue
            // 
            performingEmployeeValue.FormattingEnabled = true;
            performingEmployeeValue.Location = new Point(6, 166);
            performingEmployeeValue.Name = "performingEmployeeValue";
            performingEmployeeValue.Size = new Size(544, 45);
            performingEmployeeValue.TabIndex = 5;
            // 
            // performingEmployeeLabel
            // 
            performingEmployeeLabel.AutoSize = true;
            performingEmployeeLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            performingEmployeeLabel.Location = new Point(6, 126);
            performingEmployeeLabel.Name = "performingEmployeeLabel";
            performingEmployeeLabel.Size = new Size(436, 38);
            performingEmployeeLabel.TabIndex = 4;
            performingEmployeeLabel.Text = "Сотрудник, проводивший замер:";
            // 
            // measureDateValue
            // 
            measureDateValue.Location = new Point(279, 81);
            measureDateValue.Name = "measureDateValue";
            measureDateValue.Size = new Size(271, 43);
            measureDateValue.TabIndex = 3;
            // 
            // measureDateLabel
            // 
            measureDateLabel.AutoSize = true;
            measureDateLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            measureDateLabel.Location = new Point(279, 40);
            measureDateLabel.Name = "measureDateLabel";
            measureDateLabel.Size = new Size(174, 38);
            measureDateLabel.TabIndex = 2;
            measureDateLabel.Text = "Дата замера";
            // 
            // sohValue
            // 
            sohValue.Location = new Point(6, 80);
            sohValue.Name = "sohValue";
            sohValue.Size = new Size(246, 43);
            sohValue.TabIndex = 1;
            // 
            // sohLabel
            // 
            sohLabel.AutoSize = true;
            sohLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            sohLabel.Location = new Point(6, 39);
            sohLabel.Name = "sohLabel";
            sohLabel.Size = new Size(246, 38);
            sohLabel.TabIndex = 0;
            sohLabel.Text = "Значение SoH (%)";
            // 
            // deleteSoHMeasure
            // 
            deleteSoHMeasure.Location = new Point(424, 560);
            deleteSoHMeasure.Name = "deleteSoHMeasure";
            deleteSoHMeasure.Size = new Size(147, 58);
            deleteSoHMeasure.TabIndex = 3;
            deleteSoHMeasure.Text = "Удалить";
            deleteSoHMeasure.UseVisualStyleBackColor = true;
            deleteSoHMeasure.Click += deleteSoHMeasure_Click;
            // 
            // editSoHMeasure
            // 
            editSoHMeasure.Location = new Point(165, 560);
            editSoHMeasure.Name = "editSoHMeasure";
            editSoHMeasure.Size = new Size(216, 58);
            editSoHMeasure.TabIndex = 2;
            editSoHMeasure.Text = "Редактировать";
            editSoHMeasure.UseVisualStyleBackColor = true;
            editSoHMeasure.Click += editSoHMeasure_Click;
            // 
            // addSoHMeasure
            // 
            addSoHMeasure.Location = new Point(12, 560);
            addSoHMeasure.Name = "addSoHMeasure";
            addSoHMeasure.Size = new Size(147, 58);
            addSoHMeasure.TabIndex = 1;
            addSoHMeasure.Text = "Добавить";
            addSoHMeasure.UseVisualStyleBackColor = true;
            addSoHMeasure.Click += addSoHMeasure_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(559, 318);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.FromArgb(0, 121, 194);
            cancelButton.Location = new Point(338, 756);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(129, 55);
            cancelButton.TabIndex = 71;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // actionButton
            // 
            actionButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            actionButton.ForeColor = Color.FromArgb(0, 121, 194);
            actionButton.Location = new Point(473, 756);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(129, 55);
            actionButton.TabIndex = 70;
            actionButton.Text = "ОК";
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
            // 
            // BatteryEditingAndViewForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(614, 819);
            Controls.Add(cancelButton);
            Controls.Add(actionButton);
            Controls.Add(tabControl1);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "BatteryEditingAndViewForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Аккумулятор";
            tabControl1.ResumeLayout(false);
            tabPageMainInfo.ResumeLayout(false);
            tabPageMainInfo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bufferServiceTimeValue).EndInit();
            tabPageExtraInfo.ResumeLayout(false);
            tabPageExtraInfo.PerformLayout();
            tabPageSoHMeasures.ResumeLayout(false);
            sohMeasureGroupBox.ResumeLayout(false);
            sohMeasureGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TabControl tabControl1;
        private TabPage tabPageMainInfo;
        private TabPage tabPageExtraInfo;
        private Label technologyLabel;
        private TextBox voltageValue;
        private Label brandLabel;
        private Label voltageLabel;
        private TextBox brandValue;
        private TextBox capacityValue;
        private Label capacityLabel;
        private Label costLabel;
        private Label clampTypeLabel;
        private GroupBox groupBox1;
        private Label sohThresholdLabel;
        private TextBox sohThresholdValue;
        private Label bufferModeServiceTimeLabel;
        private TextBox costValue;
        private ComboBox structureValue;
        private ComboBox subsystemValue;
        private Label subsystemLabel;
        private Label structureLabel;
        private Label exploitationStartLabel;
        private Label exploitationEndLabel;
        private Label additionalNotesLabel;
        private RichTextBox additionalNotesValue;
        private ComboBox responsibleEmployeeValue;
        private Label responsibleEmployeeLabel;
        private Label nameLabel;
        private TextBox nameValue;
        private ComboBox exploitationStatusValue;
        private Label exploitationStatusLabel;
        private TabPage tabPageSoHMeasures;
        private Button deleteSoHMeasure;
        private Button editSoHMeasure;
        private Button addSoHMeasure;
        private DataGridView dataGridView1;
        private DateTimePicker exploitationEndValue;
        private DateTimePicker exploitationStartValue;
        private GroupBox sohMeasureGroupBox;
        private TextBox sohValue;
        private Label sohLabel;
        private ComboBox performingEmployeeValue;
        private Label performingEmployeeLabel;
        private DateTimePicker measureDateValue;
        private Label measureDateLabel;
        private NumericUpDown bufferServiceTimeValue;
        private TextBox clampTypeValue;
        private TextBox technologyValue;
        private ComboBox replacementStatusValue;
        private Label replacementStatusLabel;
        private Button cancelButton;
        private Button actionButton;
        private TextBox lengthValue;
        private TextBox widthValue;
        private TextBox heightValue;
        private Label xLabel2;
        private Label xLabel1;
        private Label sizesLabel;
    }
}