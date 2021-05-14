
namespace Lab3LinneaOchAndreas
{
    partial class Stockbalance
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
            this.dataGridView_storeData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_nrOfItems = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.comboBox_bookstore = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_book = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_storeData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_storeData
            // 
            this.dataGridView_storeData.AllowUserToAddRows = false;
            this.dataGridView_storeData.AllowUserToDeleteRows = false;
            this.dataGridView_storeData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_storeData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_storeData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_storeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_storeData.Location = new System.Drawing.Point(13, 12);
            this.dataGridView_storeData.Name = "dataGridView_storeData";
            this.dataGridView_storeData.ReadOnly = true;
            this.dataGridView_storeData.RowTemplate.Height = 25;
            this.dataGridView_storeData.Size = new System.Drawing.Size(775, 280);
            this.dataGridView_storeData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of items:";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(388, 304);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(80, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Add new";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_nrOfItems
            // 
            this.tb_nrOfItems.Location = new System.Drawing.Point(134, 362);
            this.tb_nrOfItems.Name = "tb_nrOfItems";
            this.tb_nrOfItems.Size = new System.Drawing.Size(100, 23);
            this.tb_nrOfItems.TabIndex = 5;
            this.tb_nrOfItems.TextChanged += new System.EventHandler(this.tb_nrOfItems_TextChanged);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(388, 365);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(80, 23);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox_bookstore
            // 
            this.comboBox_bookstore.FormattingEnabled = true;
            this.comboBox_bookstore.Location = new System.Drawing.Point(134, 304);
            this.comboBox_bookstore.Name = "comboBox_bookstore";
            this.comboBox_bookstore.Size = new System.Drawing.Size(220, 23);
            this.comboBox_bookstore.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bookstore:";
            // 
            // comboBox_book
            // 
            this.comboBox_book.FormattingEnabled = true;
            this.comboBox_book.Location = new System.Drawing.Point(134, 333);
            this.comboBox_book.Name = "comboBox_book";
            this.comboBox_book.Size = new System.Drawing.Size(220, 23);
            this.comboBox_book.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Book:";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(388, 336);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(80, 23);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click_1);
            // 
            // Stockbalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_book);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_bookstore);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.tb_nrOfItems);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_storeData);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 477);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 477);
            this.Name = "Stockbalance";
            this.Text = "Stockbalance";
            this.Load += new System.EventHandler(this.Stockbalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_storeData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_storeData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_nrOfItems;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ComboBox comboBox_bookstore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_book;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Update;
    }
}