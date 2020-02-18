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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Small"))
            {
                ListViewItem item = new ListViewItem(" Small Pizza");
                item.SubItems.Add("");
                item.SubItems.Add("9.00");
            }
            if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Medium"))
            {
                ListViewItem item = new ListViewItem(" Medium Pizza");
                item.SubItems.Add("");
                item.SubItems.Add("10.00");
            }
            if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Large"))
            {
                ListViewItem item = new ListViewItem(" Large Pizza");
                item.SubItems.Add("");
                item.SubItems.Add("12.00");
            }
            if (comboBox1.SelectedIndex == comboBox1.FindStringExact("XXtra Large"))
            {
                ListViewItem item = new ListViewItem(" XXtra Large Pizza");
                item.SubItems.Add("");
                item.SubItems.Add("15.00");
            }

            if (comboBox2.SelectedIndex == comboBox1.FindStringExact("Thin"))
            {
                ListViewItem item = new ListViewItem(" Small Pizza");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
            }
            if (comboBox2.SelectedIndex == comboBox1.FindStringExact("Thick"))
            {
                ListViewItem item = new ListViewItem(" Medium Pizza");
                item.SubItems.Add("");
                item.SubItems.Add("1.00");
            }
            if (comboBox2.SelectedIndex == comboBox1.FindStringExact("Large"))
            {
                ListViewItem item = new ListViewItem(" Large Pizza");
                item.SubItems.Add("");
                item.SubItems.Add("12.00");
            }

            this.Hide();
            Form5 nsds = new Form5();
            nsds.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 sfs = new Form7();
            sfs.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Small"))
            {
                ListViewItem item = new ListViewItem(" Small Pizza");
                item.SubItems.Add("");
                item.SubItems.Add("9.00");        
            }
            if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Medium"))
            {
                ListViewItem item = new ListViewItem(" Medium Pizza");
                item.SubItems.Add("");
                item.SubItems.Add("10.00");
            }
            if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Large"))
            {
                ListViewItem item = new ListViewItem(" Large Pizza");
                item.SubItems.Add("");
                item.SubItems.Add("12.00");
            }
            if (comboBox1.SelectedIndex == comboBox1.FindStringExact("XXtra Large"))
            {
                ListViewItem item = new ListViewItem(" XXtra Large Pizza");
                item.SubItems.Add("");
                item.SubItems.Add("15.00");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private int checkCounter;

        public void OnCheckedChanged(object sender, EventArgs e)
        {
            // Increase or decrease the check counter
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
                checkCounter++;
            else
                checkCounter--;

            // prevent checking
            if (checkCounter == 4)
            {
                MessageBox.Show("Please Only Select 4 Toppings", "Try Again");
                box.Checked = false;
            }

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == comboBox1.FindStringExact("Thin"))
            {
                ListViewItem item = new ListViewItem(" Small Pizza");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
            }
            if (comboBox2.SelectedIndex == comboBox1.FindStringExact("Thick"))
            {
                ListViewItem item = new ListViewItem(" Medium Pizza");
                item.SubItems.Add("");
                item.SubItems.Add("1.00");
            }
            if (comboBox2.SelectedIndex == comboBox1.FindStringExact("Large"))
            {
                ListViewItem item = new ListViewItem(" Large Pizza");
                item.SubItems.Add("");
                item.SubItems.Add("12.00");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
