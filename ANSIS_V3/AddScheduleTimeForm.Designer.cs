namespace ANSIS_V3
{
    partial class AddScheduleTimeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.mcmbTstarthours = new MetroFramework.Controls.MetroComboBox();
            this.mcmbTstartmins = new MetroFramework.Controls.MetroComboBox();
            this.mcmbTstartsec = new MetroFramework.Controls.MetroComboBox();
            this.mcmbTendsec = new MetroFramework.Controls.MetroComboBox();
            this.mcmbTendmins = new MetroFramework.Controls.MetroComboBox();
            this.mcmbTendhours = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvSchedTime = new MetroFramework.Controls.MetroGrid();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedTime)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(18, 72);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(70, 19);
            this.metroLabel8.TabIndex = 20;
            this.metroLabel8.Text = "Time Start";
            // 
            // mcmbTstarthours
            // 
            this.mcmbTstarthours.FormattingEnabled = true;
            this.mcmbTstarthours.ItemHeight = 23;
            this.mcmbTstarthours.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.mcmbTstarthours.Location = new System.Drawing.Point(17, 96);
            this.mcmbTstarthours.Name = "mcmbTstarthours";
            this.mcmbTstarthours.Size = new System.Drawing.Size(65, 29);
            this.mcmbTstarthours.TabIndex = 21;
            this.mcmbTstarthours.UseSelectable = true;
            // 
            // mcmbTstartmins
            // 
            this.mcmbTstartmins.FormattingEnabled = true;
            this.mcmbTstartmins.ItemHeight = 23;
            this.mcmbTstartmins.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.mcmbTstartmins.Location = new System.Drawing.Point(100, 96);
            this.mcmbTstartmins.Name = "mcmbTstartmins";
            this.mcmbTstartmins.Size = new System.Drawing.Size(65, 29);
            this.mcmbTstartmins.TabIndex = 22;
            this.mcmbTstartmins.UseSelectable = true;
            // 
            // mcmbTstartsec
            // 
            this.mcmbTstartsec.FormattingEnabled = true;
            this.mcmbTstartsec.ItemHeight = 23;
            this.mcmbTstartsec.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.mcmbTstartsec.Location = new System.Drawing.Point(181, 96);
            this.mcmbTstartsec.Name = "mcmbTstartsec";
            this.mcmbTstartsec.Size = new System.Drawing.Size(65, 29);
            this.mcmbTstartsec.TabIndex = 23;
            this.mcmbTstartsec.UseSelectable = true;
            // 
            // mcmbTendsec
            // 
            this.mcmbTendsec.FormattingEnabled = true;
            this.mcmbTendsec.ItemHeight = 23;
            this.mcmbTendsec.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.mcmbTendsec.Location = new System.Drawing.Point(181, 167);
            this.mcmbTendsec.Name = "mcmbTendsec";
            this.mcmbTendsec.Size = new System.Drawing.Size(65, 29);
            this.mcmbTendsec.TabIndex = 26;
            this.mcmbTendsec.UseSelectable = true;
            // 
            // mcmbTendmins
            // 
            this.mcmbTendmins.FormattingEnabled = true;
            this.mcmbTendmins.ItemHeight = 23;
            this.mcmbTendmins.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.mcmbTendmins.Location = new System.Drawing.Point(100, 167);
            this.mcmbTendmins.Name = "mcmbTendmins";
            this.mcmbTendmins.Size = new System.Drawing.Size(65, 29);
            this.mcmbTendmins.TabIndex = 25;
            this.mcmbTendmins.UseSelectable = true;
            // 
            // mcmbTendhours
            // 
            this.mcmbTendhours.FormattingEnabled = true;
            this.mcmbTendhours.ItemHeight = 23;
            this.mcmbTendhours.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.mcmbTendhours.Location = new System.Drawing.Point(17, 167);
            this.mcmbTendhours.Name = "mcmbTendhours";
            this.mcmbTendhours.Size = new System.Drawing.Size(65, 29);
            this.mcmbTendhours.TabIndex = 24;
            this.mcmbTendhours.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 144);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Time End";
            // 
            // dgvSchedTime
            // 
            this.dgvSchedTime.AllowUserToAddRows = false;
            this.dgvSchedTime.AllowUserToDeleteRows = false;
            this.dgvSchedTime.AllowUserToResizeRows = false;
            this.dgvSchedTime.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSchedTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSchedTime.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSchedTime.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedTime.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSchedTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSchedTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSchedTime.EnableHeadersVisualStyles = false;
            this.dgvSchedTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSchedTime.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSchedTime.Location = new System.Drawing.Point(260, 55);
            this.dgvSchedTime.Name = "dgvSchedTime";
            this.dgvSchedTime.ReadOnly = true;
            this.dgvSchedTime.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedTime.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSchedTime.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSchedTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedTime.Size = new System.Drawing.Size(386, 169);
            this.dgvSchedTime.TabIndex = 28;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(181, 207);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(65, 23);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Reset";
            this.btnReset.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(86, 103);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(10, 15);
            this.metroLabel2.TabIndex = 31;
            this.metroLabel2.Text = ":";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(85, 173);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(10, 15);
            this.metroLabel3.TabIndex = 32;
            this.metroLabel3.Text = ":";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(167, 102);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(10, 15);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = ":";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(167, 173);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(10, 15);
            this.metroLabel5.TabIndex = 34;
            this.metroLabel5.Text = ":";
            // 
            // AddScheduleTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 236);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvSchedTime);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mcmbTendsec);
            this.Controls.Add(this.mcmbTendmins);
            this.Controls.Add(this.mcmbTendhours);
            this.Controls.Add(this.mcmbTstartsec);
            this.Controls.Add(this.mcmbTstartmins);
            this.Controls.Add(this.mcmbTstarthours);
            this.Controls.Add(this.metroLabel8);
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "AddScheduleTimeForm";
            this.Text = "Add Schedule Time";
            this.Load += new System.EventHandler(this.AddScheduleTimeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox mcmbTstarthours;
        private MetroFramework.Controls.MetroComboBox mcmbTstartmins;
        private MetroFramework.Controls.MetroComboBox mcmbTstartsec;
        private MetroFramework.Controls.MetroComboBox mcmbTendsec;
        private MetroFramework.Controls.MetroComboBox mcmbTendmins;
        private MetroFramework.Controls.MetroComboBox mcmbTendhours;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid dgvSchedTime;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnReset;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}