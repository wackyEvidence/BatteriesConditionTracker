namespace BatteriesConditionTrackerUI
{
    partial class BatteryTechnologiesListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatteryTechnologiesListForm));
            groupBox1 = new GroupBox();
            deleteBatteryTechnologyButton = new Button();
            addBatteryTechnologyButton = new Button();
            editBatteryTechnologyButton = new Button();
            dataGridView1 = new DataGridView();
            headerLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(deleteBatteryTechnologyButton);
            groupBox1.Controls.Add(addBatteryTechnologyButton);
            groupBox1.Controls.Add(editBatteryTechnologyButton);
            groupBox1.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox1.Location = new Point(357, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 259);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Действия с элементами списка";
            // 
            // deleteBatteryTechnologyButton
            // 
            deleteBatteryTechnologyButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBatteryTechnologyButton.ForeColor = Color.FromArgb(0, 121, 194);
            deleteBatteryTechnologyButton.Location = new Point(6, 201);
            deleteBatteryTechnologyButton.Name = "deleteBatteryTechnologyButton";
            deleteBatteryTechnologyButton.Size = new Size(153, 52);
            deleteBatteryTechnologyButton.TabIndex = 16;
            deleteBatteryTechnologyButton.Text = "Удалить";
            deleteBatteryTechnologyButton.UseVisualStyleBackColor = true;
            deleteBatteryTechnologyButton.Click += deleteBatteryTechnologyButton_Click;
            // 
            // addBatteryTechnologyButton
            // 
            addBatteryTechnologyButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            addBatteryTechnologyButton.ForeColor = Color.FromArgb(0, 121, 194);
            addBatteryTechnologyButton.Location = new Point(6, 85);
            addBatteryTechnologyButton.Name = "addBatteryTechnologyButton";
            addBatteryTechnologyButton.Size = new Size(153, 52);
            addBatteryTechnologyButton.TabIndex = 14;
            addBatteryTechnologyButton.Text = "Добавить";
            addBatteryTechnologyButton.UseVisualStyleBackColor = true;
            addBatteryTechnologyButton.Click += addBatteryTechnologyButton_Click;
            // 
            // editBatteryTechnologyButton
            // 
            editBatteryTechnologyButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            editBatteryTechnologyButton.ForeColor = Color.FromArgb(0, 121, 194);
            editBatteryTechnologyButton.Location = new Point(6, 143);
            editBatteryTechnologyButton.Name = "editBatteryTechnologyButton";
            editBatteryTechnologyButton.Size = new Size(213, 52);
            editBatteryTechnologyButton.TabIndex = 15;
            editBatteryTechnologyButton.Text = "Редактировать";
            editBatteryTechnologyButton.UseVisualStyleBackColor = true;
            editBatteryTechnologyButton.Click += editBatteryTechnologyButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Gainsboro;
            dataGridView1.Location = new Point(20, 96);
            dataGridView1.Margin = new Padding(11);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(323, 241);
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
            headerLabel.Size = new Size(726, 62);
            headerLabel.TabIndex = 20;
            headerLabel.Text = "Список технологий аккумуляторов";
            // 
            // BatteryTechnologiesListForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(723, 350);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimumSize = new Size(741, 397);
            Name = "BatteryTechnologiesListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Технологии аккумуляторов";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button deleteBatteryTechnologyButton;
        private Button addBatteryTechnologyButton;
        private Button editBatteryTechnologyButton;
        private DataGridView dataGridView1;
        private Label headerLabel;
    }
}