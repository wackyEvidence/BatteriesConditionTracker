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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StructureTypesListForm));
            headerLabel = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            deleteStructureTypeButton = new Button();
            addStructureTypeButton = new Button();
            editStructureTypeButton = new Button();
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
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 96);
            dataGridView1.Margin = new Padding(11);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(333, 244);
            dataGridView1.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(deleteStructureTypeButton);
            groupBox1.Controls.Add(addStructureTypeButton);
            groupBox1.Controls.Add(editStructureTypeButton);
            groupBox1.ForeColor = Color.FromArgb(0, 121, 194);
            groupBox1.Location = new Point(367, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 259);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Действия с элементами списка";
            // 
            // deleteStructureTypeButton
            // 
            deleteStructureTypeButton.FlatAppearance.BorderColor = Color.Silver;
            deleteStructureTypeButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            deleteStructureTypeButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            deleteStructureTypeButton.FlatStyle = FlatStyle.Flat;
            deleteStructureTypeButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            deleteStructureTypeButton.ForeColor = Color.FromArgb(0, 121, 194);
            deleteStructureTypeButton.Location = new Point(6, 201);
            deleteStructureTypeButton.Name = "deleteStructureTypeButton";
            deleteStructureTypeButton.Size = new Size(153, 52);
            deleteStructureTypeButton.TabIndex = 16;
            deleteStructureTypeButton.Text = "Удалить";
            deleteStructureTypeButton.UseVisualStyleBackColor = true;
            deleteStructureTypeButton.Click += deleteStructureTypeButton_Click;
            // 
            // addStructureTypeButton
            // 
            addStructureTypeButton.FlatAppearance.BorderColor = Color.Silver;
            addStructureTypeButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            addStructureTypeButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            addStructureTypeButton.FlatStyle = FlatStyle.Flat;
            addStructureTypeButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            addStructureTypeButton.ForeColor = Color.FromArgb(0, 121, 194);
            addStructureTypeButton.Location = new Point(6, 85);
            addStructureTypeButton.Name = "addStructureTypeButton";
            addStructureTypeButton.Size = new Size(153, 52);
            addStructureTypeButton.TabIndex = 14;
            addStructureTypeButton.Text = "Добавить";
            addStructureTypeButton.UseVisualStyleBackColor = true;
            addStructureTypeButton.Click += addStructureTypeButton_Click;
            // 
            // editStructureTypeButton
            // 
            editStructureTypeButton.FlatAppearance.BorderColor = Color.Silver;
            editStructureTypeButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            editStructureTypeButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            editStructureTypeButton.FlatStyle = FlatStyle.Flat;
            editStructureTypeButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            editStructureTypeButton.ForeColor = Color.FromArgb(0, 121, 194);
            editStructureTypeButton.Location = new Point(6, 143);
            editStructureTypeButton.Name = "editStructureTypeButton";
            editStructureTypeButton.Size = new Size(224, 52);
            editStructureTypeButton.TabIndex = 15;
            editStructureTypeButton.Text = "Редактировать";
            editStructureTypeButton.UseVisualStyleBackColor = true;
            editStructureTypeButton.Click += editStructureTypeButton_Click;
            // 
            // StructureTypesListForm
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
            Name = "StructureTypesListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Типы объектов";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button deleteStructureTypeButton;
        private Button addStructureTypeButton;
        private Button editStructureTypeButton;
    }
}