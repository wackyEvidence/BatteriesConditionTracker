using BatteriesConditionTrackerUI;

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
            batteriesViewForm.ShowDialog();
        }
    }
}