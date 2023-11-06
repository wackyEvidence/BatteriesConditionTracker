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
            //var connection = new NpgsqlConnection(@"User ID=xvodnveh;Password=CsmuI3HLha3aJV5ZEeNCQJiEh-c4waBJ;Host=cornelius.db.elephantsql.com;Port=5432;Database=BatteriesConditionTracker;"); 
            //connection.Open();
            //MessageBox.Show($"Соединение установлено: UserName: {connection.UserName}");
            batteriesViewForm.ShowDialog();
        }
    }
}