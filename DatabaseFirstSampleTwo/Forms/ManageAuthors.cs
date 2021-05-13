using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseFirstSampleTwo.Models;

namespace Lab3LinneaOchAndreas
{
    public partial class ManageAuthors : Form
    {
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
            using (var db = new LAM_Lab2Context())
            {
                try
                {
                    var author = new Author
                    {
                        AFirstName = tb_Firstname.Text,
                        ALastName = tb_Lastname.Text,
                        BirthDate = DateTime.Parse(tb_Birthdate.Text),
                        Active = checkbox_Active.Checked
                    };
                    db.Authors.Update(author);
                    db.SaveChanges();
                    dataGridView_Authors.DataSource = db.Authors.ToList();

                    MessageBox.Show("Author updated successfully.", "Updated Author",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ee)
                {
                    MessageBox.Show($"{ee}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            using (var db = new LAM_Lab2Context())
            {
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
                        db.Authors.Add(author);
                        db.SaveChanges();
                        dataGridView_Authors.DataSource = db.Authors.ToList();


                        MessageBox.Show("Author added successfully.", "New Author", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show($"{ee}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }

        }

        private void dataGridView_Authors_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void ManageAuthors_Load(object sender, EventArgs e)
        {
            using (var db = new LAM_Lab2Context())
            {
                dataGridView_Authors.DataSource = db.Authors.ToList();
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            tb_Firstname.Clear();
            tb_Lastname.Clear();
            checkbox_Active.Checked = false;
        }
    }
}
