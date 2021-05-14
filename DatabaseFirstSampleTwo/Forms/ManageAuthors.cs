using DatabaseFirstSampleTwo.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab3LinneaOchAndreas
{
    public partial class ManageAuthors : Form
    {
        // Declare variable authId to be used in dataGridView-search. 
        public int authId = 0;
        public ManageAuthors()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Updates chosen author with user's altered input.
            using (var db = new LAM_Lab2Context())
            {
                try
                {
                    var author = db.Authors.Find(authId);

                    author.AFirstName = tb_Firstname.Text;
                    author.ALastName = tb_Lastname.Text;
                    author.BirthDate = DateTime.Parse(tb_Birthdate.Text);
                    author.Active = checkbox_Active.Checked;

                    if (string.IsNullOrEmpty(tb_Firstname.Text) || string.IsNullOrWhiteSpace(tb_Lastname.Text))
                    {
                        MessageBox.Show("First- or lastname can't be empty.", "Missing information",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        db.Authors.Update(author);
                        db.SaveChanges();

                        dataGridView_Authors.DataSource = db.Authors.ToList();

                        MessageBox.Show("Author updated successfully.", "Updated Author",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show($"{ee}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            using (var db = new LAM_Lab2Context())
            {
                //Adds a new author with user's input.
                try
                {
                    int searchID = authId;
                    int index = -1;
                    index = (dataGridView_Authors.Rows.Cast<DataGridViewRow>()
                        .Where(r => r.Cells[0].Value.Equals(authId))
                        .Select(r => r.Index)).FirstOrDefault();
                    if (index > 0)
                    {
                        MessageBox.Show("Author with that ID already exists", "Attention",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        var author = new Author
                        {
                            AFirstName = tb_Firstname.Text,
                            ALastName = tb_Lastname.Text,
                            BirthDate = DateTime.Parse(tb_Birthdate.Text),
                            Active = checkbox_Active.Checked
                        };

                        if (string.IsNullOrWhiteSpace(tb_Firstname.Text) || string.IsNullOrWhiteSpace(tb_Lastname.Text))
                        {
                            MessageBox.Show("First- or lastname can't be empty.", "Missing information",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {

                            db.Authors.Add(author);
                            db.SaveChanges();
                            dataGridView_Authors.DataSource = db.Authors.ToList();


                            MessageBox.Show("Author added successfully.", "New Author"
                                , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show($"{ee}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dataGridView_Authors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Updates the textboxes and other controls with information from the dataGridView.
            //And enables the Update-button if the user wants to update an author.
            try
            {
                using (var db = new LAM_Lab2Context())
                {
                    string id = dataGridView_Authors.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int idInt = int.Parse(id);

                    var author = db.Authors.Find(idInt);

                    authId = author.Id;
                    tb_Firstname.Text = author.AFirstName;
                    tb_Lastname.Text = author.ALastName;
                    tb_Birthdate.Value = author.BirthDate;
                    checkbox_Active.Checked = author.Active;


                    this.btn_Save.Enabled = true;

                }
            }
            catch (Exception ee)
            {
                MessageBox.Show($"{ee}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ManageAuthors_Load(object sender, EventArgs e)
        {
            using (var db = new LAM_Lab2Context())
            {
                //Hides two columns from the dataGridView
                dataGridView_Authors.DataSource = db.Authors.ToList();
                this.dataGridView_Authors.Columns["AFirstName"].Visible = false;
                this.dataGridView_Authors.Columns["ALastName"].Visible = false;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            tb_Firstname.Clear();
            tb_Lastname.Clear();
            checkbox_Active.Checked = false;
            authId = 0;
            this.btn_Save.Enabled = false;
        }
    }
}
