namespace BatteriesConditionTrackerUI
{
    partial class WorkersListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkersListForm));
            dataGridView1 = new DataGridView();
            headerLabel = new Label();
            groupBox1 = new GroupBox();
            deleteWorkerButton = new Button();
            addWorkerButton = new Button();
            editWorkerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 81);
            dataGridView1.Margin = new Padding(11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(483, 241);
            dataGridView1.TabIndex = 14;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(2, 9);
            headerLabel.Margin = new Padding(11, 0, 11, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(439, 62);
            headerLabel.TabIndex = 13;
            headerLabel.Text = "Список сотрудников";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(deleteWorkerButton);
            groupBox1.Controls.Add(addWorkerButton);
            groupBox1.Controls.Add(editWorkerButton);
            groupBox1.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox1.Location = new Point(512, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 259);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Действия с элементами списка";
            // 
            // deleteWorkerButton
            // 
            deleteWorkerButton.FlatAppearance.BorderColor = Color.Silver;
            deleteWorkerButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            deleteWorkerButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            deleteWorkerButton.FlatStyle = FlatStyle.Flat;
            deleteWorkerButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            deleteWorkerButton.ForeColor = Color.FromArgb(0, 121, 194);
            deleteWorkerButton.Location = new Point(6, 201);
            deleteWorkerButton.Name = "deleteWorkerButton";
            deleteWorkerButton.Size = new Size(153, 52);
            deleteWorkerButton.TabIndex = 16;
            deleteWorkerButton.Text = "Удалить";
            deleteWorkerButton.UseVisualStyleBackColor = true;
            deleteWorkerButton.Click += deleteWorkerButton_Click;
            // 
            // addWorkerButton
            // 
            addWorkerButton.FlatAppearance.BorderColor = Color.Silver;
            addWorkerButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            addWorkerButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            addWorkerButton.FlatStyle = FlatStyle.Flat;
            addWorkerButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            addWorkerButton.ForeColor = Color.FromArgb(0, 121, 194);
            addWorkerButton.Location = new Point(6, 85);
            addWorkerButton.Name = "addWorkerButton";
            addWorkerButton.Size = new Size(153, 52);
            addWorkerButton.TabIndex = 14;
            addWorkerButton.Text = "Добавить";
            addWorkerButton.UseVisualStyleBackColor = true;
            addWorkerButton.Click += addWorkerButton_Click;
            // 
            // editWorkerButton
            // 
            editWorkerButton.FlatAppearance.BorderColor = Color.Silver;
            editWorkerButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            editWorkerButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            editWorkerButton.FlatStyle = FlatStyle.Flat;
            editWorkerButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            editWorkerButton.ForeColor = Color.FromArgb(0, 121, 194);
            editWorkerButton.Location = new Point(6, 143);
            editWorkerButton.Name = "editWorkerButton";
            editWorkerButton.Size = new Size(224, 52);
            editWorkerButton.TabIndex = 15;
            editWorkerButton.Text = "Редактировать";
            editWorkerButton.UseVisualStyleBackColor = true;
            editWorkerButton.Click += editWorkerButton_Click;
            // 
            // WorkersListForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(874, 331);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "WorkersListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Сотрудники";
            Load += WorkersListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label headerLabel;
        private GroupBox groupBox1;
        private Button deleteWorkerButton;
        private Button addWorkerButton;
        private Button editWorkerButton;
    }
}