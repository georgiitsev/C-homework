using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;

namespace exam_Georgi_Itsev_29._02._2016
{
    public partial class Search_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            exam_Georgi_Itsev_29._02._2016.Population.Statistics statistics = new exam_Georgi_Itsev_29._02._2016.Population.Statistics()
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
    }
}