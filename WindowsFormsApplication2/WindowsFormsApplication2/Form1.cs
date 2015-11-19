using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Good bye";
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ok_Click(object sender, EventArgs e)
        {
            textBox1.Text = " продължаваме напред :) ";
        }

        private void apply_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Въведените промени са приложени";
        }
    }
}
