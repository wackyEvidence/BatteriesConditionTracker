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
            headerLabel = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPageMainInfo = new TabPage();
            nameLabel = new Label();
            nameValue = new TextBox();
            comboBox8 = new ComboBox();
            costValue = new TextBox();
            technologyLabel = new Label();
            brandLabel = new Label();
            technologyValue = new ComboBox();
            brandValue = new TextBox();
            clampTypeLabel = new Label();
            clampTypeValue = new ComboBox();
            groupBox1 = new GroupBox();
            bufferServiceTimeValue = new NumericUpDown();
            label5 = new Label();
            textBox2 = new TextBox();
            bufferModeServiceTimeLabel = new Label();
            costLabel = new Label();
            label19 = new Label();
            voltageValue = new TextBox();
            sizesValue = new MaskedTextBox();
            sizesLabel = new Label();
            voltageLabel = new Label();
            capacityValue = new TextBox();
            capacityLabel = new Label();
            tabPageExtraInfo = new TabPage();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            comboBox7 = new ComboBox();
            label18 = new Label();
            comboBox9 = new ComboBox();
            richTextBox1 = new RichTextBox();
            label20 = new Label();
            label17 = new Label();
            comboBox6 = new ComboBox();
            comboBox2 = new ComboBox();
            label15 = new Label();
            label14 = new Label();
            label6 = new Label();
            label7 = new Label();
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
            columnSoHMeasure = new DataGridViewTextBoxColumn();
            columnMeasureDate = new DataGridViewTextBoxColumn();
            columnPerformingWorker = new DataGridViewTextBoxColumn();
            addBatteryButton = new Button();
            applySortButton = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageMainInfo.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bufferServiceTimeValue).BeginInit();
            tabPageExtraInfo.SuspendLayout();
            tabPageSoHMeasures.SuspendLayout();
            sohMeasureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
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
            headerLabel.Size = new Size(270, 62);
            headerLabel.TabIndex = 8;
            headerLabel.Text = "headerLabel";
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(6, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 435);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageMainInfo);
            tabControl1.Controls.Add(tabPageExtraInfo);
            tabControl1.Controls.Add(tabPageSoHMeasures);
            tabControl1.Location = new Point(12, 87);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(573, 684);
            tabControl1.TabIndex = 24;
            // 
            // tabPageMainInfo
            // 
            tabPageMainInfo.Controls.Add(nameLabel);
            tabPageMainInfo.Controls.Add(nameValue);
            tabPageMainInfo.Controls.Add(comboBox8);
            tabPageMainInfo.Controls.Add(costValue);
            tabPageMainInfo.Controls.Add(technologyLabel);
            tabPageMainInfo.Controls.Add(brandLabel);
            tabPageMainInfo.Controls.Add(technologyValue);
            tabPageMainInfo.Controls.Add(brandValue);
            tabPageMainInfo.Controls.Add(clampTypeLabel);
            tabPageMainInfo.Controls.Add(clampTypeValue);
            tabPageMainInfo.Controls.Add(groupBox1);
            tabPageMainInfo.Controls.Add(costLabel);
            tabPageMainInfo.Controls.Add(label19);
            tabPageMainInfo.Controls.Add(voltageValue);
            tabPageMainInfo.Controls.Add(sizesValue);
            tabPageMainInfo.Controls.Add(sizesLabel);
            tabPageMainInfo.Controls.Add(voltageLabel);
            tabPageMainInfo.Controls.Add(capacityValue);
            tabPageMainInfo.Controls.Add(capacityLabel);
            tabPageMainInfo.Location = new Point(4, 46);
            tabPageMainInfo.Name = "tabPageMainInfo";
            tabPageMainInfo.Padding = new Padding(3);
            tabPageMainInfo.Size = new Size(565, 634);
            tabPageMainInfo.TabIndex = 0;
            tabPageMainInfo.Text = "Основные";
            tabPageMainInfo.UseVisualStyleBackColor = true;
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
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Items.AddRange(new object[] { "требует замены", "не требует замены", "заменен" });
            comboBox8.Location = new Point(7, 131);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(271, 45);
            comboBox8.TabIndex = 43;
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
            // technologyValue
            // 
            technologyValue.FormattingEnabled = true;
            technologyValue.Location = new Point(8, 394);
            technologyValue.Name = "technologyValue";
            technologyValue.Size = new Size(249, 45);
            technologyValue.TabIndex = 30;
            // 
            // brandValue
            // 
            brandValue.Location = new Point(8, 220);
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
            // clampTypeValue
            // 
            clampTypeValue.FormattingEnabled = true;
            clampTypeValue.Location = new Point(295, 394);
            clampTypeValue.Name = "clampTypeValue";
            clampTypeValue.Size = new Size(249, 45);
            clampTypeValue.TabIndex = 35;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(bufferServiceTimeValue);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox2);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 83);
            label5.Name = "label5";
            label5.Size = new Size(249, 76);
            label5.TabIndex = 42;
            label5.Text = "Минимальное\r\nзначение SoH (%):\r\n";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(261, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(69, 43);
            textBox2.TabIndex = 43;
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
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(12, 90);
            label19.Name = "label19";
            label19.Size = new Size(202, 38);
            label19.TabIndex = 42;
            label19.Text = "Статус замены";
            // 
            // voltageValue
            // 
            voltageValue.Location = new Point(294, 307);
            voltageValue.Name = "voltageValue";
            voltageValue.Size = new Size(249, 43);
            voltageValue.TabIndex = 31;
            // 
            // sizesValue
            // 
            sizesValue.Location = new Point(295, 131);
            sizesValue.Mask = "999x999x999";
            sizesValue.Name = "sizesValue";
            sizesValue.Size = new Size(221, 43);
            sizesValue.TabIndex = 28;
            // 
            // sizesLabel
            // 
            sizesLabel.AutoSize = true;
            sizesLabel.Location = new Point(289, 92);
            sizesLabel.Name = "sizesLabel";
            sizesLabel.Size = new Size(276, 38);
            sizesLabel.TabIndex = 27;
            sizesLabel.Text = "Размер (ДxШxВ, мм)";
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
            tabPageExtraInfo.Controls.Add(dateTimePicker2);
            tabPageExtraInfo.Controls.Add(dateTimePicker1);
            tabPageExtraInfo.Controls.Add(comboBox7);
            tabPageExtraInfo.Controls.Add(label18);
            tabPageExtraInfo.Controls.Add(comboBox9);
            tabPageExtraInfo.Controls.Add(richTextBox1);
            tabPageExtraInfo.Controls.Add(label20);
            tabPageExtraInfo.Controls.Add(label17);
            tabPageExtraInfo.Controls.Add(comboBox6);
            tabPageExtraInfo.Controls.Add(comboBox2);
            tabPageExtraInfo.Controls.Add(label15);
            tabPageExtraInfo.Controls.Add(label14);
            tabPageExtraInfo.Controls.Add(label6);
            tabPageExtraInfo.Controls.Add(label7);
            tabPageExtraInfo.Location = new Point(4, 29);
            tabPageExtraInfo.Name = "tabPageExtraInfo";
            tabPageExtraInfo.Padding = new Padding(3);
            tabPageExtraInfo.Size = new Size(565, 651);
            tabPageExtraInfo.TabIndex = 1;
            tabPageExtraInfo.Text = "Дополнительно";
            tabPageExtraInfo.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(6, 220);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 43);
            dateTimePicker2.TabIndex = 45;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 133);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 43);
            dateTimePicker1.TabIndex = 44;
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(6, 572);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(553, 45);
            comboBox7.TabIndex = 43;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 531);
            label18.Name = "label18";
            label18.Size = new Size(339, 38);
            label18.TabIndex = 42;
            label18.Text = "Ответственный работник";
            // 
            // comboBox9
            // 
            comboBox9.FormattingEnabled = true;
            comboBox9.Location = new Point(6, 44);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(553, 45);
            comboBox9.TabIndex = 41;
            // 
            // richTextBox1
            // 
            richTextBox1.ForeColor = Color.Gray;
            richTextBox1.Location = new Point(6, 406);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(553, 122);
            richTextBox1.TabIndex = 41;
            richTextBox1.Text = "Место установки, особенности эксплуатации АКБ и т.д. и т.п.";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 3);
            label20.Name = "label20";
            label20.Size = new Size(278, 38);
            label20.TabIndex = 40;
            label20.Text = "Статус эксплуатации";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 365);
            label17.Name = "label17";
            label17.Size = new Size(180, 38);
            label17.TabIndex = 40;
            label17.Text = "Примечания";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(6, 307);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(283, 45);
            comboBox6.TabIndex = 39;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(310, 307);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(249, 45);
            comboBox2.TabIndex = 38;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(310, 266);
            label15.Name = "label15";
            label15.Size = new Size(170, 38);
            label15.TabIndex = 36;
            label15.Text = "Подсистема";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 266);
            label14.Name = "label14";
            label14.Size = new Size(111, 38);
            label14.TabIndex = 34;
            label14.Text = "Объект";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 92);
            label6.Name = "label6";
            label6.Size = new Size(353, 38);
            label6.TabIndex = 30;
            label6.Text = "Дата начала эксплуатации";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 179);
            label7.Name = "label7";
            label7.Size = new Size(402, 38);
            label7.TabIndex = 32;
            label7.Text = "Дата окончания эксплуатации";
            // 
            // tabPageSoHMeasures
            // 
            tabPageSoHMeasures.Controls.Add(sohMeasureGroupBox);
            tabPageSoHMeasures.Controls.Add(deleteSoHMeasure);
            tabPageSoHMeasures.Controls.Add(editSoHMeasure);
            tabPageSoHMeasures.Controls.Add(addSoHMeasure);
            tabPageSoHMeasures.Controls.Add(dataGridView1);
            tabPageSoHMeasures.Location = new Point(4, 29);
            tabPageSoHMeasures.Name = "tabPageSoHMeasures";
            tabPageSoHMeasures.Size = new Size(565, 651);
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
            sohMeasureGroupBox.Location = new Point(6, 327);
            sohMeasureGroupBox.Name = "sohMeasureGroupBox";
            sohMeasureGroupBox.Size = new Size(556, 227);
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
            performingEmployeeLabel.Size = new Size(136, 38);
            performingEmployeeLabel.TabIndex = 4;
            performingEmployeeLabel.Text = "Работник";
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
            sohValue.Size = new Size(158, 43);
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
            deleteSoHMeasure.Location = new Point(415, 572);
            deleteSoHMeasure.Name = "deleteSoHMeasure";
            deleteSoHMeasure.Size = new Size(147, 58);
            deleteSoHMeasure.TabIndex = 3;
            deleteSoHMeasure.Text = "Удалить";
            deleteSoHMeasure.UseVisualStyleBackColor = true;
            // 
            // editSoHMeasure
            // 
            editSoHMeasure.Location = new Point(159, 572);
            editSoHMeasure.Name = "editSoHMeasure";
            editSoHMeasure.Size = new Size(216, 58);
            editSoHMeasure.TabIndex = 2;
            editSoHMeasure.Text = "Редактировать";
            editSoHMeasure.UseVisualStyleBackColor = true;
            // 
            // addSoHMeasure
            // 
            addSoHMeasure.Location = new Point(6, 572);
            addSoHMeasure.Name = "addSoHMeasure";
            addSoHMeasure.Size = new Size(147, 58);
            addSoHMeasure.TabIndex = 1;
            addSoHMeasure.Text = "Добавить";
            addSoHMeasure.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { columnSoHMeasure, columnMeasureDate, columnPerformingWorker });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(559, 318);
            dataGridView1.TabIndex = 0;
            // 
            // columnSoHMeasure
            // 
            columnSoHMeasure.HeaderText = "Значение SoH (%)";
            columnSoHMeasure.MinimumWidth = 6;
            columnSoHMeasure.Name = "columnSoHMeasure";
            columnSoHMeasure.ReadOnly = true;
            columnSoHMeasure.Width = 140;
            // 
            // columnMeasureDate
            // 
            columnMeasureDate.HeaderText = "Дата замера";
            columnMeasureDate.MinimumWidth = 6;
            columnMeasureDate.Name = "columnMeasureDate";
            columnMeasureDate.ReadOnly = true;
            columnMeasureDate.Width = 150;
            // 
            // columnPerformingWorker
            // 
            columnPerformingWorker.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnPerformingWorker.HeaderText = "Работник";
            columnPerformingWorker.MinimumWidth = 6;
            columnPerformingWorker.Name = "columnPerformingWorker";
            columnPerformingWorker.ReadOnly = true;
            // 
            // addBatteryButton
            // 
            addBatteryButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            addBatteryButton.ForeColor = Color.FromArgb(0, 121, 194);
            addBatteryButton.Location = new Point(594, 698);
            addBatteryButton.Name = "addBatteryButton";
            addBatteryButton.Size = new Size(402, 69);
            addBatteryButton.TabIndex = 14;
            addBatteryButton.Text = "Сохранить изменения";
            addBatteryButton.UseVisualStyleBackColor = true;
            // 
            // applySortButton
            // 
            applySortButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            applySortButton.ForeColor = Color.FromArgb(0, 121, 194);
            applySortButton.Location = new Point(91, 483);
            applySortButton.Name = "applySortButton";
            applySortButton.Size = new Size(217, 55);
            applySortButton.TabIndex = 25;
            applySortButton.Text = "Добавить фото";
            applySortButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 121, 194);
            button1.Location = new Point(91, 544);
            button1.Name = "button1";
            button1.Size = new Size(217, 55);
            button1.TabIndex = 26;
            button1.Text = "Удалить фото";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 121, 194);
            button2.Location = new Point(7, 483);
            button2.Name = "button2";
            button2.Size = new Size(78, 55);
            button2.TabIndex = 27;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 121, 194);
            button3.Location = new Point(314, 483);
            button3.Name = "button3";
            button3.Size = new Size(81, 55);
            button3.TabIndex = 28;
            button3.Text = ">";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(applySortButton);
            groupBox3.Controls.Add(button1);
            groupBox3.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox3.Location = new Point(594, 87);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(402, 605);
            groupBox3.TabIndex = 67;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBoxName";
            // 
            // BatteryEditingAndViewForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1004, 775);
            Controls.Add(groupBox3);
            Controls.Add(addBatteryButton);
            Controls.Add(tabControl1);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Margin = new Padding(6);
            Name = "BatteryEditingAndViewForm";
            Text = "BatteryEditingForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageMainInfo;
        private TabPage tabPageExtraInfo;
        private ComboBox technologyValue;
        private Label technologyLabel;
        private MaskedTextBox sizesValue;
        private TextBox voltageValue;
        private Label sizesLabel;
        private Label brandLabel;
        private Label voltageLabel;
        private TextBox brandValue;
        private TextBox capacityValue;
        private Label capacityLabel;
        private Label costLabel;
        private ComboBox clampTypeValue;
        private Label clampTypeLabel;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox textBox2;
        private Label bufferModeServiceTimeLabel;
        private TextBox costValue;
        private ComboBox comboBox6;
        private ComboBox comboBox2;
        private Label label15;
        private Label label14;
        private Label label6;
        private Label label7;
        private Label label17;
        private RichTextBox richTextBox1;
        private ComboBox comboBox7;
        private Label label18;
        private Label nameLabel;
        private TextBox nameValue;
        private ComboBox comboBox8;
        private Label label19;
        private ComboBox comboBox9;
        private Label label20;
        private Button addBatteryButton;
        private TabPage tabPageSoHMeasures;
        private Button applySortButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button deleteSoHMeasure;
        private Button editSoHMeasure;
        private Button addSoHMeasure;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private GroupBox sohMeasureGroupBox;
        private TextBox sohValue;
        private Label sohLabel;
        private ComboBox performingEmployeeValue;
        private Label performingEmployeeLabel;
        private DateTimePicker measureDateValue;
        private Label measureDateLabel;
        private GroupBox groupBox3;
        private DataGridViewTextBoxColumn columnSoHMeasure;
        private DataGridViewTextBoxColumn columnMeasureDate;
        private DataGridViewTextBoxColumn columnPerformingWorker;
        private NumericUpDown bufferServiceTimeValue;
    }
}