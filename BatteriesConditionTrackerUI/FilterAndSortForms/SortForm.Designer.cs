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
            listView1 = new ListView();
            columnHeaderFieldName = new ColumnHeader();
            columnHeaderSortOrder = new ColumnHeader();
            applySortButton = new Button();
            button1 = new Button();
            label1 = new Label();
            groupBoxSort.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxSort
            // 
            groupBoxSort.Controls.Add(button1);
            groupBoxSort.Controls.Add(applySortButton);
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
            // applySortButton
            // 
            applySortButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            applySortButton.ForeColor = Color.FromArgb(0, 121, 194);
            applySortButton.Location = new Point(9, 292);
            applySortButton.Name = "applySortButton";
            applySortButton.Size = new Size(277, 55);
            applySortButton.TabIndex = 21;
            applySortButton.Text = "Добавить уровень";
            applySortButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 121, 194);
            button1.Location = new Point(292, 292);
            button1.Name = "button1";
            button1.Size = new Size(277, 55);
            button1.TabIndex = 22;
            button1.Text = "Удалить уровень";
            button1.UseVisualStyleBackColor = true;
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
        private Button applySortButton;
        private ListView listView1;
        private ColumnHeader columnHeaderFieldName;
        private ColumnHeader columnHeaderSortOrder;
        private Button button1;
        private Label label1;
    }
}