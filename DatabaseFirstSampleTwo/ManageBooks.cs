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
            using (var db = new LAM_Lab2Context())
            {
                //Select everything in the Books-table.
                var booksData = from b in db.Books select b;

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
                    //Letar efter befintligt ISBN dataGridView och avbryter om det hittas när användaren 
                    //försöker lägga till en bok.
                    string searchISBN = tb_ISBN.Text;
                    int index = -1;
                    index = (dataGridView_books.Rows.Cast<DataGridViewRow>()
                        .Where(r => r.Cells[0].Value.Equals(searchISBN))
                        .Select(r => r.Index)).FirstOrDefault();
                    if (index > 0)
                    {
                        MessageBox.Show("Book with that ISBN is already in the database.", "Attention",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var book = new Book
                        {
                            Isbn13 = tb_ISBN.Text,
                            Title = tb_title.Text,
                            Price = decimal.Parse(tb_Price.Text),
                            Published = dateTimePicker1.Value,
                            Language = tb_Language.Text,
                            Active = checkBox_activeBook.Checked
                        };

                        db.Books.Add(book);
                        db.SaveChanges();
                        dataGridView_books.DataSource = db.Books.ToList();

                        MessageBox.Show("Book added successfully", "New book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
            if (System.Text.RegularExpressions.Regex.IsMatch(tb_ISBN.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only.");
                tb_ISBN.Text = tb_ISBN.Text.Remove(tb_ISBN.Text.Length - 1);
            }
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

                    db.Books.Update(book);
                    db.SaveChanges();
                    dataGridView_books.DataSource = db.Books.ToList();

                }
                catch (Exception ee)
                {

                    MessageBox.Show($"{ee}");
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ChooseAuthor_Click(object sender, EventArgs e)
        {
            var formPopup2 = new ConnectAuthorBooks();
            formPopup2.Show(this);
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            tb_ISBN.Clear();
            tb_title.Clear();
            tb_Price.Clear();
            tb_Language.Clear();
            checkBox_activeBook.Checked = false;
            
        }
    }
}
