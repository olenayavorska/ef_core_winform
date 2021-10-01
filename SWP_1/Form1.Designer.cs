
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Book_page = new System.Windows.Forms.TabPage();
            this.Sage_Book = new System.Windows.Forms.TabPage();
            this.Add_button = new System.Windows.Forms.Button();
            this.Change_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
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
            this.Sage.Controls.Add(this.dataGridView1);
            this.Sage.Location = new System.Drawing.Point(4, 29);
            this.Sage.Name = "Sage";
            this.Sage.Padding = new System.Windows.Forms.Padding(3);
            this.Sage.Size = new System.Drawing.Size(822, 509);
            this.Sage.TabIndex = 0;
            this.Sage.Text = "Sage";
            this.Sage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(721, 503);
            this.dataGridView1.TabIndex = 0;
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
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(840, 33);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(156, 46);
            this.Add_button.TabIndex = 1;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Change_button
            // 
            this.Change_button.Location = new System.Drawing.Point(840, 114);
            this.Change_button.Name = "Change_button";
            this.Change_button.Size = new System.Drawing.Size(156, 47);
            this.Change_button.TabIndex = 2;
            this.Change_button.Text = "Update";
            this.Change_button.UseVisualStyleBackColor = true;
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(840, 185);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(156, 48);
            this.Delete_button.TabIndex = 3;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 548);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Change_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Book);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Book.ResumeLayout(false);
            this.Sage.ResumeLayout(false);
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
    }
}

