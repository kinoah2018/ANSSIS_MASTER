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
    public partial class AddBookForm :MetroFramework.Forms.MetroForm
    {
        int BookID;
        int ProcessBookID;
        public AddBookForm()
        {
            
            InitializeComponent();
        }
        DataClassDataContext db = new DataClassDataContext();
        private void AddBookForm_Load(object sender, EventArgs e)
        {
            DisplayBook();
            DisplayProcessBook();
            
        }
        public void DisplayProcessBook()
        {

            var displayByID = from pbook in db.ProcessBooks
                              join stud in db.Students on pbook.StudentID equals stud.StudentID
                              join b in db.Books on pbook.BookID equals b.BookID
                              select new
                              {
                                  pbook.ProcessBookID,
                                  stud.StudentID,
                                  Name = stud.Firstname + " " + stud.Lastname,
                                  stud.YearLevel,
                                  b.Bookname,
                                  pbook.Distributer,
                                  pbook.BookRelease,
                                  pbook.BookReturn
                              };
            dgvProcessBook.DataSource = displayByID;
        }
        public void DisplayBook()
        {
            var dispbooks = from s in db.Books
                            select s;
            dgvCompBook.DataSource = dispbooks;
        }
        public void BookClear()
        {
            txtBookname.Clear();
            txtBookDescrip.Clear();
            cmbYearLevel.SelectedIndex = -1;
            txtBookAuthor.Clear();
            dtpBookPublished.ResetText();
            txtBookQuantity.Clear();
        }

        private void btnCompBookAdd_Click(object sender, EventArgs e)
        {
            if (btnCompBookAdd.Text=="Add")
            {
                
                Book b = new Book();
                b.Bookname = txtBookname.Text;
                b.BookDesciption = txtBookDescrip.Text;
                b.YearLevel = cmbYearLevel.Text;
                b.BookAuthor = txtBookAuthor.Text;
                b.BookReleased =  DateTime.Parse(dtpBookPublished.Text);
                b.BookQuantity = int.Parse(txtBookQuantity.Text);
                db.Books.InsertOnSubmit(b);
                db.SubmitChanges();
                MessageBox.Show("Add");
                BookClear();
                dgvCompBook.DataSource = b;
                DisplayBook();
            }
            else
            {
                var updatebook = db.Books.SingleOrDefault(x => x.BookID == int.Parse(dgvCompBook.CurrentRow.Cells[0].Value.ToString()));
                updatebook.BookID = BookID;
                updatebook.Bookname = txtBookname.Text;
                updatebook.BookDesciption = txtBookDescrip.Text;
                updatebook.YearLevel = cmbYearLevel.Text;
                updatebook.BookAuthor = txtBookAuthor.Text;
                updatebook.BookQuantity = int.Parse(txtBookQuantity.Text);
                db.SubmitChanges();
                MessageBox.Show("Update");
                BookClear();
                dgvCompBook.DataSource = updatebook;
                DisplayBook();
                btnCompBookAdd.Text = "Add";
                btnCompBookClear.Text = "Clear";

            }
        }

        private void dgvCompBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BookID = int.Parse(dgvCompBook.CurrentRow.Cells[0].Value.ToString());
            txtBookname.Text = dgvCompBook.CurrentRow.Cells[1].Value.ToString();
            txtBookDescrip.Text = dgvCompBook.CurrentRow.Cells[2].Value.ToString();
            cmbYearLevel.Text = dgvCompBook.CurrentRow.Cells[3].Value.ToString();
            txtBookAuthor.Text = dgvCompBook.CurrentRow.Cells[4].Value.ToString();
            dtpBookPublished.Text = dgvCompBook.CurrentRow.Cells[5].Value.ToString();
            txtBookQuantity.Text = dgvCompBook.CurrentRow.Cells[6].Value.ToString();
            btnCompBookAdd.Text = "Update";
            btnCompBookClear.Text = "Cancel";
        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void btnCompBookClear_Click(object sender, EventArgs e)
        {
            if (btnCompBookClear.Text=="Clear")
            {
                BookClear();
            }
            else
            {
                btnCompBookClear.Text = "Cancel";
                btnCompBookAdd.Text = "Add";
                BookClear();
            }
        }

        private void txtCompBookSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtCompBookSearch_TextChanged(object sender, EventArgs e)
        {
            var search = from z in db.Books
                         where z.Bookname.Contains(txtCompBookSearch.Text) || z.YearLevel.Contains(txtCompBookSearch.Text)
                         select new
                         {
                             z.BookID,
                             z.Bookname,
                             z.BookDesciption,
                             z.YearLevel,
                             z.BookAuthor,
                             z.BookReleased
                         };
            dgvCompBook.DataSource = search;
        }
        private void mtxtStudID_Leave(object sender, EventArgs e)
        {
        }

        private void mtxtYearLevel_TextChanged(object sender, EventArgs e)
        {
            if (txtProBookYearLevel.Text!="")
            {
                cmbProBookAvail.Enabled = true;
                var binfo = from b in db.Books
                            where b.YearLevel.Equals(txtProBookYearLevel.Text)
                            select b;

                cmbProBookAvail.DataSource = binfo;
                cmbProBookAvail.DisplayMember = "Bookname";
                cmbProBookAvail.ValueMember = "BookID";
            }
            
        }

        private void mtpProcessBook_Click(object sender, EventArgs e)
        {
           
        }
        private void btnProcesBookRelease_Click(object sender, EventArgs e)
        {
            var checkReleased = from p in db.ProcessBooks
                                where p.StudentID == int.Parse(txtProBookStudID.Text) && p.BookID == int.Parse(cmbProBookAvail.SelectedValue.ToString())
                                select p;
            var checkReturn = from p in db.ProcessBooks
                                where p.StudentID == int.Parse(txtProBookStudID.Text) && p.BookID == int.Parse(cmbProBookAvail.SelectedValue.ToString()) &&p.BookReturn!=null
                                select p;
            
            if (btnProBookRelease.Text == "Release")
            {
                if (checkReleased.Count() > 0)
                {
                    MessageBox.Show("Book already released to the student!");
                }
                else
                {
                    ProcessBook probook = new ProcessBook();
                    probook.StudentID = int.Parse(txtProBookStudID.Text);
                    probook.BookID = Convert.ToInt32(cmbProBookAvail.SelectedValue);
                    probook.Distributer = txtProcBookDistributer.Text;
                    probook.BookRelease = DateTime.Now;
                    probook.BookReturn = null;
                    db.ProcessBooks.InsertOnSubmit(probook);
                    db.SubmitChanges();
                    MessageBox.Show("Success Adding");
                    ProcessBookClear();
                    DisplayProcessBook();
                }
                
            }
            else
            {
                if (checkReturn.Count() > 0)
                {
                    MessageBox.Show("Book already returned to the student!");
                }
                else
                {
                    ProcessBookID = int.Parse(dgvProcessBook.CurrentRow.Cells[0].Value.ToString());
                    var procbooksupdate = db.ProcessBooks.SingleOrDefault(x => x.ProcessBookID == ProcessBookID);
                    procbooksupdate.BookReturn = DateTime.Now;
                    db.SubmitChanges();
                    MessageBox.Show("Success Update");
                    ProcessBookClear();
                    DisplayProcessBook();
                    btnProBookRelease.Text = "Release";
                    btnProcBookCLear.Text = "Clear";
                }
            }
        }
        public void ProcessBookClear()
        {
            txtProBookStudname.Clear();
            txtProBookYearLevel.Clear();
            cmbProBookAvail.SelectedIndex = -1;
        }

        private void btnProcesBookCLear_Click(object sender, EventArgs e)
        {
            if (btnProcBookCLear.Text =="Clear")
            {
                ProcessBookClear();
            }
            else
            {
                btnProcBookCLear.Text = "Clear";
                btnProBookRelease.Text = "Release";
                ProcessBookClear();
            }
        }

        private void dgvProcessBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           txtProBookStudID.Text = dgvProcessBook.CurrentRow.Cells[1].Value.ToString();
           txtProBookStudname.Text = dgvProcessBook.CurrentRow.Cells[2].Value.ToString();
           txtProBookYearLevel.Text = dgvProcessBook.CurrentRow.Cells[3].Value.ToString();
           cmbProBookAvail.Text = dgvProcessBook.CurrentRow.Cells[4].Value.ToString();
           txtProcBookDistributer.Text = dgvProcessBook.CurrentRow.Cells[5].Value.ToString();
           btnProBookRelease.Text = "Return";
           btnProcBookCLear.Text = "Cancel";
        }

        private void txtProBookStudID_TextChanged(object sender, EventArgs e)
        {
            
            if (txtProBookStudID.Text !="")
            {
                var displayByID = from pbook in db.ProcessBooks
                                  join stud in db.Students on pbook.StudentID equals stud.StudentID
                                  join b in db.Books on pbook.BookID equals b.BookID
                                  where stud.StudentID.Equals(txtProBookStudID.Text)
                                  select new
                                  {
                                      pbook.ProcessBookID,
                                      stud.StudentID,
                                      Name = stud.Firstname + " " + stud.Lastname,
                                      stud.YearLevel,
                                      b.Bookname,
                                      pbook.Distributer,
                                      pbook.BookRelease,
                                      pbook.BookReturn
                                  };
                dgvProcessBook.DataSource = displayByID;

                try
                {
                    var studinfo = from s in db.Students
                                   where s.StudentID.Equals(txtProBookStudID.Text)
                                   select new
                                   {
                                       Name = s.Firstname + " " + s.Lastname,
                                       s.YearLevel
                                   };
                    foreach (var stud in studinfo)
                    {
                        txtProBookStudname.Text = stud.Name;
                        txtProBookYearLevel.Text = stud.YearLevel;
                    }
                }
                catch { }

            }
            else
            {
                MessageBox.Show("No id found!");
                ProcessBookClear();
                DisplayProcessBook();
            }

            }
            
           

        private void txtProcessSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtProcessSearch_TextChanged(object sender, EventArgs e)
        {
            var processbooksearch = from pbook in db.ProcessBooks
                                    join stud in db.Students on pbook.StudentID equals stud.StudentID
                                    join b in db.Books on pbook.BookID equals b.BookID
                                    where stud.Firstname.Contains(txtProcessSearch.Text) || stud.Lastname.Contains(txtProcessSearch.Text) || stud.YearLevel.Contains(txtProcessSearch.Text) ||
                                           b.Bookname.Contains(txtProcessSearch.Text)
                                    select new
                                    {
                                        pbook.ProcessBookID,
                                        stud.StudentID,
                                        Name = stud.Firstname + " " + stud.Lastname,
                                        stud.YearLevel,
                                        b.Bookname,
                                        pbook.Distributer,
                                        pbook.BookRelease,
                                        pbook.BookReturn
                                    };
            dgvProcessBook.DataSource = processbooksearch;
        }

        private void txtProcBookDistributer_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtProcBookDistributer_Click(object sender, EventArgs e)
        {

        }

        private void mtpProcessBook_MouseClick(object sender, MouseEventArgs e)
        {
           
            
        }

        private void metroTabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtProBookStudID_Click(object sender, EventArgs e)
        {

        }

        private void txtProBookStudID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }
           
        }
    }

