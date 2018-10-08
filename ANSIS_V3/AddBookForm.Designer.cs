namespace ANSIS_V3
{
    partial class AddBookForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.mtpCoplimentBooks = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtBookQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.dtpBookPublished = new MetroFramework.Controls.MetroDateTime();
            this.txtCompBookSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.dgvCompBook = new MetroFramework.Controls.MetroGrid();
            this.btnCompBookClear = new MetroFramework.Controls.MetroButton();
            this.btnCompBookAdd = new MetroFramework.Controls.MetroButton();
            this.cmbYearLevel = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.txtBookAuthor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.txtBookname = new MetroFramework.Controls.MetroTextBox();
            this.txtBookDescrip = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.mtpProcessBook = new MetroFramework.Controls.MetroTabPage();
            this.txtProcBookDistributer = new MetroFramework.Controls.MetroTextBox();
            this.txtProcessSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dgvProcessBook = new MetroFramework.Controls.MetroGrid();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtProBookYearLevel = new MetroFramework.Controls.MetroTextBox();
            this.btnProcBookCLear = new MetroFramework.Controls.MetroButton();
            this.btnProBookRelease = new MetroFramework.Controls.MetroButton();
            this.cmbProBookAvail = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtProBookStudID = new MetroFramework.Controls.MetroTextBox();
            this.txtProBookStudname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.mtpCoplimentBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompBook)).BeginInit();
            this.mtpProcessBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessBook)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.mtpCoplimentBooks);
            this.metroTabControl1.Controls.Add(this.mtpProcessBook);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(988, 393);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTabControl1_MouseClick);
            // 
            // mtpCoplimentBooks
            // 
            this.mtpCoplimentBooks.Controls.Add(this.metroLabel6);
            this.mtpCoplimentBooks.Controls.Add(this.txtBookQuantity);
            this.mtpCoplimentBooks.Controls.Add(this.metroLabel8);
            this.mtpCoplimentBooks.Controls.Add(this.dtpBookPublished);
            this.mtpCoplimentBooks.Controls.Add(this.txtCompBookSearch);
            this.mtpCoplimentBooks.Controls.Add(this.metroLabel26);
            this.mtpCoplimentBooks.Controls.Add(this.dgvCompBook);
            this.mtpCoplimentBooks.Controls.Add(this.btnCompBookClear);
            this.mtpCoplimentBooks.Controls.Add(this.btnCompBookAdd);
            this.mtpCoplimentBooks.Controls.Add(this.cmbYearLevel);
            this.mtpCoplimentBooks.Controls.Add(this.metroLabel27);
            this.mtpCoplimentBooks.Controls.Add(this.txtBookAuthor);
            this.mtpCoplimentBooks.Controls.Add(this.metroLabel25);
            this.mtpCoplimentBooks.Controls.Add(this.txtBookname);
            this.mtpCoplimentBooks.Controls.Add(this.txtBookDescrip);
            this.mtpCoplimentBooks.Controls.Add(this.metroLabel24);
            this.mtpCoplimentBooks.Controls.Add(this.metroLabel20);
            this.mtpCoplimentBooks.HorizontalScrollbarBarColor = true;
            this.mtpCoplimentBooks.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpCoplimentBooks.HorizontalScrollbarSize = 10;
            this.mtpCoplimentBooks.Location = new System.Drawing.Point(4, 38);
            this.mtpCoplimentBooks.Name = "mtpCoplimentBooks";
            this.mtpCoplimentBooks.Size = new System.Drawing.Size(980, 351);
            this.mtpCoplimentBooks.TabIndex = 0;
            this.mtpCoplimentBooks.Text = "Complimentary Books";
            this.mtpCoplimentBooks.VerticalScrollbarBarColor = true;
            this.mtpCoplimentBooks.VerticalScrollbarHighlightOnWheel = false;
            this.mtpCoplimentBooks.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.Location = new System.Drawing.Point(22, 253);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(99, 19);
            this.metroLabel6.TabIndex = 68;
            this.metroLabel6.Text = "Book Quantity :";
            // 
            // txtBookQuantity
            // 
            // 
            // 
            // 
            this.txtBookQuantity.CustomButton.Image = null;
            this.txtBookQuantity.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtBookQuantity.CustomButton.Name = "";
            this.txtBookQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBookQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookQuantity.CustomButton.TabIndex = 1;
            this.txtBookQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookQuantity.CustomButton.UseSelectable = true;
            this.txtBookQuantity.CustomButton.Visible = false;
            this.txtBookQuantity.Lines = new string[0];
            this.txtBookQuantity.Location = new System.Drawing.Point(124, 253);
            this.txtBookQuantity.MaxLength = 32767;
            this.txtBookQuantity.Name = "txtBookQuantity";
            this.txtBookQuantity.PasswordChar = '\0';
            this.txtBookQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookQuantity.SelectedText = "";
            this.txtBookQuantity.SelectionLength = 0;
            this.txtBookQuantity.SelectionStart = 0;
            this.txtBookQuantity.ShortcutsEnabled = true;
            this.txtBookQuantity.Size = new System.Drawing.Size(191, 23);
            this.txtBookQuantity.TabIndex = 67;
            this.txtBookQuantity.UseSelectable = true;
            this.txtBookQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.Location = new System.Drawing.Point(15, 219);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(106, 19);
            this.metroLabel8.TabIndex = 66;
            this.metroLabel8.Text = "Book Published :";
            this.metroLabel8.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // dtpBookPublished
            // 
            this.dtpBookPublished.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookPublished.Location = new System.Drawing.Point(124, 215);
            this.dtpBookPublished.MinimumSize = new System.Drawing.Size(4, 29);
            this.dtpBookPublished.Name = "dtpBookPublished";
            this.dtpBookPublished.Size = new System.Drawing.Size(191, 29);
            this.dtpBookPublished.TabIndex = 65;
            // 
            // txtCompBookSearch
            // 
            // 
            // 
            // 
            this.txtCompBookSearch.CustomButton.Image = null;
            this.txtCompBookSearch.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtCompBookSearch.CustomButton.Name = "";
            this.txtCompBookSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCompBookSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCompBookSearch.CustomButton.TabIndex = 1;
            this.txtCompBookSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCompBookSearch.CustomButton.UseSelectable = true;
            this.txtCompBookSearch.CustomButton.Visible = false;
            this.txtCompBookSearch.Lines = new string[0];
            this.txtCompBookSearch.Location = new System.Drawing.Point(806, 17);
            this.txtCompBookSearch.MaxLength = 32767;
            this.txtCompBookSearch.Name = "txtCompBookSearch";
            this.txtCompBookSearch.PasswordChar = '\0';
            this.txtCompBookSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCompBookSearch.SelectedText = "";
            this.txtCompBookSearch.SelectionLength = 0;
            this.txtCompBookSearch.SelectionStart = 0;
            this.txtCompBookSearch.ShortcutsEnabled = true;
            this.txtCompBookSearch.Size = new System.Drawing.Size(171, 23);
            this.txtCompBookSearch.TabIndex = 63;
            this.txtCompBookSearch.UseSelectable = true;
            this.txtCompBookSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCompBookSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCompBookSearch.TextChanged += new System.EventHandler(this.txtCompBookSearch_TextChanged);
            this.txtCompBookSearch.Click += new System.EventHandler(this.txtCompBookSearch_Click);
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(748, 19);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(55, 19);
            this.metroLabel26.TabIndex = 62;
            this.metroLabel26.Text = "Search :";
            // 
            // dgvCompBook
            // 
            this.dgvCompBook.AllowUserToAddRows = false;
            this.dgvCompBook.AllowUserToDeleteRows = false;
            this.dgvCompBook.AllowUserToResizeColumns = false;
            this.dgvCompBook.AllowUserToResizeRows = false;
            this.dgvCompBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCompBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCompBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompBook.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompBook.EnableHeadersVisualStyles = false;
            this.dgvCompBook.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCompBook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCompBook.Location = new System.Drawing.Point(334, 46);
            this.dgvCompBook.Name = "dgvCompBook";
            this.dgvCompBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCompBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCompBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompBook.Size = new System.Drawing.Size(643, 278);
            this.dgvCompBook.TabIndex = 61;
            this.dgvCompBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompBook_CellClick);
            // 
            // btnCompBookClear
            // 
            this.btnCompBookClear.Location = new System.Drawing.Point(265, 282);
            this.btnCompBookClear.Name = "btnCompBookClear";
            this.btnCompBookClear.Size = new System.Drawing.Size(50, 25);
            this.btnCompBookClear.TabIndex = 60;
            this.btnCompBookClear.Text = "Clear";
            this.btnCompBookClear.UseSelectable = true;
            this.btnCompBookClear.Click += new System.EventHandler(this.btnCompBookClear_Click);
            // 
            // btnCompBookAdd
            // 
            this.btnCompBookAdd.Location = new System.Drawing.Point(209, 282);
            this.btnCompBookAdd.Name = "btnCompBookAdd";
            this.btnCompBookAdd.Size = new System.Drawing.Size(50, 25);
            this.btnCompBookAdd.TabIndex = 59;
            this.btnCompBookAdd.Text = "Add";
            this.btnCompBookAdd.UseSelectable = true;
            this.btnCompBookAdd.Click += new System.EventHandler(this.btnCompBookAdd_Click);
            // 
            // cmbYearLevel
            // 
            this.cmbYearLevel.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbYearLevel.FormattingEnabled = true;
            this.cmbYearLevel.ItemHeight = 19;
            this.cmbYearLevel.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.cmbYearLevel.Location = new System.Drawing.Point(124, 150);
            this.cmbYearLevel.Name = "cmbYearLevel";
            this.cmbYearLevel.Size = new System.Drawing.Size(191, 25);
            this.cmbYearLevel.TabIndex = 58;
            this.cmbYearLevel.UseSelectable = true;
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel27.Location = new System.Drawing.Point(31, 184);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(90, 19);
            this.metroLabel27.TabIndex = 57;
            this.metroLabel27.Text = "Book Author :";
            // 
            // txtBookAuthor
            // 
            // 
            // 
            // 
            this.txtBookAuthor.CustomButton.Image = null;
            this.txtBookAuthor.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtBookAuthor.CustomButton.Name = "";
            this.txtBookAuthor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBookAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookAuthor.CustomButton.TabIndex = 1;
            this.txtBookAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookAuthor.CustomButton.UseSelectable = true;
            this.txtBookAuthor.CustomButton.Visible = false;
            this.txtBookAuthor.Lines = new string[0];
            this.txtBookAuthor.Location = new System.Drawing.Point(124, 183);
            this.txtBookAuthor.MaxLength = 32767;
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.PasswordChar = '\0';
            this.txtBookAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookAuthor.SelectedText = "";
            this.txtBookAuthor.SelectionLength = 0;
            this.txtBookAuthor.SelectionStart = 0;
            this.txtBookAuthor.ShortcutsEnabled = true;
            this.txtBookAuthor.Size = new System.Drawing.Size(191, 23);
            this.txtBookAuthor.TabIndex = 56;
            this.txtBookAuthor.UseSelectable = true;
            this.txtBookAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.Location = new System.Drawing.Point(47, 150);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(74, 19);
            this.metroLabel25.TabIndex = 55;
            this.metroLabel25.Text = "Year Level :";
            // 
            // txtBookname
            // 
            // 
            // 
            // 
            this.txtBookname.CustomButton.Image = null;
            this.txtBookname.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtBookname.CustomButton.Name = "";
            this.txtBookname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBookname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookname.CustomButton.TabIndex = 1;
            this.txtBookname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookname.CustomButton.UseSelectable = true;
            this.txtBookname.CustomButton.Visible = false;
            this.txtBookname.Lines = new string[0];
            this.txtBookname.Location = new System.Drawing.Point(124, 46);
            this.txtBookname.MaxLength = 32767;
            this.txtBookname.Name = "txtBookname";
            this.txtBookname.PasswordChar = '\0';
            this.txtBookname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookname.SelectedText = "";
            this.txtBookname.SelectionLength = 0;
            this.txtBookname.SelectionStart = 0;
            this.txtBookname.ShortcutsEnabled = true;
            this.txtBookname.Size = new System.Drawing.Size(191, 23);
            this.txtBookname.TabIndex = 52;
            this.txtBookname.UseSelectable = true;
            this.txtBookname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBookDescrip
            // 
            // 
            // 
            // 
            this.txtBookDescrip.CustomButton.Image = null;
            this.txtBookDescrip.CustomButton.Location = new System.Drawing.Point(127, 2);
            this.txtBookDescrip.CustomButton.Name = "";
            this.txtBookDescrip.CustomButton.Size = new System.Drawing.Size(61, 61);
            this.txtBookDescrip.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookDescrip.CustomButton.TabIndex = 1;
            this.txtBookDescrip.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookDescrip.CustomButton.UseSelectable = true;
            this.txtBookDescrip.CustomButton.Visible = false;
            this.txtBookDescrip.Lines = new string[0];
            this.txtBookDescrip.Location = new System.Drawing.Point(124, 78);
            this.txtBookDescrip.MaxLength = 32767;
            this.txtBookDescrip.Multiline = true;
            this.txtBookDescrip.Name = "txtBookDescrip";
            this.txtBookDescrip.PasswordChar = '\0';
            this.txtBookDescrip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookDescrip.SelectedText = "";
            this.txtBookDescrip.SelectionLength = 0;
            this.txtBookDescrip.SelectionStart = 0;
            this.txtBookDescrip.ShortcutsEnabled = true;
            this.txtBookDescrip.Size = new System.Drawing.Size(191, 66);
            this.txtBookDescrip.TabIndex = 54;
            this.txtBookDescrip.UseSelectable = true;
            this.txtBookDescrip.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookDescrip.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.Location = new System.Drawing.Point(38, 47);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(83, 19);
            this.metroLabel24.TabIndex = 51;
            this.metroLabel24.Text = "Book name :";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(7, 80);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(114, 19);
            this.metroLabel20.TabIndex = 53;
            this.metroLabel20.Text = "Book description :";
            // 
            // mtpProcessBook
            // 
            this.mtpProcessBook.Controls.Add(this.txtProcBookDistributer);
            this.mtpProcessBook.Controls.Add(this.txtProcessSearch);
            this.mtpProcessBook.Controls.Add(this.metroLabel7);
            this.mtpProcessBook.Controls.Add(this.dgvProcessBook);
            this.mtpProcessBook.Controls.Add(this.metroLabel5);
            this.mtpProcessBook.Controls.Add(this.txtProBookYearLevel);
            this.mtpProcessBook.Controls.Add(this.btnProcBookCLear);
            this.mtpProcessBook.Controls.Add(this.btnProBookRelease);
            this.mtpProcessBook.Controls.Add(this.cmbProBookAvail);
            this.mtpProcessBook.Controls.Add(this.metroLabel1);
            this.mtpProcessBook.Controls.Add(this.metroLabel2);
            this.mtpProcessBook.Controls.Add(this.txtProBookStudID);
            this.mtpProcessBook.Controls.Add(this.txtProBookStudname);
            this.mtpProcessBook.Controls.Add(this.metroLabel3);
            this.mtpProcessBook.Controls.Add(this.metroLabel4);
            this.mtpProcessBook.HorizontalScrollbarBarColor = true;
            this.mtpProcessBook.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpProcessBook.HorizontalScrollbarSize = 10;
            this.mtpProcessBook.Location = new System.Drawing.Point(4, 38);
            this.mtpProcessBook.Name = "mtpProcessBook";
            this.mtpProcessBook.Size = new System.Drawing.Size(980, 351);
            this.mtpProcessBook.TabIndex = 1;
            this.mtpProcessBook.Text = "Process Books";
            this.mtpProcessBook.VerticalScrollbarBarColor = true;
            this.mtpProcessBook.VerticalScrollbarHighlightOnWheel = false;
            this.mtpProcessBook.VerticalScrollbarSize = 10;
            this.mtpProcessBook.Click += new System.EventHandler(this.mtpProcessBook_Click);
            this.mtpProcessBook.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtpProcessBook_MouseClick);
            // 
            // txtProcBookDistributer
            // 
            // 
            // 
            // 
            this.txtProcBookDistributer.CustomButton.Image = null;
            this.txtProcBookDistributer.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtProcBookDistributer.CustomButton.Name = "";
            this.txtProcBookDistributer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProcBookDistributer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProcBookDistributer.CustomButton.TabIndex = 1;
            this.txtProcBookDistributer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProcBookDistributer.CustomButton.UseSelectable = true;
            this.txtProcBookDistributer.CustomButton.Visible = false;
            this.txtProcBookDistributer.Enabled = false;
            this.txtProcBookDistributer.Lines = new string[0];
            this.txtProcBookDistributer.Location = new System.Drawing.Point(125, 195);
            this.txtProcBookDistributer.MaxLength = 32767;
            this.txtProcBookDistributer.Name = "txtProcBookDistributer";
            this.txtProcBookDistributer.PasswordChar = '\0';
            this.txtProcBookDistributer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProcBookDistributer.SelectedText = "";
            this.txtProcBookDistributer.SelectionLength = 0;
            this.txtProcBookDistributer.SelectionStart = 0;
            this.txtProcBookDistributer.ShortcutsEnabled = true;
            this.txtProcBookDistributer.Size = new System.Drawing.Size(191, 23);
            this.txtProcBookDistributer.TabIndex = 78;
            this.txtProcBookDistributer.UseSelectable = true;
            this.txtProcBookDistributer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProcBookDistributer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProcessSearch
            // 
            // 
            // 
            // 
            this.txtProcessSearch.CustomButton.Image = null;
            this.txtProcessSearch.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtProcessSearch.CustomButton.Name = "";
            this.txtProcessSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProcessSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProcessSearch.CustomButton.TabIndex = 1;
            this.txtProcessSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProcessSearch.CustomButton.UseSelectable = true;
            this.txtProcessSearch.CustomButton.Visible = false;
            this.txtProcessSearch.Lines = new string[0];
            this.txtProcessSearch.Location = new System.Drawing.Point(798, 29);
            this.txtProcessSearch.MaxLength = 32767;
            this.txtProcessSearch.Name = "txtProcessSearch";
            this.txtProcessSearch.PasswordChar = '\0';
            this.txtProcessSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProcessSearch.SelectedText = "";
            this.txtProcessSearch.SelectionLength = 0;
            this.txtProcessSearch.SelectionStart = 0;
            this.txtProcessSearch.ShortcutsEnabled = true;
            this.txtProcessSearch.Size = new System.Drawing.Size(163, 23);
            this.txtProcessSearch.TabIndex = 77;
            this.txtProcessSearch.UseSelectable = true;
            this.txtProcessSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProcessSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProcessSearch.TextChanged += new System.EventHandler(this.txtProcessSearch_TextChanged);
            this.txtProcessSearch.Click += new System.EventHandler(this.txtProcessSearch_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(740, 31);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(55, 19);
            this.metroLabel7.TabIndex = 76;
            this.metroLabel7.Text = "Search :";
            // 
            // dgvProcessBook
            // 
            this.dgvProcessBook.AllowUserToResizeRows = false;
            this.dgvProcessBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProcessBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProcessBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProcessBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcessBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProcessBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProcessBook.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProcessBook.EnableHeadersVisualStyles = false;
            this.dgvProcessBook.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProcessBook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProcessBook.Location = new System.Drawing.Point(339, 58);
            this.dgvProcessBook.Name = "dgvProcessBook";
            this.dgvProcessBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcessBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProcessBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProcessBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcessBook.Size = new System.Drawing.Size(622, 188);
            this.dgvProcessBook.TabIndex = 75;
            this.dgvProcessBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcessBook_CellClick);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(11, 164);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(108, 19);
            this.metroLabel5.TabIndex = 72;
            this.metroLabel5.Text = "Books Available :";
            // 
            // txtProBookYearLevel
            // 
            // 
            // 
            // 
            this.txtProBookYearLevel.CustomButton.Image = null;
            this.txtProBookYearLevel.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtProBookYearLevel.CustomButton.Name = "";
            this.txtProBookYearLevel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProBookYearLevel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProBookYearLevel.CustomButton.TabIndex = 1;
            this.txtProBookYearLevel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProBookYearLevel.CustomButton.UseSelectable = true;
            this.txtProBookYearLevel.CustomButton.Visible = false;
            this.txtProBookYearLevel.Enabled = false;
            this.txtProBookYearLevel.Lines = new string[0];
            this.txtProBookYearLevel.Location = new System.Drawing.Point(125, 126);
            this.txtProBookYearLevel.MaxLength = 32767;
            this.txtProBookYearLevel.Name = "txtProBookYearLevel";
            this.txtProBookYearLevel.PasswordChar = '\0';
            this.txtProBookYearLevel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProBookYearLevel.SelectedText = "";
            this.txtProBookYearLevel.SelectionLength = 0;
            this.txtProBookYearLevel.SelectionStart = 0;
            this.txtProBookYearLevel.ShortcutsEnabled = true;
            this.txtProBookYearLevel.Size = new System.Drawing.Size(191, 23);
            this.txtProBookYearLevel.TabIndex = 71;
            this.txtProBookYearLevel.UseSelectable = true;
            this.txtProBookYearLevel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProBookYearLevel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProBookYearLevel.TextChanged += new System.EventHandler(this.mtxtYearLevel_TextChanged);
            // 
            // btnProcBookCLear
            // 
            this.btnProcBookCLear.Location = new System.Drawing.Point(262, 226);
            this.btnProcBookCLear.Name = "btnProcBookCLear";
            this.btnProcBookCLear.Size = new System.Drawing.Size(54, 25);
            this.btnProcBookCLear.TabIndex = 70;
            this.btnProcBookCLear.Text = "Clear";
            this.btnProcBookCLear.UseSelectable = true;
            this.btnProcBookCLear.Click += new System.EventHandler(this.btnProcesBookCLear_Click);
            // 
            // btnProBookRelease
            // 
            this.btnProBookRelease.Location = new System.Drawing.Point(191, 226);
            this.btnProBookRelease.Name = "btnProBookRelease";
            this.btnProBookRelease.Size = new System.Drawing.Size(65, 25);
            this.btnProBookRelease.TabIndex = 69;
            this.btnProBookRelease.Text = "Release";
            this.btnProBookRelease.UseSelectable = true;
            this.btnProBookRelease.Click += new System.EventHandler(this.btnProcesBookRelease_Click);
            // 
            // cmbProBookAvail
            // 
            this.cmbProBookAvail.Enabled = false;
            this.cmbProBookAvail.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbProBookAvail.FormattingEnabled = true;
            this.cmbProBookAvail.ItemHeight = 19;
            this.cmbProBookAvail.Location = new System.Drawing.Point(125, 161);
            this.cmbProBookAvail.Name = "cmbProBookAvail";
            this.cmbProBookAvail.Size = new System.Drawing.Size(191, 25);
            this.cmbProBookAvail.TabIndex = 68;
            this.cmbProBookAvail.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(43, 199);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 67;
            this.metroLabel1.Text = "Distributer :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(45, 128);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 65;
            this.metroLabel2.Text = "Year Level :";
            // 
            // txtProBookStudID
            // 
            // 
            // 
            // 
            this.txtProBookStudID.CustomButton.Image = null;
            this.txtProBookStudID.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtProBookStudID.CustomButton.Name = "";
            this.txtProBookStudID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProBookStudID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProBookStudID.CustomButton.TabIndex = 1;
            this.txtProBookStudID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProBookStudID.CustomButton.UseSelectable = true;
            this.txtProBookStudID.CustomButton.Visible = false;
            this.txtProBookStudID.Lines = new string[0];
            this.txtProBookStudID.Location = new System.Drawing.Point(125, 58);
            this.txtProBookStudID.MaxLength = 32767;
            this.txtProBookStudID.Name = "txtProBookStudID";
            this.txtProBookStudID.PasswordChar = '\0';
            this.txtProBookStudID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProBookStudID.SelectedText = "";
            this.txtProBookStudID.SelectionLength = 0;
            this.txtProBookStudID.SelectionStart = 0;
            this.txtProBookStudID.ShortcutsEnabled = true;
            this.txtProBookStudID.Size = new System.Drawing.Size(191, 23);
            this.txtProBookStudID.TabIndex = 62;
            this.txtProBookStudID.UseSelectable = true;
            this.txtProBookStudID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProBookStudID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProBookStudID.TextChanged += new System.EventHandler(this.txtProBookStudID_TextChanged);
            this.txtProBookStudID.Click += new System.EventHandler(this.txtProBookStudID_Click);
            this.txtProBookStudID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProBookStudID_KeyPress);
            this.txtProBookStudID.Leave += new System.EventHandler(this.btnCompBookAdd_Click);
            // 
            // txtProBookStudname
            // 
            // 
            // 
            // 
            this.txtProBookStudname.CustomButton.Image = null;
            this.txtProBookStudname.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtProBookStudname.CustomButton.Name = "";
            this.txtProBookStudname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProBookStudname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProBookStudname.CustomButton.TabIndex = 1;
            this.txtProBookStudname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProBookStudname.CustomButton.UseSelectable = true;
            this.txtProBookStudname.CustomButton.Visible = false;
            this.txtProBookStudname.Enabled = false;
            this.txtProBookStudname.Lines = new string[0];
            this.txtProBookStudname.Location = new System.Drawing.Point(125, 92);
            this.txtProBookStudname.MaxLength = 32767;
            this.txtProBookStudname.Name = "txtProBookStudname";
            this.txtProBookStudname.PasswordChar = '\0';
            this.txtProBookStudname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProBookStudname.SelectedText = "";
            this.txtProBookStudname.SelectionLength = 0;
            this.txtProBookStudname.SelectionStart = 0;
            this.txtProBookStudname.ShortcutsEnabled = true;
            this.txtProBookStudname.Size = new System.Drawing.Size(191, 23);
            this.txtProBookStudname.TabIndex = 64;
            this.txtProBookStudname.UseSelectable = true;
            this.txtProBookStudname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProBookStudname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(5, 59);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(114, 19);
            this.metroLabel3.TabIndex = 61;
            this.metroLabel3.Text = "Seach Student ID :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(22, 93);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(97, 19);
            this.metroLabel4.TabIndex = 63;
            this.metroLabel4.Text = "Student name :";
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 473);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBookForm";
            this.Text = "Book Management Form";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.mtpCoplimentBooks.ResumeLayout(false);
            this.mtpCoplimentBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompBook)).EndInit();
            this.mtpProcessBook.ResumeLayout(false);
            this.mtpProcessBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage mtpCoplimentBooks;
        private MetroFramework.Controls.MetroTextBox txtCompBookSearch;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroGrid dgvCompBook;
        private MetroFramework.Controls.MetroButton btnCompBookClear;
        private MetroFramework.Controls.MetroButton btnCompBookAdd;
        private MetroFramework.Controls.MetroComboBox cmbYearLevel;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroTextBox txtBookAuthor;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroTextBox txtBookname;
        private MetroFramework.Controls.MetroTextBox txtBookDescrip;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroTabPage mtpProcessBook;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtProBookYearLevel;
        private MetroFramework.Controls.MetroButton btnProcBookCLear;
        private MetroFramework.Controls.MetroButton btnProBookRelease;
        private MetroFramework.Controls.MetroComboBox cmbProBookAvail;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtProBookStudID;
        private MetroFramework.Controls.MetroTextBox txtProBookStudname;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtProcessSearch;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroGrid dgvProcessBook;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroDateTime dtpBookPublished;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtBookQuantity;
        public MetroFramework.Controls.MetroTextBox txtProcBookDistributer;

    }
}