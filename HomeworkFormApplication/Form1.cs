using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkFormApplication
{
    public partial class UserInformation : Form
    {
        public UserInformation()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

            if (firstNameBox.Text == " " || emailBox.Text == "" || lastNameBox.Text == "")
            {
                MessageBox.Show("Your fields are empty.Please field them ");
            }
            else if ((emailBox.Text).Contains('@') == false || (emailBox.Text).Contains('.') == false)
            {
                MessageBox.Show("Are you mising somthing ? ");
            }
            using (StreamWriter text = new StreamWriter("UserInformation.txt", true))
            {
                text.WriteLine("User:");
                text.WriteLine(FirstName.Text + " " + firstNameBox.Text);
                text.WriteLine(LastName.Text + " " + emailBox.Text);
                text.WriteLine(eMail.Text + " " + lastNameBox.Text);
                text.WriteLine("");
                firstNameBox.Clear();
                emailBox.Clear();
                lastNameBox.Clear(); ;
            }
        }

    }
}
