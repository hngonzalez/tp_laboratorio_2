using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HugoNahuel.Gonzalez._2D
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void USER(object sender, EventArgs e)
        {
            if (txtUser.Text == "USER")
            {
                txtUser.Text = "";
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void PASSWORD(object sender, EventArgs e)
        {
            if (txtPassword.Text == "PASSWORD")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();

        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void USER2(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USER";
            }
        }

        private void PASSWORD2(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "PASSWORD";
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
