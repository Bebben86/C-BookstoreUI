
namespace DatabaseFirstSampleTwo
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_manageBooks = new System.Windows.Forms.Button();
            this.btn_manageAuthors = new System.Windows.Forms.Button();
            this.btn_connectAuthorsAndBooks = new System.Windows.Forms.Button();
            this.btn_stockBalances = new System.Windows.Forms.Button();
            this.btn_ = new System.Windows.Forms.Button();
            this.GridView_base = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_base)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_manageBooks
            // 
            this.btn_manageBooks.Location = new System.Drawing.Point(12, 12);
            this.btn_manageBooks.Name = "btn_manageBooks";
            this.btn_manageBooks.Size = new System.Drawing.Size(124, 45);
            this.btn_manageBooks.TabIndex = 0;
            this.btn_manageBooks.Text = "Manage books";
            this.btn_manageBooks.UseVisualStyleBackColor = true;
            this.btn_manageBooks.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_manageAuthors
            // 
            this.btn_manageAuthors.Location = new System.Drawing.Point(12, 72);
            this.btn_manageAuthors.Name = "btn_manageAuthors";
            this.btn_manageAuthors.Size = new System.Drawing.Size(124, 45);
            this.btn_manageAuthors.TabIndex = 1;
            this.btn_manageAuthors.Text = "Manage Authors";
            this.btn_manageAuthors.UseVisualStyleBackColor = true;
            this.btn_manageAuthors.Click += new System.EventHandler(this.btn_manageAuthors_Click);
            // 
            // btn_connectAuthorsAndBooks
            // 
            this.btn_connectAuthorsAndBooks.Location = new System.Drawing.Point(12, 135);
            this.btn_connectAuthorsAndBooks.Name = "btn_connectAuthorsAndBooks";
            this.btn_connectAuthorsAndBooks.Size = new System.Drawing.Size(124, 45);
            this.btn_connectAuthorsAndBooks.TabIndex = 2;
            this.btn_connectAuthorsAndBooks.Text = "Connect authors and books";
            this.btn_connectAuthorsAndBooks.UseVisualStyleBackColor = true;
            this.btn_connectAuthorsAndBooks.Click += new System.EventHandler(this.btn_connectAuthorsAndBooks_Click);
            // 
            // btn_stockBalances
            // 
            this.btn_stockBalances.Location = new System.Drawing.Point(12, 199);
            this.btn_stockBalances.Name = "btn_stockBalances";
            this.btn_stockBalances.Size = new System.Drawing.Size(124, 45);
            this.btn_stockBalances.TabIndex = 3;
            this.btn_stockBalances.Text = "Stock balances";
            this.btn_stockBalances.UseVisualStyleBackColor = true;
            this.btn_stockBalances.Click += new System.EventHandler(this.btn_stockBalances_Click);
            // 
            // btn_
            // 
            this.btn_.Location = new System.Drawing.Point(12, 393);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(124, 45);
            this.btn_.TabIndex = 4;
            this.btn_.Text = "Quit program";
            this.btn_.UseVisualStyleBackColor = true;
            this.btn_.Click += new System.EventHandler(this.btn__Click);
            // 
            // GridView_base
            // 
            this.GridView_base.AllowUserToAddRows = false;
            this.GridView_base.AllowUserToDeleteRows = false;
            this.GridView_base.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridView_base.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_base.Location = new System.Drawing.Point(154, 12);
            this.GridView_base.Name = "GridView_base";
            this.GridView_base.ReadOnly = true;
            this.GridView_base.RowTemplate.Height = 25;
            this.GridView_base.Size = new System.Drawing.Size(634, 426);
            this.GridView_base.TabIndex = 5;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridView_base);
            this.Controls.Add(this.btn_);
            this.Controls.Add(this.btn_stockBalances);
            this.Controls.Add(this.btn_connectAuthorsAndBooks);
            this.Controls.Add(this.btn_manageAuthors);
            this.Controls.Add(this.btn_manageBooks);
            this.Name = "BaseForm";
            this.Text = "The Bookstores Lab3 Andreas&Linnéa";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_base)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_manageBooks;
        private System.Windows.Forms.Button btn_manageAuthors;
        private System.Windows.Forms.Button btn_connectAuthorsAndBooks;
        private System.Windows.Forms.Button btn_stockBalances;
        private System.Windows.Forms.Button btn_;
        private System.Windows.Forms.DataGridView GridView_base;
    }
}