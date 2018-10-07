using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANSIS_V3
{
    public partial class ReportsForm : MetroFramework.Forms.MetroForm
    {
        public ReportsForm()
        {
            InitializeComponent();
        }
        bool isFormload = false;
        DataClassDataContext db = new DataClassDataContext();
        private void ReportsForm_Load(object sender, EventArgs e)
        {
            isFormload = true;
            var sections = from s in db.Sections
                           select s;
            cmbPromSection.DataSource = sections;
            cmbPromSection.DisplayMember = "Section1";
            cmbPromSection.ValueMember = "SectionID";
            cmbPromSection.SelectedIndex = 0;
            cmbPromSchoolyear.SelectedIndex = 0;
            cmbHonorYear.SelectedIndex = 0;
            var studMasterList = (from s in db.Students
                                 select new { s.StudentID,s.Firstname,s.Middlname,s.Lastname,s.YearLevel }).OrderBy(x=>x.YearLevel);
            dgvStudMasList.DataSource = studMasterList;
            displayPromoted();
            displayHonor();
            displayGraduating();
            isFormload = false;
        }
        public void displayGraduating()
        {
            dgvListGradStud.Rows.Clear();
            bool IsHagbong = false;
            var grads = from s in db.Students join sy in db.Schoolyears on s.SchoolyearID equals sy.SchoolyearID
                         where s.YearLevel == "4th Year"
                         select new { s.StudentID, Fullname = s.Firstname + " " + s.Lastname, s.YearLevel,sy.Year };
            foreach (var grad in grads)
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
                                      where sg.Period == "First Grading" && sg.YearLevel == "4th Year" && sg.StudentID == grad.StudentID && sg.SubjectID == s.SubjectID
                                      select sg).FirstOrDefault();
                    var studGrade2 = (from sg in db.StudentGrades
                                      where sg.Period == "Second Grading" && sg.YearLevel == "4th Year" && sg.StudentID == grad.StudentID && sg.SubjectID == s.SubjectID 
                                      select sg).FirstOrDefault();
                    var studGrade3 = (from sg in db.StudentGrades
                                      where sg.Period == "Third Grading" && sg.YearLevel == "4th Year" && sg.StudentID == grad.StudentID && sg.SubjectID == s.SubjectID
                                      select sg).FirstOrDefault();
                    var studGrade4 = (from sg in db.StudentGrades
                                      where sg.Period == "Fourth Grading" && sg.YearLevel == "4th Year" && sg.StudentID == grad.StudentID && sg.SubjectID == s.SubjectID
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
                    if (FinalGrade < 75)
                    {
                        IsHagbong = true;
                    }
                    var avepersub = from sg in db.StudentGrades
                                    where sg.YearLevel == "4th Year" && sg.StudentID == grad.StudentID && sg.SubjectID == s.SubjectID
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
                if (hasLackingGrade)
                {
                    continue;
                }
                if (IsHagbong)
                {
                    continue;
                }
                dgvListGradStud.Rows.Add(grad.StudentID, grad.Fullname, ave,grad.Year);
            }
        }
        public void displayHonor()
        {
            dgvHonor.Rows.Clear();
            var honors = from s in db.Students
                         where s.YearLevel == cmbHonorYear.Text
                         select new { s.StudentID,Fullname=s.Firstname+" "+s.Lastname,s.YearLevel };
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
                dgvHonor.Rows.Add(honor.StudentID, honor.Fullname,ave);
            }
            this.dgvHonor.Sort(this.dgvHonor.Columns["HonorStudentAverage"], ListSortDirection.Descending);
        }
        public void displayPromoted()
        {
            bool IsHagbong = false;
            dgvPromotStud.Rows.Clear();
            var promotedLists = from s in db.Students
                               join sec in db.Sections on s.SectionID equals sec.SectionID
                               where s.SectionID == int.Parse(cmbPromSection.SelectedValue.ToString()) && s.YearLevel==cmbPromSchoolyear.Text
                               select new { s.StudentID, Fullname=s.Firstname+" "+s.Lastname, s.YearLevel, sec.Section1 };
            foreach (var prom in promotedLists)
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
                                      where sg.Period == "First Grading" && sg.YearLevel == prom.YearLevel && sg.StudentID == prom.StudentID && sg.SubjectID == s.SubjectID
                                      select sg).FirstOrDefault();
                    var studGrade2 = (from sg in db.StudentGrades
                                      where sg.Period == "Second Grading" && sg.YearLevel == prom.YearLevel && sg.StudentID == prom.StudentID && sg.SubjectID == s.SubjectID 
                                      select sg).FirstOrDefault();
                    var studGrade3 = (from sg in db.StudentGrades
                                      where sg.Period == "Third Grading" && sg.YearLevel == prom.YearLevel && sg.StudentID == prom.StudentID && sg.SubjectID == s.SubjectID
                                      select sg).FirstOrDefault();
                    var studGrade4 = (from sg in db.StudentGrades
                                      where sg.Period == "Fourth Grading" && sg.YearLevel == prom.YearLevel && sg.StudentID == prom.StudentID && sg.SubjectID == s.SubjectID
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
                    if (FinalGrade < 75)
                    {
                        IsHagbong = true;
                    }
                    var avepersub = from sg in db.StudentGrades
                                    where sg.YearLevel == prom.YearLevel && sg.StudentID == prom.StudentID && sg.SubjectID == s.SubjectID
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
                if (hasLackingGrade)
                {
                    continue;
                }
                if (IsHagbong)
                {
                    continue;
                }
                dgvPromotStud.Rows.Add(prom.StudentID,prom.Fullname,ave);
            }
        }

        private void cmbPromSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbPromSection_SelectedValueChanged(object sender, EventArgs e)
        {
            if (isFormload==false)
            {

                displayPromoted();
            }
        }

        private void cmbHonorYear_SelectedValueChanged(object sender, EventArgs e)
        {
            if (isFormload == false)
            {

                displayHonor();
            }
        }

        private void cmbPromSchoolyear_SelectedValueChanged(object sender, EventArgs e)
        {
            if (isFormload == false)
            {

                displayPromoted();
            }
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
