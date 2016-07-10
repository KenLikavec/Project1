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
            String.Compare("A", "a", true);

            Console.WriteLine("Type out your first name:");
            string firstName = Console.ReadLine();

            //used for spacing in final product
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
            string favColor = Console.ReadLine();
            while (favColor == "help")
            {
                Console.WriteLine("\"ROYGBIV\" stands for red, orange, yellow, green, blue, indio and violet");
                Console.WriteLine("So which of these options are your favorite?");
                favColor = Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("How many siblings do you have in your family?");
            int siblings = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Now for your fortune results...");

            Console.WriteLine();
            Console.WriteLine();

            if (age % 2 != 0)
            {
                Console.WriteLine("93 years");
            }
            else
            {
                Console.WriteLine("6 months!");
            }

            Console.WriteLine();

            if (siblings == 0)
            {
                Console.WriteLine("Rain Forest");
            }
            else if (siblings == 1)
            {
                Console.WriteLine("Mars");
            }
            else if (siblings == 2)
            {
                Console.WriteLine("Sahara Desert");
            }
            else if (siblings == 3)
            {
                Console.WriteLine("Atlantis");
            }
            else if (siblings > 3)
            {
                Console.WriteLine("th moon");
            }
            else
            {
                Console.WriteLine("N/A");
            }

            Console.WriteLine();

            if (favColor == "red")
            {
                Console.WriteLine("hovercraft");
            }
            else if (favColor == "orange")
            {
                Console.WriteLine("spaceship");
            }
            else if (favColor == "yellow")
            {
                Console.WriteLine("foot");
            }
            else if (favColor == "green")
            {
                Console.WriteLine("bigfoot");
            }
            else if (favColor == "blue")
            {
                Console.WriteLine("teleportation");
            }
            else if (favColor == "indigo")
            {
                Console.WriteLine("transformer");
            }
            else if (favColor == "violet")
            {
                Console.WriteLine("delorean");
            }
            else
            {
                Console.WriteLine("N/A");
            }
            

            Console.WriteLine();


                



            Console.ReadKey();




        }
    }
}
