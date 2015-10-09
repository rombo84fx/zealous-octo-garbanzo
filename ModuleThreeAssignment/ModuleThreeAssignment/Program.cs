using System;

namespace ModuleThreeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
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
            validateDate(DateTime.Parse("05/07/1984"));
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
            Console.WriteLine("The student {0} {1} was born on: {2}", first, last, birthday);
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's birth date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            PrintTeacherDetails(firstName, lastName, birthDate.ToString());
        }

        static void PrintTeacherDetails(string first, string last, string birthday)
        {
            Console.WriteLine("The teacher {0} {1} was born on: {2}", first, last, birthday);
        }

        static void GetDegreeInformation()
        {
            Console.WriteLine("Enter the degree's name: ");
            string degreeName = Console.ReadLine();
            Console.WriteLine("Enter the degree's description: ");
            string degreeDescription = Console.ReadLine();
            Console.WriteLine("Enter the degree's type: ");
            string degreeType = Console.ReadLine();
            PrintDegreeInformation(degreeName, degreeDescription, degreeType);
        }

        static void PrintDegreeInformation(string name, string description, string type)
        {
            Console.WriteLine("The degree {0} is {1} and has a type of {2}", name, description, type);
        }

        static void GetProgramInformation()
        {
            Console.WriteLine("Enter the program's name: ");
            string programName = Console.ReadLine();
            Console.WriteLine("Enter the program's description: ");
            string programDescription = Console.ReadLine();
            Console.WriteLine("Enter the program's school: ");
            string programSchool = Console.ReadLine();
            PrintProgramInformation(programName, programDescription, programSchool);
        }

        static void PrintProgramInformation(string name, string description, string school)
        {
            Console.WriteLine("The school of {0} has the {1} program, that is {2}", school, name, description);
        }

        static void GetCourseInformation()
        {
            Console.WriteLine("Enter the course's name");
        }
        static string validateDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        static string validateDateChallenge(DateTime date)
        {

        }
    }
}
