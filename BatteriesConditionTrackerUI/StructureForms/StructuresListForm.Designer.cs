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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StructuresListForm));
            dataGridView1 = new DataGridView();
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
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 89);
            dataGridView1.Margin = new Padding(6);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(333, 244);
            dataGridView1.TabIndex = 12;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(2, 9);
            headerLabel.Margin = new Padding(11, 0, 11, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(374, 62);
            headerLabel.TabIndex = 11;
            headerLabel.Text = "Список объектов";
            // 
            // addStructureButton
            // 
            addStructureButton.FlatAppearance.BorderColor = Color.Silver;
            addStructureButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            addStructureButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            addStructureButton.FlatStyle = FlatStyle.Flat;
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
            editStructureButton.FlatAppearance.BorderColor = Color.Silver;
            editStructureButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            editStructureButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            editStructureButton.FlatStyle = FlatStyle.Flat;
            editStructureButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            editStructureButton.ForeColor = Color.FromArgb(0, 121, 194);
            editStructureButton.Location = new Point(6, 143);
            editStructureButton.Name = "editStructureButton";
            editStructureButton.Size = new Size(224, 52);
            editStructureButton.TabIndex = 15;
            editStructureButton.Text = "Редактировать";
            editStructureButton.UseVisualStyleBackColor = true;
            editStructureButton.Click += editStructureButton_Click;
            // 
            // deleteStructureButton
            // 
            deleteStructureButton.FlatAppearance.BorderColor = Color.Silver;
            deleteStructureButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            deleteStructureButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            deleteStructureButton.FlatStyle = FlatStyle.Flat;
            deleteStructureButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            deleteStructureButton.ForeColor = Color.FromArgb(0, 121, 194);
            deleteStructureButton.Location = new Point(6, 201);
            deleteStructureButton.Name = "deleteStructureButton";
            deleteStructureButton.Size = new Size(153, 52);
            deleteStructureButton.TabIndex = 16;
            deleteStructureButton.Text = "Удалить";
            deleteStructureButton.UseVisualStyleBackColor = true;
            deleteStructureButton.Click += deleteStructureButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(deleteStructureButton);
            groupBox1.Controls.Add(addStructureButton);
            groupBox1.Controls.Add(editStructureButton);
            groupBox1.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox1.Location = new Point(367, 74);
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
            Name = "StructuresListForm";
            Text = "Объекты";
            Load += StructuresListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label headerLabel;
        private Button addStructureButton;
        private Button editStructureButton;
        private Button deleteStructureButton;
        private GroupBox groupBox1;
    }
}