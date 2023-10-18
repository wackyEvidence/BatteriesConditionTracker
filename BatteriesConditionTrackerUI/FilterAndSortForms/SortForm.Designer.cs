namespace BatteriesConditionTrackerUI
{
    partial class SortForm
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
            groupBoxSort = new GroupBox();
            deleteSortLayerButton = new Button();
            addSortLayerButton = new Button();
            label1 = new Label();
            listView1 = new ListView();
            columnHeaderFieldName = new ColumnHeader();
            columnHeaderSortOrder = new ColumnHeader();
            groupBoxSort.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxSort
            // 
            groupBoxSort.Controls.Add(deleteSortLayerButton);
            groupBoxSort.Controls.Add(addSortLayerButton);
            groupBoxSort.Controls.Add(label1);
            groupBoxSort.Controls.Add(listView1);
            groupBoxSort.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxSort.ForeColor = Color.FromArgb(0, 121, 194);
            groupBoxSort.Location = new Point(12, 12);
            groupBoxSort.Name = "groupBoxSort";
            groupBoxSort.Size = new Size(1040, 357);
            groupBoxSort.TabIndex = 13;
            groupBoxSort.TabStop = false;
            groupBoxSort.Text = "Сортировка";
            // 
            // deleteSortLayerButton
            // 
            deleteSortLayerButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            deleteSortLayerButton.ForeColor = Color.FromArgb(0, 121, 194);
            deleteSortLayerButton.Location = new Point(754, 292);
            deleteSortLayerButton.Name = "deleteSortLayerButton";
            deleteSortLayerButton.Size = new Size(277, 55);
            deleteSortLayerButton.TabIndex = 22;
            deleteSortLayerButton.Text = "Удалить уровень";
            deleteSortLayerButton.UseVisualStyleBackColor = true;
            // 
            // addSortLayerButton
            // 
            addSortLayerButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            addSortLayerButton.ForeColor = Color.FromArgb(0, 121, 194);
            addSortLayerButton.Location = new Point(471, 292);
            addSortLayerButton.Name = "addSortLayerButton";
            addSortLayerButton.Size = new Size(277, 55);
            addSortLayerButton.TabIndex = 21;
            addSortLayerButton.Text = "Добавить уровень";
            addSortLayerButton.UseVisualStyleBackColor = true;
            addSortLayerButton.Click += addSortLayerButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 43);
            label1.Name = "label1";
            label1.Size = new Size(393, 38);
            label1.TabIndex = 1;
            label1.Text = "Текущие уровни сортировки:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeaderFieldName, columnHeaderSortOrder });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(9, 84);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(1022, 202);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeaderFieldName
            // 
            columnHeaderFieldName.Text = "Поле";
            columnHeaderFieldName.Width = 600;
            // 
            // columnHeaderSortOrder
            // 
            columnHeaderSortOrder.Text = "Порядок ";
            columnHeaderSortOrder.Width = 418;
            // 
            // SortForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1062, 377);
            Controls.Add(groupBoxSort);
            ForeColor = Color.FromArgb(0, 121, 194);
            Name = "SortForm";
            Text = "Настройка сортировки";
            groupBoxSort.ResumeLayout(false);
            groupBoxSort.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxSort;
        private Button addSortLayerButton;
        private ListView listView1;
        private ColumnHeader columnHeaderFieldName;
        private ColumnHeader columnHeaderSortOrder;
        private Button deleteSortLayerButton;
        private Label label1;
    }
}