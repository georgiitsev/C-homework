using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Text = Convert.ToString(listBox1.Items.Count);
            label3.Text = Convert.ToString(listBox2.Items.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                label4.Text = Convert.ToString(listBox1.Items.Count);
                label3.Text = Convert.ToString(listBox2.Items.Count);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (object ELE in listBox1.Items)
            {
                listBox2.Items.Add(ELE);
            }
                listBox1.Items.Clear();
                label4.Text = Convert.ToString(listBox1.Items.Count);
                label3.Text = Convert.ToString(listBox2.Items.Count);
            
        }
    }
}
