using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[16];
            string[] family = new string[16];
            int[] years = new int[16];

            for (int i = 0; i < 16; i++)
            {
                Console.Write("Enter fisrt name: ");
                name[i] = Console.ReadLine();
                Console.Write("Enter family name: ");
                family[i] = Console.ReadLine();
                Console.Write("Enter years of working experience: ");
                years[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (years[i] < 0)
                {
                    Massage();
                    break;
                }
            }

            string[] college = new string[] { "Telecommunications College", "Economics College", "Business College" };
            string[] university = new string[] { "Technical University", "Sofia University", "New Bulgarian University" };
            string[] title = new string[] { "Doctor", "Docent" };
            string[] subject = new string[] { "English", "Literature", "History" };
            string exercise1 = "Physics";
            string exercise2 = "Chemistry";
            string exercise3 = "Mathematics";

         
            for (int i = 0; i < 16; i++)
            {
                if (years[i] < 0)
                {
                    Massage();
                    break;
                }
                if (i >= 0 && i <= 2)
                {
                    Teacher teacher = new Teacher(name[i], family[i], years[i], subject[i]);
                    teacher.FirstName = name[i];
                    teacher.FamilyName = family[i];
                    teacher.WorkingExperience = years[i];
                    teacher.TeachingSubject = subject[i];
                    Console.WriteLine("{0} {1} has {2} years of working experience and teaches {3}.", teacher.FirstName, teacher.FamilyName, teacher.WorkingExperience, teacher.TeachingSubject);
                    teacher.SayHello();
                    teacher.SayGoodbye();
                    teacher.CheckHomeworks();
                    Console.WriteLine();
                }
                else if (i >= 3 && i <= 5)
                {
                    SchoolTeacher schoolTeacher = new SchoolTeacher();
                    schoolTeacher.FirstName = name[i];
                    schoolTeacher.FamilyName = family[i];
                    schoolTeacher.WorkingExperience = years[i];
                    schoolTeacher.TeachingSubject = subject[i - 3];
                    Console.WriteLine("{0} {1} has {2} years of working experience and teaches {3}.", schoolTeacher.FirstName, schoolTeacher.FamilyName, schoolTeacher.WorkingExperience, schoolTeacher.TeachingSubject);
                    schoolTeacher.SayHello();
                    schoolTeacher.SayGoodbye();
                    schoolTeacher.CheckHomeworks();
                    schoolTeacher.EntertainKids();
                    schoolTeacher.TeachingClasses();
                    Console.WriteLine();
                }
                else if (i >= 6 && i <= 8)
                {
                    CollegeTeacher collegeTeacher = new CollegeTeacher(name[i], family[i], years[i], subject[i - 6], college[i - 6]);
                    collegeTeacher.FirstName = name[i];
                    collegeTeacher.FamilyName = family[i];
                    collegeTeacher.WorkingExperience = years[i];
                    collegeTeacher.TeachingSubject = subject[i - 6];
                    collegeTeacher.TeachingCollege = college[i - 6];
                    Console.WriteLine("{0} {1} has {2} years of working experience and teaches {3} in {4}.", collegeTeacher.FirstName, collegeTeacher.FamilyName, collegeTeacher.WorkingExperience, collegeTeacher.TeachingSubject, collegeTeacher.TeachingCollege);
                    collegeTeacher.SayHello();
                    collegeTeacher.SayGoodbye();
                    collegeTeacher.CheckHomeworks();
                    Console.WriteLine();
                }
                else if (i >= 9 && i <= 11)
                {
                    Lecturer lecturer = new Lecturer(name[i], family[i], years[i], university[i - 9]);
                    lecturer.FirstName = name[i];
                    lecturer.FamilyName = family[i];
                    lecturer.WorkingExperience = years[i];
                    lecturer.TeachingUniversity = university[i - 9];
                    Console.WriteLine("{0} {1} has {2} years of working experience in {3}.", lecturer.FirstName, lecturer.FamilyName, lecturer.WorkingExperience, lecturer.TeachingUniversity);
                    lecturer.SayHello();
                    lecturer.CheckHomeworks();
                    if (i == 9)
                    { lecturer.WageExercise(exercise1); }
                    if (i == 10)
                    { lecturer.WageExercise(exercise1, exercise2); }
                    if (i == 11)
                    { lecturer.WageExercise(exercise1, exercise2, exercise3); }
                    Console.WriteLine("This lecturer can't wage more than {0} lectures per week!", Lecturer.maximumLecturesPerWeek);
                    Console.WriteLine();
                }
                else if (i >= 12 && i <= 13)
                {
                    Profesor professor = new Profesor(name[i], family[i], years[i], university[i - 12], title[i - 12]);
                    professor.FirstName = name[i];
                    professor.FamilyName = family[i];
                    professor.WorkingExperience = years[i];
                    professor.TeachingUniversity = university[i - 12];
                    professor.Title = title[i - 12];
                    Console.WriteLine("Professor {0} {1} is teaching at {2}.", professor.FirstName, professor.FamilyName, professor.TeachingUniversity);
                    professor.Say(professor.Title, professor.WorkingExperience);
                    professor.CheckHomeworks();
                    Console.WriteLine("This professor can't wage more than {0} lectures per week!", Profesor.maximumLecturesPerWeek);
                    professor.WageExams();
                    Console.WriteLine();
                }
                else if (i >= 14 && i <= 15)
                {
                    bool chiefAssistant = true;

                    if (years[i] < 10)
                    { chiefAssistant = false; }

                    Assistant assistant = new Assistant(name[i], family[i], years[i], university[i - 14], chiefAssistant);
                    assistant.FirstName = name[i];
                    assistant.FamilyName = family[i];
                    assistant.WorkingExperience = years[i];
                    assistant.TeachingUniversity = university[i - 14];
                    assistant.ChiefAssistant = chiefAssistant;
                    Console.WriteLine("{0} {1} has {2} years of working experience in {3}.", assistant.FirstName, assistant.FamilyName, assistant.WorkingExperience, assistant.TeachingUniversity);
                    assistant.CheckAssistant(assistant.FirstName, assistant.FamilyName, assistant.ChiefAssistant);
                    assistant.CheckHomeworks();
                    Console.WriteLine("This assistant can't assit in more than {0} lectures per week!", Assistant.maximumLecturesPerWeek);
                    assistant.CheckExams();
                    assistant.WriteScientificArticles();
                    Console.WriteLine();
                }
            }

            Console.WriteLine("TOTAL PERSONS EMPLOYED: " + Person.GetPersonCount());
            Console.WriteLine();
        }

        private static void Massage()
        {
            Console.WriteLine("The years must be positive plaese try again ");
        }
    }
}
