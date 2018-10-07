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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }
        int uid, usertypeid;
        public MainForm(int id,int utypeid)
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            uid = id;
            usertypeid = utypeid;
        }

		private void MainForm_Load(object sender, EventArgs e)
		{
            timer1.Start();
            LbDate.Text = DateTime.Now.ToLongDateString();
            LbTime.Text = DateTime.Now.ToLongTimeString();
            cmbTheme.SelectedIndex = 1;
            cbColor.SelectedIndex = 13;
            if (usertypeid != 1)
            {
                UserAccountTile.Enabled = false;
                this.Text = "Staff Form";
            }
            
		}

		private void UserAccountTile_Click(object sender, EventArgs e)
		{
			UserAccountForm uaf = new UserAccountForm();
			uaf.ShowDialog();
		}

        private void StudentProfileTile_Click(object sender, EventArgs e)
        {
            StudentInformationForm sif = new StudentInformationForm();
            sif.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            AddSectionForm asf = new AddSectionForm();
            asf.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            TeacherInformationForm tinfo = new TeacherInformationForm();
            tinfo.ShowDialog();
        }

        private void BooksTile_Click(object sender, EventArgs e)
        {
            AddBookForm abf = new AddBookForm();
            abf.txtProcBookDistributer.Text = Control_Variables.Username;
            abf.ShowDialog();
        }

        private void InquiryTile_Click(object sender, EventArgs e)
        {
            AddInquiryForm aif = new AddInquiryForm();
            aif.ShowDialog();
        }

        private void TransactionTile_Click(object sender, EventArgs e)
        {
            TransactionForm Tf = new TransactionForm();
            Tf.txtReleaseBy.Text = Control_Variables.Username;
            Tf.ShowDialog();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTheme.SelectedIndex == 0)
	        {
		        metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
	        }else
	            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
	            }

          
        }

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(cbColor.SelectedIndex);
        }

        private void MonitoringTile_Click(object sender, EventArgs e)
        {
            MonitoringForm mf = new MonitoringForm();
            mf.ShowDialog();
        }

        private void InventoryTile_Click(object sender, EventArgs e)
        {
            mtpInventoryForm inf = new mtpInventoryForm();
            inf.ShowDialog();
        }

        private void ReportsTile_Click(object sender, EventArgs e)
        {
            ReportsForm rf = new ReportsForm();
            rf.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LbTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          DialogResult dialog = MessageBox.Show("Are you sure you want to logout ?", "Wait !", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialog == DialogResult.Yes)
            {
                Login l = new Login();
                this.Close();
                l.Show();
            }
            else
            {
                return;
            }  
        }
	}
}
