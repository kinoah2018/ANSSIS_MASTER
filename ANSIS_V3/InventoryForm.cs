using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANSIS_V3
{
    public partial class mtpInventoryForm : MetroFramework.Forms.MetroForm
    {
        public mtpInventoryForm()
        {
            InitializeComponent();
        }
        DataClassDataContext db = new DataClassDataContext();
        private void InventoryForm_Load(object sender, EventArgs e)
        {
            DisplayInvent();
        }
        public void DisplayInvent()
        {
           
            var books = from b in db.Books
                        select b;
            foreach (var book in books)
            {
                var releasedBooks = from pb in db.ProcessBooks
                                    where pb.BookID == book.BookID
                                    select pb;
                var returnedBooks = from pb in db.ProcessBooks
                                    where pb.BookID == book.BookID && pb.BookReturn != null
                                    select pb;
                int quatity = book.BookQuantity - releasedBooks.Count() + returnedBooks.Count();
                dgvBookInven.Rows.Add(book.Bookname, quatity, releasedBooks.Count(), returnedBooks.Count());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //if (txtSearch.Text!="")
            //{
            //    dgvBookInven.Rows.Clear();
            //    var books = from b in db.Books
            //                select b;
            //    foreach (var book in books)
            //    {
            //        var releasedBooks = from pb in db.ProcessBooks
            //                            where pb.BookID == book.BookID || book.Bookname.Contains(txtSearch.Text)
            //                            select pb;
            //        var returnedBooks = from pb in db.ProcessBooks
            //                            where pb.BookID == book.BookID && pb.BookReturn != null
            //                            select pb;
            //        int quatity = book.BookQuantity - releasedBooks.Count() + returnedBooks.Count();
            //        dgvBookInven.Rows.Add(book.Bookname, quatity, releasedBooks.Count(), returnedBooks.Count());
            //    }
            //}
            //else
            //{
            //    //dgvBookInven.Rows.Clear();
            //    DisplayInvent();
            //}
           
        }
    }
}
