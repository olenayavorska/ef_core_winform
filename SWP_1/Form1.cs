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
        public Form1()
        {
            InitializeComponent();
            db = new SageBookContext();
           // db.Sages.
            dataGridView1.DataSource = db.Sages.Local.ToBindingList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Form Form_add = new Form();
            DialogResult result = Form_add.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Sage sage = new Sage();
            //Form_add.
            //player.Age = (int)plForm.numericUpDown1.Value;
            //player.Name = plForm.textBox1.Text;
            //player.Position = plForm.comboBox1.SelectedItem.ToString();

            db.Sages.Add(sage);
            db.SaveChanges();

            MessageBox.Show("new object added");
        }
    }
    }
}
