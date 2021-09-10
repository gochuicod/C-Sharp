using System;

namespace Activity1_INOC
{
    class Program
    {
        public static void Main(string[] args)
        {

            student stud;

            Console.Write("Enter your id: ");
            stud.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your First Name: ");
            stud.firstName = Console.ReadLine();
            Console.Write("Enter your Last Name: ");
            stud.lastName = Console.ReadLine();
            Console.Write("Enter Quiz score: ");
            stud.quizscore = Convert.ToInt32(Console.ReadLine());

            if (stud.quizscore >= 90)
            {
                int remarks = 4;
                Console.WriteLine();
                Console.WriteLine("Student ID: " + stud.id);
                Console.WriteLine("Student Name: " + stud.firstName + " " + stud.lastName);
                Console.WriteLine("Quiz Score: " + (remark)remarks);

            }

            if (stud.quizscore >= 80 && stud.quizscore < 90)
            {
                int remarks = 3;
                Console.WriteLine();
                Console.WriteLine("Student ID: " + stud.id);
                Console.WriteLine("Student Name: " + stud.firstName + " " + stud.lastName);
                Console.WriteLine("Quiz Score: " + (remark)remarks);
            }

            if (stud.quizscore >= 70 && stud.quizscore < 80)
            {
                int remarks = 2;
                Console.WriteLine();
                Console.WriteLine("Student ID: " + stud.id);
                Console.WriteLine("Student Name: " + stud.firstName + " " + stud.lastName);
                Console.WriteLine("Quiz Score: " + (remark)remarks);
            }

            if (stud.quizscore < 70)
            {
                int remarks = 1;
                Console.WriteLine();
                Console.WriteLine("Student ID: " + stud.id);
                Console.WriteLine("Student Name: " + stud.firstName + " " + stud.lastName);
                Console.WriteLine("Quiz Score: " + (remark)remarks);
            }

        }

        public struct student
        {

            public int id;
            public string firstName;
            public string lastName;
            public int quizscore;

        }
        enum remark
        {
            Poor = 1,
            Fair = 2,
            Good = 3,
            Excellent = 4,

        }
    }
}

