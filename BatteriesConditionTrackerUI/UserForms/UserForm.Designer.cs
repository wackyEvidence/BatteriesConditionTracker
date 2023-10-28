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
            headerLabel = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label6 = new Label();
            button5 = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(2, 9);
            headerLabel.Margin = new Padding(6, 0, 6, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(345, 62);
            headerLabel.TabIndex = 11;
            headerLabel.Text = "headerLabelText";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(265, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 43);
            textBox2.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 71);
            label2.Name = "label2";
            label2.Size = new Size(72, 38);
            label2.TabIndex = 17;
            label2.Text = "Имя";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 43);
            textBox1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(132, 38);
            label1.TabIndex = 15;
            label1.Text = "Фамилия";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(514, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(243, 43);
            textBox3.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(514, 71);
            label3.Name = "label3";
            label3.Size = new Size(135, 38);
            label3.TabIndex = 19;
            label3.Text = "Отчество";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 199);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(325, 43);
            textBox4.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 158);
            label4.Name = "label4";
            label4.Size = new Size(94, 38);
            label4.TabIndex = 21;
            label4.Text = "Почта";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 245);
            label5.Name = "label5";
            label5.Size = new Size(233, 38);
            label5.TabIndex = 23;
            label5.Text = "Номер телефона";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(12, 286);
            maskedTextBox1.Mask = "+7(000) 000-00-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(237, 43);
            maskedTextBox1.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 332);
            label6.Name = "label6";
            label6.Size = new Size(194, 38);
            label6.TabIndex = 26;
            label6.Text = "Руководитель";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(0, 121, 194);
            button5.Location = new Point(493, 455);
            button5.Name = "button5";
            button5.Size = new Size(129, 55);
            button5.TabIndex = 73;
            button5.Text = "Отмена";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(0, 121, 194);
            button4.Location = new Point(628, 455);
            button4.Name = "button4";
            button4.Size = new Size(129, 55);
            button4.TabIndex = 72;
            button4.Text = "ОК";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 373);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(480, 45);
            comboBox1.TabIndex = 74;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 424);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(237, 42);
            checkBox1.TabIndex = 75;
            checkBox1.Text = "Администратор";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(769, 522);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(maskedTextBox1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Margin = new Padding(6);
            Name = "UserForm";
            Text = "WorkerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private MaskedTextBox maskedTextBox1;
        private Label label6;
        private Button button5;
        private Button button4;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
    }
}