using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Profesor : Lecturer
    {
        private string title;
        public string Title {get;set;}
       

        public Profesor(string firstName, string familyName, int workingExperience, string teachingUniversity, string title)
            : base(firstName, familyName, workingExperience, teachingUniversity)
        {
            this.title = title;
        }

        public void Say(string title, int workingExperience)
        {
            Console.WriteLine("This professor is {0} and has {1} years of working experience.", title, workingExperience);
        }

        public override void CheckHomeworks()
        {
            Console.WriteLine("This professor is obliged to check homeworks too!");
        }

        public void WageExams()
        {
            Console.WriteLine("This professor has to wage exams!");
        }
    
    }
}

 
