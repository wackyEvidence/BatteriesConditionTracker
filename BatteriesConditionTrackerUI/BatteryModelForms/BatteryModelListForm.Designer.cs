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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatteryModelListForm));
            groupBox1 = new GroupBox();
            deleteBatteryModelButton = new Button();
            addBatteryModelButton = new Button();
            editBatteryModelButton = new Button();
            dataGridView1 = new DataGridView();
            headerLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(deleteBatteryModelButton);
            groupBox1.Controls.Add(addBatteryModelButton);
            groupBox1.Controls.Add(editBatteryModelButton);
            groupBox1.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox1.Location = new Point(437, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 259);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Действия с элементами списка";
            // 
            // deleteBatteryModelButton
            // 
            deleteBatteryModelButton.FlatAppearance.BorderColor = Color.Silver;
            deleteBatteryModelButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            deleteBatteryModelButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            deleteBatteryModelButton.FlatStyle = FlatStyle.Flat;
            deleteBatteryModelButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBatteryModelButton.ForeColor = Color.FromArgb(0, 121, 194);
            deleteBatteryModelButton.Location = new Point(6, 201);
            deleteBatteryModelButton.Name = "deleteBatteryModelButton";
            deleteBatteryModelButton.Size = new Size(153, 52);
            deleteBatteryModelButton.TabIndex = 16;
            deleteBatteryModelButton.Text = "Удалить";
            deleteBatteryModelButton.UseVisualStyleBackColor = true;
            deleteBatteryModelButton.Click += deleteBatteryModelButton_Click;
            // 
            // addBatteryModelButton
            // 
            addBatteryModelButton.FlatAppearance.BorderColor = Color.Silver;
            addBatteryModelButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            addBatteryModelButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            addBatteryModelButton.FlatStyle = FlatStyle.Flat;
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
            editBatteryModelButton.FlatAppearance.BorderColor = Color.Silver;
            editBatteryModelButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            editBatteryModelButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            editBatteryModelButton.FlatStyle = FlatStyle.Flat;
            editBatteryModelButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            editBatteryModelButton.ForeColor = Color.FromArgb(0, 121, 194);
            editBatteryModelButton.Location = new Point(6, 143);
            editBatteryModelButton.Name = "editBatteryModelButton";
            editBatteryModelButton.Size = new Size(224, 52);
            editBatteryModelButton.TabIndex = 15;
            editBatteryModelButton.Text = "Редактировать";
            editBatteryModelButton.UseVisualStyleBackColor = true;
            editBatteryModelButton.Click += editBatteryModelButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 90);
            dataGridView1.Margin = new Padding(11);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(410, 241);
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
            // BatteryModelListForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(797, 353);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimumSize = new Size(750, 400);
            Name = "BatteryModelListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Модели аккумуляторов";
            Load += BatteryModelListForm_Load;
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
        private Label headerLabel;
    }
}