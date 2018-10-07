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
        bool isFormLoad = false;
        DataClassDataContext db = new DataClassDataContext();
        private void TransctionForm_Load(object sender, EventArgs e)
        {
            isFormLoad = true;
            DisplayRequisitionOfRequire();
            cmbRequireType.SelectedIndex = 1;
            var paymentType = from p in db.Payments
                              select p;
            cmbPaymentType.DataSource = paymentType;
            cmbPaymentType.DisplayMember = "Payment1";
            cmbPaymentType.ValueMember = "PaymentID";
            
            cmbPaymentType.SelectedIndex = 0;
            isFormLoad = false;
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
                    var studpayment = from s in db.StudentPayments join p in db.Payments on s.PaymentID equals p.PaymentID
                                      where s.StudentID == int.Parse(txtSTID.Text)
                                      select new { p.Payment1, s.Amount, s.Date };
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
        double totalbalance;
        double bookpenalty;
        double payed;
        public void getTotalBalance()
        {
            var balance = from p in db.Payments join sc in db.Schoolyears on p.SchoolyearID equals sc.SchoolyearID
                          where p.Payment1 != "Book Penalty" && p.Payment1 != "Second Issue of Certificate" 
                          select p;
            totalbalance = 0;
            foreach (var bal in balance)
            {
                totalbalance += double.Parse(bal.Amount.ToString());
            }
            var unreturnedbooks = from p in db.ProcessBooks
                              where p.StudentID == int.Parse(txtSTID.Text) && p.BookReturn == null
                              select p;
            var bookamount = (from p in db.Payments
                              where p.Payment1 == "Book Penalty"
                              select p).FirstOrDefault();
            bookpenalty = unreturnedbooks.Count() * double.Parse(bookamount.Amount.ToString());
            var studpay = from s in db.StudentPayments
                          join p in db.Payments on s.PaymentID equals p.PaymentID
                          join sc in db.Schoolyears on p.SchoolyearID equals sc.SchoolyearID
                          where p.Payment1 != "Second Issue of Certificate" && s.StudentID==int.Parse(txtSTID.Text)
                          select s;
            payed = 0;
            foreach (var sp in studpay)
            {
                payed += double.Parse(sp.Amount.ToString());
            }
            txtBalance.Text = ((totalbalance + bookpenalty) - payed).ToString();
        }
        private void dgvPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Isselection)
            {
                clearPayment();
                txtSTID.Text = dgvStud.CurrentRow.Cells[0].Value.ToString();
                txtPayStudname.Text = dgvStud.CurrentRow.Cells[1].Value.ToString();
                txtPayShoolYear.Text = dgvStud.CurrentRow.Cells[2].Value.ToString();
                txtPayYearLevel.Text = dgvStud.CurrentRow.Cells[3].Value.ToString();
                Isselection=false;
                var studpayment = from s in db.StudentPayments
                                  join p in db.Payments on s.PaymentID equals p.PaymentID
                                  join sc in db.Schoolyears on p.SchoolyearID equals sc.SchoolyearID
                                  where s.StudentID == int.Parse(txtSTID.Text)
                                  select new {PaymentType=p.Payment1,s.Amount,s.Date };
                dgvPayment.DataSource = studpayment;
                dgvStud.Hide();
                getTotalBalance();
            }
        }
        double amounts = 0;
        double payedamounts = 0;
        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoad==false)
            {
                if (txtSTID.Text != null)
                {
                    if (cmbPaymentType.Text == "Book Penalty")
                    {
                        txtAmount.Text = bookpenalty.ToString();
                        txtAmount.ReadOnly = true;
                        txtCOH.Clear();
                        txtChanges.Clear();
                    }
                    else if (cmbPaymentType.Text == "Second Issue of Certificate")
                    {
                        var sic = (from p in db.Payments join sc in db.Schoolyears on p.SchoolyearID equals sc.SchoolyearID
                                   where p.Payment1 == "Second Issue of Certificate"
                                   select p).FirstOrDefault();
                        if (sic != null)
                        {
                            txtAmount.Text = sic.Amount.ToString();
                            txtAmount.ReadOnly = true;
                            txtCOH.Clear();
                            txtChanges.Clear();
                        }
                      
                    }
                    else
                    {
                        var amount = from p in db.Payments join sc in db.Schoolyears on p.SchoolyearID equals sc.SchoolyearID
                                      where p.PaymentID == int.Parse(cmbPaymentType.SelectedValue.ToString()) 
                                      select p;
                        var payedamount = from sp in db.StudentPayments join p in db.Payments on sp.PaymentID equals p.PaymentID
                                           join sc in db.Schoolyears on p.SchoolyearID equals sc.SchoolyearID
                                           where p.PaymentID == int.Parse(cmbPaymentType.SelectedValue.ToString())&& sp.StudentID==int.Parse(txtSTID.Text)
                                           select sp;
                        amounts = 0;
                        payedamounts = 0;
                        foreach (var a in amount)
                        {
                            amounts += double.Parse(a.Amount.ToString());
                        }
                        foreach (var pa in payedamount)
                        {
                            payedamounts += double.Parse(pa.Amount.ToString());
                        }
                        txtAmount.ReadOnly = false;
                        amounts = amounts - payedamounts;
                        txtAmount.Text = amounts.ToString();
                    }
                }
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
            
        }
        public void clearPayment()
        {
            txtPayStudname.Clear();
            txtPayShoolYear.Clear();
            txtPayYearLevel.Clear();
            cmbPaymentType.SelectedIndex = 0;
            txtAmount.Text = "0";
            txtCOH.Text = "0";
            txtChanges.Text = "0";
            txtAmount.Text = "0";
            txtBalance.Text = "0";
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
                    if (double.Parse(txtAmount.Text) > amounts)
                    {
                        MessageBox.Show("Amount is invalid!");
                    }
                    else
                    {
                        StudentPayment sp = new StudentPayment();
                        sp.StudentID = int.Parse(txtSTID.Text);
                        sp.Amount = decimal.Parse(txtAmount.Text);
                        sp.PaymentID = int.Parse(cmbPaymentType.SelectedValue.ToString());
                        sp.Date = DateTime.Now;
                        db.StudentPayments.InsertOnSubmit(sp);
                        db.SubmitChanges();
                        MessageBox.Show("Successfully Payed!");
                        var studpayment = from s in db.StudentPayments
                                          join p in db.Payments on s.PaymentID equals p.PaymentID
                                          where s.StudentID == int.Parse(txtSTID.Text)
                                          select new { p.Payment1, s.Amount, s.Date };
                        dgvPayment.DataSource = studpayment;
                        getTotalBalance();
                        PaymentReceipt pr = new PaymentReceipt(txtSTID.Text, txtPayStudname.Text, cmbPaymentType.Text, txtCOH.Text, txtAmount.Text, txtChanges.Text);
                        pr.ShowDialog();
                        txtCOH.Text = "0";
                        txtAmount.Text = "0";
                        txtChanges.Text = "0";
                    }
                }
            }
           
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAmount.Text)&&!string.IsNullOrWhiteSpace(txtCOH.Text))
            {
                txtChanges.Text = double.Parse(txtCOH.Text) - double.Parse(txtAmount.Text) + "";
                if (double.Parse(txtAmount.Text) > amounts)
                {
                    MessageBox.Show("Amount must not be greater than " + amounts);
                    txtAmount.Text = amounts.ToString();
                }
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
