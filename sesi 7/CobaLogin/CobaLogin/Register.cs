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
    public partial class Register : Form
    {
        Config db = new Config();
        public Register()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtConfPassword.PasswordChar = '*';
            db.Connect("userdata");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please insert your name!");
            }
            else if (txtUName.Text == "") { 
                MessageBox.Show("Please insert your username!");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please insert your password!");
            }
            else
            {
                if (txtConfPassword.Text == "" || txtConfPassword.Text != txtPassword.Text)
                {
                    MessageBox.Show("Password and Confirm password must be the same!");
                }
                else { 
                    db.Execute("INSERT INTO user_info(name, username, password) VALUES ('" + txtName.Text + "', '" + txtUName.Text + "', '" + txtPassword.Text + "')");
                    MessageBox.Show("User Registered!");
                    this.Close();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
