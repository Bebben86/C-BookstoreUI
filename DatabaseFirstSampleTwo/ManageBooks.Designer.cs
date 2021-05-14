
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
            this.dataGridView_books = new System.Windows.Forms.DataGridView();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_Language = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Published = new System.Windows.Forms.Label();
            this.lbl_Language = new System.Windows.Forms.Label();
            this.tb_ISBN = new System.Windows.Forms.TextBox();
            this.lbl_ISBN = new System.Windows.Forms.Label();
            this.button_AddBook = new System.Windows.Forms.Button();
            this.button_saveUpdateBook = new System.Windows.Forms.Button();
            this.checkBox_activeBook = new System.Windows.Forms.CheckBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_ChooseAuthor = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_books)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_books
            // 
            this.dataGridView_books.AllowUserToAddRows = false;
            this.dataGridView_books.AllowUserToDeleteRows = false;
            this.dataGridView_books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_books.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_books.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_books.MultiSelect = false;
            this.dataGridView_books.Name = "dataGridView_books";
            this.dataGridView_books.RowTemplate.Height = 25;
            this.dataGridView_books.Size = new System.Drawing.Size(776, 285);
            this.dataGridView_books.TabIndex = 9;
            this.dataGridView_books.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_books_CellContentClick);
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
            this.tb_Price.TabIndex = 3;
            // 
            // tb_Language
            // 
            this.tb_Language.Location = new System.Drawing.Point(91, 374);
            this.tb_Language.Name = "tb_Language";
            this.tb_Language.Size = new System.Drawing.Size(144, 23);
            this.tb_Language.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(335, 316);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 5;
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
            this.tb_ISBN.TabIndex = 0;
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
            // button_AddBook
            // 
            this.button_AddBook.Location = new System.Drawing.Point(254, 402);
            this.button_AddBook.Name = "button_AddBook";
            this.button_AddBook.Size = new System.Drawing.Size(95, 23);
            this.button_AddBook.TabIndex = 7;
            this.button_AddBook.Text = "Add new";
            this.button_AddBook.UseVisualStyleBackColor = true;
            this.button_AddBook.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // button_saveUpdateBook
            // 
            this.button_saveUpdateBook.Enabled = false;
            this.button_saveUpdateBook.Location = new System.Drawing.Point(374, 402);
            this.button_saveUpdateBook.Name = "button_saveUpdateBook";
            this.button_saveUpdateBook.Size = new System.Drawing.Size(95, 23);
            this.button_saveUpdateBook.TabIndex = 10;
            this.button_saveUpdateBook.Text = "Save update";
            this.button_saveUpdateBook.UseVisualStyleBackColor = true;
            this.button_saveUpdateBook.Click += new System.EventHandler(this.button_saveUpdateBook_Click);
            // 
            // checkBox_activeBook
            // 
            this.checkBox_activeBook.AutoSize = true;
            this.checkBox_activeBook.Location = new System.Drawing.Point(91, 432);
            this.checkBox_activeBook.Name = "checkBox_activeBook";
            this.checkBox_activeBook.Size = new System.Drawing.Size(59, 19);
            this.checkBox_activeBook.TabIndex = 4;
            this.checkBox_activeBook.Text = "Active";
            this.checkBox_activeBook.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(487, 403);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(95, 23);
            this.btn_Close.TabIndex = 9;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_ChooseAuthor
            // 
            this.btn_ChooseAuthor.Location = new System.Drawing.Point(254, 369);
            this.btn_ChooseAuthor.Name = "btn_ChooseAuthor";
            this.btn_ChooseAuthor.Size = new System.Drawing.Size(95, 23);
            this.btn_ChooseAuthor.TabIndex = 6;
            this.btn_ChooseAuthor.Text = "Choose Author";
            this.btn_ChooseAuthor.UseVisualStyleBackColor = true;
            this.btn_ChooseAuthor.Click += new System.EventHandler(this.btn_ChooseAuthor_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(374, 369);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(95, 23);
            this.button_Clear.TabIndex = 8;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // ManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.btn_ChooseAuthor);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.checkBox_activeBook);
            this.Controls.Add(this.button_saveUpdateBook);
            this.Controls.Add(this.button_AddBook);
            this.Controls.Add(this.lbl_ISBN);
            this.Controls.Add(this.tb_ISBN);
            this.Controls.Add(this.lbl_Language);
            this.Controls.Add(this.lbl_Published);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tb_Language);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.tb_title);
            this.Controls.Add(this.dataGridView_books);
            this.KeyPreview = true;
            this.Name = "ManageBooks";
            this.Text = "Manage books";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_books;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_Language;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Published;
        private System.Windows.Forms.Label lbl_Language;
        private System.Windows.Forms.TextBox tb_ISBN;
        private System.Windows.Forms.Label lbl_ISBN;
        private System.Windows.Forms.Button button_AddBook;
        private System.Windows.Forms.Button button_saveUpdateBook;
        private System.Windows.Forms.CheckBox checkBox_activeBook;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_ChooseAuthor;
        private System.Windows.Forms.Button button_Clear;
    }
}

