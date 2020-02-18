using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 fs = new Form4();
            fs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            textBox1.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 ijas = new Form6();
            ijas.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
