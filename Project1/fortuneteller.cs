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
            string favColor = Console.ReadLine();
            while(favColor == "help")
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

            if(age %2 != 0)
            {
                Console.WriteLine("You will retire in 93 years! Oh No!");
            }
            else
            {
                Console.WriteLine("You will retire in half a year! Because you'll win the lotto!");
            }

            Console.WriteLine();

            if(siblings == 0)
            {
                Console.WriteLine("You will soon live in the Rain Forest!");
            }
            if(siblings == 1)
            {
                Console.WriteLine("You will soon live on Mars!");
            }
            if(siblings == 2)
            {
                Console.WriteLine("You will soon live in in the Sahara Desert!");
            }
            if(siblings == 3)
            {
                Console.WriteLine("You will soon live in Atlantis");
            }
            if(siblings > 3)
            {
                Console.WriteLine("You will soon live in a haunted house!");
            }

            Console.WriteLine();

            if(favColor == "red")
            {
                Console.WriteLine("You will now get from place to place via hovercraft");
            }
            if(favColor == "orange")
            {
                Console.WriteLine("You will now get from place to place via spaceship");
            }
            if(favColor == "yellow")
            {
                Console.WriteLine("You will now get from place to place via your feet");
            }
            if(favColor == "green")
            {
                Console.WriteLine("You will now get from place to place via bigfoot");
            }
            if(favColor == "blue")
            {
                Console.WriteLine("You will now get from place to place via teleportation");
            }
            if(favColor == "indigo")
            {
                Console.WriteLine("You will now get from place to place via transformer");
            } 
            if(favColor == "violet")
            {
                Console.WriteLine("You will now get from place to place via delorean");
            }

            Console.WriteLine();

            string[] birthMonthArray = { birthMonth };
            string[] firstNameArray = { firstName };
            string[] lastNameArray = { lastName };

            if (birthMonthArray[0] == firstNameArray[0] || lastNameArray[0])

            Console.ReadKey();




        }
    }
}
