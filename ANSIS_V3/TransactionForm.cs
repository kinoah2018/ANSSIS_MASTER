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
    public partial class TransactionForm : MetroFramework.Forms.MetroForm
    {
        bool Isselection;
        int RequiOfRequireID;
        int PaymentID;
        public TransactionForm()
        {
            
            InitializeComponent();
        }

        DataClassDataContext db = new DataClassDataContext();
        private void TransctionForm_Load(object sender, EventArgs e)
        {
            DisplayRequisitionOfRequire();
            cmbRequireType.SelectedIndex = 1;
            var paymentType = from p in db.Payments
                              select p;
            cmbPaymentType.DataSource = paymentType;
            cmbPaymentType.DisplayMember = "Payment1";
            cmbPaymentType.ValueMember = "PaymentID";
            cmbPaymentType.SelectedIndex = -1;
        }

        private void mbtnSelectStud_Click(object sender, EventArgs e)
        {
            var displaystud = from s in db.Students
                              join sy in db.Schoolyears on s.SchoolyearID equals sy.SchoolyearID
                              select new
                              {
                                  s.StudentID,
                                  Name = s.Firstname + " " + s.Lastname,
                                  s.YearLevel,
                                  SchoolYear=sy.Year
                              };
            dgvRequiOfRequire.DataSource = displaystud;
            cmbRequireType.SelectedIndex = 1;
            Isselection = true;
        }

        private void mtbSelectedStudPay_Click(object sender, EventArgs e)
        {
            clearPayment();
            dgvStud.Visible = true;
            var displayStud = from s in db.Students
                              join sy in db.Schoolyears on s.SchoolyearID equals sy.SchoolyearID
                              select new
                              {
                                  s.StudentID,
                                  Name = s.Firstname + " " + s.Lastname,
                                  sy.Year,
                                  s.YearLevel
                              };
                                Isselection = true;
                                dgvStud.DataSource = displayStud;
        }
        public void RORCLEAR()
        {
            txtStudName.Clear();
            txtShoolYear.Clear();
            txtYearLevel.Clear();
            cmbRequireType.SelectedIndex = -1;
        }

        public void DisplayRequisitionOfRequire()
        {
            var displayRequiOfRequire = from ror in db.RequiOfRequirements
                                        join s in db.Students on ror.StudentID equals s.StudentID
                                        join sy in db.Schoolyears on s.SchoolyearID equals sy.SchoolyearID 
                                        join u in db.UserAccounts on ror.UserAccountID equals u.UserAccountID
                                        select new
                                        {
                                            ID=ror.RequiOfRequirementID,
                                            Name = s.Firstname + " " + s.Lastname,
                                            SchoolYear=sy.Year,
                                            s.YearLevel,
                                            ror.Requirement,
                                            ReleasedBy= u.Firstname+" "+u.Lastname,
                                            ror.DateRelease
                                        };
            dgvRequiOfRequire.DataSource = displayRequiOfRequire;
        }

        private void dgvRequiOfRequire_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Isselection)
            {
                txtStudID.Text = dgvRequiOfRequire.CurrentRow.Cells[0].Value.ToString();
                txtStudName.Text = dgvRequiOfRequire.CurrentRow.Cells[1].Value.ToString();
                txtShoolYear.Text = dgvRequiOfRequire.CurrentRow.Cells[2].Value.ToString();
                txtYearLevel.Text = dgvRequiOfRequire.CurrentRow.Cells[3].Value.ToString();
                Isselection = false;
                DisplayRequisitionOfRequire();
            }
        }
        
        private void btnRORAdd_Click(object sender, EventArgs e)
        {
            var rorExist = from r in db.RequiOfRequirements
                           where r.Requirement == cmbRequireType.Text && r.StudentID == int.Parse(txtStudID.Text)
                           select r;
            if (rorExist.Count() > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to go to payment tab?", "Second issue!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    metroTabControl1.SelectedIndex = 1;
                    txtSTID.Text = txtStudID.Text;
                    txtPayStudname.Text = txtStudName.Text;
                    txtPayShoolYear.Text = txtShoolYear.Text;
                    txtPayYearLevel.Text = txtYearLevel.Text;
                    cmbPaymentType.Text = " Second Issue of Certifacate";
                    var studpayment = from s in db.StudentPayments
                                      where s.StudentID == int.Parse(txtSTID.Text)
                                      select new { s.PaymentType, s.Amount, s.Date };
                    dgvPayment.DataSource = studpayment;
                    dgvStud.Visible = false;
                    getTotalBalance();
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            }
            else
            {
                RequiOfRequirement ror = new RequiOfRequirement();
                ror.StudentID = int.Parse(txtStudID.Text);
                ror.Requirement = cmbRequireType.Text;
                ror.UserAccountID = int.Parse(txtReleaseBy.Text);
                ror.DateRelease = DateTime.Now;
                db.RequiOfRequirements.InsertOnSubmit(ror);
                db.SubmitChanges();
                MessageBox.Show("Successfully Add");
                DisplayRequisitionOfRequire();
                RORCLEAR();
            }
        }

        private void btnRORClear_Click(object sender, EventArgs e)
        {
            RORCLEAR();
        }

        private void txtRequiOfRequireSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtRequiOfRequireSearch_TextChanged(object sender, EventArgs e)
        {
            if (Isselection)
            {
                var searchstud =  from s in db.Students
                                  join sy in db.Schoolyears on s.SchoolyearID equals sy.SchoolyearID
                                  where s.Firstname.Contains(txtRequiOfRequireSearch.Text) || s.Lastname.Contains(txtRequiOfRequireSearch.Text) || s.YearLevel.Contains(txtRequiOfRequireSearch.Text) || sy.Year.Contains(txtRequiOfRequireSearch.Text)
                                  select new
                                  {
                                      s.StudentID,
                                      Name = s.Firstname + " " + s.Lastname,
                                      s.YearLevel,
                                      SchoolYear = sy.Year
                                  };
                dgvRequiOfRequire.DataSource = searchstud;
            }
            else
            {
                var searchror = from ror in db.RequiOfRequirements
                                join s in db.Students on ror.StudentID equals s.StudentID
                                join sy in db.Schoolyears on s.SchoolyearID equals sy.SchoolyearID
                                join u in db.UserAccounts on ror.UserAccountID equals u.UserAccountID
                                where s.Firstname.Contains(txtRequiOfRequireSearch.Text) || sy.Year.Contains(txtRequiOfRequireSearch.Text) || s.Lastname.Contains(txtRequiOfRequireSearch.Text) || s.YearLevel.Contains(txtRequiOfRequireSearch.Text) || ror.Requirement.Contains(txtRequiOfRequireSearch.Text)
                                select new
                                {
                                    ID = ror.RequiOfRequirementID,
                                    Name = s.Firstname + " " + s.Lastname,
                                    SchoolYear = sy.Year,
                                    s.YearLevel,
                                    ror.Requirement,
                                    Releaseby = u.Firstname + " " + u.Lastname,
                                    ror.DateRelease
                                };
                dgvRequiOfRequire.DataSource = searchror;
            }
           
        }

        private void mtpRequisitionOFRequirement_Click(object sender, EventArgs e)
        {

        }

        private void txtPayStudname_Click(object sender, EventArgs e)
        {

        }

        public void displaypayment()
        {
           // var displaypay = from p in db.Payments
                             
        }
        double totalBalance = 0;
        double ptapayments = 0;
        double bookpayments = 0;
        double payedbooks = 0;
        public void getTotalBalance()
        {
            var studpay = from s in db.StudentPayments
                          where s.StudentID == int.Parse(txtSTID.Text) && s.PaymentType == "Parent Teacher Association - (PTA)"
                          select s;
            var studpayedbook = from s in db.StudentPayments
                                where s.StudentID == int.Parse(txtSTID.Text) && s.PaymentType == "Book Penalty"
                                select s;
            var bookpay = from b in db.ProcessBooks
                          where b.StudentID == int.Parse(txtSTID.Text) && b.BookReturn == null
                          select b;
            bookpayments = bookpay.Count() * 100;
            foreach (var sp in studpay)
            {
                ptapayments += double.Parse(sp.Amount.ToString());
            }
            foreach (var spb in studpayedbook)
            {
                payedbooks += double.Parse(spb.Amount.ToString());
            }
            bookpayments = bookpayments - payedbooks;
            ptapayments = 750 - ptapayments;
            totalBalance = ptapayments + bookpayments;
            txtBalance.Text = totalBalance.ToString();
        }
        private void dgvPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Isselection)
            {
                txtSTID.Text = dgvStud.CurrentRow.Cells[0].Value.ToString();
                txtPayStudname.Text = dgvStud.CurrentRow.Cells[1].Value.ToString();
                txtPayShoolYear.Text = dgvStud.CurrentRow.Cells[2].Value.ToString();
                txtPayYearLevel.Text = dgvStud.CurrentRow.Cells[3].Value.ToString();
                Isselection=false;
                dgvStud.Hide();
                var studpayment = from s in db.StudentPayments
                                  where s.StudentID==int.Parse(txtSTID.Text)
                                  select new { s.PaymentType, s.Amount, s.Date };
                dgvPayment.DataSource = studpayment;
                getTotalBalance();
            }
        }

        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaymentType.Text == "Parent Teacher Association - (PTA)")
            {
                txtAmount.Text = ptapayments.ToString();
                txtAmount.ReadOnly = false;
                txtCOH.Clear();
                txtChanges.Clear();
            }
            else if(cmbPaymentType.Text=="Book Penalty")
            {
                txtAmount.Text = bookpayments.ToString();
                txtAmount.ReadOnly = true;
                txtCOH.Clear();
                txtChanges.Clear();
            }
            else if (cmbPaymentType.Text == " Second Issue of Certifacate")
            {
                txtAmount.Text = "150";
                txtAmount.ReadOnly = true;
                txtCOH.Clear();
                txtChanges.Clear();
            }
        }

        private void txtCOH_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAmount.Text) && !string.IsNullOrWhiteSpace(txtCOH.Text))
            {
                txtChanges.Text = double.Parse(txtCOH.Text) - double.Parse(txtAmount.Text) + "";
            }
        }

        private void txtCOH_Leave(object sender, EventArgs e)
        {
            if (cmbPaymentType.Text == "Parent Teacher Association - (PTA)")
            {

            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txtAmount.Text) && !string.IsNullOrWhiteSpace(txtCOH.Text))
                {
                    if (double.Parse(txtCOH.Text) >= double.Parse(txtAmount.Text))
                    {

                    }
                    else
                    {
                        txtCOH.Clear();
                        MessageBox.Show("Books and Second issue of certificate should be payed full");
                    }
                }
            }
        }
        public void clearPayment()
        {
            txtPayStudname.Clear();
            txtPayShoolYear.Clear();
            txtPayYearLevel.Clear();
            cmbPaymentType.SelectedIndex = -1;
            txtAmount.Text = "0";
            txtCOH.Text = "0";
            txtChanges.Text = "0";
            txtAmount.Text = "0";
            txtBalance.Text = "0";
            totalBalance = 0;
            bookpayments = 0;
            ptapayments = 0;
            payedbooks = 0;
        }
        private void mbtnPayAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtChanges.Text))
            {
                if (double.Parse(txtChanges.Text) < 0)
                {
                    MessageBox.Show("Invalid transaction");
                }
                else
                {
                    StudentPayment sp = new StudentPayment();
                    sp.StudentID = int.Parse(txtSTID.Text);
                    sp.Amount = decimal.Parse(txtAmount.Text);
                    sp.PaymentType = cmbPaymentType.Text;
                    sp.Date = DateTime.Now;
                    db.StudentPayments.InsertOnSubmit(sp);
                    db.SubmitChanges();
                    PaymentReceipt pr=new PaymentReceipt(txtPayStudname.Text,cmbPaymentType.Text,txtCOH.Text,txtAmount.Text,txtChanges.Text);
                    pr.ShowDialog();
                    var studpayment = from s in db.StudentPayments
                                      where s.StudentID == int.Parse(txtSTID.Text)
                                      select new {s.PaymentType,s.Amount,s.Date};
                    dgvPayment.DataSource = studpayment;
                    clearPayment();
                }
            }
           
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAmount.Text)&&!string.IsNullOrWhiteSpace(txtCOH.Text))
            {
                txtChanges.Text = double.Parse(txtCOH.Text) - double.Parse(txtAmount.Text) + "";
            }
        }

        private void mbtnPayClear_Click(object sender, EventArgs e)
        {
            clearPayment();
        }

        private void txtAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
