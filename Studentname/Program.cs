using System;

namespace Student
{

    class Program
    {
        public struct Student
        {

            public int id_num, quizscore;
            public string firstname, lastname, remark;

        }

        public static void Main(string[] args)
        {

            int score;
            Student Student1 = new Student();
            Console.WriteLine("Enter your firstname.");
            Student1.firstname = Console.ReadLine();
            Console.WriteLine("Enter your lastname.");
            Student1.lastname = Console.ReadLine();
            Console.WriteLine("Enter your id number.");
            Student1.id_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your quizscore.");
            Student1.quizscore = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your remarks(1-4)");
            score = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\tP - Poor");
            Console.WriteLine("\tF - Fair");
            Console.WriteLine("\tG - Good");
            Console.WriteLine("\tE - Excellent");
            Console.Write("Your option? ");


            switch (score)
            {
                case 1:
                    Console.WriteLine("Poor");
                    break;
                case 2:
                    Console.WriteLine("Fair");
                    break;
                case 3:
                    Console.WriteLine("Good");
                    break;
                case 4:
                    Console.WriteLine("Excellent");
                    break;
            }

            Console.ReadKey();
        }


    }


}