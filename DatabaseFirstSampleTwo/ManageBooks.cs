using DatabaseFirstSampleTwo.Models;
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
    public partial class ManageBooks : Form
    {

        public ManageBooks()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var db = new LAM_Lab2Context();
            using (var db = new LAM_Lab2Context())
            {

                //Select everything in the Books-table.
                var booksData = from b in db.Books select b;

                //View a view named RegularCustomers.
                //var booksData = from rc in db.RegularCustomers select rc;

                //Join 3 tables and pick the information you want.
                //var booksData = from Book in db.Books
                //                 join AuthorsBook in db.AuthorsBooks
                //                 on Book.Isbn13 equals AuthorsBook.BooksIsbn13
                //                 join Author in db.Authors
                //                 on AuthorsBook.AuthorsId equals Author.Id
                //                    where Book.Active == true
                //                 select new
                //                 {
                //                     Book.Title,
                //                     Book.Isbn13,
                //                     Book.Language,
                //                     Book.Price,
                //                     Book.Active,
                //                     Author.AFirstName,
                //                     Author.ALastName
                //                 };



                if (booksData != null)
                {
                    if (booksData.Count() > 0)
                    {
                        dataGridView_books.DataSource = booksData.ToList();
                    }
                    else
                    {
                        MessageBox.Show("No records found", "No data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView_books.DataSource = null;
                    }
                }
                

            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            using (var db = new LAM_Lab2Context())
            {
                try
                {

                    var book = new Book
                    {
                        Isbn13 = tb_ISBN.Text,
                        Title = tb_title.Text,
                        Price = decimal.Parse(tb_Price.Text),
                        Published = dateTimePicker1.Value,
                        Language = tb_Language.Text
                    };

                    db.Books.Add(book);
                    db.SaveChanges();
                    dataGridView_books.DataSource = db.Books.ToList();
                    MessageBox.Show("Book added successfully", "New book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ee)
                {
                    MessageBox.Show($"{ee}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }

            }
        }

        private void tb_ISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new LAM_Lab2Context())
            {
                var id = dataGridView_books.Rows[e.RowIndex].Cells[0].Value.ToString();
                var book = db.Books.Find(id);

                tb_ISBN.Text = book.Isbn13;
                tb_title.Text = book.Title;
                tb_Price.Text = book.Price.ToString();
                tb_Language.Text = book.Language;
                checkBox_activeBook.Checked = book.Active;

                
                this.button_saveUpdateBook.Enabled = true;
            }   
        }

        private void button_saveUpdateBook_Click(object sender, EventArgs e)
        {
            using (var db = new LAM_Lab2Context())
            {
                try
                {
                    var book = db.Books.Find(tb_ISBN.Text);

                    book.Isbn13 = tb_ISBN.Text;
                    book.Title = tb_title.Text;
                    book.Price = decimal.Parse(tb_Price.Text);
                    book.Language = tb_Language.Text;
                    book.Active = checkBox_activeBook.Checked;

                    db.SaveChanges();
                    dataGridView_books.DataSource = db.Books.ToList();

                }
                catch (Exception ee)
                {

                    MessageBox.Show($"{ee}");
                }
            }
        }
    }
}
