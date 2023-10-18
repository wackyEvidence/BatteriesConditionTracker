namespace BatteriesConditionTrackerUI
{
    partial class BadBatteriesReportGeneration
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
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            generateReportButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "месяц", "полгода ", "год", "2 года ", "3 года ", "5 лет " });
            comboBox1.Location = new Point(356, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 45);
            comboBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(529, 163);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметры отчета";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(252, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 43);
            dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 103);
            label2.Name = "label2";
            label2.Size = new Size(253, 38);
            label2.TabIndex = 2;
            label2.Text = "или укажите дату: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(344, 38);
            label1.TabIndex = 1;
            label1.Text = "Потребует замены через:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox2.Location = new Point(12, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(529, 150);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вид";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 94);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(356, 42);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Агрегировать по модели";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 46);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(436, 42);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Каждый аккумулятор отдельно";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // generateReportButton
            // 
            generateReportButton.Location = new Point(299, 337);
            generateReportButton.Name = "generateReportButton";
            generateReportButton.Size = new Size(242, 51);
            generateReportButton.TabIndex = 3;
            generateReportButton.Text = "Создать отчет";
            generateReportButton.UseVisualStyleBackColor = true;
            generateReportButton.Click += generateReportButton_Click;
            // 
            // BadBatteriesReportGeneration
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(560, 401);
            Controls.Add(generateReportButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Margin = new Padding(6);
            Name = "BadBatteriesReportGeneration";
            Text = "BadBatteriesReportGeneration";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button generateReportButton;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
    }
}