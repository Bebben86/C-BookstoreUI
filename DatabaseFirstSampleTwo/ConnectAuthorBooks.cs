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

namespace Lab3LinneaOchAndreas
{
    public partial class ConnectAuthorBooks : Form
    {
        public string conn = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = LAM_Lab2; Integrated Security = True";

        public ConnectAuthorBooks()
        {
            InitializeComponent();
        }

        private void cb_Books_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConnectAuthorBooks_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT ISBN13, Title FROM Books WHERE Active = 1", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_Books.DataSource = dt; // setting the datasource property of combobox
            cb_Books.DisplayMember = "Title"; // Display Member which will display on screen
            cb_Books.ValueMember = "ISBN13";
            
            
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT Authors.ID, CONCAT(A_FirstName, ' ', A_LastName) as Name from Authors", conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cb_Authors.DataSource = dt2;        // setting the datasource property of combobox
            cb_Authors.DisplayMember = "Name";  // Display Member which will display on screen
            cb_Authors.ValueMember = "ID";
        }

        private void cb_Authors_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
