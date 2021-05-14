using DatabaseFirstSampleTwo.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Lab3LinneaOchAndreas
{
    public partial class ConnectAuthorBooks : Form
    {
        //Gets the connectionString from appsettings.json to be used for SqlDataAapters.
        public string jsonConn = new LAM_Lab2Context().connectionString;
        public ConnectAuthorBooks()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConnectAuthorBooks_Load(object sender, EventArgs e)
        {
            //Only displays active books in the dropdown.
            SqlDataAdapter da = new SqlDataAdapter("SELECT ISBN13, Title FROM Books WHERE Active = 1", jsonConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_Books.DataSource = dt;                   // setting the datasource property of combobox
            cb_Books.DisplayMember = "Title";           // Display Member which will display on screen
            cb_Books.ValueMember = "ISBN13";            // Gets the id/ISBN for what the user chose

            // Only displays active authors in the dropdown.
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT Authors.ID, CONCAT(A_FirstName, ' ', A_LastName)" +
                " as Name from Authors WHERE Active = 1", jsonConn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cb_Authors.DataSource = dt2;                // setting the datasource property of combobox
            cb_Authors.DisplayMember = "Name";          // Display Member which will display on screen
            cb_Authors.ValueMember = "ID";              // Gets the ID for the author.
        }

        private void btn_SaveConn_Click(object sender, EventArgs e)
        {
            using (var db = new LAM_Lab2Context())
            {
                try
                {
                    //Saves authorID and booksIsbn to the database so they are "connected".
                    var item = cb_Authors.SelectedValue;
                    var id = Convert.ToInt32(item);

                    var conn = new AuthorsBook()
                    {

                        AuthorsId = id,
                        BooksIsbn13 = cb_Books.SelectedValue.ToString()
                    };

                    db.AuthorsBooks.Add(conn);
                    db.SaveChanges();

                    MessageBox.Show("Author 'connected' to book", "Success",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Author already 'connected' to book", "Attention",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }

        }
    }
}
