//Create a C# program with the following components:
// struct
// name: student
// members: id, firstname, lastname, quizscore
// enum name: remark
// values: poor = 1, fair = 2, good = 3, excellent =4

using System;

namespace StructSample {
    class Program {
        static void Main(string[] args) {
            Program1 student = new Program1();
            Console.Write("First Name: ");
            student.firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            student.lastName = Console.ReadLine();
            Console.Write("ID no: ");
            student.id = int.Parse(Console.ReadLine());
            Console.Write("Score: ");
            student.quizScore = float.Parse(Console.ReadLine());
            Console.WriteLine("\nName: {0} {1}\nID no: {2}\nScore: {3}\nRemark: {4}",student.firstName, student.lastName, student.id, student.quizScore, gradeRemark(student.quizScore));
            Console.ReadKey();
        }

        public enum Remark: int {
            poor = 1, fair = 2, good = 3, excellent = 4
        }

        public struct Program1 {
            public string firstName, lastName;
            public float quizScore;
            public int id;
        }

        public static string gradeRemark(float grade){
            if(grade > 69 && grade < 80) return (Remark.poor).ToString();
            if(grade > 79 && grade < 90) return (Remark.fair).ToString();
            if(grade > 89 && grade < 100) return (Remark.good).ToString();
            if(grade == 100) return (Remark.excellent).ToString();
            return "";
        }
    }
}
