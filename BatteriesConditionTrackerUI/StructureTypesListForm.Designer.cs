namespace BatteriesConditionTrackerUI
{
    partial class StructureTypesListForm
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
            structureTypeColumn = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            deleteBatteryButton = new Button();
            addBatteryButton = new Button();
            editBatteryButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(2, 9);
            headerLabel.Margin = new Padding(21, 0, 21, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(505, 62);
            headerLabel.TabIndex = 14;
            headerLabel.Text = "Список типов объектов";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { structureTypeColumn });
            dataGridView1.Location = new Point(20, 96);
            dataGridView1.Margin = new Padding(11, 11, 11, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(342, 241);
            dataGridView1.TabIndex = 15;
            // 
            // structureTypeColumn
            // 
            structureTypeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            structureTypeColumn.HeaderText = "Наименование";
            structureTypeColumn.MinimumWidth = 6;
            structureTypeColumn.Name = "structureTypeColumn";
            structureTypeColumn.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(deleteBatteryButton);
            groupBox1.Controls.Add(addBatteryButton);
            groupBox1.Controls.Add(editBatteryButton);
            groupBox1.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox1.Location = new Point(376, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 259);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Действия с элементами списка";
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
            // StructureTypesList
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(743, 350);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Margin = new Padding(6, 6, 6, 6);
            Name = "StructureTypesList";
            Text = "StructureTypesList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn structureTypeColumn;
        private GroupBox groupBox1;
        private Button deleteBatteryButton;
        private Button addBatteryButton;
        private Button editBatteryButton;
    }
}