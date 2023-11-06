namespace BatteriesConditionTrackerUI
{
    partial class PositionForm
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
            cancelButton = new Button();
            actionButton = new Button();
            positionNameValue = new TextBox();
            positionNameLabel = new Label();
            headerLabel = new Label();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.FromArgb(0, 121, 194);
            cancelButton.Location = new Point(377, 159);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(129, 55);
            cancelButton.TabIndex = 80;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // actionButton
            // 
            actionButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            actionButton.ForeColor = Color.FromArgb(0, 121, 194);
            actionButton.Location = new Point(512, 159);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(129, 55);
            actionButton.TabIndex = 79;
            actionButton.Text = "ОК";
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
            // 
            // positionNameValue
            // 
            positionNameValue.Location = new Point(12, 112);
            positionNameValue.Name = "positionNameValue";
            positionNameValue.Size = new Size(260, 43);
            positionNameValue.TabIndex = 78;
            // 
            // positionNameLabel
            // 
            positionNameLabel.AutoSize = true;
            positionNameLabel.Location = new Point(12, 71);
            positionNameLabel.Name = "positionNameLabel";
            positionNameLabel.Size = new Size(210, 38);
            positionNameLabel.TabIndex = 77;
            positionNameLabel.Text = "Наименование";
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
            headerLabel.TabIndex = 76;
            headerLabel.Text = "headerLabel";
            // 
            // PositionForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(653, 226);
            Controls.Add(cancelButton);
            Controls.Add(actionButton);
            Controls.Add(positionNameValue);
            Controls.Add(positionNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Margin = new Padding(6);
            Name = "PositionForm";
            Text = "PositionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button actionButton;
        private TextBox positionNameValue;
        private Label positionNameLabel;
        private Label headerLabel;
    }
}