namespace BatteriesConditionTrackerUI
{
    partial class BatterySubsystemsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatterySubsystemsListForm));
            groupBox1 = new GroupBox();
            deleteSubsystemButton = new Button();
            addSubsystemButton = new Button();
            editSubsystemButton = new Button();
            dataGridView1 = new DataGridView();
            headerLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(deleteSubsystemButton);
            groupBox1.Controls.Add(addSubsystemButton);
            groupBox1.Controls.Add(editSubsystemButton);
            groupBox1.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox1.Location = new Point(367, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 259);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Действия с элементами списка";
            // 
            // deleteSubsystemButton
            // 
            deleteSubsystemButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSubsystemButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            deleteSubsystemButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            deleteSubsystemButton.FlatStyle = FlatStyle.Flat;
            deleteSubsystemButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            deleteSubsystemButton.ForeColor = Color.FromArgb(0, 121, 194);
            deleteSubsystemButton.Location = new Point(6, 201);
            deleteSubsystemButton.Name = "deleteSubsystemButton";
            deleteSubsystemButton.Size = new Size(153, 52);
            deleteSubsystemButton.TabIndex = 16;
            deleteSubsystemButton.Text = "Удалить";
            deleteSubsystemButton.UseVisualStyleBackColor = true;
            deleteSubsystemButton.Click += deleteSubsystemButton_Click;
            // 
            // addSubsystemButton
            // 
            addSubsystemButton.FlatAppearance.BorderColor = Color.Silver;
            addSubsystemButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            addSubsystemButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            addSubsystemButton.FlatStyle = FlatStyle.Flat;
            addSubsystemButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            addSubsystemButton.ForeColor = Color.FromArgb(0, 121, 194);
            addSubsystemButton.Location = new Point(6, 85);
            addSubsystemButton.Name = "addSubsystemButton";
            addSubsystemButton.Size = new Size(153, 52);
            addSubsystemButton.TabIndex = 14;
            addSubsystemButton.Text = "Добавить";
            addSubsystemButton.UseVisualStyleBackColor = true;
            addSubsystemButton.Click += addSubsystemButton_Click;
            // 
            // editSubsystemButton
            // 
            editSubsystemButton.FlatAppearance.BorderColor = Color.Silver;
            editSubsystemButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            editSubsystemButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            editSubsystemButton.FlatStyle = FlatStyle.Flat;
            editSubsystemButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            editSubsystemButton.ForeColor = Color.FromArgb(0, 121, 194);
            editSubsystemButton.Location = new Point(6, 143);
            editSubsystemButton.Name = "editSubsystemButton";
            editSubsystemButton.Size = new Size(224, 52);
            editSubsystemButton.TabIndex = 15;
            editSubsystemButton.Text = "Редактировать";
            editSubsystemButton.UseVisualStyleBackColor = true;
            editSubsystemButton.Click += editSubsystemButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 89);
            dataGridView1.Margin = new Padding(11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(333, 244);
            dataGridView1.TabIndex = 21;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(2, 9);
            headerLabel.Margin = new Padding(21, 0, 21, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(402, 62);
            headerLabel.TabIndex = 20;
            headerLabel.Text = "Список подсистем";
            // 
            // BatterySubsystemsListForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(732, 353);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimumSize = new Size(750, 400);
            Name = "BatterySubsystemsListForm";
            Text = "Подсистемы аккумулятора";
            Load += BatterySubsystemsListForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button deleteSubsystemButton;
        private Button addSubsystemButton;
        private Button editSubsystemButton;
        private DataGridView dataGridView1;
        private Label headerLabel;
    }
}