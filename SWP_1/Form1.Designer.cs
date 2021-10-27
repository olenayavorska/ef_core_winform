
namespace SWP_1
{
    partial class Form1
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
            this.Book = new System.Windows.Forms.TabControl();
            this.Sage = new System.Windows.Forms.TabPage();
            this.city_sage = new System.Windows.Forms.TextBox();
            this.photo_sage = new System.Windows.Forms.TextBox();
            this.age_sage = new System.Windows.Forms.TextBox();
            this.name_sage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Change_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add_button = new System.Windows.Forms.Button();
            this.Book_page = new System.Windows.Forms.TabPage();
            this.Sage_Book = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.Book.SuspendLayout();
            this.Sage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Book
            // 
            this.Book.Controls.Add(this.Sage);
            this.Book.Controls.Add(this.Book_page);
            this.Book.Controls.Add(this.Sage_Book);
            this.Book.Location = new System.Drawing.Point(4, 1);
            this.Book.Name = "Book";
            this.Book.SelectedIndex = 0;
            this.Book.Size = new System.Drawing.Size(830, 542);
            this.Book.TabIndex = 0;
            // 
            // Sage
            // 
            this.Sage.Controls.Add(this.city_sage);
            this.Sage.Controls.Add(this.photo_sage);
            this.Sage.Controls.Add(this.age_sage);
            this.Sage.Controls.Add(this.name_sage);
            this.Sage.Controls.Add(this.label6);
            this.Sage.Controls.Add(this.label5);
            this.Sage.Controls.Add(this.label4);
            this.Sage.Controls.Add(this.label3);
            this.Sage.Controls.Add(this.Change_button);
            this.Sage.Controls.Add(this.Delete_button);
            this.Sage.Controls.Add(this.dataGridView1);
            this.Sage.Controls.Add(this.Add_button);
            this.Sage.Location = new System.Drawing.Point(4, 29);
            this.Sage.Name = "Sage";
            this.Sage.Padding = new System.Windows.Forms.Padding(3);
            this.Sage.Size = new System.Drawing.Size(822, 509);
            this.Sage.TabIndex = 0;
            this.Sage.Text = "Sage";
            this.Sage.UseVisualStyleBackColor = true;
            this.Sage.Click += new System.EventHandler(this.Sage_Click);
            // 
            // city_sage
            // 
            this.city_sage.Location = new System.Drawing.Point(579, 57);
            this.city_sage.Name = "city_sage";
            this.city_sage.Size = new System.Drawing.Size(142, 27);
            this.city_sage.TabIndex = 14;
            this.city_sage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sity_sage_KeyPress);
            // 
            // photo_sage
            // 
            this.photo_sage.Location = new System.Drawing.Point(411, 57);
            this.photo_sage.Name = "photo_sage";
            this.photo_sage.Size = new System.Drawing.Size(92, 27);
            this.photo_sage.TabIndex = 13;
            this.photo_sage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.photo_sage_KeyPress);
            // 
            // age_sage
            // 
            this.age_sage.Location = new System.Drawing.Point(216, 57);
            this.age_sage.Name = "age_sage";
            this.age_sage.Size = new System.Drawing.Size(77, 27);
            this.age_sage.TabIndex = 12;
            this.age_sage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_sage_KeyPress);
            // 
            // name_sage
            // 
            this.name_sage.Location = new System.Drawing.Point(16, 57);
            this.name_sage.Name = "name_sage";
            this.name_sage.Size = new System.Drawing.Size(116, 27);
            this.name_sage.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "city";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "photo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "name";
            // 
            // Change_button
            // 
            this.Change_button.Location = new System.Drawing.Point(319, 128);
            this.Change_button.Name = "Change_button";
            this.Change_button.Size = new System.Drawing.Size(102, 34);
            this.Change_button.TabIndex = 2;
            this.Change_button.Text = "Update";
            this.Change_button.UseVisualStyleBackColor = true;
            this.Change_button.Click += new System.EventHandler(this.Change_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(599, 129);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(122, 35);
            this.Delete_button.TabIndex = 3;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(743, 302);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(16, 129);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(116, 33);
            this.Add_button.TabIndex = 1;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Book_page
            // 
            this.Book_page.Location = new System.Drawing.Point(4, 29);
            this.Book_page.Name = "Book_page";
            this.Book_page.Padding = new System.Windows.Forms.Padding(3);
            this.Book_page.Size = new System.Drawing.Size(822, 509);
            this.Book_page.TabIndex = 1;
            this.Book_page.Text = "Book";
            this.Book_page.UseVisualStyleBackColor = true;
            // 
            // Sage_Book
            // 
            this.Sage_Book.Location = new System.Drawing.Point(4, 29);
            this.Sage_Book.Name = "Sage_Book";
            this.Sage_Book.Padding = new System.Windows.Forms.Padding(3);
            this.Sage_Book.Size = new System.Drawing.Size(822, 509);
            this.Sage_Book.TabIndex = 2;
            this.Sage_Book.Text = "Sage_Book";
            this.Sage_Book.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 548);
            this.Controls.Add(this.Book);
            this.MaximumSize = new System.Drawing.Size(853, 595);
            this.MinimumSize = new System.Drawing.Size(853, 595);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Book.ResumeLayout(false);
            this.Sage.ResumeLayout(false);
            this.Sage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Book;
        private System.Windows.Forms.TabPage Sage;
        private System.Windows.Forms.TabPage Book_page;
        private System.Windows.Forms.TabPage Sage_Book;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Change_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox city_sage;
        private System.Windows.Forms.TextBox photo_sage;
        private System.Windows.Forms.TextBox age_sage;
        private System.Windows.Forms.TextBox name_sage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

