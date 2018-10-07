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
    public partial class MonitoringForm : MetroForm
    {
        public MonitoringForm()
        {
            InitializeComponent();
        }
        bool isFormLoad = false;
        DataClassDataContext db = new DataClassDataContext();
        private void MonitoringForm_Load(object sender, EventArgs e)
        {
            displayBalance();
            DisplayRequirments();
            displayBMI();
            DisplayRequisitionOfRequire();
            DisplayStudBOOKS();
            Inquiry();
        }
        public void Inquiry()
        {
            var displayinq = from Inq in db.Inquiries
                             select Inq;
            dgvAnnouncement.DataSource = displayinq;
        }
        public void DisplayStudBOOKS()
        {
            var processbooksearch = from pbook in db.ProcessBooks
                                    join stud in db.Students on pbook.StudentID equals stud.StudentID
                                    join b in db.Books on pbook.BookID equals b.BookID
                                    select new
                                    {
                                        pbook.ProcessBookID,
                                        stud.StudentID,
                                        Name = stud.Firstname + " " + stud.Lastname,
                                        stud.YearLevel,
                                        b.Bookname,
                                        pbook.Distributer,
                                        pbook.BookRelease,
                                        pbook.BookReturn
                                    };
            dgvBooksStud.DataSource = processbooksearch;
        }
        public void DisplayRequisitionOfRequire()
        {
            var displayRequiOfRequire = from ror in db.RequiOfRequirements
                                        join s in db.Students on ror.StudentID equals s.StudentID
                                        join u in db.UserAccounts on ror.UserAccountID equals u.UserAccountID
                                        join sy in db.Schoolyears on s.SchoolyearID equals sy.SchoolyearID
                                        select new
                                        {
                                            ID = ror.RequiOfRequirementID,
                                            Name = s.Firstname + " " + s.Lastname,
                                            SchoolYear = sy.Year,
                                            s.YearLevel,
                                            ror.Requirement,
                                            ReleaseBy = u.Firstname+" "+u.Lastname,
                                            ror.DateRelease
                                        };
            dgvRequisitionofRequi.DataSource = displayRequiOfRequire;
        }
        public void DisplayRequirments()
        {
            var displayreq = from d in db.Students
                             let Fullname = d.Firstname + " " + d.Lastname
                             select new
                             {
                                 Fullname,
                                 d.Form137,
                                 d.Form138,
                                 d.GoodMoral,
                                 d.NSO
                             };
            dgvRequirment.DataSource = displayreq;
        }
        public void displayHonor()
        {
            dgvHonorStud.Rows.Clear();
            var honors = from s in db.Students
                         where s.YearLevel == cmbHonorYear.Text
                         select new { s.StudentID, Fullname = s.Firstname + " " + s.Lastname, s.YearLevel };
            foreach (var honor in honors)
            {
                double ave = 0;
                bool hasLackingGrade = false;
                var sub = from s in db.Subjects
                          select s;
                foreach (var s in sub)
                {
                    double final = 0;
                    double FirstGrading = 0;
                    double SecondGrading = 0;
                    double ThirdGrading = 0;
                    double FourthGrading = 0;
                    double FinalGrade = 0;
                    var studGrade1 = (from sg in db.StudentGrades
                                      where sg.Period == "First Grading" && sg.YearLevel == honor.YearLevel && sg.StudentID == honor.StudentID && sg.SubjectID == s.SubjectID
                                      select sg).FirstOrDefault();
                    var studGrade2 = (from sg in db.StudentGrades
                                      where sg.Period == "Second Grading" && sg.YearLevel == honor.YearLevel && sg.StudentID == honor.StudentID && sg.SubjectID == s.SubjectID
                                      select sg).FirstOrDefault();
                    var studGrade3 = (from sg in db.StudentGrades
                                      where sg.Period == "Third Grading" && sg.YearLevel == honor.YearLevel && sg.StudentID == honor.StudentID && sg.SubjectID == s.SubjectID
                                      select sg).FirstOrDefault();
                    var studGrade4 = (from sg in db.StudentGrades
                                      where sg.Period == "Fourth Grading" && sg.YearLevel == honor.YearLevel && sg.StudentID == honor.StudentID && sg.SubjectID == s.SubjectID
                                      select sg).FirstOrDefault();
                    if (studGrade1 != null)
                    {
                        FirstGrading = double.Parse(studGrade1.Grade.ToString());
                    }
                    else
                    {
                        hasLackingGrade = true;
                    }
                    if (studGrade2 != null)
                    {
                        SecondGrading = double.Parse(studGrade2.Grade.ToString());
                    }
                    else
                    {
                        hasLackingGrade = true;
                    }
                    if (studGrade3 != null)
                    {
                        ThirdGrading = double.Parse(studGrade3.Grade.ToString());
                    }
                    else
                    {
                        hasLackingGrade = true;
                    }
                    if (studGrade4 != null)
                    {
                        FourthGrading = double.Parse(studGrade4.Grade.ToString());
                    }
                    else
                    {
                        hasLackingGrade = true;
                    }
                    if (!hasLackingGrade)
                    {
                        FinalGrade = (FirstGrading + SecondGrading + ThirdGrading + FourthGrading) / 4;
                    }
                    var avepersub = from sg in db.StudentGrades
                                    where sg.YearLevel == honor.YearLevel && sg.StudentID == honor.StudentID && sg.SubjectID == s.SubjectID
                                    select sg;
                    foreach (var avp in avepersub)
                    {
                        final += double.Parse(avp.Grade.ToString());
                    }
                    if (avepersub.Count() < 4)
                    {
                        ave = 0;
                    }
                    else
                    {
                        final = final / 4;
                        ave += final;
                    }
                }
                ave = Math.Round((ave / sub.Count()), 2);
                if (ave < 85)
                {
                    continue;
                }
                if (hasLackingGrade)
                {
                    continue;
                }
                dgvHonorStud.Rows.Add(honor.StudentID, honor.Fullname, ave);
            }
            this.dgvHonorStud.Sort(this.dgvHonorStud.Columns["HonorStudentAverage"], ListSortDirection.Descending);
        }
        public void displayBalance()
        {
            dgvBalanceofStud.Rows.Clear();
            var studs = from s in db.Students
                        select s;
            foreach (var stud in studs)
            {
                var studpay = from s in db.StudentPayments
                          where s.StudentID == stud.StudentID && s.PaymentType == "Parent Teacher Association - (PTA)"
                          select s;
            var studpayedbook = from s in db.StudentPayments
                                where s.StudentID == stud.StudentID && s.PaymentType == "Book Penalty"
                                select s;
            var bookpay = from b in db.ProcessBooks
                          where b.StudentID == stud.StudentID && b.BookReturn == null
                          select b;
            double totalBalance = 0;
            double ptapayments = 0;
            double bookpayments = 0;
            double payedbooks = 0;
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
            dgvBalanceofStud.Rows.Add(stud.StudentID, stud.Firstname + " " + stud.Lastname, totalBalance);
            }
           
        }

        private void txtBalanceSearch_TextChanged(object sender, EventArgs e)
        {
            dgvBalanceofStud.Rows.Clear();
            var studs = from s in db.Students
                        where s.Firstname.Contains(txtBalanceSearch.Text) || s.Lastname.Contains(txtBalanceSearch.Text)
                        select s;
            foreach (var stud in studs)
            {
                var studpay = from s in db.StudentPayments
                              where s.StudentID == stud.StudentID && s.PaymentType == "Parent Teacher Association - (PTA)"
                              select s;
                var studpayedbook = from s in db.StudentPayments
                                    where s.StudentID == stud.StudentID && s.PaymentType == "Book Penalty"
                                    select s;
                var bookpay = from b in db.ProcessBooks
                              where b.StudentID == stud.StudentID && b.BookReturn == null
                              select b;
                double totalBalance = 0;
                double ptapayments = 0;
                double bookpayments = 0;
                double payedbooks = 0;
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
                dgvBalanceofStud.Rows.Add(stud.StudentID, stud.Firstname + " " + stud.Lastname, totalBalance);
            }
        }

        private void cmbHonorYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayHonor();
        }
        public void displayBMI()
        {
            var studbmi = from s in db.Students
                          select s;

            dgvStudHealthStat.Rows.Clear();
            foreach (var s in studbmi)
            {
                double bmi = 0;
                double height = 0;
                double weight = 0;
                string bmires = "";
                height = double.Parse(s.Height.ToString());
                weight = double.Parse(s.Weight.ToString());
                height = height / 3.28;
                bmi = Math.Round((weight / Math.Pow((height), 2)), 2);
                if (bmi < 15)
                {
                    bmires = "Very severly underweight";
                }
                else if (bmi >= 15 && bmi <= 16)
                {
                    bmires = "Severly underweight";
                }
                else if (bmi >= 16 && bmi <= 18.5)
                {
                    bmires = "Underweight";
                }
                else if (bmi >= 18.5 && bmi <= 25)
                {
                    bmires = "Normal";
                }
                else if (bmi >= 25 && bmi < 30)
                {
                    bmires = "Overweight";
                }
                else if (bmi >= 30 && bmi < 35)
                {
                    bmires = "Moderately obese";
                }
                else if (bmi >= 35 && bmi < 40)
                {
                    bmires = "Severly Obese";
                }
                else if (bmi >= 40)
                {
                    bmires = "Very severly obese";
                }
                int systolic;
                int diastolic;
                systolic = int.Parse(s.Systolic.ToString());
                diastolic = int.Parse(s.Diastolic.ToString());
                var bpres = "";
                if (systolic <= 90 && diastolic <= 60)
                {
                    bpres = "Low Blood Pressure";
                }
                else if ((systolic >= 90 && systolic <= 120) && (diastolic >= 60 && diastolic <= 80))
                {
                    bpres = "Ideal and Helthy Blood Pressure";
                }
                else if ((systolic >= 120 && systolic <= 140) && (diastolic >= 80 && diastolic <= 90))
                {
                    bpres = "Normal blood pressure ";
                }
                else if (systolic >= 140 && diastolic >= 90)
                {
                    bpres = "High blood pressure";
                }
                else if (systolic >= 140 || diastolic >= 110)
                {
                    bpres = "High blood pressure";
                }
                else if (systolic <= 90 || diastolic <= 60)
                {
                    bpres = "Low blood pressure";
                }
                dgvStudHealthStat.Rows.Add(s.Firstname + " " + s.Lastname, bmires, bpres);

            }
        }
    }
}
