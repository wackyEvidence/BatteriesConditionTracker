namespace BatteriesConditionTrackerUI
{
    partial class AdminPanelForm
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
            groupBoxTableOptions = new GroupBox();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            authorizeButton = new Button();
            headerLabel = new Label();
            groupBoxTableOptions.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTableOptions
            // 
            groupBoxTableOptions.Controls.Add(button2);
            groupBoxTableOptions.Controls.Add(button4);
            groupBoxTableOptions.Controls.Add(button3);
            groupBoxTableOptions.ForeColor = Color.FromArgb(0, 121, 194);
            groupBoxTableOptions.Location = new Point(22, 103);
            groupBoxTableOptions.Margin = new Padding(6, 6, 6, 6);
            groupBoxTableOptions.Name = "groupBoxTableOptions";
            groupBoxTableOptions.Padding = new Padding(6, 6, 6, 6);
            groupBoxTableOptions.Size = new Size(600, 246);
            groupBoxTableOptions.TabIndex = 18;
            groupBoxTableOptions.TabStop = false;
            groupBoxTableOptions.Text = "Перейти к редактированию базы данных";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 121, 194);
            button2.Location = new Point(15, 42);
            button2.Margin = new Padding(6, 6, 6, 6);
            button2.Name = "button2";
            button2.Size = new Size(214, 61);
            button2.TabIndex = 11;
            button2.Text = "Аккумуляторы";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(0, 121, 194);
            button4.Location = new Point(15, 176);
            button4.Margin = new Padding(6, 6, 6, 6);
            button4.Name = "button4";
            button4.Size = new Size(168, 61);
            button4.TabIndex = 13;
            button4.Text = "Объекты";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 121, 194);
            button3.Location = new Point(15, 109);
            button3.Margin = new Padding(6, 6, 6, 6);
            button3.Name = "button3";
            button3.Size = new Size(190, 61);
            button3.TabIndex = 12;
            button3.Text = "Сотрудники";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 121, 194);
            button1.Location = new Point(37, 352);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(168, 61);
            button1.TabIndex = 17;
            button1.Text = "Настройки";
            button1.UseVisualStyleBackColor = true;
            // 
            // authorizeButton
            // 
            authorizeButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            authorizeButton.ForeColor = Color.FromArgb(0, 121, 194);
            authorizeButton.Location = new Point(37, 416);
            authorizeButton.Margin = new Padding(6, 6, 6, 6);
            authorizeButton.Name = "authorizeButton";
            authorizeButton.Size = new Size(130, 61);
            authorizeButton.TabIndex = 16;
            authorizeButton.Text = "Выход";
            authorizeButton.UseVisualStyleBackColor = true;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(22, 24);
            headerLabel.Margin = new Padding(11, 0, 11, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(523, 62);
            headerLabel.TabIndex = 15;
            headerLabel.Text = "Панель администратора";
            // 
            // AdminPanelForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(753, 505);
            Controls.Add(groupBoxTableOptions);
            Controls.Add(authorizeButton);
            Controls.Add(headerLabel);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 6, 6, 6);
            Name = "AdminPanelForm";
            Text = "AdminPanelForm";
            groupBoxTableOptions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTableOptions;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button1;
        private Button authorizeButton;
        private Label headerLabel;
    }
}