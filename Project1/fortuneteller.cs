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
                string ageAnswer = "93 years";
            }
            else
            {
                Console.WriteLine("6 months");
                string ageAnswer = "6 months";
            }

            Console.WriteLine();

            if (siblings == 0)
            {
                Console.WriteLine("Rain Forest");
                string siblingsAnswer = "Rainforest";
            }
            else if (siblings == 1)
            {
                Console.WriteLine("Mars");
                string siblingsAnswer = "Mars";
            }
            else if (siblings == 2)
            {
                Console.WriteLine("Sahara Desert");
                string siblingsAnswer = "Sahara Desert";
            }
            else if (siblings == 3)
            {
                Console.WriteLine("Atlantis");
                string siblingsAnswer = "Atlantis";
            }
            else if (siblings > 3)
            {
                Console.WriteLine("the Moon");
                string siblingsAnswer = "the Moon";
            }
            else
            {
                Console.WriteLine("Rome");
                string siblingsAnswer = "Rome";
            }

            Console.WriteLine();

            if (favColor == "red")
            {
                Console.WriteLine("hovercraft");
                string favColorAnswer = "hovercraft";
            }
            else if (favColor == "orange")
            {
                Console.WriteLine("spaceship");
                string favColorAnswer = "Spaceship";
            }
            else if (favColor == "yellow")
            {
                Console.WriteLine("BMW");
                string favColorAnswer = "BMW";
            }
            else if (favColor == "green")
            {
                Console.WriteLine("Mercedes");
                string favColorAnswer = "Mercedes";
            }
            else if (favColor == "blue")
            {
                Console.WriteLine("teleportation");
                string favColorAnswer = "teleportation";
            }
            else if (favColor == "indigo")
            {
                Console.WriteLine("transformer");
                string favColorAnswer = "Transformer";
            }
            else if (favColor == "violet")
            {
                Console.WriteLine("delorean");
                string favColorAnswer = "Delorean";
            }
            else
            {
                Console.WriteLine("Garbage truck");
                string favColorAnswer = "Garbage Truck";
            }
            

            Console.WriteLine();

            int index1 = firstName.IndexOf(birthMonth[0]);
            int index2 = lastName.IndexOf(birthMonth[0]);
            int index3 = firstName.IndexOf(birthMonth[1]);
            int index4 = lastName.IndexOf(birthMonth[1]);
            int index5 = firstName.IndexOf(birthMonth[2]);
            int index6 = lastName.IndexOf(birthMonth[2]);
            if (index1 != -1 || index2 != -1)
            {
                Console.WriteLine("$0");
            }
            else if (index3 != -1 || index4 != -1)
            {
                Console.WriteLine("$1,000,000");
            }
            else if (index5 != -1 || index6 != -1)
            {
                Console.WriteLine("$100");
            }
            else
            {
                Console.WriteLine("0.50");
            }

            //Console.WriteLine(firstName + "" + lastName + "" + "will retire in " + favColorAnswer)
                



            Console.ReadKey();




        }
    }
}
