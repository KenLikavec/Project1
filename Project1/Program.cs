using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Type out your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Type out your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Write out the month you were born:");
            string birthMonth = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("What ROYGBIV color is your favorite? (Any questions concerning \"ROYGBIV\" type out the word \"help\" then press enter");
            Console.ReadLine();
            if (Console.ReadLine() = "Help")
            {
                Console.WriteLine("\"ROYGBIV\" stands for Red, Orange, Yellow, Green, Indigo and violet");
            }
            else
            {
                string favColor = Console.ReadLine();
            }



            Console.ReadKey();




        }
    }
}
