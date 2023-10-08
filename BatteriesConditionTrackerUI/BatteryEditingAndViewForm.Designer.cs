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
            batterNameLabel = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPageMainInfo = new TabPage();
            dateTimePicker3 = new DateTimePicker();
            label3 = new Label();
            textBox10 = new TextBox();
            label16 = new Label();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            comboBox5 = new ComboBox();
            textBox6 = new TextBox();
            label12 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label13 = new Label();
            label9 = new Label();
            label11 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label10 = new Label();
            tabPageExtraInfo = new TabPage();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            comboBox8 = new ComboBox();
            comboBox7 = new ComboBox();
            label19 = new Label();
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
            tabPageCapacityMeasures = new TabPage();
            groupBox2 = new GroupBox();
            comboBox3 = new ComboBox();
            label22 = new Label();
            dateTimePicker4 = new DateTimePicker();
            label21 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            columnCapacityMeasure = new DataGridViewTextBoxColumn();
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
            tabPageExtraInfo.SuspendLayout();
            tabPageCapacityMeasures.SuspendLayout();
            groupBox2.SuspendLayout();
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
            headerLabel.Size = new Size(655, 62);
            headerLabel.TabIndex = 8;
            headerLabel.Text = "Информация об аккумуляторе:";
            // 
            // batterNameLabel
            // 
            batterNameLabel.AutoSize = true;
            batterNameLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            batterNameLabel.ForeColor = Color.FromArgb(0, 121, 194);
            batterNameLabel.Location = new Point(654, 9);
            batterNameLabel.Margin = new Padding(6, 0, 6, 0);
            batterNameLabel.Name = "batterNameLabel";
            batterNameLabel.Size = new Size(349, 62);
            batterNameLabel.TabIndex = 9;
            batterNameLabel.Text = "<batteryName>";
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageMainInfo);
            tabControl1.Controls.Add(tabPageExtraInfo);
            tabControl1.Controls.Add(tabPageCapacityMeasures);
            tabControl1.Location = new Point(12, 87);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(573, 684);
            tabControl1.TabIndex = 24;
            // 
            // tabPageMainInfo
            // 
            tabPageMainInfo.Controls.Add(dateTimePicker3);
            tabPageMainInfo.Controls.Add(label3);
            tabPageMainInfo.Controls.Add(textBox10);
            tabPageMainInfo.Controls.Add(label16);
            tabPageMainInfo.Controls.Add(textBox3);
            tabPageMainInfo.Controls.Add(groupBox1);
            tabPageMainInfo.Controls.Add(label2);
            tabPageMainInfo.Controls.Add(comboBox1);
            tabPageMainInfo.Controls.Add(label1);
            tabPageMainInfo.Controls.Add(comboBox5);
            tabPageMainInfo.Controls.Add(textBox6);
            tabPageMainInfo.Controls.Add(label12);
            tabPageMainInfo.Controls.Add(maskedTextBox2);
            tabPageMainInfo.Controls.Add(label13);
            tabPageMainInfo.Controls.Add(label9);
            tabPageMainInfo.Controls.Add(label11);
            tabPageMainInfo.Controls.Add(textBox4);
            tabPageMainInfo.Controls.Add(textBox5);
            tabPageMainInfo.Controls.Add(label10);
            tabPageMainInfo.Location = new Point(4, 46);
            tabPageMainInfo.Name = "tabPageMainInfo";
            tabPageMainInfo.Padding = new Padding(3);
            tabPageMainInfo.Size = new Size(565, 634);
            tabPageMainInfo.TabIndex = 0;
            tabPageMainInfo.Text = "Основные";
            tabPageMainInfo.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(310, 399);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(250, 43);
            dateTimePicker3.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 3);
            label3.Name = "label3";
            label3.Size = new Size(139, 38);
            label3.TabIndex = 46;
            label3.Text = "Название";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(6, 44);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(553, 43);
            textBox10.TabIndex = 47;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(310, 357);
            label16.Name = "label16";
            label16.Size = new Size(189, 38);
            label16.TabIndex = 44;
            label16.Text = "Дата выпуска";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(310, 311);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 43);
            textBox3.TabIndex = 43;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox1.Location = new Point(6, 457);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 169);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            groupBox1.Text = "Срок службы";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 83);
            label5.Name = "label5";
            label5.Size = new Size(374, 76);
            label5.TabIndex = 42;
            label5.Text = "В циклическом режиме \r\n(циклов при 100% разряде):";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(386, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(69, 43);
            textBox2.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 39);
            label4.Name = "label4";
            label4.Size = new Size(355, 38);
            label4.TabIndex = 40;
            label4.Text = "В буферном режиме (лет):";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(367, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(42, 43);
            textBox1.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 270);
            label2.Name = "label2";
            label2.Size = new Size(221, 38);
            label2.TabIndex = 36;
            label2.Text = "Стоимость (руб)";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(310, 222);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(249, 45);
            comboBox1.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 181);
            label1.Name = "label1";
            label1.Size = new Size(156, 38);
            label1.TabIndex = 34;
            label1.Text = "Тип клемм";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(310, 133);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(249, 45);
            comboBox5.TabIndex = 30;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(6, 311);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(221, 43);
            textBox6.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(310, 92);
            label12.Name = "label12";
            label12.Size = new Size(164, 38);
            label12.TabIndex = 29;
            label12.Text = "Технология";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(6, 399);
            maskedTextBox2.Mask = "999x999x999";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(221, 43);
            maskedTextBox2.TabIndex = 28;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 357);
            label13.Name = "label13";
            label13.Size = new Size(222, 38);
            label13.TabIndex = 27;
            label13.Text = "Размер (ДxШxВ)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 92);
            label9.Name = "label9";
            label9.Size = new Size(95, 38);
            label9.TabIndex = 26;
            label9.Text = "Бренд";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 270);
            label11.Name = "label11";
            label11.Size = new Size(220, 38);
            label11.TabIndex = 30;
            label11.Text = "Напряжение (В)";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 133);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(221, 43);
            textBox4.TabIndex = 27;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 220);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(221, 43);
            textBox5.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 179);
            label10.Name = "label10";
            label10.Size = new Size(177, 38);
            label10.TabIndex = 28;
            label10.Text = "Емкость (Ач)";
            // 
            // tabPageExtraInfo
            // 
            tabPageExtraInfo.Controls.Add(dateTimePicker2);
            tabPageExtraInfo.Controls.Add(dateTimePicker1);
            tabPageExtraInfo.Controls.Add(comboBox8);
            tabPageExtraInfo.Controls.Add(comboBox7);
            tabPageExtraInfo.Controls.Add(label19);
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
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(310, 44);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(249, 45);
            comboBox8.TabIndex = 43;
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(6, 572);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(283, 45);
            comboBox7.TabIndex = 43;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(310, 3);
            label19.Name = "label19";
            label19.Size = new Size(202, 38);
            label19.TabIndex = 42;
            label19.Text = "Статус замены";
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
            comboBox9.Size = new Size(223, 45);
            comboBox9.TabIndex = 41;
            // 
            // richTextBox1
            // 
            richTextBox1.ForeColor = Color.Gray;
            richTextBox1.Location = new Point(6, 406);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(538, 122);
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
            // tabPageCapacityMeasures
            // 
            tabPageCapacityMeasures.Controls.Add(groupBox2);
            tabPageCapacityMeasures.Controls.Add(button6);
            tabPageCapacityMeasures.Controls.Add(button5);
            tabPageCapacityMeasures.Controls.Add(button4);
            tabPageCapacityMeasures.Controls.Add(dataGridView1);
            tabPageCapacityMeasures.Location = new Point(4, 29);
            tabPageCapacityMeasures.Name = "tabPageCapacityMeasures";
            tabPageCapacityMeasures.Size = new Size(565, 651);
            tabPageCapacityMeasures.TabIndex = 2;
            tabPageCapacityMeasures.Text = "Замеры емкости";
            tabPageCapacityMeasures.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(dateTimePicker4);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox2.Location = new Point(6, 327);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(556, 227);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Замер емкости";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(229, 166);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(321, 45);
            comboBox3.TabIndex = 5;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(229, 126);
            label22.Name = "label22";
            label22.Size = new Size(136, 38);
            label22.TabIndex = 4;
            label22.Text = "Работник";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Format = DateTimePickerFormat.Short;
            dateTimePicker4.Location = new Point(6, 168);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(189, 43);
            dateTimePicker4.TabIndex = 3;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(6, 126);
            label21.Name = "label21";
            label21.Size = new Size(174, 38);
            label21.TabIndex = 2;
            label21.Text = "Дата замера";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(6, 80);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 43);
            textBox7.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 39);
            label8.Name = "label8";
            label8.Size = new Size(311, 38);
            label8.TabIndex = 0;
            label8.Text = "Значение емкости (Ач)";
            // 
            // button6
            // 
            button6.Location = new Point(415, 572);
            button6.Name = "button6";
            button6.Size = new Size(147, 58);
            button6.TabIndex = 3;
            button6.Text = "Удалить";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(159, 572);
            button5.Name = "button5";
            button5.Size = new Size(216, 58);
            button5.TabIndex = 2;
            button5.Text = "Редактировать";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(6, 572);
            button4.Name = "button4";
            button4.Size = new Size(147, 58);
            button4.TabIndex = 1;
            button4.Text = "Добавить";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { columnCapacityMeasure, columnMeasureDate, columnPerformingWorker });
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
            // columnCapacityMeasure
            // 
            columnCapacityMeasure.HeaderText = "Значение емкости (Ач)";
            columnCapacityMeasure.MinimumWidth = 6;
            columnCapacityMeasure.Name = "columnCapacityMeasure";
            columnCapacityMeasure.ReadOnly = true;
            columnCapacityMeasure.Width = 140;
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
            addBatteryButton.Size = new Size(388, 69);
            addBatteryButton.TabIndex = 14;
            addBatteryButton.Text = "Сохранить изменения";
            addBatteryButton.UseVisualStyleBackColor = true;
            // 
            // applySortButton
            // 
            applySortButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            applySortButton.ForeColor = Color.FromArgb(0, 121, 194);
            applySortButton.Location = new Point(90, 468);
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
            button1.Location = new Point(90, 526);
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
            button2.Location = new Point(6, 468);
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
            button3.Location = new Point(313, 467);
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
            // BatteryEditingForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1004, 778);
            Controls.Add(groupBox3);
            Controls.Add(addBatteryButton);
            Controls.Add(tabControl1);
            Controls.Add(batterNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Margin = new Padding(6);
            Name = "BatteryEditingForm";
            Text = "цц";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageMainInfo.ResumeLayout(false);
            tabPageMainInfo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPageExtraInfo.ResumeLayout(false);
            tabPageExtraInfo.PerformLayout();
            tabPageCapacityMeasures.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label batterNameLabel;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageMainInfo;
        private TabPage tabPageExtraInfo;
        private ComboBox comboBox5;
        private Label label12;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox6;
        private Label label13;
        private Label label9;
        private Label label11;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label10;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label16;
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
        private Label label3;
        private TextBox textBox10;
        private ComboBox comboBox8;
        private Label label19;
        private ComboBox comboBox9;
        private Label label20;
        private Button addBatteryButton;
        private TabPage tabPageCapacityMeasures;
        private Button applySortButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn columnCapacityMeasure;
        private DataGridViewTextBoxColumn columnMeasureDate;
        private DataGridViewTextBoxColumn columnPerformingWorker;
        private TextBox textBox7;
        private Label label8;
        private ComboBox comboBox3;
        private Label label22;
        private DateTimePicker dateTimePicker4;
        private Label label21;
        private GroupBox groupBox3;
    }
}