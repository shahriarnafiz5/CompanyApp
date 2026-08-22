using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Login_and_Register
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(
     ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" ||
                txtPassword.Text == "" ||
                txtConPassword.Text == "")
            {
                MessageBox.Show(
                    "Username and Password fields are empty",
                    "Register Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConPassword.Text)
            {
                try
                {
                    con.Open();

                    string register =
                        "INSERT INTO tbl_users (username, [password]) " +
                        "VALUES (@username, @password)";

                    SqlCommand cmd = new SqlCommand(register, con);

                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    cmd.ExecuteNonQuery();

                    con.Close();

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConPassword.Text = "";
                    txtUsername.Focus();

                    MessageBox.Show(
                        "Your Account has been Successfully Created",
                        "Registration Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Close();
                    }

                    MessageBox.Show(
                        ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    "Passwords do not match. Please re-enter.",
                    "Register Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtPassword.Text = "";
                txtConPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtConPassword.PasswordChar = '•';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConPassword.Text = "";
            txtUsername.Focus();
        }

        private void clickLogin_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
        }
    }
}

