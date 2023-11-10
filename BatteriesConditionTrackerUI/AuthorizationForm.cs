using BatteriesConditionTrackerUI;
using Npgsql;

namespace BatteriesConditionTracker
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void authorizeButton_Click(object sender, EventArgs e)
        {
            var batteriesViewForm = new BatteriesListForm();
            //var connection = new NpgsqlConnection(@"");
            //connection.Open();
            //MessageBox.Show($"Соединение установлено: UserName: {connection.UserName}");
            //MessageBox.Show($"{Environment.CurrentDirectory}");
            batteriesViewForm.ShowDialog();
        }
    }
}