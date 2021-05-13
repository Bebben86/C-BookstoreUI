using DatabaseFirstSampleTwo.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Lab3LinneaOchAndreas
{
    public partial class Stockbalance : Form
    {
        public string conn = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = LAM_Lab2; Integrated Security = True";
        public Stockbalance()
        {
            InitializeComponent();
        }

        private void Stockbalance_Load(object sender, EventArgs e)
        {
            using (var db = new LAM_Lab2Context())
            {
                var storedata = from stockbalance in db.StockBalances
                                join book in db.Books
                                on stockbalance.BooksIsbn13 equals book.Isbn13
                                join store in db.BookStores
                                on stockbalance.BookStoresId equals store.Id
                                where book.Active == true
                                select new

                                //Här är bara det som ska synas.
                                {
                                    store.Name,
                                    book.Title,
                                    stockbalance.NumberOfItems
                                };
                
                dataGridView_storeData.DataSource = storedata.ToList();

                //Shows the different bookstores
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT ID, Name FROM BookStores", conn);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                comboBox_bookstore.DataSource = dt2; // setting the datasource property of combobox
                comboBox_bookstore.DisplayMember = "Name"; // Display Member which will display on screen
                comboBox_bookstore.ValueMember = "ID";


                //Shows the different books
                SqlDataAdapter da = new SqlDataAdapter("SELECT ISBN13, Title FROM Books WHERE Active = 1", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox_book.DataSource = dt; // setting the datasource property of combobox
                comboBox_book.DisplayMember = "Title"; // Display Member which will display on screen
                comboBox_book.ValueMember = "ISBN13";
            }
        }

        private void comboBox_book_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_storeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new LAM_Lab2Context())
            {    
                var id = dataGridView_storeData.Rows[e.RowIndex].Cells[0].Value.ToString();

                var book = db.StockBalances.Find(id);

                tb_nrOfItems.Text = book.NumberOfItems.ToString();
                dataGridView_storeData.Update();
                
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            using (var db = new LAM_Lab2Context())
            {
                //TODO Varför godkänner den inte vår int fast den vill ha en int?
                var bookInStock = new StockBalance()
                {
                    NumberOfItems = Int32.Parse(tb_nrOfItems.Text),
                    BookStoresId = Int32.Parse(comboBox_bookstore.ValueMember),
                    BooksIsbn13 = comboBox_book.ValueMember
                };

                db.StockBalances.Add(bookInStock);
                db.SaveChanges();

                //Reload the gridView.
                var storedata = from stockbalance in db.StockBalances
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


                dataGridView_storeData.DataSource = storedata.ToList();
            }


            //using (var db = new LAM_Lab2Context())
            //{
            //    string id = dataGridView_storeData.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    var author = db.StockBalances.Find(id);

            //}

            //foreach (DataGridViewRow row in dataGridView_storeData.Rows)
            //{
            //    var comboValue = string.IsNullOrEmpty(row.Cells[comboBox_book.SelectedIndex].Value.ToString()) ? "" : row.Cells[comboBox_book.SelectedIndex].Value.ToString();
            //    if (dataGridView_storeData.Rows != null)
            //    {

            //        var update = dataGridView_storeData.Rows[e.RowIndex].Cells[0].Value.ToString();

            //        //update your_table set field = value where id = row.Cells["fieldname"].Value;
            //        dataGridView_storeData.Update();


            //    }

            //}
        }
    }
}
