
namespace Lab3LinneaOchAndreas
{
    partial class ConnectAuthorBooks
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
            this.btn_SaveConn = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Books = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_SaveConn
            // 
            this.btn_SaveConn.Location = new System.Drawing.Point(12, 51);
            this.btn_SaveConn.Name = "btn_SaveConn";
            this.btn_SaveConn.Size = new System.Drawing.Size(114, 34);
            this.btn_SaveConn.TabIndex = 2;
            this.btn_SaveConn.Text = "Save Connection";
            this.btn_SaveConn.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(12, 116);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(114, 34);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Books";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.Location = new System.Drawing.Point(190, 116);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(477, 94);
            this.checkedListBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Connected Books";
            // 
            // cb_Books
            // 
            this.cb_Books.FormattingEnabled = true;
            this.cb_Books.Location = new System.Drawing.Point(190, 51);
            this.cb_Books.Name = "cb_Books";
            this.cb_Books.Size = new System.Drawing.Size(477, 23);
            this.cb_Books.TabIndex = 8;
            this.cb_Books.SelectedIndexChanged += new System.EventHandler(this.cb_Books_SelectedIndexChanged);
            // 
            // ConnectAuthorBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 317);
            this.Controls.Add(this.cb_Books);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_SaveConn);
            this.Name = "ConnectAuthorBooks";
            this.Text = "ConnectAuthorBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_SaveConn;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Books;
    }
}