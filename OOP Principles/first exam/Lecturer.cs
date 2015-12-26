using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Lecturer : Person
    {
        public const int maximumLecturesPerWeek = 16;

        private string teachingUniversity;
        public string TeachingUniversity { get; set; }


        public Lecturer()
        {
        }

        public Lecturer(string firstName, string familyName, int workingExperience, string teachingUniversity)
            : base(firstName, familyName, workingExperience)
        {
            this.teachingUniversity = teachingUniversity;
        }

        public void WageExercise(string first)
        {
            Console.WriteLine("This lecturer can wage exercises in {0}!", first);
        }

        public void WageExercise(string first, string second)
        {
            Console.WriteLine("This lecturer can wage exercises in {0} and {1}!", first, second);
        }

        public void WageExercise(string first, string second, string third)
        {
            Console.WriteLine("This lecturer can wage exercises in {0}, {1} and {2}!", first, second, third);
        }
    }
}
