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
            structureNameColumn = new DataGridViewTextBoxColumn();
            structureTypeColumn = new DataGridViewTextBoxColumn();
            batteriesAmountColumn = new DataGridViewTextBoxColumn();
            headerLabel = new Label();
            addStructureButton = new Button();
            editStructureButton = new Button();
            deleteStructureButton = new Button();
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
            dataGridView1.Margin = new Padding(6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(748, 438);
            dataGridView1.TabIndex = 12;
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
            // addStructureButton
            // 
            addStructureButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            addStructureButton.ForeColor = Color.FromArgb(0, 121, 194);
            addStructureButton.Location = new Point(6, 85);
            addStructureButton.Name = "addStructureButton";
            addStructureButton.Size = new Size(153, 52);
            addStructureButton.TabIndex = 14;
            addStructureButton.Text = "Добавить";
            addStructureButton.UseVisualStyleBackColor = true;
            addStructureButton.Click += addStructureButton_Click;
            // 
            // editStructureButton
            // 
            editStructureButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            editStructureButton.ForeColor = Color.FromArgb(0, 121, 194);
            editStructureButton.Location = new Point(6, 143);
            editStructureButton.Name = "editStructureButton";
            editStructureButton.Size = new Size(213, 52);
            editStructureButton.TabIndex = 15;
            editStructureButton.Text = "Редактировать";
            editStructureButton.UseVisualStyleBackColor = true;
            editStructureButton.Click += editStructureButton_Click;
            // 
            // deleteStructureButton
            // 
            deleteStructureButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            deleteStructureButton.ForeColor = Color.FromArgb(0, 121, 194);
            deleteStructureButton.Location = new Point(6, 201);
            deleteStructureButton.Name = "deleteStructureButton";
            deleteStructureButton.Size = new Size(153, 52);
            deleteStructureButton.TabIndex = 16;
            deleteStructureButton.Text = "Удалить";
            deleteStructureButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(deleteStructureButton);
            groupBox1.Controls.Add(addStructureButton);
            groupBox1.Controls.Add(editStructureButton);
            groupBox1.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox1.Location = new Point(772, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 259);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Действия с элементами списка";
            // 
            // StructuresListForm
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
            Margin = new Padding(6);
            Name = "StructuresListForm";
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
        private Button addStructureButton;
        private Button editStructureButton;
        private Button deleteStructureButton;
        private GroupBox groupBox1;
    }
}