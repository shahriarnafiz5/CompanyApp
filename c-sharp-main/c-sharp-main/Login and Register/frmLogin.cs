using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Login_and_Register
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(
    ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string login = "SELECT COUNT(*) FROM tbl_users " +
                               "WHERE username = @username AND [password] = @password";

                SqlCommand cmd = new SqlCommand(login, con);

                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                con.Close();

                if (count > 0)
                {
                    new Form1().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Username and Password are incorrect. Please try again.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void clickRegister_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}
