using System;

namespace StructProject
{
    class Program
    {

      public struct Person
      {
         public string Firstname, Lastname, Remarks;
         public int Id, Quizscore;
      }
         static void Main(string[] args)
      {
         int marks;
             Person person1 = new Person();
             Console.WriteLine("Enter your Id:");
             person1. Id = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter Firstname: ");
             person1.Firstname = Console.ReadLine();
             Console.WriteLine("Enter your Lastname:");
             person1.Lastname = Console.ReadLine();
             Console.WriteLine("Enter your Quizscore: ");
             person1.Quizscore = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter your Remarks [1-4]:");
             marks = int.Parse(Console.ReadLine());

             Console.WriteLine(person1.Id);
             Console.WriteLine(person1.Firstname);
             Console.WriteLine(person1.Lastname);
             Console.WriteLine(person1.Quizscore);
            

            switch(marks)
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
























