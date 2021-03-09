using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CLI
{
    class main
    {
        static void Main(string[] args)
        {
            Console.Title = "CLI Number Guessing Game by ScarVite";
            while (true)
            {
                Console.Write("Please Enter a Number between 1-100: ");
                string input = Console.ReadLine();
                Console.WriteLine(" ");
                Boolean number = int.TryParse(input, out int inp);
                if (number)
                {
                    Random ran = new Random();
                    int rand = ran.Next(0, 100);
                    if (inp > 100)
                    {
                        Console.WriteLine("Your Number is too large,please Select a Smaller One");
                    }
                    else if (inp < 0)
                    {
                        Console.WriteLine("Your Number is too Small, please choose a bigger one");
                    }
                    else if (inp == rand)
                    {
                        Console.WriteLine("Congratulations, you guessed the right Number");
                    }
                    else
                    {
                        Console.WriteLine("You did not Choose The Correct Number, the Correct Number was: " + rand + ".\nYou can try again if you Want to");
                    }
                    switch(inp)
                    {
                        case 666:
                            Console.WriteLine("May The Devil be with you.");
                            break;
                        case 420:
                            Console.WriteLine("Blaze it");
                            break;
                        case 42:
                            Console.WriteLine("The Answer to the Universe and Everything");
                            break;
                        case 69:
                            Console.WriteLine("Nice");
                            break;
                        default:
                            break;
                    }
                } else
                {
                    Console.WriteLine("You did Not Enter a valid Number, you Dirty Cheater");
                }
            }
        }
    }
}
