using DatabaseFirstSampleTwo.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab3LinneaOchAndreas
{
    public partial class Stockbalance : Form
    {

        public string jsonConn = new LAM_Lab2Context().connectionString;

        public object sqlResult()
        {
            //LINQ query for the dataGridView.
            using (var db = new LAM_Lab2Context())
            {
                var storedata2 = from stockbalance in db.StockBalances
                                join book in db.Books
                                on stockbalance.BooksIsbn13 equals book.Isbn13
                                join store in db.BookStores
                                on stockbalance.BookStoresId equals store.Id
                                where book.Active == true
                                select new
                                {
                                    store.Name,
                                    book.Title,
                                    stockbalance.NumberOfItems
                                };
                var storedata = storedata2.ToList();
                return storedata;
            }

        }

        public Stockbalance()
        {
            InitializeComponent();
        }

        private void Stockbalance_Load(object sender, EventArgs e)
        {
            using (var db = new LAM_Lab2Context())
            {
                //Fills the dataGridView with data from the database.
                dataGridView_storeData.DataSource = sqlResult();


                //Shows the different bookstores by name
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT ID, Name FROM BookStores", jsonConn);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                comboBox_bookstore.DataSource = dt2;                // setting the datasource property of combobox
                comboBox_bookstore.DisplayMember = "Name";          // Display Member which will display on screen
                comboBox_bookstore.ValueMember = "ID";              // Fetching the ID for the bookStore


                //Shows the different books by title
                SqlDataAdapter da = new SqlDataAdapter("SELECT ISBN13, Title FROM Books WHERE Active = 1", jsonConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox_book.DataSource = dt;                      // setting the datasource property of combobox
                comboBox_book.DisplayMember = "Title";              // Display Member which will display on screen
                comboBox_book.ValueMember = "ISBN13";               // Fetching the id for the Title


            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            using (var db = new LAM_Lab2Context())
            {
                // Adds a new book (from combobox_book) to a bookstore.
                // Shows errormessage if fail.
                try
                {
                    var item = comboBox_bookstore.SelectedValue;
                    var id = Convert.ToInt32(item);

                    var bookInStock = new StockBalance()
                    {

                        NumberOfItems = Int32.Parse(tb_nrOfItems.Text),
                        BookStoresId = id,
                        BooksIsbn13 = comboBox_book.SelectedValue.ToString()
                    };

                    db.StockBalances.Add(bookInStock);
                    db.SaveChanges();
                }
                catch (Exception ee)
                {
                    MessageBox.Show($"{ee}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                dataGridView_storeData.DataSource = sqlResult();
            }
        }

        private void tb_nrOfItems_TextChanged(object sender, EventArgs e)
        {
            //Data validation for numbers only.
            if (System.Text.RegularExpressions.Regex.IsMatch(tb_nrOfItems.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only.");
                tb_nrOfItems.Text = tb_nrOfItems.Text.Remove(tb_nrOfItems.Text.Length - 1);
            }
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            //Updates the number of books of a user-chosen book at a user-chosen bookstore.
            using (var db = new LAM_Lab2Context())
            {
                try
                {
                    var item = comboBox_bookstore.SelectedValue;
                    var id = Convert.ToInt32(item);

                    var bookInStock = new StockBalance()
                    {
                        NumberOfItems = Int32.Parse(tb_nrOfItems.Text),
                        BookStoresId = id,
                        BooksIsbn13 = comboBox_book.SelectedValue.ToString()
                    };

                    db.StockBalances.Update(bookInStock);
                    db.SaveChanges();
 
                }
                catch (Exception ee)
                {
                    MessageBox.Show($"{ee}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
                dataGridView_storeData.DataSource = sqlResult();
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            //Remove a user-chosen book at a user-chosen bookstore.
            using (var db = new LAM_Lab2Context())
            {
                var result = MessageBox.Show("Are you sure?", "Confirm delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var item = comboBox_bookstore.SelectedValue;
                        var id = Convert.ToInt32(item);

                        var bookInStock = new StockBalance()
                        {
                            BookStoresId = id,
                            BooksIsbn13 = comboBox_book.SelectedValue.ToString()
                        };

                        db.StockBalances.Remove(bookInStock);
                        db.SaveChanges();

                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show($"{ee}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    dataGridView_storeData.DataSource = sqlResult();
                }
            }
        }
    }
}
