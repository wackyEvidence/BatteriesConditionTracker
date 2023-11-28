using BatteriesConditionTrackerUI;
using Npgsql;
using BCrypt.Net;
using BatteriesConditionTrackerLib;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace BatteriesConditionTracker
{
    public partial class AuthorizationForm : Form
    {
        public bool AuthorizationSuccessful { get; private set; }

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void authorizeButton_Click(object sender, EventArgs e)
        {
            if(Authorizer.Authorize(loginTextBox.Text, passwordTextBox.Text))
            {
                AuthorizationSuccessful = true;
                Close();
            }
            else
                MessageBox.Show("¬веден неправильный логин или пароль", "ќшибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}