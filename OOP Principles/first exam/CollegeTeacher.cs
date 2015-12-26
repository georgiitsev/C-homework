using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class CollegeTeacher : Teacher
    {
        private string teachingCollege;
        public string TeachingCollege { get; set; }

        public CollegeTeacher(string firstName, string familyName, int workingExperience, string teachingSubject, string teachingCollege)
            : base(firstName, familyName, workingExperience, teachingSubject)
        {
            this.teachingCollege = teachingCollege;
        }
    }
}
