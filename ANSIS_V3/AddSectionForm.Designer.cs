namespace ANSIS_V3
{
    partial class AddSectionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtxtYearLevel = new MetroFramework.Controls.MetroComboBox();
            this.mcmbSubject = new MetroFramework.Controls.MetroLabel();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.mtxtcapacity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.mtxtSecname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.mbtnClear = new MetroFramework.Controls.MetroButton();
            this.mbtnAdd = new MetroFramework.Controls.MetroButton();
            this.mtxtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.mdgvAddSection = new MetroFramework.Controls.MetroGrid();
            this.cmbAdviser = new MetroFramework.Controls.MetroComboBox();
            this.cmbFilterYearLevel = new MetroFramework.Controls.MetroComboBox();
            this.lblFileterYearLevel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvAddSection)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxtYearLevel
            // 
            this.mtxtYearLevel.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.mtxtYearLevel.FormattingEnabled = true;
            this.mtxtYearLevel.ItemHeight = 19;
            this.mtxtYearLevel.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.mtxtYearLevel.Location = new System.Drawing.Point(135, 140);
            this.mtxtYearLevel.Name = "mtxtYearLevel";
            this.mtxtYearLevel.Size = new System.Drawing.Size(187, 25);
            this.mtxtYearLevel.TabIndex = 41;
            this.mtxtYearLevel.UseSelectable = true;
            // 
            // mcmbSubject
            // 
            this.mcmbSubject.AutoSize = true;
            this.mcmbSubject.BackColor = System.Drawing.Color.Transparent;
            this.mcmbSubject.Location = new System.Drawing.Point(18, 171);
            this.mcmbSubject.Name = "mcmbSubject";
            this.mcmbSubject.Size = new System.Drawing.Size(113, 19);
            this.mcmbSubject.TabIndex = 40;
            this.mcmbSubject.Text = "Advisory Section :";
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel27.Location = new System.Drawing.Point(57, 142);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(74, 19);
            this.metroLabel27.TabIndex = 39;
            this.metroLabel27.Text = "Year Level :";
            // 
            // mtxtcapacity
            // 
            // 
            // 
            // 
            this.mtxtcapacity.CustomButton.Image = null;
            this.mtxtcapacity.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.mtxtcapacity.CustomButton.Name = "";
            this.mtxtcapacity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtcapacity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtcapacity.CustomButton.TabIndex = 1;
            this.mtxtcapacity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtcapacity.CustomButton.UseSelectable = true;
            this.mtxtcapacity.CustomButton.Visible = false;
            this.mtxtcapacity.Lines = new string[0];
            this.mtxtcapacity.Location = new System.Drawing.Point(135, 111);
            this.mtxtcapacity.MaxLength = 32767;
            this.mtxtcapacity.Name = "mtxtcapacity";
            this.mtxtcapacity.PasswordChar = '\0';
            this.mtxtcapacity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtcapacity.SelectedText = "";
            this.mtxtcapacity.SelectionLength = 0;
            this.mtxtcapacity.SelectionStart = 0;
            this.mtxtcapacity.ShortcutsEnabled = true;
            this.mtxtcapacity.Size = new System.Drawing.Size(187, 23);
            this.mtxtcapacity.TabIndex = 38;
            this.mtxtcapacity.UseSelectable = true;
            this.mtxtcapacity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtcapacity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.Location = new System.Drawing.Point(22, 111);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(109, 19);
            this.metroLabel25.TabIndex = 37;
            this.metroLabel25.Text = "Section capacity :";
            // 
            // mtxtSecname
            // 
            // 
            // 
            // 
            this.mtxtSecname.CustomButton.Image = null;
            this.mtxtSecname.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.mtxtSecname.CustomButton.Name = "";
            this.mtxtSecname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtSecname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtSecname.CustomButton.TabIndex = 1;
            this.mtxtSecname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtSecname.CustomButton.UseSelectable = true;
            this.mtxtSecname.CustomButton.Visible = false;
            this.mtxtSecname.Lines = new string[0];
            this.mtxtSecname.Location = new System.Drawing.Point(135, 82);
            this.mtxtSecname.MaxLength = 32767;
            this.mtxtSecname.Name = "mtxtSecname";
            this.mtxtSecname.PasswordChar = '\0';
            this.mtxtSecname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtSecname.SelectedText = "";
            this.mtxtSecname.SelectionLength = 0;
            this.mtxtSecname.SelectionStart = 0;
            this.mtxtSecname.ShortcutsEnabled = true;
            this.mtxtSecname.Size = new System.Drawing.Size(187, 23);
            this.mtxtSecname.TabIndex = 36;
            this.mtxtSecname.UseSelectable = true;
            this.mtxtSecname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtSecname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(36, 83);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(95, 19);
            this.metroLabel20.TabIndex = 35;
            this.metroLabel20.Text = "Section name :";
            // 
            // mbtnClear
            // 
            this.mbtnClear.Location = new System.Drawing.Point(274, 206);
            this.mbtnClear.Name = "mbtnClear";
            this.mbtnClear.Size = new System.Drawing.Size(50, 25);
            this.mbtnClear.TabIndex = 44;
            this.mbtnClear.Text = "Clear";
            this.mbtnClear.UseSelectable = true;
            this.mbtnClear.Click += new System.EventHandler(this.mbtnClear_Click);
            // 
            // mbtnAdd
            // 
            this.mbtnAdd.Location = new System.Drawing.Point(218, 206);
            this.mbtnAdd.Name = "mbtnAdd";
            this.mbtnAdd.Size = new System.Drawing.Size(50, 25);
            this.mbtnAdd.TabIndex = 43;
            this.mbtnAdd.Text = "Add";
            this.mbtnAdd.UseSelectable = true;
            this.mbtnAdd.Click += new System.EventHandler(this.mbtnAdd_Click);
            // 
            // mtxtSearch
            // 
            // 
            // 
            // 
            this.mtxtSearch.CustomButton.Image = null;
            this.mtxtSearch.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.mtxtSearch.CustomButton.Name = "";
            this.mtxtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtSearch.CustomButton.TabIndex = 1;
            this.mtxtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtSearch.CustomButton.UseSelectable = true;
            this.mtxtSearch.CustomButton.Visible = false;
            this.mtxtSearch.Lines = new string[0];
            this.mtxtSearch.Location = new System.Drawing.Point(831, 37);
            this.mtxtSearch.MaxLength = 32767;
            this.mtxtSearch.Name = "mtxtSearch";
            this.mtxtSearch.PasswordChar = '\0';
            this.mtxtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtSearch.SelectedText = "";
            this.mtxtSearch.SelectionLength = 0;
            this.mtxtSearch.SelectionStart = 0;
            this.mtxtSearch.ShortcutsEnabled = true;
            this.mtxtSearch.Size = new System.Drawing.Size(171, 23);
            this.mtxtSearch.TabIndex = 47;
            this.mtxtSearch.UseSelectable = true;
            this.mtxtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(771, 38);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(55, 19);
            this.metroLabel26.TabIndex = 46;
            this.metroLabel26.Text = "Search :";
            // 
            // mdgvAddSection
            // 
            this.mdgvAddSection.AllowUserToAddRows = false;
            this.mdgvAddSection.AllowUserToDeleteRows = false;
            this.mdgvAddSection.AllowUserToResizeColumns = false;
            this.mdgvAddSection.AllowUserToResizeRows = false;
            this.mdgvAddSection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mdgvAddSection.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvAddSection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvAddSection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvAddSection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvAddSection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mdgvAddSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvAddSection.DefaultCellStyle = dataGridViewCellStyle5;
            this.mdgvAddSection.EnableHeadersVisualStyles = false;
            this.mdgvAddSection.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvAddSection.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvAddSection.Location = new System.Drawing.Point(330, 66);
            this.mdgvAddSection.Name = "mdgvAddSection";
            this.mdgvAddSection.ReadOnly = true;
            this.mdgvAddSection.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvAddSection.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mdgvAddSection.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvAddSection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvAddSection.Size = new System.Drawing.Size(672, 240);
            this.mdgvAddSection.TabIndex = 45;
            this.mdgvAddSection.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mdgvAddSection_CellClick);
            this.mdgvAddSection.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mdgvAddSection_CellContentClick);
            // 
            // cmbAdviser
            // 
            this.cmbAdviser.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbAdviser.FormattingEnabled = true;
            this.cmbAdviser.ItemHeight = 19;
            this.cmbAdviser.Location = new System.Drawing.Point(135, 171);
            this.cmbAdviser.Name = "cmbAdviser";
            this.cmbAdviser.Size = new System.Drawing.Size(187, 25);
            this.cmbAdviser.TabIndex = 48;
            this.cmbAdviser.UseSelectable = true;
            // 
            // cmbFilterYearLevel
            // 
            this.cmbFilterYearLevel.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbFilterYearLevel.FormattingEnabled = true;
            this.cmbFilterYearLevel.ItemHeight = 19;
            this.cmbFilterYearLevel.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.cmbFilterYearLevel.Location = new System.Drawing.Point(470, 30);
            this.cmbFilterYearLevel.Name = "cmbFilterYearLevel";
            this.cmbFilterYearLevel.Size = new System.Drawing.Size(187, 25);
            this.cmbFilterYearLevel.TabIndex = 49;
            this.cmbFilterYearLevel.UseSelectable = true;
            this.cmbFilterYearLevel.SelectedIndexChanged += new System.EventHandler(this.cmbFilterYearLevel_SelectedIndexChanged);
            // 
            // lblFileterYearLevel
            // 
            this.lblFileterYearLevel.AutoSize = true;
            this.lblFileterYearLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblFileterYearLevel.Location = new System.Drawing.Point(352, 32);
            this.lblFileterYearLevel.Name = "lblFileterYearLevel";
            this.lblFileterYearLevel.Size = new System.Drawing.Size(112, 19);
            this.lblFileterYearLevel.TabIndex = 50;
            this.lblFileterYearLevel.Text = "Select Year Level :";
            // 
            // AddSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 326);
            this.Controls.Add(this.lblFileterYearLevel);
            this.Controls.Add(this.cmbFilterYearLevel);
            this.Controls.Add(this.cmbAdviser);
            this.Controls.Add(this.mtxtSearch);
            this.Controls.Add(this.metroLabel26);
            this.Controls.Add(this.mdgvAddSection);
            this.Controls.Add(this.mbtnClear);
            this.Controls.Add(this.mbtnAdd);
            this.Controls.Add(this.mtxtYearLevel);
            this.Controls.Add(this.mcmbSubject);
            this.Controls.Add(this.metroLabel27);
            this.Controls.Add(this.mtxtcapacity);
            this.Controls.Add(this.metroLabel25);
            this.Controls.Add(this.mtxtSecname);
            this.Controls.Add(this.metroLabel20);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSectionForm";
            this.Text = "Add Section Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddSectionForm_FormClosed);
            this.Load += new System.EventHandler(this.AddSectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mdgvAddSection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox mtxtYearLevel;
        private MetroFramework.Controls.MetroLabel mcmbSubject;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroTextBox mtxtcapacity;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroTextBox mtxtSecname;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroButton mbtnClear;
        private MetroFramework.Controls.MetroButton mbtnAdd;
        private MetroFramework.Controls.MetroTextBox mtxtSearch;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroGrid mdgvAddSection;
		private MetroFramework.Controls.MetroComboBox cmbAdviser;
        private MetroFramework.Controls.MetroComboBox cmbFilterYearLevel;
        private MetroFramework.Controls.MetroLabel lblFileterYearLevel;
	}
}