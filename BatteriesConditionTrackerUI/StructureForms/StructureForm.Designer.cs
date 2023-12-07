namespace BatteriesConditionTrackerUI
{
    partial class StructureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StructureForm));
            headerLabel = new Label();
            structureNameValue = new TextBox();
            structureNameLabel = new Label();
            structureTypeValue = new ComboBox();
            structureTypeLabel = new Label();
            cancelButton = new Button();
            actionButton = new Button();
            addStructureTypeLinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 24F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(2, 9);
            headerLabel.Margin = new Padding(11, 0, 11, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(227, 54);
            headerLabel.TabIndex = 12;
            headerLabel.Text = "headerLabel";
            // 
            // structureNameValue
            // 
            structureNameValue.Location = new Point(12, 131);
            structureNameValue.Name = "structureNameValue";
            structureNameValue.Size = new Size(364, 43);
            structureNameValue.TabIndex = 13;
            // 
            // structureNameLabel
            // 
            structureNameLabel.AutoSize = true;
            structureNameLabel.Location = new Point(12, 90);
            structureNameLabel.Name = "structureNameLabel";
            structureNameLabel.Size = new Size(210, 38);
            structureNameLabel.TabIndex = 14;
            structureNameLabel.Text = "Наименование";
            // 
            // structureTypeValue
            // 
            structureTypeValue.DropDownStyle = ComboBoxStyle.DropDownList;
            structureTypeValue.FormattingEnabled = true;
            structureTypeValue.Location = new Point(12, 218);
            structureTypeValue.Name = "structureTypeValue";
            structureTypeValue.Size = new Size(364, 45);
            structureTypeValue.TabIndex = 15;
            // 
            // structureTypeLabel
            // 
            structureTypeLabel.AutoSize = true;
            structureTypeLabel.Location = new Point(12, 177);
            structureTypeLabel.Name = "structureTypeLabel";
            structureTypeLabel.Size = new Size(175, 38);
            structureTypeLabel.TabIndex = 16;
            structureTypeLabel.Text = "Тип объекта";
            // 
            // cancelButton
            // 
            cancelButton.FlatAppearance.BorderColor = Color.Silver;
            cancelButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            cancelButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.FromArgb(0, 121, 194);
            cancelButton.Location = new Point(112, 289);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(129, 55);
            cancelButton.TabIndex = 71;
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
            actionButton.Location = new Point(247, 289);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(129, 55);
            actionButton.TabIndex = 70;
            actionButton.Text = "ОК";
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
            // 
            // addStructureTypeLinkLabel
            // 
            addStructureTypeLinkLabel.AutoSize = true;
            addStructureTypeLinkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addStructureTypeLinkLabel.Location = new Point(273, 184);
            addStructureTypeLinkLabel.Name = "addStructureTypeLinkLabel";
            addStructureTypeLinkLabel.Size = new Size(103, 28);
            addStructureTypeLinkLabel.TabIndex = 72;
            addStructureTypeLinkLabel.TabStop = true;
            addStructureTypeLinkLabel.Text = "добавить ";
            addStructureTypeLinkLabel.LinkClicked += addStructureTypeLinkLabel_LinkClicked;
            // 
            // StructureForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(388, 357);
            Controls.Add(addStructureTypeLinkLabel);
            Controls.Add(cancelButton);
            Controls.Add(actionButton);
            Controls.Add(structureTypeLabel);
            Controls.Add(structureTypeValue);
            Controls.Add(structureNameLabel);
            Controls.Add(structureNameValue);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StructureForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Объект";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox structureNameValue;
        private Label structureNameLabel;
        private ComboBox structureTypeValue;
        private Label structureTypeLabel;
        private Button cancelButton;
        private Button actionButton;
        private LinkLabel addStructureTypeLinkLabel;
    }
}