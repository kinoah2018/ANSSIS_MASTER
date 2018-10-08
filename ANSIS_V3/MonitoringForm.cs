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
            displayHonor();
        }
        public void Inquiry()
        {
            var displayinq = from Inq in db.Inquiries
                             join s in db.Students on Inq.StudentID equals s.StudentID
                             where Inq.InquiryType == "Announcement And Events"
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
                                        join sy in db.Schoolyears on s.SchoolyearID equals sy.SchoolyearID
                                        select new
                                        {
                                            ID = ror.RequiOfRequirementID,
                                            Name = s.Firstname + " " + s.Lastname,
                                            SchoolYear = sy.Year,
                                            s.YearLevel,
                                            ror.Requirement,
                                            ror.Releasedby,
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
                          where s.YearLevel == cmbHonorYear.Text
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
            double totalbalance;
            double bookpenalty;
            double payed;
            var stud = from s in db.Students
                       select s;
            foreach (var s in stud)
            {
                var balance = from p in db.Payments
                              join sc in db.Schoolyears on p.SchoolyearID equals sc.SchoolyearID
                              where p.Payment1 != "Book Penalty" && p.Payment1 != "Second Issue of Certificate"
                              select p;
                totalbalance = 0;
                foreach (var bal in balance)
                {
                    totalbalance += double.Parse(bal.Amount.ToString());
                }
                var unreturnedbooks = from p in db.ProcessBooks
                                      where p.StudentID == s.StudentID && p.BookReturn == null
                                      select p;
                var bookamount = (from p in db.Payments
                                  where p.Payment1 == "Book Penalty"
                                  select p).FirstOrDefault();
                bookpenalty = unreturnedbooks.Count() * double.Parse(bookamount.Amount.ToString());
                var studpay = from sp in db.StudentPayments
                              join p in db.Payments on sp.PaymentID equals p.PaymentID
                              where p.Payment1 != "Second Issue of Certificate" && sp.StudentID == s.StudentID
                              select sp;
                payed = 0;
                foreach (var studp in studpay)
                {
                    payed += double.Parse(studp.Amount.ToString());
                }
                totalbalance = ((totalbalance + bookpenalty) - payed);
                dgvBalanceofStud.Rows.Add(s.StudentID, s.Firstname + " " + s.Lastname, totalbalance);
            }
        }

        private void txtBalanceSearch_TextChanged(object sender, EventArgs e)
        {
            
            if (txtBalanceSearch.Text!="")
            {
                dgvBalanceofStud.Rows.Clear();
                double totalbalance;
                double bookpenalty;
                double payed;
                var stud = from s in db.Students
                           where s.Firstname.Contains(txtBalanceSearch.Text) || s.Lastname.Contains(txtBalanceSearch.Text)
                           select s;
                foreach (var s in stud)
                {
                    var balance = from p in db.Payments
                                  join sc in db.Schoolyears on p.SchoolyearID equals sc.SchoolyearID
                                  where p.Payment1 != "Book Penalty" && p.Payment1 != "Second Issue of Certificate"
                                  select p;
                    totalbalance = 0;
                    foreach (var bal in balance)
                    {
                        totalbalance += double.Parse(bal.Amount.ToString());
                    }
                    var unreturnedbooks = from p in db.ProcessBooks
                                          where p.StudentID == s.StudentID && p.BookReturn == null
                                          select p;
                    var bookamount = (from p in db.Payments
                                      where p.Payment1 == "Book Penalty"
                                      select p).FirstOrDefault();
                    bookpenalty = unreturnedbooks.Count() * double.Parse(bookamount.Amount.ToString());
                    var studpay = from sp in db.StudentPayments
                                  join p in db.Payments on sp.PaymentID equals p.PaymentID
                                  where p.Payment1 != "Second Issue of Certificate" && sp.StudentID == s.StudentID
                                  select sp;
                    payed = 0;
                    foreach (var studp in studpay)
                    {
                        payed += double.Parse(studp.Amount.ToString());
                    }
                    totalbalance = ((totalbalance + bookpenalty) - payed);
                    dgvBalanceofStud.Rows.Add(s.StudentID, s.Firstname + " " + s.Lastname, totalbalance);
                }
            }
            else
            {
                dgvBalanceofStud.Rows.Clear();
                displayBalance();
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

        private void txtRequiofRequiSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtRequiofRequiSearch.Text!="")
            {
                var searchror = from ror in db.RequiOfRequirements
                                join s in db.Students on ror.StudentID equals s.StudentID
                                join sy in db.Schoolyears on s.SchoolyearID equals sy.SchoolyearID
                                where s.Firstname.Contains(txtRequiofRequiSearch.Text) || sy.Year.Contains(txtRequiofRequiSearch.Text) || s.Lastname.Contains(txtRequiofRequiSearch.Text) || s.YearLevel.Contains(txtRequiofRequiSearch.Text) || ror.Requirement.Contains(txtRequiofRequiSearch.Text)
                                select new
                                {
                                    ID = ror.RequiOfRequirementID,
                                    Name = s.Firstname + " " + s.Lastname,
                                    SchoolYear = sy.Year,
                                    s.YearLevel,
                                    ror.Requirement,
                                    ror.Releasedby,
                                    ror.DateRelease
                                };
                dgvRequisitionofRequi.DataSource = searchror;
            }
            else
            {
                DisplayRequisitionOfRequire();
            }
          
        }

        private void txtProBookSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtProBookSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtProBookSearch.Text!="")
            {
                var pbsearch = from pbook in db.ProcessBooks
                               join stud in db.Students on pbook.StudentID equals stud.StudentID
                               join b in db.Books on pbook.BookID equals b.BookID
                               where stud.Firstname.Contains(txtProBookSearch.Text) || stud.Lastname.Contains(txtProBookSearch.Text) || stud.YearLevel.Contains(txtProBookSearch.Text) ||
                                               b.Bookname.Contains(txtProBookSearch.Text)
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
                dgvBooksStud.DataSource = pbsearch;
            }
            else
            {
                DisplayStudBOOKS();
            }
           
        }

        private void txtAnnEventsSearch_TextChanged(object sender, EventArgs e)
        {
           if (txtAnnEventsSearch.Text!="")
	        {
                var searhInq = from Inq in db.Inquiries
                                join s in db.Students on Inq.StudentID equals s.StudentID
                               where Inq.InquiryType.Contains("Announcement And Events") && s.Firstname.Contains(txtAnnEventsSearch.Text)
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
                dgvAnnouncement.DataSource = searhInq;
	        }
           else
	            {
                    Inquiry();
	            }
        }

        private void txtRequirementStud_TextChanged(object sender, EventArgs e)
        {
            if (txtRequirementStud.Text !="")
            {
                var searchReq = from d in db.Students
                                where d.Firstname.Contains(txtRequirementStud.Text) || d.Lastname.Contains(txtRequirementStud.Text)
                                let Fullname = d.Firstname + " " + d.Lastname
                                select new
                                {
                                    Fullname,
                                    d.Form137,
                                    d.Form138,
                                    d.GoodMoral,
                                    d.NSO
                                };
                dgvRequirment.DataSource = searchReq;
            }
            else
            {
                DisplayRequirments();
            }
            
        }

        private void txtStudHealthSearch_TextChanged(object sender, EventArgs e)
        {
            var studbmi = from s in db.Students
                          where s.Firstname.Contains(txtStudHealthSearch.Text) || s.Lastname.Contains(txtStudHealthSearch.Text)
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