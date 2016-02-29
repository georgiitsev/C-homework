using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Configuration;

namespace exam_Georgi_Itsev_29._02._2016
{
    public class Database
    {
        public static List<exam_Georgi_Itsev_29._02._2016.Population.Statistics> GetResults()
        {
            List<exam_Georgi_Itsev_29._02._2016.Population.Statistics> result = new List<exam_Georgi_Itsev_29._02._2016.Population.Statistics>();

            using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"]))
            {
                string line = reader.ReadLine();
                do
                {
                    string[] countryInfo = line.Split('|');
                    result.Add(new exam_Georgi_Itsev_29._02._2016.Population.Statistics()
                    {
                        Country = countryInfo[0],
                        Capital = countryInfo[1],
                        Population = int.Parse(countryInfo[2])
                    });
                    line = reader.ReadLine();
                } while (line != null);
            }
            return result;
        }
    }
}