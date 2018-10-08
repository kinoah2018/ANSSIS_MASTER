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
using MetroFramework.Drawing;
using MetroFramework;

namespace ANSIS_V3
{
    public partial class AddInquiryForm : MetroFramework.Forms.MetroForm
    {
        int InqID;
        public AddInquiryForm()
        {
            InitializeComponent();
        }
        DataClassDataContext db = new DataClassDataContext();
        private void AddInquiryForm_Load(object sender, EventArgs e)
        {
            DisplayInq();
        }

        private void mtxtcapacity_Click(object sender, EventArgs e)
        {
            
        }
        public void Clear()
        {
            txtInqDesc.Clear();
            cmbInqType.SelectedIndex = -1;
            txtInqAnswer.Clear();
            txtInqDesc.Clear();
            cmbStatus.SelectedIndex = -1;
            txtSTID.Clear();
            txtStudName.Clear();
        }
        public void DisplayInq()
        {
            var displayinq = from Inq in db.Inquiries
                             join s in db.Students on Inq.StudentID equals s.StudentID
                             select new
                             {
                                 Inq.InquiryID,
                                 Inq.InquiryType,
                                 Inq.Inquiry1,
                                 s.StudentID,
                                 Name = s.Firstname + " " + s.Lastname,
                                 Inq.Status,
                                 Inq.InqAnswer
                             };
            dgvInquiry.DataSource = displayinq;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudName.Text)||string.IsNullOrWhiteSpace(txtInqDesc.Text)||cmbInqType.Text=="")
            {
                MessageBox.Show("Input all fields");
            }
            if (btnAdd.Text == "Add")
            {
                Inquiry inq = new Inquiry();
                inq.InquiryType = cmbInqType.Text;
                inq.Inquiry1 = txtInqDesc.Text;
                inq.StudentID = int.Parse(txtSTID.Text);
                inq.Status = cmbStatus.Text;
                inq.InqAnswer = txtInqAnswer.Text;
                db.Inquiries.InsertOnSubmit(inq);
                db.SubmitChanges();
                MessageBox.Show("Inquiry Add");
                DisplayInq();
                Clear();
            }
            else
            {
                var updateinq = db.Inquiries.SingleOrDefault(x => x.InquiryID == InqID);
                updateinq.InquiryType = cmbInqType.Text;
                updateinq.Inquiry1 = txtInqDesc.Text;
                updateinq.StudentID = int.Parse(txtSTID.Text);
                updateinq.InqAnswer = txtInqAnswer.Text;
                updateinq.Status = cmbStatus.Text;
                db.SubmitChanges();
                MessageBox.Show("Inquiry Update");
                DisplayInq();
                Clear();
                btnAdd.Text = "Add";
                btnClear.Text = "Clear";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (btnClear.Text=="Clear")
            {
                Clear();
            }
            else
            {
                btnClear.Text = "Clear";
                Clear();
                btnAdd.Text = "Add";
            }
        }

        private void dgvInquiry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InqID = int.Parse(dgvInquiry.CurrentRow.Cells[0].Value.ToString());
            cmbInqType.Text = dgvInquiry.CurrentRow.Cells[1].Value.ToString();
            txtInqDesc.Text = dgvInquiry.CurrentRow.Cells[2].Value.ToString();
            txtSTID.Text = dgvInquiry.CurrentRow.Cells[3].Value.ToString();
            txtStudName.Text = dgvInquiry.CurrentRow.Cells[4].Value.ToString();
            cmbStatus.Text = dgvInquiry.CurrentRow.Cells[5].Value.ToString();
            txtInqAnswer.Text = dgvInquiry.CurrentRow.Cells[6].Value.ToString();
            btnAdd.Text = "Update";
            btnClear.Text = "Cancel";
            if (cmbStatus.SelectedIndex==0)
            {
                txtInqAnswer.ReadOnly = true;

            }
            else
            {
                txtInqAnswer.ReadOnly = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var SearchInq = from Inq in db.Inquiries
                             join s in db.Students on Inq.StudentID equals s.StudentID
                             where Inq.Status.Contains(txtInqSearch.Text) || s.Firstname.Contains(txtInqSearch.Text) || s.Lastname.Contains(txtInqSearch.Text)
                             select new
                             {
                                 Inq.InquiryID,
                                 Inq.InquiryType,
                                 Inq.Inquiry1,
                                 s.StudentID,
                                 Name = s.Firstname + " " + s.Lastname,
                                 Inq.Status,
                                 Inq.InqAnswer
                             };
            dgvInquiry.DataSource = SearchInq;
        }

        private void txtSTID_TextChanged(object sender, EventArgs e)
        {

            var getstud = from s in db.Students
                          where s.StudentID.Equals(txtSTID.Text)
                          select new{
                                    Name = s.Firstname + " " + s.Lastname
        };
            try
            {
                if (getstud.Count() > 0)
                {
                    foreach (var stud in getstud)
                    {
                        txtStudName.Text = stud.Name;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Student ID");
                    txtSTID.Clear();
                }
            }
            catch { }
           
            
        }

        private void btnAdd_TextChanged(object sender, EventArgs e)
        {
            if (btnAdd.Text=="Update")
            {
                cmbInqType.Enabled = false;
                txtInqDesc.Enabled = false;
                txtSTID.Enabled = false;
                txtStudName.Enabled = false;
            }
            else
            {
                cmbInqType.Enabled = true;
                txtInqDesc.Enabled = true;
                txtSTID.Enabled = true;
                txtStudName.Enabled = true;
                cmbStatus.Enabled = true;
                txtInqAnswer.Enabled = true;
            }
        }

        private void cmbStatus_Leave(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedIndex==0)
            {
                txtInqAnswer.ReadOnly = true;
            }
            else
            {
                txtInqAnswer.ReadOnly = false;
            }
        }

        private void txtInqAnswer_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSTID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}