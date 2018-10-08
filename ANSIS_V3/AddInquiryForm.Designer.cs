namespace ANSIS_V3
{
    partial class AddInquiryForm
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
            this.txtInqDesc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.txtInqSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.dgvInquiry = new MetroFramework.Controls.MetroGrid();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.txtSTID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtStudName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbStatus = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtInqAnswer = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmbInqType = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquiry)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInqDesc
            // 
            // 
            // 
            // 
            this.txtInqDesc.CustomButton.Image = null;
            this.txtInqDesc.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtInqDesc.CustomButton.Name = "";
            this.txtInqDesc.CustomButton.Size = new System.Drawing.Size(61, 61);
            this.txtInqDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInqDesc.CustomButton.TabIndex = 1;
            this.txtInqDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInqDesc.CustomButton.UseSelectable = true;
            this.txtInqDesc.CustomButton.Visible = false;
            this.txtInqDesc.Lines = new string[0];
            this.txtInqDesc.Location = new System.Drawing.Point(133, 115);
            this.txtInqDesc.MaxLength = 32767;
            this.txtInqDesc.Multiline = true;
            this.txtInqDesc.Name = "txtInqDesc";
            this.txtInqDesc.PasswordChar = '\0';
            this.txtInqDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInqDesc.SelectedText = "";
            this.txtInqDesc.SelectionLength = 0;
            this.txtInqDesc.SelectionStart = 0;
            this.txtInqDesc.ShortcutsEnabled = true;
            this.txtInqDesc.Size = new System.Drawing.Size(244, 63);
            this.txtInqDesc.TabIndex = 43;
            this.txtInqDesc.UseSelectable = true;
            this.txtInqDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInqDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(6, 115);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(121, 19);
            this.metroLabel20.TabIndex = 42;
            this.metroLabel20.Text = "Inquiry Description:";
            // 
            // txtInqSearch
            // 
            // 
            // 
            // 
            this.txtInqSearch.CustomButton.Image = null;
            this.txtInqSearch.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.txtInqSearch.CustomButton.Name = "";
            this.txtInqSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInqSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInqSearch.CustomButton.TabIndex = 1;
            this.txtInqSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInqSearch.CustomButton.UseSelectable = true;
            this.txtInqSearch.CustomButton.Visible = false;
            this.txtInqSearch.Lines = new string[0];
            this.txtInqSearch.Location = new System.Drawing.Point(854, 49);
            this.txtInqSearch.MaxLength = 32767;
            this.txtInqSearch.Name = "txtInqSearch";
            this.txtInqSearch.PasswordChar = '\0';
            this.txtInqSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInqSearch.SelectedText = "";
            this.txtInqSearch.SelectionLength = 0;
            this.txtInqSearch.SelectionStart = 0;
            this.txtInqSearch.ShortcutsEnabled = true;
            this.txtInqSearch.Size = new System.Drawing.Size(178, 23);
            this.txtInqSearch.TabIndex = 50;
            this.txtInqSearch.UseSelectable = true;
            this.txtInqSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInqSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInqSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(796, 52);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(55, 19);
            this.metroLabel26.TabIndex = 49;
            this.metroLabel26.Text = "Search :";
            // 
            // dgvInquiry
            // 
            this.dgvInquiry.AllowUserToAddRows = false;
            this.dgvInquiry.AllowUserToDeleteRows = false;
            this.dgvInquiry.AllowUserToResizeColumns = false;
            this.dgvInquiry.AllowUserToResizeRows = false;
            this.dgvInquiry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInquiry.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInquiry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInquiry.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInquiry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInquiry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInquiry.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInquiry.EnableHeadersVisualStyles = false;
            this.dgvInquiry.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvInquiry.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInquiry.Location = new System.Drawing.Point(389, 78);
            this.dgvInquiry.Name = "dgvInquiry";
            this.dgvInquiry.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInquiry.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInquiry.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInquiry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInquiry.Size = new System.Drawing.Size(643, 293);
            this.dgvInquiry.TabIndex = 48;
            this.dgvInquiry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInquiry_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(221, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.TextChanged += new System.EventHandler(this.btnAdd_TextChanged);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(302, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSTID
            // 
            // 
            // 
            // 
            this.txtSTID.CustomButton.Image = null;
            this.txtSTID.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txtSTID.CustomButton.Name = "";
            this.txtSTID.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSTID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSTID.CustomButton.TabIndex = 1;
            this.txtSTID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSTID.CustomButton.UseSelectable = true;
            this.txtSTID.CustomButton.Visible = false;
            this.txtSTID.Lines = new string[0];
            this.txtSTID.Location = new System.Drawing.Point(133, 186);
            this.txtSTID.MaxLength = 32767;
            this.txtSTID.Name = "txtSTID";
            this.txtSTID.PasswordChar = '\0';
            this.txtSTID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSTID.SelectedText = "";
            this.txtSTID.SelectionLength = 0;
            this.txtSTID.SelectionStart = 0;
            this.txtSTID.ShortcutsEnabled = true;
            this.txtSTID.Size = new System.Drawing.Size(244, 29);
            this.txtSTID.TabIndex = 55;
            this.txtSTID.UseSelectable = true;
            this.txtSTID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSTID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSTID.TextChanged += new System.EventHandler(this.txtSTID_TextChanged);
            this.txtSTID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSTID_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(56, 188);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 54;
            this.metroLabel1.Text = "Search ID :";
            // 
            // txtStudName
            // 
            // 
            // 
            // 
            this.txtStudName.CustomButton.Image = null;
            this.txtStudName.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txtStudName.CustomButton.Name = "";
            this.txtStudName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtStudName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStudName.CustomButton.TabIndex = 1;
            this.txtStudName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStudName.CustomButton.UseSelectable = true;
            this.txtStudName.CustomButton.Visible = false;
            this.txtStudName.Enabled = false;
            this.txtStudName.Lines = new string[0];
            this.txtStudName.Location = new System.Drawing.Point(133, 224);
            this.txtStudName.MaxLength = 32767;
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.PasswordChar = '\0';
            this.txtStudName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudName.SelectedText = "";
            this.txtStudName.SelectionLength = 0;
            this.txtStudName.SelectionStart = 0;
            this.txtStudName.ShortcutsEnabled = true;
            this.txtStudName.Size = new System.Drawing.Size(244, 29);
            this.txtStudName.TabIndex = 57;
            this.txtStudName.UseSelectable = true;
            this.txtStudName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 225);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 19);
            this.metroLabel2.TabIndex = 56;
            this.metroLabel2.Text = "Student Name :";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ItemHeight = 23;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending ",
            "Processed"});
            this.cmbStatus.Location = new System.Drawing.Point(133, 262);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(244, 29);
            this.cmbStatus.TabIndex = 58;
            this.cmbStatus.UseSelectable = true;
            this.cmbStatus.Leave += new System.EventHandler(this.cmbStatus_Leave);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(33, 264);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 19);
            this.metroLabel3.TabIndex = 59;
            this.metroLabel3.Text = "Inquiry Status :";
            // 
            // txtInqAnswer
            // 
            // 
            // 
            // 
            this.txtInqAnswer.CustomButton.Image = null;
            this.txtInqAnswer.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtInqAnswer.CustomButton.Name = "";
            this.txtInqAnswer.CustomButton.Size = new System.Drawing.Size(67, 67);
            this.txtInqAnswer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInqAnswer.CustomButton.TabIndex = 1;
            this.txtInqAnswer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInqAnswer.CustomButton.UseSelectable = true;
            this.txtInqAnswer.CustomButton.Visible = false;
            this.txtInqAnswer.Lines = new string[0];
            this.txtInqAnswer.Location = new System.Drawing.Point(133, 302);
            this.txtInqAnswer.MaxLength = 32767;
            this.txtInqAnswer.Multiline = true;
            this.txtInqAnswer.Name = "txtInqAnswer";
            this.txtInqAnswer.PasswordChar = '\0';
            this.txtInqAnswer.ReadOnly = true;
            this.txtInqAnswer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInqAnswer.SelectedText = "";
            this.txtInqAnswer.SelectionLength = 0;
            this.txtInqAnswer.SelectionStart = 0;
            this.txtInqAnswer.ShortcutsEnabled = true;
            this.txtInqAnswer.Size = new System.Drawing.Size(244, 69);
            this.txtInqAnswer.TabIndex = 61;
            this.txtInqAnswer.UseSelectable = true;
            this.txtInqAnswer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInqAnswer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInqAnswer.TextChanged += new System.EventHandler(this.txtInqAnswer_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(25, 302);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(102, 19);
            this.metroLabel4.TabIndex = 60;
            this.metroLabel4.Text = "Inquiry Answer :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(40, 78);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(87, 19);
            this.metroLabel5.TabIndex = 62;
            this.metroLabel5.Text = "Inquiry Type :";
            // 
            // cmbInqType
            // 
            this.cmbInqType.FormattingEnabled = true;
            this.cmbInqType.ItemHeight = 23;
            this.cmbInqType.Items.AddRange(new object[] {
            "Announcement And Events",
            "Concern"});
            this.cmbInqType.Location = new System.Drawing.Point(133, 78);
            this.cmbInqType.Name = "cmbInqType";
            this.cmbInqType.Size = new System.Drawing.Size(244, 29);
            this.cmbInqType.TabIndex = 63;
            this.cmbInqType.UseSelectable = true;
            // 
            // AddInquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 411);
            this.Controls.Add(this.cmbInqType);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtInqAnswer);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtStudName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtSTID);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInqSearch);
            this.Controls.Add(this.metroLabel26);
            this.Controls.Add(this.dgvInquiry);
            this.Controls.Add(this.txtInqDesc);
            this.Controls.Add(this.metroLabel20);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddInquiryForm";
            this.Text = "Inquiry Form";
            this.Load += new System.EventHandler(this.AddInquiryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquiry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtInqDesc;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroTextBox txtInqSearch;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroGrid dgvInquiry;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroTextBox txtSTID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtStudName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbStatus;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtInqAnswer;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cmbInqType;
    }
}