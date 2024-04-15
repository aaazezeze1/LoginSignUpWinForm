// import database
using System.Data.OleDb;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace LoginSignUp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Amazing\\Desktop\\LoginSignUp\\bin\\Debug\\db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        // Register
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            // Check if all fields are empty
            if (UsernameTxtBox.Text == "" && PasswordTxtBox.Text == "" && CFPassTxtBox.Text == "")
            {
                MessageBox.Show("Please enter a valid Username and Password", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Create an account if passwords matches the confirm password box
            else if (PasswordTxtBox.Text == CFPassTxtBox.Text)
            {
                con.Open();
                // Send credentials to the database
                string register = "INSERT INTO tbl_users VALUES ('" + UsernameTxtBox.Text + "', '" + PasswordTxtBox.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                // Clear the fields
                UsernameTxtBox.Text = "";
                PasswordTxtBox.Text = "";
                CFPassTxtBox.Text = "";

                MessageBox.Show("Account created successfully", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            else
            {
                MessageBox.Show("Passwords does not match", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTxtBox.Text = "";
                CFPassTxtBox.Text = "";
                PasswordTxtBox.Focus();
                con.Close();
            }
        }

        private void ShowPassCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassCBox.Checked)
            {
                PasswordTxtBox.PasswordChar = '\0';
                CFPassTxtBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTxtBox.PasswordChar = '•';
                CFPassTxtBox.PasswordChar = '•';
            }
        }

        // Login
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + LUsernameTxtBox.Text + "' and password= '" + LPasswordTxtBox.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            // Check if username and password match
            if (dr.Read() == true)
            {
                // If it matches then show the main menu form
                new MainMenu().Show();
                this.Hide();
                con.Close();
            }
            // If the credentials are incorrect
            else
            {
                MessageBox.Show("Invalid Username or Password. Please Try Again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Clear the fields
                UsernameTxtBox.Text = "";
                PasswordTxtBox.Text = "";
                UsernameTxtBox.Focus();
                con.Close();
            }
        }

        private void LShowPassCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LShowPassCBox.Checked)
            {
                LPasswordTxtBox.PasswordChar = '\0';
            }
            else
            {
                LPasswordTxtBox.PasswordChar = '•';
            }
        }
    }
}
