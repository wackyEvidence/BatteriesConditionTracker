namespace BatteriesConditionTrackerUI
{
    partial class StructureTypeForm
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
            button5 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(2, 9);
            headerLabel.Margin = new Padding(21, 0, 21, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(270, 62);
            headerLabel.TabIndex = 15;
            headerLabel.Text = "headerLabel";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 43);
            textBox2.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(210, 38);
            label2.TabIndex = 19;
            label2.Text = "Наименование";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(0, 121, 194);
            button5.Location = new Point(377, 159);
            button5.Name = "button5";
            button5.Size = new Size(129, 55);
            button5.TabIndex = 75;
            button5.Text = "Отмена";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(0, 121, 194);
            button4.Location = new Point(512, 159);
            button4.Name = "button4";
            button4.Size = new Size(129, 55);
            button4.TabIndex = 74;
            button4.Text = "ОК";
            button4.UseVisualStyleBackColor = true;
            // 
            // StructureTypeAddingForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(653, 226);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Margin = new Padding(6, 6, 6, 6);
            Name = "StructureTypeAddingForm";
            Text = "StructureTypeAddingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox textBox2;
        private Label label2;
        private Button button5;
        private Button button4;
    }
}