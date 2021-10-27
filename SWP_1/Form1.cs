using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWP_1
{
    public partial class Form1 : Form
    {
        SageBookContext db;

        //int ID = 0;
        public Form1()
        {
            InitializeComponent();
            db = new SageBookContext();
            //db.Sages.Load();
            db.Sages.Load();
            db.Books.Load();
            dataGridView1.DataSource = db.Sages.Local.ToBindingList();
            dataGridView2.DataSource = db.Books.Local.ToBindingList();
            comboBox1.DataSource = db.Sages.Local.ToList();
            comboBox2.DataSource = db.Sages.Local.ToList();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            
            if (name_sage.Text!="" && photo_sage.Text != "" && city_sage.Text != "" && age_sage.Text != "") {
                Sage sage = new Sage();
                //ID++;
                //sage.IdSage = ID;
                sage.name = name_sage.Text;
                sage.photo = Convert.ToInt32(photo_sage.Text);
                sage.age = Convert.ToInt32(age_sage.Text);
                sage.city = city_sage.Text;
                db.Sages.Add(sage);
                
                db.SaveChanges();
            }
            else { MessageBox.Show("fill in all fields, please"); }

            //MessageBox.Show("new object added");
        }

        private void id_sage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void age_sage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void photo_sage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void sity_sage_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var _dataGrid = (DataGridView)sender;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                _dataGrid[0, i].ReadOnly = true;
            }
            //dataGridView1.Columns[1].ReadOnly =true;
            //??????????????????????????
            //why not working

        }

        private void Change_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Sage sage = db.Sages.Find(id);
                sage.name = name_sage.Text;
                sage.photo = Convert.ToInt32(photo_sage.Text);
                sage.age = Convert.ToInt32(age_sage.Text);
                sage.city = city_sage.Text;
                db.SaveChanges();
               
               
            }

         }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Sage sage = db.Sages.Find(id);
                db.Sages.Remove(sage);
                db.SaveChanges();
                
                
            }
        }
    //    private void dataGridView1_DataBindingComplete(object sender,
    //DataGridViewBindingCompleteEventArgs e)
    //    {
    //        dataGridView1.Columns["IdSage"].Visible = false;
    //    }
        private void Sage_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void book_add_Click(object sender, EventArgs e)
        {
            if (name_book.Text != "" && description_book.Text != "" )
            {
                Book book = new Book();
                //ID++;
                //sage.IdSage = ID;
                book.name = name_book.Text;
                book.description = description_book.Text;
                db.Books.Add(book);

                db.SaveChanges();
            }
            else { MessageBox.Show("fill in all fields, please"); }

        }

        private void book_update_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int index = dataGridView2.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView2[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Book book = db.Books.Find(id);
                book.name = name_book.Text;
                book.description = description_book.Text;
                db.SaveChanges();


            }
        }

        private void book_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int index = dataGridView2.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView2[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Book book = db.Books.Find(id);
                db.Books.Remove(book);
                db.SaveChanges();


            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void Sage_Book_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
