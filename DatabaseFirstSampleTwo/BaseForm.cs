using DatabaseFirstSampleTwo.Models;
using Lab3LinneaOchAndreas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseFirstSampleTwo
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formPopup = new ManageBooks();
            formPopup.Show(this);
        }
        private void btn_manageAuthors_Click(object sender, EventArgs e)
        {
            var formPopup2 = new ManageAuthors();
            formPopup2.Show(this);
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {   
            using (var db = new LAM_Lab2Context())
            {       
                var booksData = from book in db.Books
                                join AuthorsBook in db.AuthorsBooks
                                on book.Isbn13 equals AuthorsBook.BooksIsbn13
                                join Author in db.Authors
                                on AuthorsBook.AuthorsId equals Author.Id
                                where book.Active == true
                                select new
                                {
                                    Author.AFirstName,
                                    Author.ALastName,
                                    book.Title
                                };

                if (booksData != null)
                {
                    if (booksData.Count() > 0)
                    {
                        GridView_base.DataSource = booksData.ToList();
                        GridView_base.Columns[0].HeaderText = "Firstname";
                        GridView_base.Columns[1].HeaderText = "Lastname";
                        GridView_base.Columns[2].HeaderText = "Title of the book";
                    }
                    else
                    {
                        MessageBox.Show("No records found", "No data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GridView_base.DataSource = null;
                    }
                }
            }
        }

        private void btn__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_connectAuthorsAndBooks_Click(object sender, EventArgs e)
        {
            var formPopup3 = new ConnectAuthorBooks();
            formPopup3.Show(this);
        }

        private void btn_stockBalances_Click(object sender, EventArgs e)
        {
            var formPopup4 = new Stockbalance();
            formPopup4.Show(this);
        }
    }
}
