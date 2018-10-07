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
    public partial class ForgotPasswordForm : MetroForm
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }
        DataClassDataContext db = new DataClassDataContext();
        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {             
            if (!string.IsNullOrWhiteSpace(txtUsername.Text) || !string.IsNullOrWhiteSpace(cmbSecuritQues.Text) || !string.IsNullOrWhiteSpace(txtAnswer.Text) || !string.IsNullOrWhiteSpace(txtPass.Text) || !string.IsNullOrWhiteSpace(txtRetypePass.Text))
            {
                if (txtPass.Text==txtRetypePass.Text)
                {
                    var userupdate = db.UserAccounts.Where(x => x.Username == txtUsername.Text).SingleOrDefault();
                    userupdate.Password = txtRetypePass.Text;
                    db.SubmitChanges();
                    MessageBox.Show("Succesfully Change!");
                    Login l = new Login();
                    this.Close();
                    l.Show();
                }
                else
                {
                    MessageBox.Show("Password doesn't match");
                }
            }
            else
            {
                MessageBox.Show("Input All Fields");
            }
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtAnswer_Leave(object sender, EventArgs e)
        {
            
        }

        private void ForgotPasswordForm_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void txtAnswer_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            var chkSecurity = from usec in db.UserSecurities
                              join u in db.UserAccounts on usec.UserAccountID equals u.UserAccountID
                              where usec.SecurityQuestion == cmbSecuritQues.Text && usec.Answer == txtAnswer.Text && usec.UserAccountID == u.UserAccountID
                              select usec;

            if (chkSecurity.Count() > 0)
            {
                txtPass.ReadOnly = false;
                txtRetypePass.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Invalid security!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Close();
            l.Show();
        }
    }
}
