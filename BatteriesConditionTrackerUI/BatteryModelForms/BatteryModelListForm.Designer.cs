namespace BatteriesConditionTrackerUI
{
    partial class BatteryModelListForm
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
            deleteBatteryModelButton = new Button();
            addBatteryModelButton = new Button();
            editBatteryModelButton = new Button();
            dataGridView1 = new DataGridView();
            headerLabel = new Label();
            structureNameColumn = new DataGridViewTextBoxColumn();
            structureTypeColumn = new DataGridViewTextBoxColumn();
            batteriesAmountColumn = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(deleteBatteryModelButton);
            groupBox1.Controls.Add(addBatteryModelButton);
            groupBox1.Controls.Add(editBatteryModelButton);
            groupBox1.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox1.Location = new Point(770, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 259);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Действия с элементами списка";
            // 
            // deleteBatteryModelButton
            // 
            deleteBatteryModelButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBatteryModelButton.ForeColor = Color.FromArgb(0, 121, 194);
            deleteBatteryModelButton.Location = new Point(6, 201);
            deleteBatteryModelButton.Name = "deleteBatteryModelButton";
            deleteBatteryModelButton.Size = new Size(153, 52);
            deleteBatteryModelButton.TabIndex = 16;
            deleteBatteryModelButton.Text = "Удалить";
            deleteBatteryModelButton.UseVisualStyleBackColor = true;
            // 
            // addBatteryModelButton
            // 
            addBatteryModelButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            addBatteryModelButton.ForeColor = Color.FromArgb(0, 121, 194);
            addBatteryModelButton.Location = new Point(6, 85);
            addBatteryModelButton.Name = "addBatteryModelButton";
            addBatteryModelButton.Size = new Size(153, 52);
            addBatteryModelButton.TabIndex = 14;
            addBatteryModelButton.Text = "Добавить";
            addBatteryModelButton.UseVisualStyleBackColor = true;
            addBatteryModelButton.Click += addBatteryModelButton_Click;
            // 
            // editBatteryModelButton
            // 
            editBatteryModelButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            editBatteryModelButton.ForeColor = Color.FromArgb(0, 121, 194);
            editBatteryModelButton.Location = new Point(6, 143);
            editBatteryModelButton.Name = "editBatteryModelButton";
            editBatteryModelButton.Size = new Size(213, 52);
            editBatteryModelButton.TabIndex = 15;
            editBatteryModelButton.Text = "Редактировать";
            editBatteryModelButton.UseVisualStyleBackColor = true;
            editBatteryModelButton.Click += editBatteryModelButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { structureNameColumn, structureTypeColumn, batteriesAmountColumn });
            dataGridView1.Location = new Point(13, 77);
            dataGridView1.Margin = new Padding(6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(748, 438);
            dataGridView1.TabIndex = 15;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(6, 9);
            headerLabel.Margin = new Padding(11, 0, 11, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(674, 62);
            headerLabel.TabIndex = 14;
            headerLabel.Text = "Список моделей аккумуляторов";
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
            structureTypeColumn.HeaderText = "Емкость (Ач)";
            structureTypeColumn.MinimumWidth = 6;
            structureTypeColumn.Name = "structureTypeColumn";
            structureTypeColumn.ReadOnly = true;
            structureTypeColumn.Width = 175;
            // 
            // batteriesAmountColumn
            // 
            batteriesAmountColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            batteriesAmountColumn.HeaderText = "Напряжение (В)";
            batteriesAmountColumn.MinimumWidth = 6;
            batteriesAmountColumn.Name = "batteriesAmountColumn";
            batteriesAmountColumn.ReadOnly = true;
            // 
            // BatteryModelListForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1138, 527);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Margin = new Padding(6, 6, 6, 6);
            Name = "BatteryModelListForm";
            Text = "BatteryModelListForm";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button deleteBatteryModelButton;
        private Button addBatteryModelButton;
        private Button editBatteryModelButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn structureNameColumn;
        private DataGridViewTextBoxColumn structureTypeColumn;
        private DataGridViewTextBoxColumn batteriesAmountColumn;
        private Label headerLabel;
    }
}