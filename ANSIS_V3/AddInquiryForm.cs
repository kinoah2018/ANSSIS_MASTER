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
        }
        public void DisplayInq()
        {
            var displayinq = from Inq in db.Inquiries
                             select Inq;
            dgvInquiry.DataSource = displayinq;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                Inquiry inq = new Inquiry();
                inq.InquiryID = InqID;
                inq.InquiryFor = txtInquiFor.Text;
                inq.InquiryDesc = txtInqDesc.Text;
                inq.Creator = txtCreatedBy.Text;
                db.Inquiries.InsertOnSubmit(inq);
                db.SubmitChanges();
                MessageBox.Show("Success Add");
                DisplayInq();
                Clear();
            }
            else
            {
                var updateinq = db.Inquiries.SingleOrDefault(x => x.InquiryID == InqID);
                updateinq.InquiryFor = txtInquiFor.Text;
                updateinq.InquiryDesc = txtInqDesc.Text;
                updateinq.Creator = txtCreatedBy.Text;
                db.SubmitChanges();
                MessageBox.Show("Success Update");
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
                  InqID= int.Parse(dgvInquiry.CurrentRow.Cells[0].Value.ToString());
            txtInquiFor.Text = dgvInquiry.CurrentRow.Cells[1].Value.ToString();
            txtInqDesc.Text = dgvInquiry.CurrentRow.Cells[2].Value.ToString();
            txtCreatedBy.Text = dgvInquiry.CurrentRow.Cells[3].Value.ToString();
            btnAdd.Text = "Update";
            btnClear.Text = "Cancel";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var search = from Inq in db.Inquiries
                         where Inq.Creator.Contains(txtSearch.Text) 
                             select Inq;
            dgvInquiry.DataSource = search;
        }
    }
}
