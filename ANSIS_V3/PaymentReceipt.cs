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
using System.Drawing.Printing;

namespace ANSIS_V3
{
    public partial class PaymentReceipt : MetroForm
    {
        public PaymentReceipt()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }
        string sname, patype, coh, amnt, chng,id;
        public PaymentReceipt(string studid,string studname, string paymenttype, string cashonhand, string amount, string change)
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            sname = studname;
            this.patype = paymenttype;
            coh = cashonhand;
            amnt = amount;
            chng = change;
            id = studid;
        }
        Bitmap MemoryImage;
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }
        public void Print(Panel pnl)
        {
            panel1 = pnl;
            GetPrintArea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void PaymentReceipt_Load(object sender, EventArgs e)
        {
            lblSname.Text = sname;
            lblAmnt.Text = amnt;
            lblChange.Text = chng;
            lblSpaytype.Text = patype;
            lblCOH.Text = coh;
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblStudID.Text = id;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
        }
    }
}
