namespace ANSIS_V3
{
	partial class ManageSchoolyear
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
			this.txtSchoolyear = new MetroFramework.Controls.MetroTextBox();
			this.btnAdd = new MetroFramework.Controls.MetroButton();
			this.btnClear = new MetroFramework.Controls.MetroButton();
			this.dgvSchoolyear = new MetroFramework.Controls.MetroGrid();
			((System.ComponentModel.ISupportInitialize)(this.dgvSchoolyear)).BeginInit();
			this.SuspendLayout();
			// 
			// txtSchoolyear
			// 
			// 
			// 
			// 
			this.txtSchoolyear.CustomButton.Image = null;
			this.txtSchoolyear.CustomButton.Location = new System.Drawing.Point(207, 1);
			this.txtSchoolyear.CustomButton.Name = "";
			this.txtSchoolyear.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtSchoolyear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtSchoolyear.CustomButton.TabIndex = 1;
			this.txtSchoolyear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtSchoolyear.CustomButton.UseSelectable = true;
			this.txtSchoolyear.CustomButton.Visible = false;
			this.txtSchoolyear.Lines = new string[0];
			this.txtSchoolyear.Location = new System.Drawing.Point(40, 72);
			this.txtSchoolyear.MaxLength = 32767;
			this.txtSchoolyear.Name = "txtSchoolyear";
			this.txtSchoolyear.PasswordChar = '\0';
			this.txtSchoolyear.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtSchoolyear.SelectedText = "";
			this.txtSchoolyear.SelectionLength = 0;
			this.txtSchoolyear.SelectionStart = 0;
			this.txtSchoolyear.ShortcutsEnabled = true;
			this.txtSchoolyear.Size = new System.Drawing.Size(229, 23);
			this.txtSchoolyear.TabIndex = 0;
			this.txtSchoolyear.UseSelectable = true;
			this.txtSchoolyear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtSchoolyear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(275, 72);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseSelectable = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(356, 72);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 2;
			this.btnClear.Text = "Clear";
			this.btnClear.UseSelectable = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// dgvSchoolyear
			// 
			this.dgvSchoolyear.AllowUserToAddRows = false;
			this.dgvSchoolyear.AllowUserToDeleteRows = false;
			this.dgvSchoolyear.AllowUserToResizeRows = false;
			this.dgvSchoolyear.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSchoolyear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvSchoolyear.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSchoolyear.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvSchoolyear.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSchoolyear.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSchoolyear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSchoolyear.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvSchoolyear.EnableHeadersVisualStyles = false;
			this.dgvSchoolyear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgvSchoolyear.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvSchoolyear.Location = new System.Drawing.Point(42, 117);
			this.dgvSchoolyear.Name = "dgvSchoolyear";
			this.dgvSchoolyear.ReadOnly = true;
			this.dgvSchoolyear.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSchoolyear.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvSchoolyear.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvSchoolyear.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSchoolyear.Size = new System.Drawing.Size(389, 219);
			this.dgvSchoolyear.TabIndex = 3;
			this.dgvSchoolyear.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchoolyear_CellClick);
			// 
			// ManageSchoolyear
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 360);
			this.Controls.Add(this.dgvSchoolyear);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtSchoolyear);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ManageSchoolyear";
			this.Text = "Manage Schoolyear";
			this.Load += new System.EventHandler(this.ManageSchoolyear_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSchoolyear)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTextBox txtSchoolyear;
		private MetroFramework.Controls.MetroButton btnAdd;
		private MetroFramework.Controls.MetroButton btnClear;
		private MetroFramework.Controls.MetroGrid dgvSchoolyear;
	}
}