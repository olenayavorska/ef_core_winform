
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
            this.label2 = new System.Windows.Forms.Label();
            this.Book_page = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name_book = new System.Windows.Forms.TextBox();
            this.description_book = new System.Windows.Forms.RichTextBox();
            this.book_add = new System.Windows.Forms.Button();
            this.book_update = new System.Windows.Forms.Button();
            this.book_delete = new System.Windows.Forms.Button();
            this.Sage = new System.Windows.Forms.TabPage();
            this.Add_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Change_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name_sage = new System.Windows.Forms.TextBox();
            this.age_sage = new System.Windows.Forms.TextBox();
            this.photo_sage = new System.Windows.Forms.TextBox();
            this.city_sage = new System.Windows.Forms.TextBox();
            this.Book = new System.Windows.Forms.TabControl();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Sage_Book = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.add_sagebook = new System.Windows.Forms.Button();
            this.edit_sagebook = new System.Windows.Forms.Button();
            this.delete_sagebook = new System.Windows.Forms.Button();
            this.Book_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Sage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Sage_Book.SuspendLayout();
            this.SuspendLayout();
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
            // Book_page
            // 
            this.Book_page.Controls.Add(this.book_delete);
            this.Book_page.Controls.Add(this.book_update);
            this.Book_page.Controls.Add(this.book_add);
            this.Book_page.Controls.Add(this.description_book);
            this.Book_page.Controls.Add(this.name_book);
            this.Book_page.Controls.Add(this.label7);
            this.Book_page.Controls.Add(this.label1);
            this.Book_page.Controls.Add(this.dataGridView2);
            this.Book_page.Location = new System.Drawing.Point(4, 29);
            this.Book_page.Name = "Book_page";
            this.Book_page.Padding = new System.Windows.Forms.Padding(3);
            this.Book_page.Size = new System.Drawing.Size(822, 509);
            this.Book_page.TabIndex = 1;
            this.Book_page.Text = "Book";
            this.Book_page.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeight = 29;
            this.dataGridView2.Location = new System.Drawing.Point(4, 225);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(755, 281);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "description";
            // 
            // name_book
            // 
            this.name_book.Location = new System.Drawing.Point(18, 65);
            this.name_book.Name = "name_book";
            this.name_book.Size = new System.Drawing.Size(153, 27);
            this.name_book.TabIndex = 3;
            // 
            // description_book
            // 
            this.description_book.Location = new System.Drawing.Point(468, 51);
            this.description_book.Name = "description_book";
            this.description_book.Size = new System.Drawing.Size(291, 124);
            this.description_book.TabIndex = 4;
            this.description_book.Text = "";
            // 
            // book_add
            // 
            this.book_add.Location = new System.Drawing.Point(18, 130);
            this.book_add.Name = "book_add";
            this.book_add.Size = new System.Drawing.Size(113, 34);
            this.book_add.TabIndex = 5;
            this.book_add.Text = "Add";
            this.book_add.UseVisualStyleBackColor = true;
            this.book_add.Click += new System.EventHandler(this.book_add_Click);
            // 
            // book_update
            // 
            this.book_update.Location = new System.Drawing.Point(167, 130);
            this.book_update.Name = "book_update";
            this.book_update.Size = new System.Drawing.Size(113, 34);
            this.book_update.TabIndex = 6;
            this.book_update.Text = "Update";
            this.book_update.UseVisualStyleBackColor = true;
            this.book_update.Click += new System.EventHandler(this.book_update_Click);
            // 
            // book_delete
            // 
            this.book_delete.Location = new System.Drawing.Point(322, 130);
            this.book_delete.Name = "book_delete";
            this.book_delete.Size = new System.Drawing.Size(113, 34);
            this.book_delete.TabIndex = 7;
            this.book_delete.Text = "Delete";
            this.book_delete.UseVisualStyleBackColor = true;
            this.book_delete.Click += new System.EventHandler(this.book_delete_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "name";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "photo";
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
            // name_sage
            // 
            this.name_sage.Location = new System.Drawing.Point(16, 57);
            this.name_sage.Name = "name_sage";
            this.name_sage.Size = new System.Drawing.Size(116, 27);
            this.name_sage.TabIndex = 11;
            // 
            // age_sage
            // 
            this.age_sage.Location = new System.Drawing.Point(216, 57);
            this.age_sage.Name = "age_sage";
            this.age_sage.Size = new System.Drawing.Size(77, 27);
            this.age_sage.TabIndex = 12;
            this.age_sage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_sage_KeyPress);
            // 
            // photo_sage
            // 
            this.photo_sage.Location = new System.Drawing.Point(411, 57);
            this.photo_sage.Name = "photo_sage";
            this.photo_sage.Size = new System.Drawing.Size(92, 27);
            this.photo_sage.TabIndex = 13;
            this.photo_sage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.photo_sage_KeyPress);
            // 
            // city_sage
            // 
            this.city_sage.Location = new System.Drawing.Point(579, 57);
            this.city_sage.Name = "city_sage";
            this.city_sage.Size = new System.Drawing.Size(142, 27);
            this.city_sage.TabIndex = 14;
            this.city_sage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sity_sage_KeyPress);
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
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(4, 220);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(755, 286);
            this.dataGridView3.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "idSage";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "idBook";
            // 
            // Sage_Book
            // 
            this.Sage_Book.Controls.Add(this.delete_sagebook);
            this.Sage_Book.Controls.Add(this.edit_sagebook);
            this.Sage_Book.Controls.Add(this.add_sagebook);
            this.Sage_Book.Controls.Add(this.comboBox3);
            this.Sage_Book.Controls.Add(this.label9);
            this.Sage_Book.Controls.Add(this.label8);
            this.Sage_Book.Controls.Add(this.comboBox1);
            this.Sage_Book.Controls.Add(this.dataGridView3);
            this.Sage_Book.Controls.Add(this.comboBox2);
            this.Sage_Book.Location = new System.Drawing.Point(4, 29);
            this.Sage_Book.Name = "Sage_Book";
            this.Sage_Book.Padding = new System.Windows.Forms.Padding(3);
            this.Sage_Book.Size = new System.Drawing.Size(822, 509);
            this.Sage_Book.TabIndex = 2;
            this.Sage_Book.Text = "SageBook";
            this.Sage_Book.UseVisualStyleBackColor = true;
            this.Sage_Book.Click += new System.EventHandler(this.Sage_Book_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(336, 240);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(282, 55);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(151, 28);
            this.comboBox3.TabIndex = 5;
            // 
            // add_sagebook
            // 
            this.add_sagebook.Location = new System.Drawing.Point(17, 123);
            this.add_sagebook.Name = "add_sagebook";
            this.add_sagebook.Size = new System.Drawing.Size(119, 32);
            this.add_sagebook.TabIndex = 6;
            this.add_sagebook.Text = "Add";
            this.add_sagebook.UseVisualStyleBackColor = true;
            // 
            // edit_sagebook
            // 
            this.edit_sagebook.Location = new System.Drawing.Point(270, 123);
            this.edit_sagebook.Name = "edit_sagebook";
            this.edit_sagebook.Size = new System.Drawing.Size(125, 32);
            this.edit_sagebook.TabIndex = 7;
            this.edit_sagebook.Text = "Update";
            this.edit_sagebook.UseVisualStyleBackColor = true;
            // 
            // delete_sagebook
            // 
            this.delete_sagebook.Location = new System.Drawing.Point(500, 123);
            this.delete_sagebook.Name = "delete_sagebook";
            this.delete_sagebook.Size = new System.Drawing.Size(112, 32);
            this.delete_sagebook.TabIndex = 8;
            this.delete_sagebook.Text = "Delete";
            this.delete_sagebook.UseVisualStyleBackColor = true;
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
            this.Book_page.ResumeLayout(false);
            this.Book_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Sage.ResumeLayout(false);
            this.Sage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Book.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Sage_Book.ResumeLayout(false);
            this.Sage_Book.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Book_page;
        private System.Windows.Forms.Button book_delete;
        private System.Windows.Forms.Button book_update;
        private System.Windows.Forms.Button book_add;
        private System.Windows.Forms.RichTextBox description_book;
        private System.Windows.Forms.TextBox name_book;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage Sage;
        private System.Windows.Forms.TextBox city_sage;
        private System.Windows.Forms.TextBox photo_sage;
        private System.Windows.Forms.TextBox age_sage;
        private System.Windows.Forms.TextBox name_sage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Change_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.TabControl Book;
        private System.Windows.Forms.TabPage Sage_Book;
        private System.Windows.Forms.Button delete_sagebook;
        private System.Windows.Forms.Button edit_sagebook;
        private System.Windows.Forms.Button add_sagebook;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

