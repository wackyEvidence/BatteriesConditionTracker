namespace BatteriesConditionTracker
{
    partial class DataSourceChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSourceChange));
            optionsGroupBox = new GroupBox();
            changeTextFilesDirectory = new LinkLabel();
            usingDefaultDirectory = new CheckBox();
            textFilesRadioButton = new RadioButton();
            sqlServerRadioButton = new RadioButton();
            postgreRadioButton = new RadioButton();
            actionButton = new Button();
            optionsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // optionsGroupBox
            // 
            optionsGroupBox.Controls.Add(changeTextFilesDirectory);
            optionsGroupBox.Controls.Add(usingDefaultDirectory);
            optionsGroupBox.Controls.Add(textFilesRadioButton);
            optionsGroupBox.Controls.Add(sqlServerRadioButton);
            optionsGroupBox.Controls.Add(postgreRadioButton);
            optionsGroupBox.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            optionsGroupBox.ForeColor = Color.FromArgb(0, 121, 194);
            optionsGroupBox.Location = new Point(12, 12);
            optionsGroupBox.Name = "optionsGroupBox";
            optionsGroupBox.Size = new Size(464, 241);
            optionsGroupBox.TabIndex = 1;
            optionsGroupBox.TabStop = false;
            optionsGroupBox.Text = "Доступные варианты";
            // 
            // changeTextFilesDirectory
            // 
            changeTextFilesDirectory.AutoSize = true;
            changeTextFilesDirectory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            changeTextFilesDirectory.Location = new Point(15, 190);
            changeTextFilesDirectory.Name = "changeTextFilesDirectory";
            changeTextFilesDirectory.Size = new Size(336, 28);
            changeTextFilesDirectory.TabIndex = 14;
            changeTextFilesDirectory.TabStop = true;
            changeTextFilesDirectory.Text = "Изменить выбранную директорию";
            changeTextFilesDirectory.LinkClicked += changeTextFilesDirectory_LinkClicked;
            // 
            // usingDefaultDirectory
            // 
            usingDefaultDirectory.AutoSize = true;
            usingDefaultDirectory.Checked = true;
            usingDefaultDirectory.CheckState = CheckState.Checked;
            usingDefaultDirectory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usingDefaultDirectory.Location = new Point(15, 186);
            usingDefaultDirectory.Name = "usingDefaultDirectory";
            usingDefaultDirectory.Size = new Size(425, 32);
            usingDefaultDirectory.TabIndex = 3;
            usingDefaultDirectory.Text = "Использовать директорию по умолчанию";
            usingDefaultDirectory.UseVisualStyleBackColor = true;
            // 
            // textFilesRadioButton
            // 
            textFilesRadioButton.AutoSize = true;
            textFilesRadioButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textFilesRadioButton.Location = new Point(15, 138);
            textFilesRadioButton.Name = "textFilesRadioButton";
            textFilesRadioButton.Size = new Size(264, 42);
            textFilesRadioButton.TabIndex = 2;
            textFilesRadioButton.TabStop = true;
            textFilesRadioButton.Text = "Текстовые файлы";
            textFilesRadioButton.UseVisualStyleBackColor = true;
            textFilesRadioButton.CheckedChanged += textFilesRadioButton_CheckedChanged;
            // 
            // sqlServerRadioButton
            // 
            sqlServerRadioButton.AutoSize = true;
            sqlServerRadioButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            sqlServerRadioButton.Location = new Point(15, 90);
            sqlServerRadioButton.Name = "sqlServerRadioButton";
            sqlServerRadioButton.Size = new Size(173, 42);
            sqlServerRadioButton.TabIndex = 1;
            sqlServerRadioButton.TabStop = true;
            sqlServerRadioButton.Text = "SQL Server";
            sqlServerRadioButton.UseVisualStyleBackColor = true;
            sqlServerRadioButton.CheckedChanged += sqlServerRadioButton_CheckedChanged;
            // 
            // postgreRadioButton
            // 
            postgreRadioButton.AutoSize = true;
            postgreRadioButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            postgreRadioButton.Location = new Point(15, 42);
            postgreRadioButton.Name = "postgreRadioButton";
            postgreRadioButton.Size = new Size(180, 42);
            postgreRadioButton.TabIndex = 0;
            postgreRadioButton.TabStop = true;
            postgreRadioButton.Text = "PostgreSQL";
            postgreRadioButton.UseVisualStyleBackColor = true;
            postgreRadioButton.CheckedChanged += postgreRadioButton_CheckedChanged;
            // 
            // actionButton
            // 
            actionButton.Location = new Point(350, 259);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(126, 53);
            actionButton.TabIndex = 4;
            actionButton.Text = "OK";
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
            // 
            // DataSourceChange
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(489, 321);
            Controls.Add(actionButton);
            Controls.Add(optionsGroupBox);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "DataSourceChange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменение источника данных";
            optionsGroupBox.ResumeLayout(false);
            optionsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox optionsGroupBox;
        private CheckBox usingDefaultDirectory;
        private RadioButton textFilesRadioButton;
        private RadioButton sqlServerRadioButton;
        private RadioButton postgreRadioButton;
        private Button actionButton;
        private LinkLabel changeTextFilesDirectory;
    }
}