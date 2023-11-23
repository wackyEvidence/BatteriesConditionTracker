namespace BatteriesConditionTrackerUI
{
    partial class BatteryClampTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatteryClampTypeForm));
            cancelButton = new Button();
            OKButton = new Button();
            clampTypeNameValue = new TextBox();
            clampTypeNameLabel = new Label();
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
            cancelButton.Location = new Point(220, 200);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(129, 55);
            cancelButton.TabIndex = 85;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // OKButton
            // 
            OKButton.FlatAppearance.BorderColor = Color.Silver;
            OKButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            OKButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            OKButton.FlatStyle = FlatStyle.Flat;
            OKButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            OKButton.ForeColor = Color.FromArgb(0, 121, 194);
            OKButton.Location = new Point(355, 202);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(129, 55);
            OKButton.TabIndex = 84;
            OKButton.Text = "ОК";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // clampTypeNameValue
            // 
            clampTypeNameValue.Location = new Point(12, 131);
            clampTypeNameValue.Name = "clampTypeNameValue";
            clampTypeNameValue.Size = new Size(264, 43);
            clampTypeNameValue.TabIndex = 83;
            // 
            // clampTypeNameLabel
            // 
            clampTypeNameLabel.AutoSize = true;
            clampTypeNameLabel.Location = new Point(12, 90);
            clampTypeNameLabel.Name = "clampTypeNameLabel";
            clampTypeNameLabel.Size = new Size(210, 38);
            clampTypeNameLabel.TabIndex = 82;
            clampTypeNameLabel.Text = "Наименование";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(2, 9);
            headerLabel.Margin = new Padding(21, 0, 21, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(253, 60);
            headerLabel.TabIndex = 81;
            headerLabel.Text = "headerLabel";
            // 
            // BatteryClampTypeForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(496, 269);
            Controls.Add(cancelButton);
            Controls.Add(OKButton);
            Controls.Add(clampTypeNameValue);
            Controls.Add(clampTypeNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BatteryClampTypeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Тип клемм";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button OKButton;
        private TextBox clampTypeNameValue;
        private Label clampTypeNameLabel;
        private Label headerLabel;
    }
}