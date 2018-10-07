namespace ANSIS_V3
{
    partial class PaymentReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentReceipt));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lblChange = new MetroFramework.Controls.MetroLabel();
            this.lblCOH = new MetroFramework.Controls.MetroLabel();
            this.lblAmnt = new MetroFramework.Controls.MetroLabel();
            this.lblSpaytype = new MetroFramework.Controls.MetroLabel();
            this.lblSname = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblStudID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(40, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Student Name:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(39, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Payment Type:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(39, 151);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Amount";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(39, 179);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(97, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Cash on hand:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(40, 212);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Change:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(311, 25);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(41, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Date:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(463, 344);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblStudID);
            this.panel1.Controls.Add(this.metroLabel10);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.metroLabel8);
            this.panel1.Controls.Add(this.lblChange);
            this.panel1.Controls.Add(this.lblCOH);
            this.panel1.Controls.Add(this.lblAmnt);
            this.panel1.Controls.Add(this.lblSpaytype);
            this.panel1.Controls.Add(this.lblSname);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Location = new System.Drawing.Point(23, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 271);
            this.panel1.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDate.Location = new System.Drawing.Point(358, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 19);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(191, 240);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(160, 19);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "Abellana National School";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblChange.Location = new System.Drawing.Point(139, 212);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(98, 19);
            this.lblChange.TabIndex = 10;
            this.lblChange.Text = "Student name:";
            // 
            // lblCOH
            // 
            this.lblCOH.AutoSize = true;
            this.lblCOH.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCOH.Location = new System.Drawing.Point(139, 179);
            this.lblCOH.Name = "lblCOH";
            this.lblCOH.Size = new System.Drawing.Size(98, 19);
            this.lblCOH.TabIndex = 9;
            this.lblCOH.Text = "Student name:";
            // 
            // lblAmnt
            // 
            this.lblAmnt.AutoSize = true;
            this.lblAmnt.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAmnt.Location = new System.Drawing.Point(139, 151);
            this.lblAmnt.Name = "lblAmnt";
            this.lblAmnt.Size = new System.Drawing.Size(98, 19);
            this.lblAmnt.TabIndex = 8;
            this.lblAmnt.Text = "Student name:";
            // 
            // lblSpaytype
            // 
            this.lblSpaytype.AutoSize = true;
            this.lblSpaytype.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSpaytype.Location = new System.Drawing.Point(139, 120);
            this.lblSpaytype.Name = "lblSpaytype";
            this.lblSpaytype.Size = new System.Drawing.Size(98, 19);
            this.lblSpaytype.TabIndex = 7;
            this.lblSpaytype.Text = "Student name:";
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSname.Location = new System.Drawing.Point(139, 95);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(78, 19);
            this.lblSname.TabIndex = 6;
            this.lblSname.Text = "Student ID:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(57, 25);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(156, 25);
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "Payment Receipt";
            // 
            // lblStudID
            // 
            this.lblStudID.AutoSize = true;
            this.lblStudID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblStudID.Location = new System.Drawing.Point(139, 76);
            this.lblStudID.Name = "lblStudID";
            this.lblStudID.Size = new System.Drawing.Size(78, 19);
            this.lblStudID.TabIndex = 14;
            this.lblStudID.Text = "Student ID:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(40, 76);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(78, 19);
            this.metroLabel10.TabIndex = 13;
            this.metroLabel10.Text = "Student ID:";
            // 
            // PaymentReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 378);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrint);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentReceipt";
            this.Resizable = false;
            this.Text = "Payment Receipt";
            this.Load += new System.EventHandler(this.PaymentReceipt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private MetroFramework.Controls.MetroButton btnPrint;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lblChange;
        private MetroFramework.Controls.MetroLabel lblCOH;
        private MetroFramework.Controls.MetroLabel lblAmnt;
        private MetroFramework.Controls.MetroLabel lblSpaytype;
        private MetroFramework.Controls.MetroLabel lblSname;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroLabel lblStudID;
        private MetroFramework.Controls.MetroLabel metroLabel10;
    }
}