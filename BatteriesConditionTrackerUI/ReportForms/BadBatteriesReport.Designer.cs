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
            headerLabel = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            groupBoxFilters = new GroupBox();
            batterySubsystemLabel = new Label();
            subsystemCheckedListBox = new CheckedListBox();
            batteryStructureLabel = new Label();
            structureCheckedListBox = new CheckedListBox();
            batteryCapacityLabel = new Label();
            capacityCheckedListBox = new CheckedListBox();
            batteryManufacturerLabel = new Label();
            manufacturerCheckedListBox = new CheckedListBox();
            groupBoxSort = new GroupBox();
            removeSortButton = new Button();
            sortSettingsButton = new Button();
            deleteBatteryButton = new Button();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxFilters.SuspendLayout();
            groupBoxSort.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(12, 9);
            headerLabel.Margin = new Padding(6, 0, 6, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(270, 62);
            headerLabel.TabIndex = 9;
            headerLabel.Text = "headerLabel";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(783, 577);
            dataGridView1.TabIndex = 11;
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
            // groupBoxFilters
            // 
            groupBoxFilters.BackColor = Color.White;
            groupBoxFilters.Controls.Add(batterySubsystemLabel);
            groupBoxFilters.Controls.Add(subsystemCheckedListBox);
            groupBoxFilters.Controls.Add(batteryStructureLabel);
            groupBoxFilters.Controls.Add(structureCheckedListBox);
            groupBoxFilters.Controls.Add(batteryCapacityLabel);
            groupBoxFilters.Controls.Add(capacityCheckedListBox);
            groupBoxFilters.Controls.Add(batteryManufacturerLabel);
            groupBoxFilters.Controls.Add(manufacturerCheckedListBox);
            groupBoxFilters.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxFilters.ForeColor = Color.FromArgb(0, 121, 194);
            groupBoxFilters.Location = new Point(806, 56);
            groupBoxFilters.Name = "groupBoxFilters";
            groupBoxFilters.Size = new Size(631, 480);
            groupBoxFilters.TabIndex = 14;
            groupBoxFilters.TabStop = false;
            groupBoxFilters.Text = "Фильтрация";
            // 
            // batterySubsystemLabel
            // 
            batterySubsystemLabel.AutoSize = true;
            batterySubsystemLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            batterySubsystemLabel.Location = new Point(295, 313);
            batterySubsystemLabel.Name = "batterySubsystemLabel";
            batterySubsystemLabel.Size = new Size(176, 38);
            batterySubsystemLabel.TabIndex = 31;
            batterySubsystemLabel.Text = "Подсистема:";
            // 
            // subsystemCheckedListBox
            // 
            subsystemCheckedListBox.FormattingEnabled = true;
            subsystemCheckedListBox.Location = new Point(295, 354);
            subsystemCheckedListBox.Name = "subsystemCheckedListBox";
            subsystemCheckedListBox.Size = new Size(329, 118);
            subsystemCheckedListBox.TabIndex = 30;
            // 
            // batteryStructureLabel
            // 
            batteryStructureLabel.AutoSize = true;
            batteryStructureLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            batteryStructureLabel.Location = new Point(295, 37);
            batteryStructureLabel.Name = "batteryStructureLabel";
            batteryStructureLabel.Size = new Size(117, 38);
            batteryStructureLabel.TabIndex = 29;
            batteryStructureLabel.Text = "Объект:";
            // 
            // structureCheckedListBox
            // 
            structureCheckedListBox.FormattingEnabled = true;
            structureCheckedListBox.Location = new Point(295, 78);
            structureCheckedListBox.Name = "structureCheckedListBox";
            structureCheckedListBox.Size = new Size(329, 232);
            structureCheckedListBox.TabIndex = 28;
            // 
            // batteryCapacityLabel
            // 
            batteryCapacityLabel.AutoSize = true;
            batteryCapacityLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            batteryCapacityLabel.Location = new Point(6, 313);
            batteryCapacityLabel.Name = "batteryCapacityLabel";
            batteryCapacityLabel.Size = new Size(125, 38);
            batteryCapacityLabel.TabIndex = 27;
            batteryCapacityLabel.Text = "Емкость:";
            // 
            // capacityCheckedListBox
            // 
            capacityCheckedListBox.FormattingEnabled = true;
            capacityCheckedListBox.Location = new Point(6, 354);
            capacityCheckedListBox.Name = "capacityCheckedListBox";
            capacityCheckedListBox.Size = new Size(264, 118);
            capacityCheckedListBox.TabIndex = 26;
            // 
            // batteryManufacturerLabel
            // 
            batteryManufacturerLabel.AutoSize = true;
            batteryManufacturerLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            batteryManufacturerLabel.Location = new Point(6, 37);
            batteryManufacturerLabel.Name = "batteryManufacturerLabel";
            batteryManufacturerLabel.Size = new Size(220, 38);
            batteryManufacturerLabel.TabIndex = 25;
            batteryManufacturerLabel.Text = "Производитель:";
            // 
            // manufacturerCheckedListBox
            // 
            manufacturerCheckedListBox.FormattingEnabled = true;
            manufacturerCheckedListBox.Location = new Point(6, 78);
            manufacturerCheckedListBox.Name = "manufacturerCheckedListBox";
            manufacturerCheckedListBox.Size = new Size(264, 232);
            manufacturerCheckedListBox.TabIndex = 24;
            // 
            // groupBoxSort
            // 
            groupBoxSort.BackColor = Color.White;
            groupBoxSort.Controls.Add(removeSortButton);
            groupBoxSort.Controls.Add(sortSettingsButton);
            groupBoxSort.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxSort.ForeColor = Color.FromArgb(0, 121, 194);
            groupBoxSort.Location = new Point(806, 542);
            groupBoxSort.Name = "groupBoxSort";
            groupBoxSort.Size = new Size(631, 109);
            groupBoxSort.TabIndex = 32;
            groupBoxSort.TabStop = false;
            groupBoxSort.Text = "Сортировка";
            // 
            // removeSortButton
            // 
            removeSortButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            removeSortButton.ForeColor = Color.FromArgb(0, 121, 194);
            removeSortButton.Location = new Point(328, 42);
            removeSortButton.Name = "removeSortButton";
            removeSortButton.Size = new Size(290, 55);
            removeSortButton.TabIndex = 20;
            removeSortButton.Text = "Убрать сортировку";
            removeSortButton.UseVisualStyleBackColor = true;
            // 
            // sortSettingsButton
            // 
            sortSettingsButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            sortSettingsButton.ForeColor = Color.FromArgb(0, 121, 194);
            sortSettingsButton.Location = new Point(4, 42);
            sortSettingsButton.Name = "sortSettingsButton";
            sortSettingsButton.Size = new Size(318, 55);
            sortSettingsButton.TabIndex = 21;
            sortSettingsButton.Text = "Настройка сортировки ";
            sortSettingsButton.UseVisualStyleBackColor = true;
            // 
            // deleteBatteryButton
            // 
            deleteBatteryButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBatteryButton.ForeColor = Color.FromArgb(0, 121, 194);
            deleteBatteryButton.Location = new Point(555, 674);
            deleteBatteryButton.Name = "deleteBatteryButton";
            deleteBatteryButton.Size = new Size(240, 92);
            deleteBatteryButton.TabIndex = 33;
            deleteBatteryButton.Text = "Удалить элемент\r\nсписка";
            deleteBatteryButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 121, 194);
            button1.Location = new Point(6, 47);
            button1.Name = "button1";
            button1.Size = new Size(247, 52);
            button1.TabIndex = 34;
            button1.Text = "Экспорт в Excel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 121, 194);
            button2.Location = new Point(259, 47);
            button2.Name = "button2";
            button2.Size = new Size(359, 52);
            button2.TabIndex = 35;
            button2.Text = "Прислать мне на почту";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox1.Location = new Point(806, 657);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(631, 109);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Дополнительно";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(372, 39);
            label3.Name = "label3";
            label3.Size = new Size(221, 38);
            label3.TabIndex = 34;
            label3.Text = "<quantityLabel>";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(265, 77);
            label4.Name = "label4";
            label4.Size = new Size(328, 38);
            label4.TabIndex = 35;
            label4.Text = "<replacementCostLabel>";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox2.Location = new Point(12, 657);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(532, 119);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            groupBox2.Text = "Статистика";
            // 
            // BadBatteriesReport
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1442, 784);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(deleteBatteryButton);
            Controls.Add(groupBoxSort);
            Controls.Add(groupBoxFilters);
            Controls.Add(dataGridView1);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Margin = new Padding(6, 6, 6, 6);
            Name = "BadBatteriesReport";
            Text = "BadBatteriesReport";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxFilters.ResumeLayout(false);
            groupBoxFilters.PerformLayout();
            groupBoxSort.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private GroupBox groupBoxFilters;
        private Label batterySubsystemLabel;
        private CheckedListBox subsystemCheckedListBox;
        private Label batteryStructureLabel;
        private CheckedListBox structureCheckedListBox;
        private Label batteryCapacityLabel;
        private CheckedListBox capacityCheckedListBox;
        private Label batteryManufacturerLabel;
        private CheckedListBox manufacturerCheckedListBox;
        private GroupBox groupBoxSort;
        private Button removeSortButton;
        private Button sortSettingsButton;
        private Button deleteBatteryButton;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
    }
}