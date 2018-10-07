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
    public partial class AddSectionForm : MetroFramework.Forms.MetroForm
    {
        public AddSectionForm()
        {
            InitializeComponent();
        }
		DataClassDataContext db = new DataClassDataContext();
        private void AddSectionForm_Load(object sender, EventArgs e)
        {
			displaySection();
			var teacher = from t in db.Teachers
						  select new { ID = t.TeacherID, Name = t.Firstname + " " + t.Lastname };
			cmbAdviser.DataSource = teacher;
			cmbAdviser.ValueMember = "ID";
			cmbAdviser.DisplayMember = "Name";
		}
		public void displaySection()
		{
			var section = from s in db.Sections 
                          join t in db.Teachers on s.TeacherID equals t.TeacherID
						  select new {s.SectionID,s.Section1,s.Capacity,s.YearLevel,Adviser=t.Firstname+" "+t.Lastname};
			mdgvAddSection.DataSource = section;
		}
        private void mdgvAddSection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
		private void mbtnAdd_Click(object sender, EventArgs e)
		{
            var checksec = from c in db.Sections
                           where c.Section1 == mtxtSecname.Text && c.YearLevel == mtxtYearLevel.Text
                           select c;
            var checkadviser = from c in db.Sections
                               where c.TeacherID == int.Parse(cmbAdviser.SelectedValue.ToString())
                               select c;
			if (mbtnAdd.Text == "Add")
			{
                if (checksec.Count() > 0)
                {
                    MessageBox.Show("Duplicate section.");
                }
                else
                {
                    if (checkadviser.Count() > 0)
                    {
                        MessageBox.Show("Adviser already taken.");
                    }
                    else
                    {
                        Section s = new Section();
                        s.Section1 = mtxtSecname.Text;
                        s.Capacity = int.Parse(mtxtcapacity.Text);
                        s.YearLevel = mtxtYearLevel.Text;
                        s.TeacherID = int.Parse(cmbAdviser.SelectedValue.ToString());
                        db.Sections.InsertOnSubmit(s);
                        db.SubmitChanges();
                        MessageBox.Show("ADDED");
                        clearSection();
                        displaySection();
                        //MessageBox.Show(s.SectionID.ToString());
                    }
                }
			}
			else
			{
                if (checksec.Count() > 0)
                {
                    MessageBox.Show("Duplicate section.");
                }
                else
                {
                    if (checkadviser.Count() > 0)
                    {
                        MessageBox.Show("Adviser already taken.");
                    }
                    else
                    {
                        var s = db.Sections.SingleOrDefault(x => x.SectionID == int.Parse(mdgvAddSection.CurrentRow.Cells[0].Value.ToString()));
                        s.Section1 = mtxtSecname.Text;
                        s.Capacity = int.Parse(mtxtcapacity.Text);
                        s.YearLevel = mtxtYearLevel.Text;
                        s.TeacherID = int.Parse(cmbAdviser.SelectedValue.ToString());
                        db.SubmitChanges();
                        MessageBox.Show("UPDATED");
                        clearSection();
                        displaySection();
                        mbtnAdd.Text = "Add";
                        mbtnClear.Text = "Clear";
                    }
                }
			}
		}
		public void clearSection()
		{
			mtxtSecname.Clear();
			mtxtcapacity.Clear();
			mtxtYearLevel.SelectedIndex = -1;
			cmbAdviser.SelectedIndex = -1;
		}

		private void mdgvAddSection_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			mtxtSecname.Text = mdgvAddSection.CurrentRow.Cells[1].Value.ToString();
			mtxtcapacity.Text = mdgvAddSection.CurrentRow.Cells[2].Value.ToString();
			mtxtYearLevel.Text= mdgvAddSection.CurrentRow.Cells[3].Value.ToString();
			cmbAdviser.Text= mdgvAddSection.CurrentRow.Cells[4].Value.ToString();
			mbtnAdd.Text = "Update";
			mbtnClear.Text = "Cancel";
		}

		private void mbtnClear_Click(object sender, EventArgs e)
		{
			if (mbtnClear.Text=="Clear")
			{
				clearSection();
			}else
			{
				clearSection();
				mbtnAdd.Text = "Add";
				mbtnClear.Text = "Clear";
			}
		}

        private void AddSectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
	}
}
