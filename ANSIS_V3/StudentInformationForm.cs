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
	public partial class StudentInformationForm : MetroFramework.Forms.MetroForm
	{
       
		public StudentInformationForm()
		{
			InitializeComponent();
		}
		DataClassDataContext db = new DataClassDataContext();
		private void StudentProfileForm_Load(object sender, EventArgs e)
		{
            cmbGradePeriod.SelectedIndex = 0;
            
			var section = from s in db.Sections
						  select s;
			mcmbSecname.DataSource = section;
			mcmbSecname.DisplayMember = "Section1";
			mcmbSecname.ValueMember = "SectionID";
			var sy = from s in db.Schoolyears
					 select s;
			mcmbShoolYear.DataSource = sy;
			mcmbShoolYear.DisplayMember = "Year";
			mcmbShoolYear.ValueMember = "SchoolyearID";
			displayStudent();
			var studbmi = from s in db.Students
						  select s;
            cmbSchoolYear.DataSource = sy;
            cmbSchoolYear.DisplayMember = "Year";
            cmbSchoolYear.ValueMember = "SchoolyearID";
			displayBMI();
            DisplayRequirments();
            DisplayPayDet();
		}
        public void displayGrade()
        {
            double ave = 0;
            bool hasLackingGrade = false;
            dgvStudGrade.Rows.Clear();
            var sub = from s in db.Subjects
                      where s.YearLevel == txtGrYear.Text
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
                                 where sg.Period == "First Grading" && sg.YearLevel == txtGrYear.Text && sg.StudentID == int.Parse(txtGrSTID.Text) && sg.SubjectID == s.SubjectID
                                 select sg).FirstOrDefault();
                var studGrade2 = (from sg in db.StudentGrades
                                  where sg.Period == "Second Grading" && sg.YearLevel == txtGrYear.Text && sg.StudentID == int.Parse(txtGrSTID.Text) && sg.SubjectID == s.SubjectID
                                  select sg).FirstOrDefault();
                var studGrade3 = (from sg in db.StudentGrades
                                  where sg.Period == "Third Grading" && sg.YearLevel == txtGrYear.Text && sg.StudentID == int.Parse(txtGrSTID.Text) && sg.SubjectID == s.SubjectID
                                  select sg).FirstOrDefault();
                var studGrade4 = (from sg in db.StudentGrades
                                  where sg.Period == "Fourth Grading" && sg.YearLevel == txtGrYear.Text && sg.StudentID == int.Parse(txtGrSTID.Text) && sg.SubjectID == s.SubjectID
                                  select sg).FirstOrDefault();
                if (studGrade1 != null)
                {
                    FirstGrading = double.Parse(studGrade1.Grade.ToString());
                }else{
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
                    FinalGrade = (FirstGrading + SecondGrading+ThirdGrading+FourthGrading)/4;
                }
                dgvStudGrade.Rows.Add(s.Subject1, FirstGrading, SecondGrading, ThirdGrading, FourthGrading, FinalGrade);

                var avepersub = from sg in db.StudentGrades
                                where sg.YearLevel == txtGrYear.Text && sg.StudentID == int.Parse(txtGrSTID.Text) && sg.SubjectID == s.SubjectID
                                select sg;
                foreach (var avp in avepersub)
                {
                    final += double.Parse(avp.Grade.ToString());
                }
                if (avepersub.Count() < 4)
                {
                    ave = 0;
                    lblAverage.Text = 0+"";
                }
                else
                {
                    final = final / 4;
                    ave += final;
                }
            }
            ave = Math.Round((ave / sub.Count()),2);
            lblAverage.Text = ave.ToString();
        }
        
		public void displayBMI()
		{
			var studbmi = from s in db.Students
						  select s;

			dgvBMI.Rows.Clear();
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
				}else if(bmi>=15 && bmi <= 16)
				{
					bmires = "Severly underweight";
				}else if(bmi >= 16 && bmi <= 18.5)
				{
					bmires = "Underweight";
				}else if(bmi >= 18.5 && bmi <= 25)
				{
					bmires = "Normal";
				}else if(bmi>=25 && bmi<30)
				{
					bmires = "Overweight";
				}else if(bmi>=30&&bmi<35)
				{
					bmires = "Moderately obese";
				}else if (bmi >= 35 && bmi < 40)
				{
					bmires = "Severly Obese";
				}else if (bmi >= 40)
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
				dgvBMI.Rows.Add(s.Firstname+" "+s.Lastname, bmires,bpres);

			}
		}
		private void tpStudProfile_Click(object sender, EventArgs e)
		{

		}
		public void displayStudent()
		{
			var student = from s in db.Students
						  join sy in db.Schoolyears on s.SchoolyearID equals sy.SchoolyearID
						  join sec in db.Sections on s.SectionID equals sec.SectionID
						  select new { s.StudentID, s.Firstname, s.Middlname, s.Lastname, s.Birthdate,s.Age, s.Address, s.Gender, s.ParentName, s.ParentNo, s.Occupation, s.Height, s.Weight, s.Systolic, s.Diastolic, s.Form137, s.Form138, s.GoodMoral, s.NSO,s.YearLevel, sy.Year, sec.Section1 };
			dgvStud.DataSource = student;
		}

		private void mbtnManageSY_Click(object sender, EventArgs e)
		{
			ManageSchoolyear m = new ManageSchoolyear();
			m.ShowDialog();
		}

		private void mbtnAdd_Click(object sender, EventArgs e)
		{
			if (mbtnAdd.Text == "Add")
			{
                if (string.IsNullOrWhiteSpace(mtxtFname.Text) || string.IsNullOrWhiteSpace(mtxtMname.Text) || string.IsNullOrWhiteSpace(mtxtLname.Text) || string.IsNullOrWhiteSpace(mdtpBirthdate.Text) || string.IsNullOrWhiteSpace(mtxtAge.Text) || string.IsNullOrWhiteSpace(mtxtAddress.Text) || string.IsNullOrWhiteSpace(mtxtGender.Text) || string.IsNullOrWhiteSpace(mtxtParentname.Text) || string.IsNullOrWhiteSpace(mtxtContact.Text) || string.IsNullOrWhiteSpace(mtxtOccupation.Text) || string.IsNullOrWhiteSpace(mtxtHeight.Text) || string.IsNullOrWhiteSpace(mtxtWeight.Text) || string.IsNullOrWhiteSpace(mtxtSystolic.Text) || mtxtDiastolic.Text == "" || string.IsNullOrWhiteSpace(mcmbYearLevel.Text) || string.IsNullOrWhiteSpace(mcmbSecname.Text) || string.IsNullOrWhiteSpace(mcmbShoolYear.Text))
                {
                    MessageBox.Show("Please Input All Fields");
                }
                else
                {
                    Student stud = new Student();
                    stud.Firstname = mtxtFname.Text;
                    stud.Middlname = mtxtMname.Text;
                    stud.Lastname = mtxtLname.Text;
                    stud.Birthdate = mdtpBirthdate.Value;
                    stud.Age = int.Parse(mtxtAge.Text);
                    stud.Address = mtxtAddress.Text;
                    stud.Gender = mtxtGender.Text;
                    stud.ParentName = mtxtParentname.Text;
                    stud.ParentNo = mtxtContact.Text;
                    stud.Occupation = mtxtOccupation.Text;
                    stud.Height = decimal.Parse(mtxtHeight.Text);
                    stud.Weight = decimal.Parse(mtxtWeight.Text);
                    stud.Systolic = int.Parse(mtxtSystolic.Text);
                    stud.Diastolic = int.Parse(mtxtDiastolic.Text);
                    stud.YearLevel = mcmbYearLevel.Text;
                    if (mchk137.Checked)
                    {
                        stud.Form137 = "Submitted";
                    }
                    else
                    {
                        stud.Form137 = "Not Submitted";
                    }
                    if (mchkForm138.Checked)
                    {
                        stud.Form138 = "Submitted";
                    }
                    else
                    {
                        stud.Form138 = "Not Submitted";
                    }
                    if (mchkGoodmoral.Checked)
                    {
                        stud.GoodMoral = "Submitted";
                    }
                    else
                    {
                        stud.GoodMoral = "Not Submitted";
                    }
                    if (mchkNso.Checked)
                    {
                        stud.NSO = "Submitted";
                    }
                    else
                    {
                        stud.NSO = "Not Submitted";
                    }
                    stud.SectionID = int.Parse(mcmbSecname.SelectedValue.ToString());
                    stud.SchoolyearID = int.Parse(mcmbShoolYear.SelectedValue.ToString());
                    db.Students.InsertOnSubmit(stud);
                    db.SubmitChanges();
                    MessageBox.Show("ADDED");
                    displayStudent();
                    clearStudent();
                    displayBMI();
                }
				
			}
			else
			{
				var stud = db.Students.SingleOrDefault(x => x.StudentID == int.Parse(dgvStud.CurrentRow.Cells[0].Value.ToString()));
				stud.Firstname = mtxtFname.Text;
				stud.Middlname = mtxtMname.Text;
				stud.Lastname = mtxtLname.Text;
				stud.Birthdate = mdtpBirthdate.Value;
				stud.Age = int.Parse(mtxtAge.Text);
				stud.Address = mtxtAddress.Text;
				stud.Gender = mtxtGender.Text;
				stud.ParentName = mtxtParentname.Text;
				stud.ParentNo = mtxtContact.Text;
				stud.Occupation = mtxtOccupation.Text;
				stud.Height = decimal.Parse(mtxtHeight.Text);
				stud.Weight = decimal.Parse(mtxtWeight.Text);
				stud.Systolic = int.Parse(mtxtSystolic.Text);
				stud.Diastolic = int.Parse(mtxtDiastolic.Text);
				if (mchk137.Checked)
				{
					stud.Form137 = "Submitted";
				}
				else
				{
					stud.Form137 = "Not Submitted";
				}
				if (mchkForm138.Checked)
				{
					stud.Form138 = "Submitted";
				}
				else
				{
					stud.Form138 = "Not Submitted";
				}
				if (mchkGoodmoral.Checked)
				{
					stud.GoodMoral = "Submitted";
				}
				else
				{
					stud.GoodMoral = "Not Submitted";
				}
				if (mchkNso.Checked)
				{
					stud.NSO = "Submitted";
				}
				else
				{
					stud.NSO = "Not Submitted";
				}
				stud.YearLevel = mcmbYearLevel.Text;
				stud.SectionID = int.Parse(mcmbSecname.SelectedValue.ToString());
				stud.SchoolyearID = int.Parse(mcmbShoolYear.SelectedValue.ToString());
				db.SubmitChanges();
				MessageBox.Show("UPDATED");
				mbtnAdd.Text = "Add";
				mbtnClear.Text = "Clear";
				displayStudent();
				clearStudent();
				displayBMI();
			}
		}
		public void clearStudent()
		{
			mtxtStudID.Clear();
			mtxtFname.Clear();
			mtxtMname.Clear();
			mtxtLname.Clear();
			mdtpBirthdate.Value = DateTime.Now;
			mtxtAddress.Clear();
			mtxtGender.SelectedIndex = -1;
			mtxtParentname.Clear();
			mtxtContact.Clear();
			mtxtOccupation.Clear();
			mtxtHeight.Clear();
			mtxtWeight.Clear();
			mtxtSystolic.Clear();
			mtxtDiastolic.Clear();
			mchk137.Checked = false;
			mchk137.Enabled = true;
			mchkForm138.Checked = false;
			mchkForm138.Enabled = true;
			mchkGoodmoral.Checked = false;
			mchkGoodmoral.Enabled = true;
			mchkNso.Checked = false;
			mchkNso.Enabled = true;
			mcmbYearLevel.SelectedIndex = -1;
			mcmbSecname.SelectedIndex = -1;
			mcmbShoolYear.SelectedIndex = -1;
		}
		private void mdtpBirthdate_ValueChanged(object sender, EventArgs e)
		{
			if (DateTime.Now.Month <= mdtpBirthdate.Value.Month)
			{
				mtxtAge.Text = (DateTime.Now.Year - mdtpBirthdate.Value.Year) + "";
			}
			else
			{
				mtxtAge.Text = (DateTime.Now.Year - mdtpBirthdate.Value.Year) + 1 + "";
			}
		}

		private void txtSearchStud_TextChanged(object sender, EventArgs e)
		{
			var student = from s in db.Students
						  join sy in db.Schoolyears on s.SchoolyearID equals sy.SchoolyearID
						  join sec in db.Sections on s.SectionID equals sec.SectionID
						  where s.Firstname.Contains(txtSearchStud.Text)||s.Lastname.Contains(txtSearchStud.Text)
						  select new { s.StudentID,s.Firstname, s.Middlname, s.Lastname, s.Birthdate, s.Address, s.Age, s.Gender, s.ParentName, s.ParentNo, s.Occupation, s.Height, s.Weight, s.Systolic, s.Diastolic, s.Form137, s.Form138, s.GoodMoral, s.NSO, sy.Year, sec.Section1 };
			dgvStud.DataSource = student;
		}

		private void dgvStud_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			mtxtStudID.Text = dgvStud.CurrentRow.Cells[0].Value.ToString();
			mtxtFname.Text = dgvStud.CurrentRow.Cells[1].Value.ToString();
			mtxtMname.Text = dgvStud.CurrentRow.Cells[2].Value.ToString();
			mtxtLname.Text = dgvStud.CurrentRow.Cells[3].Value.ToString();
			mdtpBirthdate.Text = dgvStud.CurrentRow.Cells[4].Value.ToString();
			mtxtAge.Text = dgvStud.CurrentRow.Cells[5].Value.ToString();
			mtxtAddress.Text = dgvStud.CurrentRow.Cells[6].Value.ToString();
			mtxtGender.Text = dgvStud.CurrentRow.Cells[7].Value.ToString();
			mtxtParentname.Text = dgvStud.CurrentRow.Cells[8].Value.ToString();
			mtxtContact.Text = dgvStud.CurrentRow.Cells[9].Value.ToString();
			mtxtOccupation.Text = dgvStud.CurrentRow.Cells[10].Value.ToString();
			mtxtHeight.Text = dgvStud.CurrentRow.Cells[11].Value.ToString();
			mtxtWeight.Text = dgvStud.CurrentRow.Cells[12].Value.ToString();
			mtxtSystolic.Text = dgvStud.CurrentRow.Cells[13].Value.ToString();
			mtxtDiastolic.Text = dgvStud.CurrentRow.Cells[14].Value.ToString();
			mcmbYearLevel.Text = dgvStud.CurrentRow.Cells[19].Value.ToString();
			mcmbSecname.Text = dgvStud.CurrentRow.Cells[21].Value.ToString();
			mcmbShoolYear.Text = dgvStud.CurrentRow.Cells[20].Value.ToString();
			if (dgvStud.CurrentRow.Cells[15].Value.ToString() == "Submitted")
			{
				mchk137.Checked = true;
				mchk137.Enabled = false;
			}else
			{
				mchk137.Checked = false;
				mchk137.Enabled = true;
			}
			if (dgvStud.CurrentRow.Cells[16].Value.ToString() == "Submitted")
			{
				mchkForm138.Checked = true;
				mchkForm138.Enabled = false;
			}
			else
			{
				mchkForm138.Checked = false;
				mchkForm138.Enabled = true;
			}
			if (dgvStud.CurrentRow.Cells[17].Value.ToString() == "Submitted")
			{
				mchkGoodmoral.Checked = true;
				mchkGoodmoral.Enabled = false;
			}
			else
			{
				mchkGoodmoral.Checked = false;
				mchkGoodmoral.Enabled = true;
			}
			if (dgvStud.CurrentRow.Cells[18].Value.ToString() == "Submitted")
			{
				mchkNso.Checked = true;
				mchkNso.Enabled = false;
			}
			else
			{
				mchkNso.Checked = false;
				mchkNso.Enabled = true;
			}
			mbtnAdd.Text = "Update";
			mbtnClear.Text = "Cancel";
		}

		private void mbtnClear_Click(object sender, EventArgs e)
		{
			if (mbtnClear.Text == "Clear")
			{
				clearStudent();
			}
			else
			{
				clearStudent();
				mbtnAdd.Text = "Add";
				mbtnClear.Text = "Clear";
			}
		}

		private void txtSearchBMI_TextChanged(object sender, EventArgs e)
		{
			var studbmi = from s in db.Students
						  where s.Firstname.Contains(txtSearchBMI.Text) || s.Lastname.Contains(txtSearchBMI.Text)
						  select s;

			dgvBMI.Rows.Clear();
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
				dgvBMI.Rows.Add(s.Firstname+" "+s.Lastname, bmires,bpres);
			}
            
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
            mdgvRequirments.DataSource = displayreq;
        }

        private void metroPanel3_Paint()
        {
        
        }

        private void mtxtSearch_Click(object sender, EventArgs e)
        {
         
        }

        private void txtSearchStud_Click(object sender, EventArgs e)
        {

        }

        private void mtxtSearch_TextChanged(object sender, EventArgs e)
        {
            var displayreq = from d in db.Students
                             let Fullname = d.Firstname + " " + d.Lastname
                             where Fullname.Contains(mtxtSearch.Text)
                             select new
                             {
                                 Fullname,
                                 d.Form137,
                                 d.Form138,
                                 d.GoodMoral,
                                 d.NSO
                             };
            mdgvRequirments.DataSource = displayreq;
        }

        private void mdgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mbtnSelectStud_Click(object sender, EventArgs e)
        {
            dgvStudGrade.Visible = false;
            dgvSelectedStud.Visible = true;
            var displayStud = from s in db.Students
                              join sy in db.Schoolyears on s.SchoolyearID equals sy.SchoolyearID
                              where s.YearLevel!="Graduated"
                              select new
                              {
                                  s.StudentID,
                                  Name = s.Firstname + " " + s.Lastname,
                                  sy.SchoolyearID,
                                  sy.Year,
                                  s.YearLevel
                              };
            dgvSelectedStud.DataSource = displayStud;
        }

        private void dgvStudGrade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbGrSubject.Text = dgvStudGrade.CurrentRow.Cells[0].Value.ToString();
        }
        public void incrementGradePeriod()
        {
            if (cmbGradePeriod.SelectedIndex == cmbGradePeriod.Items.Count - 1)
            {
                cmbGradePeriod.SelectedIndex = 0;
                if (cmbGrSubject.SelectedIndex < 8)
                {
                    
                }
                else
                {
                    cmbGrSubject.SelectedIndex += 1;
                }
            }
            else
            {
                cmbGradePeriod.SelectedIndex = cmbGradePeriod.SelectedIndex + 1;
            }
        }
        int syid = 0;
        private void dgvSelectedStud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtGrSTID.Text = dgvSelectedStud.CurrentRow.Cells[0].Value.ToString();
            txtGrStudName.Text = dgvSelectedStud.CurrentRow.Cells[1].Value.ToString();
            txtGrSchoolYear.Text = dgvSelectedStud.CurrentRow.Cells[3].Value.ToString();
            txtGrYear.Text = dgvSelectedStud.CurrentRow.Cells[4].Value.ToString();
            dgvSelectedStud.Visible = false;
            dgvStudGrade.Visible = true;
            displayGrade();
            syid = int.Parse(dgvSelectedStud.CurrentRow.Cells[2].Value.ToString());
            var sub = from s in db.Subjects
                      where s.YearLevel == txtGrYear.Text
                      select s;
            cmbGrSubject.DataSource = sub;
            cmbGrSubject.DisplayMember = "Subject1";
            cmbGrSubject.ValueMember = "SubjectID";
        }

        private void txtGrSTID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtGrSTID.Text))
            {
            }
        }

        private void btnGrAdd_Click(object sender, EventArgs e)
        {
            if (cmbGradePeriod.Text == "First Grading")
            {
                var studGrade = from sg in db.StudentGrades
                                 where sg.Period == "First Grading" && sg.YearLevel == txtGrYear.Text && sg.StudentID == int.Parse(txtGrSTID.Text) && sg.SubjectID == int.Parse(cmbGrSubject.SelectedValue.ToString())
                                 select sg;
                if (studGrade.Count() > 0)
                {
                    var sg = db.StudentGrades.SingleOrDefault(x => x.StudentID == int.Parse(txtGrSTID.Text) && x.SubjectID == int.Parse(cmbGrSubject.SelectedValue.ToString()) && x.Period == cmbGradePeriod.Text && x.YearLevel == txtGrYear.Text);
                    sg.Grade = decimal.Parse(txtGrade.Text);
                    db.SubmitChanges();
                    MessageBox.Show("Successfully changed");
                    incrementGradePeriod();
                    displayGrade();
                }
                else
                {
                    StudentGrade sg = new StudentGrade();
                    sg.Grade = decimal.Parse(txtGrade.Text);
                    sg.StudentID = int.Parse(txtGrSTID.Text);
                    sg.SubjectID = int.Parse(cmbGrSubject.SelectedValue.ToString());
                    sg.YearLevel = txtGrYear.Text; ;
                    sg.Period = cmbGradePeriod.Text;
                    sg.SchoolyearID = syid;
                    db.StudentGrades.InsertOnSubmit(sg);
                    db.SubmitChanges();
                    MessageBox.Show("Successfully added");
                    incrementGradePeriod();
                    displayGrade();
                }
            }
            else if (cmbGradePeriod.Text == "Second Grading")
            {
                var studGrade1 = from sg in db.StudentGrades
                                where sg.Period == "First Grading" && sg.YearLevel == txtGrYear.Text && sg.StudentID == int.Parse(txtGrSTID.Text) && sg.SubjectID == int.Parse(cmbGrSubject.SelectedValue.ToString())
                                select sg;
                if (studGrade1.Count() > 0)
                {
                    var studGrade = from sg in db.StudentGrades
                                    where sg.Period == "Second Grading" && sg.YearLevel == txtGrYear.Text && sg.StudentID == int.Parse(txtGrSTID.Text) && sg.SubjectID == int.Parse(cmbGrSubject.SelectedValue.ToString())
                                    select sg;
                    if (studGrade.Count() > 0)
                    {
                        var sg = db.StudentGrades.SingleOrDefault(x => x.StudentID == int.Parse(txtGrSTID.Text) && x.SubjectID == int.Parse(cmbGrSubject.SelectedValue.ToString()) && x.Period == cmbGradePeriod.Text && x.YearLevel == txtGrYear.Text);
                        sg.Grade = decimal.Parse(txtGrade.Text);
                        db.SubmitChanges();
                        MessageBox.Show("Successfully changed");
                        incrementGradePeriod();
                        displayGrade();
                    }
                    else
                    {
                        StudentGrade sg = new StudentGrade();
                        sg.Grade = decimal.Parse(txtGrade.Text);
                        sg.StudentID = int.Parse(txtGrSTID.Text);
                        sg.SubjectID = int.Parse(cmbGrSubject.SelectedValue.ToString());
                        sg.YearLevel = txtGrYear.Text;
                        sg.SchoolyearID = syid;
                        sg.Period = cmbGradePeriod.Text;
                        db.StudentGrades.InsertOnSubmit(sg);
                        db.SubmitChanges();
                        MessageBox.Show("Successfully added");
                        incrementGradePeriod();
                        displayGrade();
                    }
                }
                else
                {
                    MessageBox.Show("Please input first grading period please.");
                }
                
            }
            else if (cmbGradePeriod.Text == "Third Grading")
            {
                var studGrade2 = from sg in db.StudentGrades
                                 where sg.Period == "Second Grading" && sg.YearLevel == txtGrYear.Text && sg.StudentID == int.Parse(txtGrSTID.Text) && sg.SubjectID == int.Parse(cmbGrSubject.SelectedValue.ToString())
                                 select sg;
                if (studGrade2.Count() > 0)
                {
                    var studGrade = from sg in db.StudentGrades
                                    where sg.Period == "Third Grading" && sg.YearLevel == txtGrYear.Text && sg.StudentID == int.Parse(txtGrSTID.Text) && sg.SubjectID == int.Parse(cmbGrSubject.SelectedValue.ToString())
                                    select sg;
                    if (studGrade.Count() > 0)
                    {
                        var sg = db.StudentGrades.SingleOrDefault(x => x.StudentID == int.Parse(txtGrSTID.Text) && x.SubjectID == int.Parse(cmbGrSubject.SelectedValue.ToString()) && x.Period == cmbGradePeriod.Text && x.YearLevel == txtGrYear.Text);
                        sg.Grade = decimal.Parse(txtGrade.Text);
                        db.SubmitChanges();
                        MessageBox.Show("Successfully changed");
                        incrementGradePeriod();
                        displayGrade();
                    }
                    else
                    {
                        StudentGrade sg = new StudentGrade();
                        sg.Grade = decimal.Parse(txtGrade.Text);
                        sg.StudentID = int.Parse(txtGrSTID.Text);
                        sg.SubjectID = int.Parse(cmbGrSubject.SelectedValue.ToString());
                        sg.YearLevel = txtGrYear.Text;
                        sg.SchoolyearID = syid;
                        sg.Period = cmbGradePeriod.Text;
                        db.StudentGrades.InsertOnSubmit(sg);
                        db.SubmitChanges();
                        MessageBox.Show("Successfully added");
                        incrementGradePeriod();
                        displayGrade();
                    }
                }
                else
                {
                    MessageBox.Show("Please input second grading period please.");
                }
            }
            else if (cmbGradePeriod.Text == "Fourth Grading")
            {
                var studGrade3 = from sg in db.StudentGrades
                                 where sg.Period == "Third Grading" && sg.YearLevel == txtGrYear.Text && sg.StudentID == int.Parse(txtGrSTID.Text) && sg.SubjectID == int.Parse(cmbGrSubject.SelectedValue.ToString())
                                 select sg;
                if (studGrade3.Count() > 0)
                {
                    var studGrade = from sg in db.StudentGrades
                                    where sg.Period == "Fourth Grading" && sg.YearLevel == txtGrYear.Text && sg.StudentID == int.Parse(txtGrSTID.Text) && sg.SubjectID == int.Parse(cmbGrSubject.SelectedValue.ToString())
                                    select sg;
                    if (studGrade.Count() > 0)
                    {
                        var sg = db.StudentGrades.SingleOrDefault(x => x.StudentID == int.Parse(txtGrSTID.Text) && x.SubjectID == int.Parse(cmbGrSubject.SelectedValue.ToString()) && x.Period == cmbGradePeriod.Text && x.YearLevel == txtGrYear.Text);
                        sg.Grade = decimal.Parse(txtGrade.Text);
                        db.SubmitChanges();
                        MessageBox.Show("Successfully changed");
                        incrementGradePeriod();
                        displayGrade();
                    }
                    else
                    {
                        StudentGrade sg = new StudentGrade();
                        sg.Grade = decimal.Parse(txtGrade.Text);
                        sg.StudentID = int.Parse(txtGrSTID.Text);
                        sg.SubjectID = int.Parse(cmbGrSubject.SelectedValue.ToString());
                        sg.YearLevel = txtGrYear.Text;
                        sg.SchoolyearID = syid;
                        sg.Period = cmbGradePeriod.Text;
                        db.StudentGrades.InsertOnSubmit(sg);
                        db.SubmitChanges();
                        MessageBox.Show("Successfully added");
                        incrementGradePeriod();
                        displayGrade();
                    }
                }
                else
                {
                    MessageBox.Show("Please input third grading period please.");
                }
            }
        }
        public void DisplayPayDet()
        {
            var displaypaydet = from p in db.Payments
                                join sy in db.Schoolyears on p.SchoolyearID equals sy.SchoolyearID
                                select new{
                                    p.PaymentID,
                                    p.Payment1,
                                    p.Amount,
                                    sy.SchoolyearID,
                                    sy.Year
                                };
            dgvPayments.DataSource = displaypaydet;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPayments.Text) || !string.IsNullOrWhiteSpace(txtAmount.Text) || !string.IsNullOrWhiteSpace(cmbSchoolYear.Text))
            {
                if (btnAdd.Text=="Add")
                {
                    Payment stud = new Payment();
                    stud.Payment1 = txtPayments.Text;
                    stud.Amount = decimal.Parse(txtAmount.Text);
                    stud.SchoolyearID = int.Parse(cmbSchoolYear.SelectedValue.ToString());
                    db.Payments.InsertOnSubmit(stud);
                    db.SubmitChanges();
                    MessageBox.Show("Successfully Saved");
                    PayClear();
                    DisplayPayDet();
                }
                else
                {
                    var updatepaydet = db.Payments.SingleOrDefault(x => x.PaymentID == int.Parse(txtPayID.Text));
                    updatepaydet.Payment1 = txtPayments.Text;
                    updatepaydet.Amount = decimal.Parse(txtAmount.Text);
                    updatepaydet.SchoolyearID = int.Parse(cmbSchoolYear.SelectedValue.ToString());
                    db.SubmitChanges();
                    MessageBox.Show("Successfully Update");
                    PayClear();
                    DisplayPayDet();
                    btnAdd.Text = "Add";
                    btnClear.Text = "Clear";
                }
               
            }
            else
            {
                MessageBox.Show("Input all fields");
            }
         
        }
        public void PayClear()
        {
            txtPayments.Clear();
            txtAmount.Clear();
            cmbSchoolYear.SelectedIndex = - 1;
        }

        private void dgvPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPayID.Text =  dgvPayments.CurrentRow.Cells[0].Value.ToString();
            txtPayments.Text = dgvPayments.CurrentRow.Cells[1].Value.ToString();
            txtAmount.Text = dgvPayments.CurrentRow.Cells[2].Value.ToString();
            txtSyID.Text = dgvPayments.CurrentRow.Cells[3].Value.ToString();
            cmbSchoolYear.Text = dgvPayments.CurrentRow.Cells[4].Value.ToString();
            btnAdd.Text = "Update";
            btnClear.Text = "Cancel";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (btnClear.Text=="Clear")
            {
                PayClear();
            }
            else
            {
                btnAdd.Text = "Add";
                btnClear.Text = "Clear";
                PayClear();
            }
        }
	}
}
