using Krypton.Toolkit;
using LibrariumAdmin.Backend;

namespace LibrariumAdmin.Forms
{
    public partial class LoginForm : KryptonForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = AdminUsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (AdminBackend.ValidateAdminLogin(username, password) != null)
            {
                MessageBox.Show("Login successful!");

                this.Hide();
                DashboardForm dashboardForm = new();
                dashboardForm.Closed += (s, args) => this.Close();
                dashboardForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }
    }
}
