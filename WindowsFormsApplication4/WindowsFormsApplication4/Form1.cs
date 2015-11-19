using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Въведете стойност за N");
            else
            {
                int n; double core; Random rn = new Random(); double x;
                n = Convert.ToInt32(textBox1.Text);
                if (checkBox1.Checked) core = 0.2; else core = 0;
                listBox1.Items.Clear();
                if (radioButton2.Checked)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        x = rn.Next(50, 100); x = x + core * x;
                        listBox1.Items.Add(x);

                    }
                }
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        x = 2 * i + core * 2 * i;
                        listBox1.Items.Add(x);

                    }
                }

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double suma = 0;
            foreach (object el in listBox1.SelectedItems)
                suma = suma + Convert.ToDouble(el);
            textBox2.Text = "Сумата на маркираните елементи на списъчното поле е =" + Convert.ToString(suma);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
