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
using MetroFramework;

namespace ANSIS_V3
{
    public partial class UserAccountForm : MetroFramework.Forms.MetroForm
	{
		public UserAccountForm()
		{
			InitializeComponent();
		}
		DataClassDataContext db = new DataClassDataContext();
		private void UserAccountForm_Load(object sender, EventArgs e)
		{
			DisplayUserAccounts();
			var utype = from u in db.UserTypes
						select u;
			cmbUserType.DataSource = utype;
			cmbUserType.DisplayMember = "Type";
			cmbUserType.ValueMember = "UserTypeID";
            cmbStatus.SelectedIndex = 0;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (btnAdd.Text == "Add")
			{
                if (string.IsNullOrWhiteSpace(txtFname.Text) || string.IsNullOrWhiteSpace(txtLname.Text) || string.IsNullOrWhiteSpace(txtContactNo.Text))
                {
                    MessageBox.Show("Please Input all data needed","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    var useraccount = new UserAccount();
                    useraccount.Firstname = txtFname.Text;
                    useraccount.Lastname = txtLname.Text;
                    useraccount.Middlename = txtMname.Text;
                    useraccount.Username = txtFname.Text + txtLname.Text;
                    useraccount.Password = "1234";
                    useraccount.ContactNumber = txtContactNo.Text;
                    useraccount.UserTypeID = int.Parse(cmbUserType.SelectedValue.ToString());
                    useraccount.AccessCode = RandomString(8);
                    useraccount.IsFirstLogin = true;
                    useraccount.Status = cmbStatus.Text;
                    db.UserAccounts.InsertOnSubmit(useraccount);
                    db.SubmitChanges();
                    MessageBox.Show("Successfully Added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayUserAccounts();
                    clear();  
                }
				
			}
			else
			{
				var updateuser = db.UserAccounts.SingleOrDefault(u => u.UserAccountID == id);
                updateuser.Status = cmbStatus.Text;
				updateuser.UserTypeID = int.Parse(cmbUserType.SelectedValue.ToString());
				db.SubmitChanges();
                MessageBox.Show("Successfully Update!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayUserAccounts();
                clear();
				clear();
				DisplayUserAccounts();
				btnAdd.Text = "Add";
                cmbStatus.Enabled = false;
			}
		}
		private static Random random = new Random();
		public static string RandomString(int length)
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars, length)
			  .Select(s => s[random.Next(s.Length)]).ToArray());
		}
		public void DisplayUserAccounts()
		{
			var user = from u in db.UserAccounts join utype in db.UserTypes on u.UserTypeID equals utype.UserTypeID
					   select new{u.UserAccountID,u.Firstname,u.Middlename,u.Lastname,u.Username,u.ContactNumber,u.Status,utype.Type,u.AccessCode};
			dgvUserAccounts.DataSource = user;
		}
		public void clear()
		{
			txtFname.Clear();
			txtMname.Clear();
			txtLname.Clear();
			txtContactNo.Clear();
            cmbStatus.SelectedIndex = 0;
            cmbUserType.SelectedIndex = -1;
			id = 0;
		}
		int id = 0;
		private void dgvUserAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			id =int.Parse(dgvUserAccounts.CurrentRow.Cells[0].Value.ToString());
			txtFname.Text = dgvUserAccounts.CurrentRow.Cells[1].Value.ToString();
			txtMname.Text = dgvUserAccounts.CurrentRow.Cells[2].Value.ToString();
			txtLname.Text = dgvUserAccounts.CurrentRow.Cells[3].Value.ToString();
			txtContactNo.Text = dgvUserAccounts.CurrentRow.Cells[5].Value.ToString();
            cmbStatus.Text = dgvUserAccounts.CurrentRow.Cells[6].Value.ToString();
            cmbUserType.Text = dgvUserAccounts.CurrentRow.Cells[7].Value.ToString();
			btnAdd.Text = "Update";
			btnCancel.Text = "Cancel";
            cmbStatus.Enabled = true;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (btnCancel.Text == "Cancel")
			{
				clear();
				btnCancel.Text = "Clear";
				btnAdd.Text = "Add";
			}else
			{
				clear();
			}
		}

		private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var search = from u in db.UserAccounts
                       join utype in db.UserTypes on u.UserTypeID equals utype.UserTypeID
                       where u.Firstname.Contains(txtSearch.Text) || u.Lastname.Contains(txtSearch.Text) || utype.Type.Contains(txtSearch.Text)
                       select new { u.UserAccountID, u.Firstname, u.Middlename, u.Lastname, u.Username, u.ContactNumber, utype.Type, u.AccessCode };
            dgvUserAccounts.DataSource = search;
        }

        private void btnAdd_TextChanged(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Update")
            {
                txtFname.Enabled = false;
                txtMname.Enabled = false;
                txtLname.Enabled = false;
                txtContactNo.Enabled = false;
            }
            else
            {
                txtFname.Enabled = true;
                txtMname.Enabled = true;
                txtLname.Enabled = true;
                txtContactNo.Enabled = true;
            }
        }
	}
}
