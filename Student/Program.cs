using System;

namespace Student
{
    
    class Program 
    {
        public struct Student
        {
           
            public int id_num, quizscore;
            public string firstname, lastname,remark;

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

            Console.WriteLine(Student1.firstname);
            Console.WriteLine(Student1.lastname);
            Console.WriteLine(Student1.id_num);
            Console.WriteLine(Student1.quizscore);
            Console.ReadKey();
            

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