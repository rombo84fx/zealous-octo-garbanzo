using System;

namespace ModuleThreeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Student Attributes
            //string studentFirstName;
            //string studentLastName;
            //DateTime studentBirthDate;

            //// Teacher Attributes
            //string teacherFirstName;
            //string teacherLastName;
            //DateTime teacherBirthDate;

            //// Degree Attributes
            //string degreeName;
            //string degreeDescription;
            //string degreeType;

            //// Program Attributes
            //string programName;
            //string programDescription;
            //string programSchool;

            //// Course Attributes
            //string courseName;
            //string courseDescription;
            //string courseInstructor;

            GetStudentInformation();
            Console.ReadKey();
        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birth date:");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            PrintStudentDetails(firstName, lastName, birthDate.ToString("d"));
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }
    }
}
