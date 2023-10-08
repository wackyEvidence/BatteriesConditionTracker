namespace BatteriesConditionTrackerUI
{
    partial class StructuresListForm
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
            dataGridView1 = new DataGridView();
            headerLabel = new Label();
            structureNameColumn = new DataGridViewTextBoxColumn();
            structureTypeColumn = new DataGridViewTextBoxColumn();
            batteriesAmountColumn = new DataGridViewTextBoxColumn();
            addBatteryButton = new Button();
            editBatteryButton = new Button();
            deleteBatteryButton = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { structureNameColumn, structureTypeColumn, batteriesAmountColumn });
            dataGridView1.Location = new Point(15, 81);
            dataGridView1.Margin = new Padding(6, 6, 6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(748, 438);
            dataGridView1.TabIndex = 12;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(8, 13);
            headerLabel.Margin = new Padding(11, 0, 11, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(374, 62);
            headerLabel.TabIndex = 11;
            headerLabel.Text = "Список объектов";
            // 
            // structureNameColumn
            // 
            structureNameColumn.HeaderText = "Наименование";
            structureNameColumn.MinimumWidth = 6;
            structureNameColumn.Name = "structureNameColumn";
            structureNameColumn.ReadOnly = true;
            structureNameColumn.Width = 350;
            // 
            // structureTypeColumn
            // 
            structureTypeColumn.HeaderText = "Тип объекта";
            structureTypeColumn.MinimumWidth = 6;
            structureTypeColumn.Name = "structureTypeColumn";
            structureTypeColumn.ReadOnly = true;
            structureTypeColumn.Width = 175;
            // 
            // batteriesAmountColumn
            // 
            batteriesAmountColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            batteriesAmountColumn.HeaderText = "Количество аккумуляторов";
            batteriesAmountColumn.MinimumWidth = 6;
            batteriesAmountColumn.Name = "batteriesAmountColumn";
            batteriesAmountColumn.ReadOnly = true;
            // 
            // addBatteryButton
            // 
            addBatteryButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            addBatteryButton.ForeColor = Color.FromArgb(0, 121, 194);
            addBatteryButton.Location = new Point(6, 85);
            addBatteryButton.Name = "addBatteryButton";
            addBatteryButton.Size = new Size(153, 52);
            addBatteryButton.TabIndex = 14;
            addBatteryButton.Text = "Добавить";
            addBatteryButton.UseVisualStyleBackColor = true;
            // 
            // editBatteryButton
            // 
            editBatteryButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            editBatteryButton.ForeColor = Color.FromArgb(0, 121, 194);
            editBatteryButton.Location = new Point(6, 143);
            editBatteryButton.Name = "editBatteryButton";
            editBatteryButton.Size = new Size(213, 52);
            editBatteryButton.TabIndex = 15;
            editBatteryButton.Text = "Редактировать";
            editBatteryButton.UseVisualStyleBackColor = true;
            // 
            // deleteBatteryButton
            // 
            deleteBatteryButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBatteryButton.ForeColor = Color.FromArgb(0, 121, 194);
            deleteBatteryButton.Location = new Point(6, 201);
            deleteBatteryButton.Name = "deleteBatteryButton";
            deleteBatteryButton.Size = new Size(153, 52);
            deleteBatteryButton.TabIndex = 16;
            deleteBatteryButton.Text = "Удалить";
            deleteBatteryButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(deleteBatteryButton);
            groupBox1.Controls.Add(addBatteryButton);
            groupBox1.Controls.Add(editBatteryButton);
            groupBox1.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox1.Location = new Point(772, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 259);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Действия с элементами списка";
            // 
            // StructureViewForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1132, 532);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Margin = new Padding(6, 6, 6, 6);
            Name = "StructureViewForm";
            Text = "StructureViewForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label headerLabel;
        private DataGridViewTextBoxColumn structureNameColumn;
        private DataGridViewTextBoxColumn structureTypeColumn;
        private DataGridViewTextBoxColumn batteriesAmountColumn;
        private Button addBatteryButton;
        private Button editBatteryButton;
        private Button deleteBatteryButton;
        private GroupBox groupBox1;
    }
}