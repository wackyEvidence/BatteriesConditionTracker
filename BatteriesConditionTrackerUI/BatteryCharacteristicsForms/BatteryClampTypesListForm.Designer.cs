namespace BatteriesConditionTrackerUI
{
    partial class BatteryClampTypesListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatteryClampTypesListForm));
            groupBox1 = new GroupBox();
            deleteClampTypeButton = new Button();
            addClampTypeButton = new Button();
            editClampTypeButton = new Button();
            dataGridView1 = new DataGridView();
            headerLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(deleteClampTypeButton);
            groupBox1.Controls.Add(addClampTypeButton);
            groupBox1.Controls.Add(editClampTypeButton);
            groupBox1.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox1.Location = new Point(367, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 259);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Действия с элементами списка";
            // 
            // deleteClampTypeButton
            // 
            deleteClampTypeButton.FlatAppearance.BorderColor = Color.Silver;
            deleteClampTypeButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            deleteClampTypeButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            deleteClampTypeButton.FlatStyle = FlatStyle.Flat;
            deleteClampTypeButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            deleteClampTypeButton.ForeColor = Color.FromArgb(0, 121, 194);
            deleteClampTypeButton.Location = new Point(6, 201);
            deleteClampTypeButton.Name = "deleteClampTypeButton";
            deleteClampTypeButton.Size = new Size(153, 52);
            deleteClampTypeButton.TabIndex = 16;
            deleteClampTypeButton.Text = "Удалить";
            deleteClampTypeButton.UseVisualStyleBackColor = true;
            deleteClampTypeButton.Click += deleteClampTypeButton_Click;
            // 
            // addClampTypeButton
            // 
            addClampTypeButton.FlatAppearance.BorderColor = Color.Silver;
            addClampTypeButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            addClampTypeButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            addClampTypeButton.FlatStyle = FlatStyle.Flat;
            addClampTypeButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            addClampTypeButton.ForeColor = Color.FromArgb(0, 121, 194);
            addClampTypeButton.Location = new Point(6, 85);
            addClampTypeButton.Name = "addClampTypeButton";
            addClampTypeButton.Size = new Size(153, 52);
            addClampTypeButton.TabIndex = 14;
            addClampTypeButton.Text = "Добавить";
            addClampTypeButton.UseVisualStyleBackColor = true;
            addClampTypeButton.Click += addClampTypeButton_Click;
            // 
            // editClampTypeButton
            // 
            editClampTypeButton.FlatAppearance.BorderColor = Color.Silver;
            editClampTypeButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            editClampTypeButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            editClampTypeButton.FlatStyle = FlatStyle.Flat;
            editClampTypeButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            editClampTypeButton.ForeColor = Color.FromArgb(0, 121, 194);
            editClampTypeButton.Location = new Point(6, 143);
            editClampTypeButton.Name = "editClampTypeButton";
            editClampTypeButton.Size = new Size(224, 52);
            editClampTypeButton.TabIndex = 15;
            editClampTypeButton.Text = "Редактировать";
            editClampTypeButton.UseVisualStyleBackColor = true;
            editClampTypeButton.Click += editClampTypeButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 89);
            dataGridView1.Margin = new Padding(11);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
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
            headerLabel.Size = new Size(448, 62);
            headerLabel.TabIndex = 20;
            headerLabel.Text = "Список типов клемм";
            // 
            // BatteryClampTypesListForm
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
            Name = "BatteryClampTypesListForm";
            Text = "Типы клемм";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button deleteClampTypeButton;
        private Button addClampTypeButton;
        private Button editClampTypeButton;
        private DataGridView dataGridView1;
        private Label headerLabel;
    }
}