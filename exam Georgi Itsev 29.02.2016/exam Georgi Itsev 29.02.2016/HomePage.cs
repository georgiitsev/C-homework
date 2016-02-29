using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace exam_Georgi_Itsev_29._02._2016
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics()
            {
                Country = countryTextBox.Text,
                Capital = capitalTextBox.Text,
                Population = int.Parse(populationTextBox.Text),
            };

            using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
            {
                writer.WriteLine(statistics);
            }

            countryTextBox.Text = "";
            capitalTextBox.Text = "";
            populationTextBox.Text = "";
        }
    }
}