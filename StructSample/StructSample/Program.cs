//Create a C# program with the following components:
// struct
// name: student
// members: id, firstname, lastname, quizscore
// enum name: remark
// values: poor = 1, fair = 2, good = 3, excellent =4

using System;

namespace StructSample
{
    public enum Remark: int
    {
        poor = 1, fair = 2, good = 3, excellent = 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            Program1 student = new Program1();
            Console.Write("First Name: ");
            student.firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            student.lastName = Console.ReadLine();
            Console.Write("ID no: ");
            student.id = int.Parse(Console.ReadLine());
            Console.Write("Score: ");
            student.quizScore = int.Parse(Console.ReadLine());
            Console.Write("Remark(1-4): ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    student.remark = "Poor";
                    break;
                case 2:
                    student.remark = "Fair";
                    break;
                case 3:
                    student.remark = "Good";
                    break;
                case 4:
                    student.remark = "Excellent";
                    break;
                default:
                    student.remark = "INC";
                    break;
            }

            Console.WriteLine("\nName: {0} {1}\nID no: {2}\nScore: {3}\nRemark: {4}",student.firstName, student.lastName, student.id, student.quizScore, student.remark);
            Console.ReadKey();
        }
    }
    public struct Program1 {
        public string firstName, lastName, remark;
        public int id, quizScore;
    }
}