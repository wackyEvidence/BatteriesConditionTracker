namespace BatteriesConditionTrackerUI
{
    partial class UserFilterForm
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
            filterGroupBox = new GroupBox();
            filterConditionComboBox = new ComboBox();
            applyFilterButton = new Button();
            filterAttributeLabel = new Label();
            filterAttributeComboBox = new ComboBox();
            filterValueLabel = new Label();
            filterValueTextBox = new TextBox();
            filterGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // filterGroupBox
            // 
            filterGroupBox.Controls.Add(filterConditionComboBox);
            filterGroupBox.Controls.Add(applyFilterButton);
            filterGroupBox.Controls.Add(filterAttributeLabel);
            filterGroupBox.Controls.Add(filterAttributeComboBox);
            filterGroupBox.Controls.Add(filterValueLabel);
            filterGroupBox.Controls.Add(filterValueTextBox);
            filterGroupBox.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            filterGroupBox.ForeColor = Color.FromArgb(0, 121, 194);
            filterGroupBox.Location = new Point(12, 12);
            filterGroupBox.Name = "filterGroupBox";
            filterGroupBox.Size = new Size(824, 226);
            filterGroupBox.TabIndex = 5;
            filterGroupBox.TabStop = false;
            filterGroupBox.Text = "Фильтрация:";
            // 
            // filterConditionComboBox
            // 
            filterConditionComboBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            filterConditionComboBox.FormattingEnabled = true;
            filterConditionComboBox.Items.AddRange(new object[] { "Больше или равно ", "Выше среднего ", "Заканчивается на" });
            filterConditionComboBox.Location = new Point(294, 94);
            filterConditionComboBox.Name = "filterConditionComboBox";
            filterConditionComboBox.Size = new Size(299, 45);
            filterConditionComboBox.TabIndex = 17;
            // 
            // applyFilterButton
            // 
            applyFilterButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            applyFilterButton.ForeColor = Color.FromArgb(0, 121, 194);
            applyFilterButton.Location = new Point(548, 165);
            applyFilterButton.Name = "applyFilterButton";
            applyFilterButton.Size = new Size(270, 55);
            applyFilterButton.TabIndex = 15;
            applyFilterButton.Text = "Применить фильтр";
            applyFilterButton.UseVisualStyleBackColor = true;
            // 
            // filterAttributeLabel
            // 
            filterAttributeLabel.AutoSize = true;
            filterAttributeLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            filterAttributeLabel.ForeColor = Color.FromArgb(0, 121, 194);
            filterAttributeLabel.Location = new Point(6, 49);
            filterAttributeLabel.Name = "filterAttributeLabel";
            filterAttributeLabel.Size = new Size(303, 38);
            filterAttributeLabel.TabIndex = 9;
            filterAttributeLabel.Text = "Поле для фильтрации:";
            // 
            // filterAttributeComboBox
            // 
            filterAttributeComboBox.FormattingEnabled = true;
            filterAttributeComboBox.Location = new Point(315, 42);
            filterAttributeComboBox.Name = "filterAttributeComboBox";
            filterAttributeComboBox.Size = new Size(503, 45);
            filterAttributeComboBox.TabIndex = 8;
            // 
            // filterValueLabel
            // 
            filterValueLabel.AutoSize = true;
            filterValueLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            filterValueLabel.ForeColor = Color.FromArgb(0, 121, 194);
            filterValueLabel.Location = new Point(6, 101);
            filterValueLabel.Name = "filterValueLabel";
            filterValueLabel.Size = new Size(291, 38);
            filterValueLabel.TabIndex = 6;
            filterValueLabel.Text = "Условие фильтрации:";
            // 
            // filterValueTextBox
            // 
            filterValueTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            filterValueTextBox.Location = new Point(599, 96);
            filterValueTextBox.Name = "filterValueTextBox";
            filterValueTextBox.Size = new Size(219, 43);
            filterValueTextBox.TabIndex = 7;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(848, 256);
            Controls.Add(filterGroupBox);
            Name = "FilterForm";
            Text = "Настройка фильтра";
            filterGroupBox.ResumeLayout(false);
            filterGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox filterGroupBox;
        private Button applyFilterButton;
        private Label filterAttributeLabel;
        private ComboBox filterAttributeComboBox;
        private Label filterValueLabel;
        private TextBox filterValueTextBox;
        private CheckBox checkBox1;
        private ComboBox filterConditionComboBox;
    }
}