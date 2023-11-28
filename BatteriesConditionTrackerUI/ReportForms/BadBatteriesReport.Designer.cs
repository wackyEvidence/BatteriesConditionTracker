namespace BatteriesConditionTrackerUI
{
    partial class BadBatteriesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BadBatteriesReport));
            dataGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            quantityLabel = new Label();
            replacementCostLabel = new Label();
            groupBox2 = new GroupBox();
            groupBoxFilters = new GroupBox();
            resetAllFiltersLinkLabel = new LinkLabel();
            replacementStatusComboBox = new ComboBox();
            exploitationStatusComboBox = new ComboBox();
            subsystemLabel = new Label();
            subsystemCheckedListBox = new CheckedListBox();
            structureLabel = new Label();
            structuresCheckedListBox = new CheckedListBox();
            capacityLabel = new Label();
            capacitiesCheckedListBox = new CheckedListBox();
            brandLabel = new Label();
            brandsCheckedListBox = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            groupBoxFilters.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BackgroundColor = Color.Gainsboro;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(629, 577);
            dataGridView.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(373, 38);
            label1.TabIndex = 12;
            label1.Text = "Количество аккумуляторов:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 77);
            label2.Name = "label2";
            label2.Size = new Size(270, 38);
            label2.TabIndex = 13;
            label2.Text = "Стоимость замены: ";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            quantityLabel.Location = new Point(372, 39);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(221, 38);
            quantityLabel.TabIndex = 34;
            quantityLabel.Text = "<quantityLabel>";
            // 
            // replacementCostLabel
            // 
            replacementCostLabel.AutoSize = true;
            replacementCostLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            replacementCostLabel.Location = new Point(265, 77);
            replacementCostLabel.Name = "replacementCostLabel";
            replacementCostLabel.Size = new Size(328, 38);
            replacementCostLabel.TabIndex = 35;
            replacementCostLabel.Text = "<replacementCostLabel>";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(replacementCostLabel);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(quantityLabel);
            groupBox2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox2.Location = new Point(12, 595);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(532, 119);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            groupBox2.Text = "Статистика";
            // 
            // groupBoxFilters
            // 
            groupBoxFilters.BackColor = Color.White;
            groupBoxFilters.Controls.Add(resetAllFiltersLinkLabel);
            groupBoxFilters.Controls.Add(replacementStatusComboBox);
            groupBoxFilters.Controls.Add(exploitationStatusComboBox);
            groupBoxFilters.Controls.Add(subsystemLabel);
            groupBoxFilters.Controls.Add(subsystemCheckedListBox);
            groupBoxFilters.Controls.Add(structureLabel);
            groupBoxFilters.Controls.Add(structuresCheckedListBox);
            groupBoxFilters.Controls.Add(capacityLabel);
            groupBoxFilters.Controls.Add(capacitiesCheckedListBox);
            groupBoxFilters.Controls.Add(brandLabel);
            groupBoxFilters.Controls.Add(brandsCheckedListBox);
            groupBoxFilters.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxFilters.ForeColor = Color.FromArgb(0, 121, 194);
            groupBoxFilters.Location = new Point(647, -5);
            groupBoxFilters.Name = "groupBoxFilters";
            groupBoxFilters.Size = new Size(633, 715);
            groupBoxFilters.TabIndex = 37;
            groupBoxFilters.TabStop = false;
            groupBoxFilters.Text = "Фильтрация";
            // 
            // resetAllFiltersLinkLabel
            // 
            resetAllFiltersLinkLabel.AutoSize = true;
            resetAllFiltersLinkLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            resetAllFiltersLinkLabel.Location = new Point(376, 104);
            resetAllFiltersLinkLabel.Name = "resetAllFiltersLinkLabel";
            resetAllFiltersLinkLabel.Size = new Size(252, 31);
            resetAllFiltersLinkLabel.TabIndex = 36;
            resetAllFiltersLinkLabel.TabStop = true;
            resetAllFiltersLinkLabel.Text = "Сбросить все фильтры";
            resetAllFiltersLinkLabel.LinkClicked += resetAllFiltersLinkLabel_LinkClicked;
            // 
            // replacementStatusComboBox
            // 
            replacementStatusComboBox.ForeColor = Color.Gray;
            replacementStatusComboBox.FormattingEnabled = true;
            replacementStatusComboBox.Location = new Point(6, 90);
            replacementStatusComboBox.Name = "replacementStatusComboBox";
            replacementStatusComboBox.Size = new Size(288, 45);
            replacementStatusComboBox.TabIndex = 35;
            replacementStatusComboBox.Text = "Статус замены";
            replacementStatusComboBox.SelectedIndexChanged += replacementStatusComboBox_SelectedIndexChanged;
            // 
            // exploitationStatusComboBox
            // 
            exploitationStatusComboBox.ForeColor = Color.Gray;
            exploitationStatusComboBox.FormattingEnabled = true;
            exploitationStatusComboBox.Location = new Point(6, 39);
            exploitationStatusComboBox.Name = "exploitationStatusComboBox";
            exploitationStatusComboBox.Size = new Size(421, 45);
            exploitationStatusComboBox.TabIndex = 34;
            exploitationStatusComboBox.Text = "Статус эксплуатации";
            exploitationStatusComboBox.SelectedIndexChanged += exploitationStatusComboBox_SelectedIndexChanged;
            // 
            // subsystemLabel
            // 
            subsystemLabel.AutoSize = true;
            subsystemLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            subsystemLabel.Location = new Point(6, 462);
            subsystemLabel.Name = "subsystemLabel";
            subsystemLabel.Size = new Size(176, 38);
            subsystemLabel.TabIndex = 31;
            subsystemLabel.Text = "Подсистема:";
            // 
            // subsystemCheckedListBox
            // 
            subsystemCheckedListBox.CheckOnClick = true;
            subsystemCheckedListBox.FormattingEnabled = true;
            subsystemCheckedListBox.Location = new Point(6, 503);
            subsystemCheckedListBox.Name = "subsystemCheckedListBox";
            subsystemCheckedListBox.Size = new Size(256, 194);
            subsystemCheckedListBox.TabIndex = 30;
            subsystemCheckedListBox.SelectedIndexChanged += subsystemCheckedListBox_SelectedIndexChanged;
            // 
            // structureLabel
            // 
            structureLabel.AutoSize = true;
            structureLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            structureLabel.Location = new Point(291, 138);
            structureLabel.Name = "structureLabel";
            structureLabel.Size = new Size(117, 38);
            structureLabel.TabIndex = 29;
            structureLabel.Text = "Объект:";
            // 
            // structuresCheckedListBox
            // 
            structuresCheckedListBox.CheckOnClick = true;
            structuresCheckedListBox.FormattingEnabled = true;
            structuresCheckedListBox.Location = new Point(291, 179);
            structuresCheckedListBox.Name = "structuresCheckedListBox";
            structuresCheckedListBox.Size = new Size(329, 498);
            structuresCheckedListBox.TabIndex = 28;
            structuresCheckedListBox.SelectedIndexChanged += structuresCheckedListBox_SelectedIndexChanged;
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            capacityLabel.Location = new Point(6, 300);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new Size(125, 38);
            capacityLabel.TabIndex = 27;
            capacityLabel.Text = "Емкость:";
            // 
            // capacitiesCheckedListBox
            // 
            capacitiesCheckedListBox.CheckOnClick = true;
            capacitiesCheckedListBox.FormattingEnabled = true;
            capacitiesCheckedListBox.Location = new Point(6, 341);
            capacitiesCheckedListBox.Name = "capacitiesCheckedListBox";
            capacitiesCheckedListBox.Size = new Size(256, 118);
            capacitiesCheckedListBox.TabIndex = 26;
            capacitiesCheckedListBox.SelectedIndexChanged += capacitiesCheckedListBox_SelectedIndexChanged;
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            brandLabel.Location = new Point(6, 138);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(101, 38);
            brandLabel.TabIndex = 25;
            brandLabel.Text = "Бренд:";
            // 
            // brandsCheckedListBox
            // 
            brandsCheckedListBox.CheckOnClick = true;
            brandsCheckedListBox.FormattingEnabled = true;
            brandsCheckedListBox.Location = new Point(6, 179);
            brandsCheckedListBox.Name = "brandsCheckedListBox";
            brandsCheckedListBox.Size = new Size(256, 118);
            brandsCheckedListBox.TabIndex = 24;
            brandsCheckedListBox.SelectedIndexChanged += brandsCheckedListBox_SelectedIndexChanged;
            // 
            // BadBatteriesReport
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1284, 721);
            Controls.Add(groupBoxFilters);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BadBatteriesReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Отчет";
            Load += BadBatteriesReport_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBoxFilters.ResumeLayout(false);
            groupBoxFilters.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView;
        private Label label1;
        private Label label2;
        private Label quantityLabel;
        private Label replacementCostLabel;
        private GroupBox groupBox2;
        private GroupBox groupBoxFilters;
        private LinkLabel resetAllFiltersLinkLabel;
        private ComboBox replacementStatusComboBox;
        private ComboBox exploitationStatusComboBox;
        private Label subsystemLabel;
        private CheckedListBox subsystemCheckedListBox;
        private Label structureLabel;
        private CheckedListBox structuresCheckedListBox;
        private Label capacityLabel;
        private CheckedListBox capacitiesCheckedListBox;
        private Label brandLabel;
        private CheckedListBox brandsCheckedListBox;
    }
}