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
    public partial class TeacherInformationForm : MetroFramework.Forms.MetroForm
    {
        bool Isselection;
        int schedID;
        public TeacherInformationForm()
        {
            InitializeComponent();
        }
		DataClassDataContext db = new DataClassDataContext();
        private void TeacherInformationForm_Load(object sender, EventArgs e)
        {
            mcmbstatus.SelectedIndex = 0;
			displaySubject();

			var sub = from s in db.Subjects
					  select s;
			cmbSubject.DataSource = sub;
			cmbSubject.ValueMember = "SubjectID";
			cmbSubject.DisplayMember = "Subject1";

			displayTeacher();

			var ts = from t in db.TimeSchedules
					 select new {ID=t.TimeScheduleID,Time=t.TimeStart+" - "+t.TimeEnd};
			mcmbTimeStartENd.DataSource = ts;
			mcmbTimeStartENd.DisplayMember = "Time";
			mcmbTimeStartENd.ValueMember = "ID";

            var sec = from z in db.Sections
                      select z;
            cmbSectionname.DataSource = sec;
            cmbSectionname.DisplayMember = "Section1";
            cmbSectionname.ValueMember = "SectionID";

            displayteacherSched();
		}

        private void btnAddSched_Click(object sender, EventArgs e)
        {
            AddScheduleTimeForm astf = new AddScheduleTimeForm();
            astf.ShowDialog();
        }

        private void mtpTeacherProfile_Click(object sender, EventArgs e)
        {

        }
		public void displaySubject()
		{
            var sub = from s in db.Subjects
                      select new
                      {
                          s.SubjectID,
                          Subject = s.Subject1,
                          s.YearLevel
                      };
			dgvSubject.DataSource = sub;
		}
		public void clear()
		{
			if (btnSubCancel.Text == "Clear")
			{
				txtSubject.Clear();
			}else
			{
				txtSubject.Clear();
				btnSubCancel.Text = "Clear";
			}
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
            var subExist=from s in db.Subjects
                    where s.Subject1==cmbSub.Text&& s.YearLevel == cmbSubYearlvl.Text
                    select s;
            if (subExist.Count() > 0)
            {
                MessageBox.Show("Duplicate Subject!");
            }
            else
            {
                    if (btnSubAdd.Text == "Add")
                    {
                        Subject sub = new Subject();
                        sub.Subject1 = cmbSub.Text;
                        sub.YearLevel = cmbSubYearlvl.Text;
                        db.Subjects.InsertOnSubmit(sub);
                        db.SubmitChanges();
                        MessageBox.Show("Added Subject");
                        clear();
                        displaySubject();
                    }
                    else
                    {
                        var sub = db.Subjects.SingleOrDefault(x => x.SubjectID == id);
                        sub.Subject1 = cmbSub.Text;
                        sub.YearLevel = cmbSubYearlvl.Text;
                        MessageBox.Show("Update Subject");
                        db.SubmitChanges();
                        btnSubAdd.Text = "Add";
                        btnSubCancel.Text = "Clear";
                        clear();
                        displaySubject();
                    }
                }
                
            }
		int id = 0;
		private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			id = int.Parse(dgvSubject.CurrentRow.Cells[0].Value.ToString());
			cmbSub.Text = dgvSubject.CurrentRow.Cells[1].Value.ToString();
			btnSubAdd.Text = "Update";
		}

		private void mtxtSearchsub_TextChanged(object sender, EventArgs e)
		{
			var sub = from s in db.Subjects
					  where s.Subject1.Contains(txtSearchsub.Text) || s.YearLevel.Contains(txtSearchsub.Text)
					  select s;
			dgvSubject.DataSource = sub;
		}
		private void mbtnAdd_Click(object sender, EventArgs e)
		{
            if (String.IsNullOrWhiteSpace(mtxtFname.Text) || String.IsNullOrWhiteSpace(mtxtLname.Text) || String.IsNullOrWhiteSpace(mtxtMname.Text) || String.IsNullOrWhiteSpace(mtxtContact.Text) || String.IsNullOrWhiteSpace(cmbSubject.Text) || String.IsNullOrWhiteSpace(mcmbstatus.Text))
            {
                MessageBox.Show("Input all fields");
            }
            else
            {
                if (mbtnAdd.Text == "Add")
                {
                    Teacher teach = new Teacher();
                    teach.Firstname = mtxtFname.Text;
                    teach.Middlename = mtxtMname.Text;
                    teach.Lastname = mtxtLname.Text;
                    teach.ContactNumber = mtxtContact.Text;
                    teach.Status = mcmbstatus.Text;
                    teach.SubjectID = int.Parse(cmbSubject.SelectedValue.ToString());
                    db.Teachers.InsertOnSubmit(teach);
                    db.SubmitChanges();
                    MessageBox.Show("Added");
                    displayTeacher();
                    clearTeacher();
                }
                else
                {
                    var teach = db.Teachers.SingleOrDefault(x => x.TeacherID == tid);
                    teach.Firstname = mtxtFname.Text;
                    teach.Middlename = mtxtMname.Text;
                    teach.Lastname = mtxtLname.Text;
                    teach.ContactNumber = mtxtContact.Text;
                    teach.Status = mcmbstatus.Text;
                    teach.SubjectID = int.Parse(cmbSubject.SelectedValue.ToString());
                    db.SubmitChanges();
                    MessageBox.Show("Updated");
                    displayTeacher();
                    clearTeacher();
                    mbtnAdd.Text = "Add";
                    mbtnClear.Text = "Clear";
                    mcmbstatus.Enabled = false;
                }
            }
		
		}
		public void clearTeacher()
		{
			mtxtFname.Clear();
			mtxtMname.Clear();
			mtxtLname.Clear();
			mtxtContact.Clear();
			mcmbstatus.SelectedIndex = -1;
			cmbSubject.SelectedIndex = -1;
		}
		public void displayTeacher()
		{
			var teacher = from t in db.Teachers join s in db.Subjects on t.SubjectID equals s.SubjectID
						  select new{t.TeacherID,
                                    t.Firstname,
                                    t.Middlename,
                                    t.Lastname,
                                    t.ContactNumber,
                                    t.Status,
                                    Subject=s.Subject1};
			dgvTeacher.DataSource = teacher;
		}

		private void mtxtSearch_TextChanged(object sender, EventArgs e)
		{
			var teacher = from t in db.Teachers
						  join s in db.Subjects on t.SubjectID equals s.SubjectID
						  where t.Firstname.Contains(mtxtSearch.Text) || t.Lastname.Contains(mtxtSearch.Text)
						  select new { t.TeacherID, t.Firstname, t.Middlename, t.Lastname, t.ContactNumber, t.Status, s.Subject1 };
			dgvTeacher.DataSource = teacher;
		}
		int tid = 0;
		private void dgvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			tid = int.Parse(dgvTeacher.CurrentRow.Cells[0].Value.ToString());
			mtxtFname.Text = dgvTeacher.CurrentRow.Cells[1].Value.ToString();
			mtxtMname.Text = dgvTeacher.CurrentRow.Cells[2].Value.ToString();
			mtxtLname.Text = dgvTeacher.CurrentRow.Cells[3].Value.ToString();
			mtxtContact.Text = dgvTeacher.CurrentRow.Cells[4].Value.ToString();
			mcmbstatus.Text = dgvTeacher.CurrentRow.Cells[5].Value.ToString();
			cmbSubject.Text = dgvTeacher.CurrentRow.Cells[6].Value.ToString();
			mbtnAdd.Text = "Update";
			mbtnClear.Text = "Cancel";
            mcmbstatus.Enabled = true;
		}

		private void mbtnClear_Click(object sender, EventArgs e)
		{
			if (mbtnClear.Text == "Clear")
			{
				clearTeacher();
			}
			else
			{
				mbtnClear.Text = "Clear";
				mbtnAdd.Text = "Add";
				clearTeacher();
			}
		}

		private void mbtnSelectTeac_Click(object sender, EventArgs e)
		{
			var teacher = from t in db.Teachers
                          join s in db.Subjects on t.SubjectID equals s.SubjectID
						  select new {t.TeacherID,Name=t.Firstname+" "+t.Lastname,s.Subject1};
			dgvSchedule.DataSource = teacher;
            Isselection = true;
            
            
		}
		private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
            if (Isselection)
            {
                txtTID.Text = dgvSchedule.CurrentRow.Cells[0].Value.ToString();
                mtxtTeachername.Text =dgvSchedule.CurrentRow.Cells[1].Value.ToString();
                txtSubject.Text =dgvSchedule.CurrentRow.Cells[2].Value.ToString();
                Isselection=false;
                displayteacherSched();

            }
            else
            {
                schedID = int.Parse(dgvSchedule.CurrentRow.Cells[0].Value.ToString());
                txtTID.Text = dgvSchedule.CurrentRow.Cells[1].Value.ToString();
                mtxtTeachername.Text = dgvSchedule.CurrentRow.Cells[2].Value.ToString();
                cmbSectionname.Text = dgvSchedule.CurrentRow.Cells[3].Value.ToString();
                cmbYearlevel.Text = dgvSchedule.CurrentRow.Cells[4].Value.ToString();
                txtSubject.Text = dgvSchedule.CurrentRow.Cells[5].Value.ToString();
                mcmbTimeStartENd.Text = dgvSchedule.CurrentRow.Cells[6].Value.ToString();
                btnSchedAdd.Text = "Update";
                btnSchedClear.Text = "Cancel";
                
            }
		}

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnSchedAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtTeachername.Text) || string.IsNullOrWhiteSpace(cmbYearlevel.Text) || string.IsNullOrWhiteSpace(cmbSectionname.Text) || string.IsNullOrWhiteSpace(txtSubject.Text) || string.IsNullOrWhiteSpace(mcmbTimeStartENd.Text))
            {
                MessageBox.Show("Input all fields");
            }
            else
            {
                if (btnSchedAdd.Text == "Add")
                {
                    var dispthsched = from sc in db.Schedules
                                      join t in db.Teachers on sc.TeacherID equals t.TeacherID
                                      join sec in db.Sections on sc.SectionID equals sec.SectionID
                                      join sub in db.Subjects on t.SubjectID equals sub.SubjectID
                                      join tsched in db.TimeSchedules on sc.TimeScheduleID equals tsched.TimeScheduleID
                                      where t.TeacherID == int.Parse(txtTID.Text) && sub.SubjectID == int.Parse(cmbSubject.SelectedValue.ToString()) && tsched.TimeScheduleID == int.Parse(mcmbTimeStartENd.SelectedValue.ToString()) && sec.SectionID == int.Parse(cmbSectionname.SelectedValue.ToString()) && sc.YearLevel == cmbYearlevel.Text
                                      select new
                                      {
                                          ID = sc.ScheduleID,
                                          TID = t.TeacherID,
                                          Name = t.Firstname + " " + t.Lastname,
                                          Section = sec.Section1,
                                          Subject = sub.Subject1,
                                          Schedule = tsched.TimeStart + " - " + tsched.TimeEnd
                                      };
                    if (dispthsched.Count() > 0)
                    {
                        MessageBox.Show("Duplicate schedule!");
                    }
                    else
                    {
                        Schedule sched = new Schedule();
                        sched.TeacherID = Convert.ToInt32(txtTID.Text);
                        sched.SectionID = Convert.ToInt32(cmbSectionname.SelectedValue);
                        sched.YearLevel = cmbYearlevel.Text;
                        sched.TimeScheduleID = Convert.ToInt32(mcmbTimeStartENd.SelectedValue);
                        db.Schedules.InsertOnSubmit(sched);
                        db.SubmitChanges();
                        MessageBox.Show("Success ADD");
                        SchedClear();
                        dgvSchedule.DataSource = sched;
                        displayteacherSched();
                    }

                }
                else
                {
                    var dispthsched = from sc in db.Schedules
                                      join t in db.Teachers on sc.TeacherID equals t.TeacherID
                                      join sec in db.Sections on sc.SectionID equals sec.SectionID
                                      join sub in db.Subjects on t.SubjectID equals sub.SubjectID
                                      join tsched in db.TimeSchedules on sc.TimeScheduleID equals tsched.TimeScheduleID
                                      where t.TeacherID == int.Parse(txtTID.Text) && sub.SubjectID == int.Parse(txtSubject.Text) && tsched.TimeScheduleID == int.Parse(mcmbTimeStartENd.SelectedValue.ToString()) && sec.SectionID == int.Parse(cmbSectionname.SelectedValue.ToString()) && sc.YearLevel == cmbYearlevel.Text
                                      select new
                                      {
                                          ID = sc.ScheduleID,
                                          TID = t.TeacherID,
                                          Name = t.Firstname + " " + t.Lastname,
                                          Section = sec.Section1,
                                          Subject = sub.Subject1,
                                          Schedule = tsched.TimeStart + " - " + tsched.TimeEnd
                                      };
                    if (dispthsched.Count() > 0)
                    {
                        MessageBox.Show("Duplicate schedule!");
                    }
                    else
                    {
                        var updatesched = db.Schedules.SingleOrDefault(x => x.ScheduleID == schedID);
                        updatesched.TeacherID = int.Parse(txtTID.Text);
                        updatesched.SectionID = int.Parse(cmbSectionname.SelectedValue.ToString());
                        updatesched.YearLevel = cmbYearlevel.Text;
                        updatesched.TimeScheduleID = int.Parse(mcmbTimeStartENd.SelectedValue.ToString());
                        db.SubmitChanges();
                        MessageBox.Show("Success UPDATE");
                        dgvSchedule.DataSource = updatesched;
                        displayteacherSched();
                        SchedClear();
                        btnSchedAdd.Text = "Add";
                        btnSchedClear.Text = "Clear";
                    }

                }
            }
           
        }
        public void SchedClear()
        {
            mtxtTeachername.Clear();
            cmbSectionname.SelectedIndex = -1;
            txtSubject.Clear();
            mcmbTimeStartENd.SelectedIndex = -1;
            cmbYearlevel.SelectedIndex = -1;
        }
        public void displayteacherSched()
        {
            var dispthsched = from sc in db.Schedules
                              join t in db.Teachers on sc.TeacherID equals t.TeacherID
                              join sec in db.Sections on sc.SectionID equals sec.SectionID
                              join sub in db.Subjects on t.SubjectID equals sub.SubjectID
                              join tsched in db.TimeSchedules on sc.TimeScheduleID equals tsched.TimeScheduleID
                              select new
                              {
                                  ID=sc.ScheduleID,
                                  TID=t.TeacherID,
                                  Name=t.Firstname+" "+t.Lastname,
                                  Section=sec.Section1,
                                  sc.YearLevel,
                                  Subject=sub.Subject1,
                                  Schedule=tsched.TimeStart+" - "+tsched.TimeEnd
                              };
            dgvSchedule.DataSource = dispthsched;
        }

        private void btnSchedClear_Click(object sender, EventArgs e)
        {
            if (btnSchedClear.Text=="Clear")
            {
                SchedClear();
            }
            else
            {
                btnSchedAdd.Text = "Add";
                btnSchedClear.Text = "Clear";
                SchedClear();
            }
        }

        private void mtpSchedule_Click(object sender, EventArgs e)
        {

        }

        private void mtxtSeach_TextChanged(object sender, EventArgs e)
        {
            if (Isselection)
            {
                var searchteacher = from t in db.Teachers
                                    join s in db.Subjects on t.SubjectID equals s.SubjectID
                                    where t.Firstname.Contains(txtSchedSearch.Text) || t.Lastname.Contains(txtSchedSearch.Text) || s.Subject1.Contains(txtSchedSearch.Text)
                                    select new { t.TeacherID, Name = t.Firstname + " " + t.Lastname, s.Subject1 };
                dgvSchedule.DataSource = searchteacher;
            }
            else
            {
                var searchthsched = from sc in db.Schedules
                                    join t in db.Teachers on sc.TeacherID equals t.TeacherID
                                    join sec in db.Sections on sc.SectionID equals sec.SectionID
                                    join sub in db.Subjects on t.SubjectID equals sub.SubjectID
                                    join tsched in db.TimeSchedules on sc.TimeScheduleID equals tsched.TimeScheduleID
                                    where t.Firstname.Contains(txtSchedSearch.Text) || t.Lastname.Contains(txtSchedSearch.Text) || sec.Section1.Contains(txtSchedSearch.Text) || sub.Subject1.Contains(txtSchedSearch.Text)
                                    select new
                                    {
                                        ID = sc.ScheduleID,
                                        TID = t.TeacherID,
                                        Name = t.Firstname + " " + t.Lastname,
                                        Section = sec.Section1,
                                        Subject = sub.Subject1,
                                        Schedule = tsched.TimeStart + " - " + tsched.TimeEnd
                                    };
                dgvSchedule.DataSource = searchthsched;
            }
         
        }
	}
}
