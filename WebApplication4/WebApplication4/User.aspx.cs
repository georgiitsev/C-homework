using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication4
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerButton_Click(object sender, EventArgs e)
        {

            if (firstNameBox.Text == " " || passwordBox.Text == " " || confirmPassBox.Text == " " || emailBox.Text == " " || ageBox.Text == " ")
            {
               Console.WriteLine("Please fill all boxes");
            }
            else if (passwordBox.Text != confirmPassBox.Text)
            {
               Console.WriteLine("Invalid password");
            }
            else
            {
                
                using (StreamWriter info = new StreamWriter (Server.MapPath("UserInformation.txt"), true))
                {
                    info.WriteLine(firstName + "" + firstNameBox.Text);
                    info.WriteLine(password + "" + passwordBox.Text);
                    info.WriteLine(age + "" + ageBox.Text);
                    info.WriteLine(email + "" + emailBox.Text);
                }
            }





        }
    }
}