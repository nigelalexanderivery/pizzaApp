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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 fsx = new Form5();
            fsx.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Have Finished Ordering your pizza. It will arrive to your address in 30 Minutes.");
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
          
        }
    }
}
