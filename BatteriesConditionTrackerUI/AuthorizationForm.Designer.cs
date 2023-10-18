namespace BatteriesConditionTracker
{
    partial class AuthorizationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            pictureBox1 = new PictureBox();
            authorizationGroupBox = new GroupBox();
            authorizeButton = new Button();
            passwordTextBox = new TextBox();
            loginLabel = new Label();
            loginTextBox = new TextBox();
            passwordLabel = new Label();
            headerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            authorizationGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(180, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // authorizationGroupBox
            // 
            authorizationGroupBox.BackColor = Color.White;
            authorizationGroupBox.Controls.Add(authorizeButton);
            authorizationGroupBox.Controls.Add(passwordTextBox);
            authorizationGroupBox.Controls.Add(loginLabel);
            authorizationGroupBox.Controls.Add(loginTextBox);
            authorizationGroupBox.Controls.Add(passwordLabel);
            authorizationGroupBox.Location = new Point(117, 258);
            authorizationGroupBox.Name = "authorizationGroupBox";
            authorizationGroupBox.Size = new Size(361, 296);
            authorizationGroupBox.TabIndex = 8;
            authorizationGroupBox.TabStop = false;
            // 
            // authorizeButton
            // 
            authorizeButton.FlatAppearance.BorderColor = Color.Silver;
            authorizeButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            authorizeButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            authorizeButton.FlatStyle = FlatStyle.Flat;
            authorizeButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            authorizeButton.ForeColor = Color.FromArgb(0, 121, 194);
            authorizeButton.Location = new Point(196, 229);
            authorizeButton.Name = "authorizeButton";
            authorizeButton.Size = new Size(118, 52);
            authorizeButton.TabIndex = 3;
            authorizeButton.Text = "ОК";
            authorizeButton.UseVisualStyleBackColor = true;
            authorizeButton.Click += authorizeButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(32, 175);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(282, 43);
            passwordTextBox.TabIndex = 5;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.FromArgb(0, 121, 194);
            loginLabel.Location = new Point(32, 23);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(101, 38);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Логин:";
            // 
            // loginTextBox
            // 
            loginTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            loginTextBox.Location = new Point(32, 72);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(282, 43);
            loginTextBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.FromArgb(0, 121, 194);
            passwordLabel.Location = new Point(32, 126);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(118, 38);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Пароль:";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(0, 121, 194);
            headerLabel.Location = new Point(132, 196);
            headerLabel.Margin = new Padding(6, 0, 6, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(330, 62);
            headerLabel.TabIndex = 7;
            headerLabel.Text = "Вход в систему";
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(595, 598);
            Controls.Add(authorizationGroupBox);
            Controls.Add(headerLabel);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AuthorizationForm";
            Text = "Авторизация пользователя";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            authorizationGroupBox.ResumeLayout(false);
            authorizationGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox authorizationGroupBox;
        private Button authorizeButton;
        private TextBox passwordTextBox;
        private Label loginLabel;
        private TextBox loginTextBox;
        private Label passwordLabel;
        private Label headerLabel;
    }
}