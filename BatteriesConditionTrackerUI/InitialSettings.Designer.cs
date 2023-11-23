namespace BatteriesConditionTrackerUI
{
    partial class InitialSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialSettings));
            optionsGroupBox = new GroupBox();
            headerLabel = new Label();
            postgreRadioButton = new RadioButton();
            sqlServerRadioButton = new RadioButton();
            textFilesRadioButton = new RadioButton();
            supplementaryLabel = new Label();
            actionButton = new Button();
            optionsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // optionsGroupBox
            // 
            optionsGroupBox.Controls.Add(textFilesRadioButton);
            optionsGroupBox.Controls.Add(sqlServerRadioButton);
            optionsGroupBox.Controls.Add(postgreRadioButton);
            optionsGroupBox.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            optionsGroupBox.ForeColor = Color.FromArgb(0, 121, 194);
            optionsGroupBox.Location = new Point(31, 122);
            optionsGroupBox.Name = "optionsGroupBox";
            optionsGroupBox.Size = new Size(326, 191);
            optionsGroupBox.TabIndex = 0;
            optionsGroupBox.TabStop = false;
            optionsGroupBox.Text = "Доступные варианты";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Location = new Point(31, 26);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(464, 76);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Пожалуйста, выберите тип \r\nиспользуемого хранилища данных";
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
            // 
            // textFilesRadioButton
            // 
            textFilesRadioButton.AutoSize = true;
            textFilesRadioButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textFilesRadioButton.Location = new Point(15, 138);
            textFilesRadioButton.Name = "textFilesRadioButton";
            textFilesRadioButton.Size = new Size(276, 42);
            textFilesRadioButton.TabIndex = 2;
            textFilesRadioButton.TabStop = true;
            textFilesRadioButton.Text = "Текстовые файлы*";
            textFilesRadioButton.UseVisualStyleBackColor = true;
            // 
            // supplementaryLabel
            // 
            supplementaryLabel.AutoSize = true;
            supplementaryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            supplementaryLabel.Location = new Point(31, 316);
            supplementaryLabel.Name = "supplementaryLabel";
            supplementaryLabel.Size = new Size(330, 28);
            supplementaryLabel.TabIndex = 2;
            supplementaryLabel.Text = "* потребуется указать директорию";
            // 
            // actionButton
            // 
            actionButton.Location = new Point(369, 366);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(126, 53);
            actionButton.TabIndex = 3;
            actionButton.Text = "OK";
            actionButton.UseVisualStyleBackColor = true;
            // 
            // InitialSettings
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(527, 431);
            Controls.Add(actionButton);
            Controls.Add(supplementaryLabel);
            Controls.Add(headerLabel);
            Controls.Add(optionsGroupBox);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 6, 6, 6);
            Name = "InitialSettings";
            Text = "Первоначальная настройка";
            optionsGroupBox.ResumeLayout(false);
            optionsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox optionsGroupBox;
        private RadioButton textFilesRadioButton;
        private RadioButton sqlServerRadioButton;
        private RadioButton postgreRadioButton;
        private Label headerLabel;
        private Label supplementaryLabel;
        private Button actionButton;
    }
}