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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StructureTypeForm));
            headerLabel = new Label();
            structureTypeNameValue = new TextBox();
            structureTypeNameLabel = new Label();
            cancelButton = new Button();
            actionButton = new Button();
            SuspendLayout();
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
            headerLabel.TabIndex = 15;
            headerLabel.Text = "headerLabel";
            // 
            // structureTypeNameValue
            // 
            structureTypeNameValue.Location = new Point(12, 131);
            structureTypeNameValue.Name = "structureTypeNameValue";
            structureTypeNameValue.Size = new Size(452, 43);
            structureTypeNameValue.TabIndex = 20;
            // 
            // structureTypeNameLabel
            // 
            structureTypeNameLabel.AutoSize = true;
            structureTypeNameLabel.Location = new Point(12, 90);
            structureTypeNameLabel.Name = "structureTypeNameLabel";
            structureTypeNameLabel.Size = new Size(210, 38);
            structureTypeNameLabel.TabIndex = 19;
            structureTypeNameLabel.Text = "Наименование";
            // 
            // cancelButton
            // 
            cancelButton.FlatAppearance.BorderColor = Color.Silver;
            cancelButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            cancelButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.FromArgb(0, 121, 194);
            cancelButton.Location = new Point(200, 202);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(129, 55);
            cancelButton.TabIndex = 75;
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
            actionButton.Location = new Point(335, 202);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(129, 55);
            actionButton.TabIndex = 74;
            actionButton.Text = "ОК";
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
            // 
            // StructureTypeForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(476, 269);
            Controls.Add(cancelButton);
            Controls.Add(actionButton);
            Controls.Add(structureTypeNameValue);
            Controls.Add(structureTypeNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StructureTypeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Тип объекта";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox structureTypeNameValue;
        private Label structureTypeNameLabel;
        private Button cancelButton;
        private Button actionButton;
    }
}