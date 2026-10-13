using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello");
            Console.Write("AIUB");
            */
            /*int a = 3;
            float b = 8.6f;
            double c = 5.5;
            string d = "HEHEHE";*/

            /* Console.WriteLine("Numerical values:" + a + " " + b + " " + c);
             Console.WriteLine("Numerical values:{2}{0}{1}", c, a, b);
             Console.WriteLine($"d is :{d}{c}");*/
            /*Console.Write("Enter your name:");
            string a = Console.ReadLine();
            Console.Write("Enter your age:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter your height:");
            float c = float.Parse(Console.ReadLine());

            Console.WriteLine("Student name:" + a);
            Console.WriteLine("Student age:" + b);
            Console.WriteLine("Student height:" + c);
            if (b < 18)
            {
                Console.WriteLine("Teenage");
            }
            else { Console.WriteLine("Adult"); }*/
            string[] students = new string[5];
            Console.Write("Enter Name:");
            for(int i = 0; i < students.Length; i++)
            {
                students[i] = Console.ReadLine();
            }
            foreach(var s in students)
            {
                Console.WriteLine("Students Name:" + s);
            }
            int[] studentsage = new int[5];
            Console.Write("Enter Age:");
            for (int i = 0; i < studentsage.Length; i++)
            {
                studentsage[i] = int.Parse(Console.ReadLine());
            }
            foreach (var a in studentsage)
            {
                Console.WriteLine("Students age:" + a);
            }
            Console.ReadKey();
            
        }
    }
}
