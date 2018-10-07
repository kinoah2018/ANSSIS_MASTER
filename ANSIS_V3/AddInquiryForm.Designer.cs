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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCreatedBy = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.txtInqDesc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.dgvInquiry = new MetroFramework.Controls.MetroGrid();
            this.txtInquiFor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquiry)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCreatedBy
            // 
            // 
            // 
            // 
            this.txtCreatedBy.CustomButton.Image = null;
            this.txtCreatedBy.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtCreatedBy.CustomButton.Name = "";
            this.txtCreatedBy.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCreatedBy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCreatedBy.CustomButton.TabIndex = 1;
            this.txtCreatedBy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCreatedBy.CustomButton.UseSelectable = true;
            this.txtCreatedBy.CustomButton.Visible = false;
            this.txtCreatedBy.Enabled = false;
            this.txtCreatedBy.Lines = new string[] {
        "Default"};
            this.txtCreatedBy.Location = new System.Drawing.Point(133, 251);
            this.txtCreatedBy.MaxLength = 32767;
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.PasswordChar = '\0';
            this.txtCreatedBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCreatedBy.SelectedText = "";
            this.txtCreatedBy.SelectionLength = 0;
            this.txtCreatedBy.SelectionStart = 0;
            this.txtCreatedBy.ShortcutsEnabled = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(244, 23);
            this.txtCreatedBy.TabIndex = 45;
            this.txtCreatedBy.Text = "Default";
            this.txtCreatedBy.UseSelectable = true;
            this.txtCreatedBy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCreatedBy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCreatedBy.Click += new System.EventHandler(this.mtxtcapacity_Click);
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.Location = new System.Drawing.Point(46, 251);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(81, 19);
            this.metroLabel25.TabIndex = 44;
            this.metroLabel25.Text = "Created By :";
            // 
            // txtInqDesc
            // 
            // 
            // 
            // 
            this.txtInqDesc.CustomButton.Image = null;
            this.txtInqDesc.CustomButton.Location = new System.Drawing.Point(110, 2);
            this.txtInqDesc.CustomButton.Name = "";
            this.txtInqDesc.CustomButton.Size = new System.Drawing.Size(131, 131);
            this.txtInqDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInqDesc.CustomButton.TabIndex = 1;
            this.txtInqDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInqDesc.CustomButton.UseSelectable = true;
            this.txtInqDesc.CustomButton.Visible = false;
            this.txtInqDesc.Lines = new string[0];
            this.txtInqDesc.Location = new System.Drawing.Point(133, 109);
            this.txtInqDesc.MaxLength = 32767;
            this.txtInqDesc.Multiline = true;
            this.txtInqDesc.Name = "txtInqDesc";
            this.txtInqDesc.PasswordChar = '\0';
            this.txtInqDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInqDesc.SelectedText = "";
            this.txtInqDesc.SelectionLength = 0;
            this.txtInqDesc.SelectionStart = 0;
            this.txtInqDesc.ShortcutsEnabled = true;
            this.txtInqDesc.Size = new System.Drawing.Size(244, 136);
            this.txtInqDesc.TabIndex = 43;
            this.txtInqDesc.UseSelectable = true;
            this.txtInqDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInqDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(2, 123);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(125, 19);
            this.metroLabel20.TabIndex = 42;
            this.metroLabel20.Text = "Inquiry Description :";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(854, 49);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(178, 23);
            this.txtSearch.TabIndex = 50;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInquiry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInquiry.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInquiry.EnableHeadersVisualStyles = false;
            this.dgvInquiry.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvInquiry.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInquiry.Location = new System.Drawing.Point(389, 78);
            this.dgvInquiry.Name = "dgvInquiry";
            this.dgvInquiry.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInquiry.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInquiry.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInquiry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInquiry.Size = new System.Drawing.Size(643, 243);
            this.dgvInquiry.TabIndex = 48;
            this.dgvInquiry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInquiry_CellClick);
            // 
            // txtInquiFor
            // 
            // 
            // 
            // 
            this.txtInquiFor.CustomButton.Image = null;
            this.txtInquiFor.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtInquiFor.CustomButton.Name = "";
            this.txtInquiFor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInquiFor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInquiFor.CustomButton.TabIndex = 1;
            this.txtInquiFor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInquiFor.CustomButton.UseSelectable = true;
            this.txtInquiFor.CustomButton.Visible = false;
            this.txtInquiFor.Enabled = false;
            this.txtInquiFor.Lines = new string[] {
        "Announcement & Events"};
            this.txtInquiFor.Location = new System.Drawing.Point(133, 78);
            this.txtInquiFor.MaxLength = 32767;
            this.txtInquiFor.Name = "txtInquiFor";
            this.txtInquiFor.PasswordChar = '\0';
            this.txtInquiFor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInquiFor.SelectedText = "";
            this.txtInquiFor.SelectionLength = 0;
            this.txtInquiFor.SelectionStart = 0;
            this.txtInquiFor.ShortcutsEnabled = true;
            this.txtInquiFor.Size = new System.Drawing.Size(244, 23);
            this.txtInquiFor.TabIndex = 51;
            this.txtInquiFor.Text = "Announcement & Events";
            this.txtInquiFor.UseSelectable = true;
            this.txtInquiFor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInquiFor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel27.Location = new System.Drawing.Point(50, 78);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(77, 19);
            this.metroLabel27.TabIndex = 46;
            this.metroLabel27.Text = "Inquiry for :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(221, 287);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(302, 287);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddInquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 333);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInquiFor);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.metroLabel26);
            this.Controls.Add(this.dgvInquiry);
            this.Controls.Add(this.metroLabel27);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.metroLabel25);
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

        private MetroFramework.Controls.MetroTextBox txtCreatedBy;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroTextBox txtInqDesc;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroGrid dgvInquiry;
        private MetroFramework.Controls.MetroTextBox txtInquiFor;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnClear;
    }
}