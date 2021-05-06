
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
            this.SuspendLayout();
            // 
            // btn_manageBooks
            // 
            this.btn_manageBooks.Location = new System.Drawing.Point(61, 63);
            this.btn_manageBooks.Name = "btn_manageBooks";
            this.btn_manageBooks.Size = new System.Drawing.Size(124, 45);
            this.btn_manageBooks.TabIndex = 0;
            this.btn_manageBooks.Text = "Manage books";
            this.btn_manageBooks.UseVisualStyleBackColor = true;
            this.btn_manageBooks.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_manageAuthors
            // 
            this.btn_manageAuthors.Location = new System.Drawing.Point(61, 123);
            this.btn_manageAuthors.Name = "btn_manageAuthors";
            this.btn_manageAuthors.Size = new System.Drawing.Size(124, 45);
            this.btn_manageAuthors.TabIndex = 1;
            this.btn_manageAuthors.Text = "Manage Authors";
            this.btn_manageAuthors.UseVisualStyleBackColor = true;
            // 
            // btn_connectAuthorsAndBooks
            // 
            this.btn_connectAuthorsAndBooks.Location = new System.Drawing.Point(61, 184);
            this.btn_connectAuthorsAndBooks.Name = "btn_connectAuthorsAndBooks";
            this.btn_connectAuthorsAndBooks.Size = new System.Drawing.Size(124, 45);
            this.btn_connectAuthorsAndBooks.TabIndex = 2;
            this.btn_connectAuthorsAndBooks.Text = "Connect authors and books";
            this.btn_connectAuthorsAndBooks.UseVisualStyleBackColor = true;
            // 
            // btn_stockBalances
            // 
            this.btn_stockBalances.Location = new System.Drawing.Point(61, 244);
            this.btn_stockBalances.Name = "btn_stockBalances";
            this.btn_stockBalances.Size = new System.Drawing.Size(124, 45);
            this.btn_stockBalances.TabIndex = 3;
            this.btn_stockBalances.Text = "Stock balances";
            this.btn_stockBalances.UseVisualStyleBackColor = true;
            // 
            // btn_
            // 
            this.btn_.Location = new System.Drawing.Point(61, 371);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(124, 45);
            this.btn_.TabIndex = 4;
            this.btn_.Text = "Stock balances";
            this.btn_.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_);
            this.Controls.Add(this.btn_stockBalances);
            this.Controls.Add(this.btn_connectAuthorsAndBooks);
            this.Controls.Add(this.btn_manageAuthors);
            this.Controls.Add(this.btn_manageBooks);
            this.Name = "BaseForm";
            this.Text = "Stock balances";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_manageBooks;
        private System.Windows.Forms.Button btn_manageAuthors;
        private System.Windows.Forms.Button btn_connectAuthorsAndBooks;
        private System.Windows.Forms.Button btn_stockBalances;
        private System.Windows.Forms.Button btn_;
    }
}