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
    public partial class AddScheduleTimeForm : MetroFramework.Forms.MetroForm
    {
        public AddScheduleTimeForm()
        {
            InitializeComponent();
        }
		DataClassDataContext db = new DataClassDataContext();
        private void AddScheduleTimeForm_Load(object sender, EventArgs e)
        {
			var ts = from t in db.TimeSchedules
					 select t;
			dgvSchedTime.DataSource = ts;
        }
		private void btnAdd_Click(object sender, EventArgs e)
		{
			TimeSchedule ts = new TimeSchedule();
			ts.TimeStart = mcmbTstarthours.Text + ":" + mcmbTstartmins.Text + ":" + mcmbTstartsec.Text;
			ts.TimeEnd = mcmbTendhours.Text + ":" + mcmbTendmins.Text + ":" + mcmbTendsec.Text;
			db.TimeSchedules.InsertOnSubmit(ts);
			db.SubmitChanges();
			MessageBox.Show("ADDED");
			var timesched = from t in db.TimeSchedules
					 select t;
			dgvSchedTime.DataSource = timesched;
		}
	}
}
