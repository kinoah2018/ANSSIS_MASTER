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
	public partial class ManageSchoolyear : MetroForm
	{
		DataClassDataContext db = new DataClassDataContext();
		public ManageSchoolyear()
		{
			InitializeComponent();
		}

		private void ManageSchoolyear_Load(object sender, EventArgs e)
		{
			displaySchoolyear();
		}
		public void displaySchoolyear()
		{
			var sy = from s in db.Schoolyears
					 select s;
			dgvSchoolyear.DataSource = sy;
			
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
            var syexist = from s in db.Schoolyears
                     where s.Year == txtSchoolyear.Text
                     select s;
            if (syexist.Count() > 0)
            {
                MessageBox.Show("Duplicate Schoolyear!");
            }
            else
            {
                if (btnAdd.Text == "Add")
                {
                    Schoolyear sy = new Schoolyear();
                    sy.Year = txtSchoolyear.Text;
                    db.Schoolyears.InsertOnSubmit(sy);
                    db.SubmitChanges();
                    displaySchoolyear();
                    MessageBox.Show("Successfully!");
                }
                else
                {
                    var updatesy = db.Schoolyears.SingleOrDefault(x => x.SchoolyearID == id);
                    updatesy.Year = txtSchoolyear.Text;
                    db.SubmitChanges();
                    btnAdd.Text = "Add";
                    btnClear.Text = "Clear";
                }
            }
			
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			if (btnClear.Text == "Clear")
			{
				txtSchoolyear.Clear();
			}else
			{
				txtSchoolyear.Clear();
				btnClear.Text = "Clear";
				btnAdd.Text = "Add";
			}
		}
		int id = 0;
		private void dgvSchoolyear_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			id = int.Parse(dgvSchoolyear.CurrentRow.Cells[0].Value.ToString());
			txtSchoolyear.Text = dgvSchoolyear.CurrentRow.Cells[1].Value.ToString();
			btnAdd.Text = "Update";
			btnClear.Text = "Cancel";
		}
	}
}
