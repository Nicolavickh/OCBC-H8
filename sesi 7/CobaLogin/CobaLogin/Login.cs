using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CobaLogin
{
    public partial class Login : Form
    {
        Config db = new Config();
        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            db.Connect("userdata");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM user_info WHERE username='" + txtUsername.Text + "' AND password='" + txtPassword.Text +"'");
            if (db.count() == 1)
            {
                MessageBox.Show("Login Success! You logged in as " + db.Results(0, "name"));
            }
            else {
                MessageBox.Show("Wrong username or password combination!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
