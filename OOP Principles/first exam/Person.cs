using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    abstract class Person
    {
        public static int personCount;

        protected string firstName;
        public string FirstName { get; set; }

        protected string familyName;
        public string FamilyName { get; set; }

        protected int workingExperience;
        public int WorkingExperience { get; set; }

        public Person()
        {
            personCount += 1;
        }

        public Person(string firstName, string familyName, int workingExperience)
        {
            this.firstName = firstName;
            this.familyName = familyName;
            this.workingExperience = workingExperience;

            personCount += 1;
        }

        public static int GetPersonCount()
        {
            return personCount;
        }

        public void SayHello()
        {
            Console.WriteLine("He/She has to greet with \"Good afternoon!\" students every day!");
        }

        public virtual void CheckHomeworks()
        {
            Console.WriteLine("He/She is supposed to check homeworks!");
        }
    }
}
