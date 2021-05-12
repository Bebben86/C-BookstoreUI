
namespace Lab3LinneaOchAndreas
{
    partial class ManageAuthors
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.tb_Lastname = new System.Windows.Forms.TextBox();
            this.tb_Firstname = new System.Windows.Forms.TextBox();
            this.checkbox_Active = new System.Windows.Forms.CheckBox();
            this.label_Firstname = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_Birthdate = new System.Windows.Forms.Label();
            this.dataGridView_Authors = new System.Windows.Forms.DataGridView();
            this.tb_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.button_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Authors)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(265, 387);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(88, 32);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add New";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Location = new System.Drawing.Point(372, 387);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(96, 32);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save Update";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(588, 387);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(88, 32);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // tb_Lastname
            // 
            this.tb_Lastname.Location = new System.Drawing.Point(78, 365);
            this.tb_Lastname.Name = "tb_Lastname";
            this.tb_Lastname.Size = new System.Drawing.Size(168, 23);
            this.tb_Lastname.TabIndex = 2;
            // 
            // tb_Firstname
            // 
            this.tb_Firstname.Location = new System.Drawing.Point(78, 336);
            this.tb_Firstname.Name = "tb_Firstname";
            this.tb_Firstname.Size = new System.Drawing.Size(168, 23);
            this.tb_Firstname.TabIndex = 1;
            // 
            // checkbox_Active
            // 
            this.checkbox_Active.AutoSize = true;
            this.checkbox_Active.Location = new System.Drawing.Point(78, 426);
            this.checkbox_Active.Name = "checkbox_Active";
            this.checkbox_Active.Size = new System.Drawing.Size(59, 19);
            this.checkbox_Active.TabIndex = 4;
            this.checkbox_Active.Text = "Active";
            this.checkbox_Active.UseVisualStyleBackColor = true;
            // 
            // label_Firstname
            // 
            this.label_Firstname.AutoSize = true;
            this.label_Firstname.Location = new System.Drawing.Point(12, 336);
            this.label_Firstname.Name = "label_Firstname";
            this.label_Firstname.Size = new System.Drawing.Size(59, 15);
            this.label_Firstname.TabIndex = 7;
            this.label_Firstname.Text = "Firstname";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(12, 365);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(58, 15);
            this.label_LastName.TabIndex = 8;
            this.label_LastName.Text = "Lastname";
            // 
            // label_Birthdate
            // 
            this.label_Birthdate.AutoSize = true;
            this.label_Birthdate.Location = new System.Drawing.Point(12, 397);
            this.label_Birthdate.Name = "label_Birthdate";
            this.label_Birthdate.Size = new System.Drawing.Size(55, 15);
            this.label_Birthdate.TabIndex = 9;
            this.label_Birthdate.Text = "Birthdate";
            // 
            // dataGridView_Authors
            // 
            this.dataGridView_Authors.AllowUserToAddRows = false;
            this.dataGridView_Authors.AllowUserToDeleteRows = false;
            this.dataGridView_Authors.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_Authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Authors.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Authors.Name = "dataGridView_Authors";
            this.dataGridView_Authors.ReadOnly = true;
            this.dataGridView_Authors.RowTemplate.Height = 25;
            this.dataGridView_Authors.Size = new System.Drawing.Size(776, 307);
            this.dataGridView_Authors.TabIndex = 12;
            this.dataGridView_Authors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Authors_CellClick);
            // 
            // tb_Birthdate
            // 
            this.tb_Birthdate.Location = new System.Drawing.Point(78, 397);
            this.tb_Birthdate.Name = "tb_Birthdate";
            this.tb_Birthdate.Size = new System.Drawing.Size(168, 23);
            this.tb_Birthdate.TabIndex = 3;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(485, 387);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(88, 32);
            this.button_clear.TabIndex = 13;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // ManageAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.tb_Birthdate);
            this.Controls.Add(this.dataGridView_Authors);
            this.Controls.Add(this.label_Birthdate);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_Firstname);
            this.Controls.Add(this.checkbox_Active);
            this.Controls.Add(this.tb_Firstname);
            this.Controls.Add(this.tb_Lastname);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Add);
            this.Name = "ManageAuthors";
            this.Text = "ManageAuthors";
            this.Load += new System.EventHandler(this.ManageAuthors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Authors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TextBox tb_Lastname;
        private System.Windows.Forms.TextBox tb_Firstname;
        private System.Windows.Forms.CheckBox checkbox_Active;
        private System.Windows.Forms.Label label_Firstname;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_Birthdate;
        private System.Windows.Forms.DataGridView dataGridView_Authors;
        private System.Windows.Forms.DateTimePicker tb_Birthdate;
        private System.Windows.Forms.Button button_clear;
    }
}