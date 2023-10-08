namespace BatteriesConditionTrackerUI
{
    partial class AddSortLayerForm
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
            groupBox1 = new GroupBox();
            sortAttributeLabel = new Label();
            sortAttributeComboBox = new ComboBox();
            sortOrderLabel = new Label();
            sortOrderComboBox = new ComboBox();
            approveLayerAdditionButton = new Button();
            cancelLayerAdditionButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cancelLayerAdditionButton);
            groupBox1.Controls.Add(approveLayerAdditionButton);
            groupBox1.Controls.Add(sortAttributeLabel);
            groupBox1.Controls.Add(sortAttributeComboBox);
            groupBox1.Controls.Add(sortOrderLabel);
            groupBox1.Controls.Add(sortOrderComboBox);
            groupBox1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(767, 223);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление уровня";
            // 
            // sortAttributeLabel
            // 
            sortAttributeLabel.AutoSize = true;
            sortAttributeLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            sortAttributeLabel.ForeColor = Color.FromArgb(0, 121, 194);
            sortAttributeLabel.Location = new Point(6, 44);
            sortAttributeLabel.Name = "sortAttributeLabel";
            sortAttributeLabel.Size = new Size(298, 38);
            sortAttributeLabel.TabIndex = 19;
            sortAttributeLabel.Text = "Поле для сортировки:";
            // 
            // sortAttributeComboBox
            // 
            sortAttributeComboBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            sortAttributeComboBox.FormattingEnabled = true;
            sortAttributeComboBox.Location = new Point(310, 37);
            sortAttributeComboBox.Name = "sortAttributeComboBox";
            sortAttributeComboBox.Size = new Size(319, 45);
            sortAttributeComboBox.TabIndex = 18;
            // 
            // sortOrderLabel
            // 
            sortOrderLabel.AutoSize = true;
            sortOrderLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            sortOrderLabel.ForeColor = Color.FromArgb(0, 121, 194);
            sortOrderLabel.Location = new Point(9, 97);
            sortOrderLabel.Name = "sortOrderLabel";
            sortOrderLabel.Size = new Size(233, 38);
            sortOrderLabel.TabIndex = 16;
            sortOrderLabel.Text = "Сортировать по: ";
            // 
            // sortOrderComboBox
            // 
            sortOrderComboBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            sortOrderComboBox.FormattingEnabled = true;
            sortOrderComboBox.Items.AddRange(new object[] { "возрастанию", "убыванию" });
            sortOrderComboBox.Location = new Point(248, 90);
            sortOrderComboBox.Name = "sortOrderComboBox";
            sortOrderComboBox.Size = new Size(196, 45);
            sortOrderComboBox.TabIndex = 17;
            // 
            // approveLayerAdditionButton
            // 
            approveLayerAdditionButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            approveLayerAdditionButton.ForeColor = Color.FromArgb(0, 121, 194);
            approveLayerAdditionButton.Location = new Point(641, 162);
            approveLayerAdditionButton.Name = "approveLayerAdditionButton";
            approveLayerAdditionButton.Size = new Size(120, 55);
            approveLayerAdditionButton.TabIndex = 25;
            approveLayerAdditionButton.Text = "ОК";
            approveLayerAdditionButton.UseVisualStyleBackColor = true;
            // 
            // cancelLayerAdditionButton
            // 
            cancelLayerAdditionButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            cancelLayerAdditionButton.ForeColor = Color.FromArgb(0, 121, 194);
            cancelLayerAdditionButton.Location = new Point(498, 162);
            cancelLayerAdditionButton.Name = "cancelLayerAdditionButton";
            cancelLayerAdditionButton.Size = new Size(137, 55);
            cancelLayerAdditionButton.TabIndex = 26;
            cancelLayerAdditionButton.Text = "Отмена";
            cancelLayerAdditionButton.UseVisualStyleBackColor = true;
            // 
            // AddSortLayerForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(799, 243);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Margin = new Padding(6, 6, 6, 6);
            Name = "AddSortLayerForm";
            Text = "AddSortLayerForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label sortAttributeLabel;
        private ComboBox sortAttributeComboBox;
        private Label sortOrderLabel;
        private ComboBox sortOrderComboBox;
        private Button cancelLayerAdditionButton;
        private Button approveLayerAdditionButton;
    }
}