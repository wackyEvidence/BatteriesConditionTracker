namespace BatteriesConditionTrackerUI
{
    partial class BatteryTechnologyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatteryTechnologyForm));
            cancelButton = new Button();
            actionButton = new Button();
            technologyNameValue = new TextBox();
            technologyNameLabel = new Label();
            headerLabel = new Label();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.FlatAppearance.BorderColor = Color.Silver;
            cancelButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            cancelButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.FromArgb(0, 121, 194);
            cancelButton.Location = new Point(164, 202);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(129, 55);
            cancelButton.TabIndex = 85;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // actionButton
            // 
            actionButton.FlatAppearance.BorderColor = Color.Silver;
            actionButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            actionButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            actionButton.FlatStyle = FlatStyle.Flat;
            actionButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            actionButton.ForeColor = Color.FromArgb(0, 121, 194);
            actionButton.Location = new Point(299, 202);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(129, 55);
            actionButton.TabIndex = 84;
            actionButton.Text = "ОК";
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
            // 
            // technologyNameValue
            // 
            technologyNameValue.Location = new Point(12, 131);
            technologyNameValue.Name = "technologyNameValue";
            technologyNameValue.Size = new Size(416, 43);
            technologyNameValue.TabIndex = 83;
            // 
            // technologyNameLabel
            // 
            technologyNameLabel.AutoSize = true;
            technologyNameLabel.Location = new Point(12, 90);
            technologyNameLabel.Name = "technologyNameLabel";
            technologyNameLabel.Size = new Size(210, 38);
            technologyNameLabel.TabIndex = 82;
            technologyNameLabel.Text = "Наименование";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 24F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(2, 9);
            headerLabel.Margin = new Padding(21, 0, 21, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(227, 54);
            headerLabel.TabIndex = 81;
            headerLabel.Text = "headerLabel";
            // 
            // BatteryTechnologyForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(437, 269);
            Controls.Add(cancelButton);
            Controls.Add(actionButton);
            Controls.Add(technologyNameValue);
            Controls.Add(technologyNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BatteryTechnologyForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Технология аккумулятора";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button actionButton;
        private TextBox technologyNameValue;
        private Label technologyNameLabel;
        private Label headerLabel;
    }
}