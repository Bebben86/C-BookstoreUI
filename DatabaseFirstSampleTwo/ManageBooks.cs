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
                //var booksData = from customer in db.Customers
                //                join address in db.Addresses
                //                on customer.Id equals address.Id
                //                join PostalCode in db.PostalCodes
                //                on address.PostalCodeId equals PostalCode.Id
                //                where customer.CFirstName == "Kim"
                //                select new
                //                {
                //                    customer.CFirstName,
                //                    customer.CLastName,
                //                    address.Street,
                //                    address.Box,
                //                    PostalCode.PostalCode1,
                //                    PostalCode.City
                //                };



                if (booksData != null)
                {
                    if (booksData.Count() > 0)
                    {
                        dataGridView1.DataSource = booksData.ToList();
                    }
                    else
                    {
                        MessageBox.Show("No records found", "No data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
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
                        Language = tb_AuthorId.Text
                    };

                    db.Books.Add(book);
                    db.SaveChanges();
                    dataGridView1.DataSource = db.Books.ToList();
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
    }
}
