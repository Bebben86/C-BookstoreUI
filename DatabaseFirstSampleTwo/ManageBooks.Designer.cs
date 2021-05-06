
namespace DatabaseFirstSampleTwo
{
    partial class ManageBooks
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_AuthorId = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Published = new System.Windows.Forms.Label();
            this.lbl_Language = new System.Windows.Forms.Label();
            this.tb_ISBN = new System.Windows.Forms.TextBox();
            this.lbl_ISBN = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(91, 345);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(144, 23);
            this.tb_title.TabIndex = 1;
            // 
            // tb_Price
            // 
            this.tb_Price.Location = new System.Drawing.Point(91, 403);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(144, 23);
            this.tb_Price.TabIndex = 2;
            // 
            // tb_AuthorId
            // 
            this.tb_AuthorId.Location = new System.Drawing.Point(91, 374);
            this.tb_AuthorId.Name = "tb_AuthorId";
            this.tb_AuthorId.Size = new System.Drawing.Size(144, 23);
            this.tb_AuthorId.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(335, 316);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(22, 348);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(32, 15);
            this.lbl_Title.TabIndex = 5;
            this.lbl_Title.Text = "Title:";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(22, 406);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(66, 15);
            this.lbl_Price.TabIndex = 6;
            this.lbl_Price.Text = "Price (SEK):";
            // 
            // lbl_Published
            // 
            this.lbl_Published.AutoSize = true;
            this.lbl_Published.Location = new System.Drawing.Point(241, 319);
            this.lbl_Published.Name = "lbl_Published";
            this.lbl_Published.Size = new System.Drawing.Size(88, 15);
            this.lbl_Published.TabIndex = 7;
            this.lbl_Published.Text = "Published date:";
            // 
            // lbl_Language
            // 
            this.lbl_Language.AutoSize = true;
            this.lbl_Language.Location = new System.Drawing.Point(22, 377);
            this.lbl_Language.Name = "lbl_Language";
            this.lbl_Language.Size = new System.Drawing.Size(62, 15);
            this.lbl_Language.TabIndex = 8;
            this.lbl_Language.Text = "Language:";
            // 
            // tb_ISBN
            // 
            this.tb_ISBN.BackColor = System.Drawing.SystemColors.Info;
            this.tb_ISBN.Location = new System.Drawing.Point(91, 316);
            this.tb_ISBN.MaxLength = 13;
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.PlaceholderText = "Numbers only";
            this.tb_ISBN.Size = new System.Drawing.Size(144, 23);
            this.tb_ISBN.TabIndex = 9;
            this.tb_ISBN.TextChanged += new System.EventHandler(this.tb_ISBN_TextChanged);
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.Location = new System.Drawing.Point(23, 319);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(35, 15);
            this.lbl_ISBN.TabIndex = 10;
            this.lbl_ISBN.Text = "ISBN:";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(254, 360);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // ManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_ISBN);
            this.Controls.Add(this.tb_ISBN);
            this.Controls.Add(this.lbl_Language);
            this.Controls.Add(this.lbl_Published);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tb_AuthorId);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.tb_title);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageBooks";
            this.Text = "Manage books";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_AuthorId;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Published;
        private System.Windows.Forms.Label lbl_Language;
        private System.Windows.Forms.TextBox tb_ISBN;
        private System.Windows.Forms.Label lbl_ISBN;
        private System.Windows.Forms.Button btn_Save;
    }
}

