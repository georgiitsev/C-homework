using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcolator
{
    public partial class Form1 : Form
    {
        double l,r,res, char oper ;
        public Form1()
        {
            InitializeComponent();
        }

        private void digits_click(object sender, EventArgs e)
        {
            Button Bob = (Button)sender;
            textBox1.Text = textBox1.Text + Bob.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf('.')<0) textBox1.Text = textBox1.Text + '.';
            {
               
            }
        }

        private void operation_click(object sender, EventArgs e)
        {
            l =Convert.ToDouble (textBox1.Text);
            textBox1.Text="";
             Button Bob = (Button)sender;
           oper= Convert.ToChar(Bob.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            r =Convert.ToDouble( textBox1.Text);
            switch (oper)
            {
                case '+' : res = l +  r ;break;
		        case '-' : res = l +  r ;break;
                case '*' : res = l +  r ;break;
                case '/' : res = l +  r ;break;
                case '^' : res =Math.Pow (l,r) ;break;
 break;
	}
            textBox1.Text = Convert.ToString(res);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':button6.PerformClick();break;
                case '1':button1.PerformClick();break;
                    case '2':button2.PerformClick();break;
                    case '3':button3.PerformClick();break;
                    case '4':button4.PerformClick();break;
                    case '5':button5.PerformClick();break;
                    case '6':button6.PerformClick();break;
                    case '7':button7.PerformClick();break;
                    case '8':button8.PerformClick();break;
                    case '9':button9.PerformClick();break;
                    
                    case (char) Keys.Back:button19.PerformClick();break;
            
	
		
 break;
	}
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

    }
}
