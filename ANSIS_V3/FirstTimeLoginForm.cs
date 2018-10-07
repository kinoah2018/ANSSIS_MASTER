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
    public partial class FirstTimeLoginForm : MetroForm
    {
        public FirstTimeLoginForm()
        {
            InitializeComponent();
        }
        int uid;
        public FirstTimeLoginForm(int id)
        {
            InitializeComponent();
            uid = id;
        }
        DataClassDataContext db = new DataClassDataContext();
        private void FirstTimeLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var checkaccesscode = from u in db.UserAccounts
                                  where u.UserAccountID == uid && u.AccessCode == txtAccessCode.Text
                                  select u;
            if (!string.IsNullOrWhiteSpace(txtUsername.Text) || !string.IsNullOrWhiteSpace(txtPassword.Text) || !string.IsNullOrWhiteSpace(txtCPass.Text) || !string.IsNullOrWhiteSpace(cmbSecuQues.Text) || !string.IsNullOrWhiteSpace(txtAnswer.Text) || !string.IsNullOrWhiteSpace(txtAccessCode.Text) )
            {
                if (checkaccesscode.Count() > 0)
                {
                    if (txtPassword.Text == txtCPass.Text)
                    {
                        if (txtPassword.Text != "1234")
                        {
                            var user = db.UserAccounts.Where(x => x.UserAccountID == uid).SingleOrDefault();
                            user.Username = txtUsername.Text;
                            user.Password = txtPassword.Text;
                            user.IsFirstLogin = false;
                            db.SubmitChanges();
                            UserSecurity usec = new UserSecurity();
                            usec.SecurityQuestion = cmbSecuQues.Text;
                            usec.Answer = txtAnswer.Text;
                            usec.UserAccountID = uid;
                            db.UserSecurities.InsertOnSubmit(usec);
                            db.SubmitChanges();
                            if (user.UserTypeID == 1)
                            {
                                MessageBox.Show(user.Firstname + " " + user.Lastname, "ADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Control_Variables.Username = user.Firstname + " " + user.Lastname;
                                MainForm mf = new MainForm(uid, (int)user.UserTypeID);
                                this.Hide();
                                mf.Show();
                            }
                            else
                            {
                                MessageBox.Show(user.Firstname + " " + user.Lastname, "STAFF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Control_Variables.Username = user.Firstname + " " + user.Lastname;
                                MainForm mf = new MainForm(uid, (int)user.UserTypeID);
                                this.Hide();
                                mf.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Dont user default password!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Password dont match!");
                    }
                }
                else
                {
                    MessageBox.Show("Access Code Not found!");
                }
            }
            else
            {
                MessageBox.Show("Input all fields!");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
