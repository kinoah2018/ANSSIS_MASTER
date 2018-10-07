using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ANSIS_V3
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        DataClassDataContext db = new DataClassDataContext();
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = from u in db.UserAccounts
                       where u.Username == txtUname.Text && u.Password == txtPassword.Text && u.Status=="Active"
                       select u;
            if (user.Count() > 0)
            {
                foreach (var u in user)
                {
                    if (u.IsFirstLogin == true)
                    {
                        FirstTimeLoginForm fl = new FirstTimeLoginForm(u.UserAccountID);
                        this.Hide();
                        fl.Show();
                    }
                    else
                    {
                        if (u.UserTypeID == 1)
                        {
                            MainForm mf = new MainForm(u.UserAccountID, (int)u.UserTypeID);
                            MessageBox.Show(u.Firstname + " " + u.Lastname, "ADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Control_Variables.Username = u.Firstname + " " + u.Lastname;
                            this.Hide();
                            mf.Show();

                            
                        }
                        else
                        {
                            MainForm mf = new MainForm(u.UserAccountID, (int)u.UserTypeID);
                            MessageBox.Show(u.Firstname + " " + u.Lastname, "STAFF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Control_Variables.Username = u.Firstname + " " + u.Lastname;
                            this.Hide();
                            mf.Show();
                        }
                       
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid credentials or account Inactive!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm fp = new ForgotPasswordForm();
            this.Hide();
            fp.Show();
        }
    }
}
