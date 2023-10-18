namespace BatteriesConditionTrackerUI
{
    partial class PositionsListForm
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
            deletePositionButton = new Button();
            addPositionButton = new Button();
            editPositionButton = new Button();
            dataGridView1 = new DataGridView();
            structureTypeColumn = new DataGridViewTextBoxColumn();
            headerLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(deletePositionButton);
            groupBox1.Controls.Add(addPositionButton);
            groupBox1.Controls.Add(editPositionButton);
            groupBox1.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox1.Location = new Point(376, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 259);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Действия с элементами списка";
            // 
            // deletePositionButton
            // 
            deletePositionButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            deletePositionButton.ForeColor = Color.FromArgb(0, 121, 194);
            deletePositionButton.Location = new Point(6, 201);
            deletePositionButton.Name = "deletePositionButton";
            deletePositionButton.Size = new Size(153, 52);
            deletePositionButton.TabIndex = 16;
            deletePositionButton.Text = "Удалить";
            deletePositionButton.UseVisualStyleBackColor = true;
            // 
            // addPositionButton
            // 
            addPositionButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            addPositionButton.ForeColor = Color.FromArgb(0, 121, 194);
            addPositionButton.Location = new Point(6, 85);
            addPositionButton.Name = "addPositionButton";
            addPositionButton.Size = new Size(153, 52);
            addPositionButton.TabIndex = 14;
            addPositionButton.Text = "Добавить";
            addPositionButton.UseVisualStyleBackColor = true;
            addPositionButton.Click += addPositionButton_Click;
            // 
            // editPositionButton
            // 
            editPositionButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            editPositionButton.ForeColor = Color.FromArgb(0, 121, 194);
            editPositionButton.Location = new Point(6, 143);
            editPositionButton.Name = "editPositionButton";
            editPositionButton.Size = new Size(213, 52);
            editPositionButton.TabIndex = 15;
            editPositionButton.Text = "Редактировать";
            editPositionButton.UseVisualStyleBackColor = true;
            editPositionButton.Click += editPositionButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { structureTypeColumn });
            dataGridView1.Location = new Point(20, 96);
            dataGridView1.Margin = new Padding(11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(342, 241);
            dataGridView1.TabIndex = 18;
            // 
            // structureTypeColumn
            // 
            structureTypeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            structureTypeColumn.HeaderText = "Наименование";
            structureTypeColumn.MinimumWidth = 6;
            structureTypeColumn.Name = "structureTypeColumn";
            structureTypeColumn.ReadOnly = true;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(2, 9);
            headerLabel.Margin = new Padding(21, 0, 21, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(433, 62);
            headerLabel.TabIndex = 17;
            headerLabel.Text = "Список должностей";
            // 
            // PositionsListForm
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
            Margin = new Padding(6);
            Name = "PositionsListForm";
            Text = "PositionsListForm";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button deletePositionButton;
        private Button addPositionButton;
        private Button editPositionButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn structureTypeColumn;
        private Label headerLabel;
    }
}