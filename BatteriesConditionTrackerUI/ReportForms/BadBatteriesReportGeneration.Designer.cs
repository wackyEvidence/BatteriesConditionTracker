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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BadBatteriesReportGeneration));
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            dateTimePicker = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            generateReportButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "сейчас", "месяц", "полгода ", "год", "2 года ", "3 года ", "5 лет " });
            comboBox1.Location = new Point(356, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 45);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(631, 163);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметры отчета";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(359, 98);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(266, 43);
            dateTimePicker.TabIndex = 3;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 103);
            label2.Name = "label2";
            label2.Size = new Size(359, 38);
            label2.TabIndex = 2;
            label2.Text = "или потребует замены на: ";
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
            // generateReportButton
            // 
            generateReportButton.Location = new Point(401, 178);
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
            ClientSize = new Size(654, 241);
            Controls.Add(generateReportButton);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BadBatteriesReportGeneration";
            Text = "Создание отчета";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Button generateReportButton;
        private DateTimePicker dateTimePicker;
        private Label label2;
        private Label label1;
    }
}