using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAssignment1
{
    class Methods
    {
        public int getRandom()
        {
            Random random = new Random();
            int randomInt = random.Next(0, 5);

            Console.Write("Random Number: " + randomInt + "\n\n");

            return randomInt;
        }
        public int intCheck(string guess)
        {
            int checkedNumber;
            try
            {
                checkedNumber = int.Parse(guess);
            }
            catch (FormatException)
            {
                checkedNumber = 99;
                Console.WriteLine("\nNot a valid Number \n");
            }
            catch (OverflowException)
            {
                checkedNumber = 99;
                Console.WriteLine("\nNot a valid Number \n");
            }

            return checkedNumber;

        }
        public void checkGuess(string guess, int random)
        {
            if (intCheck(guess) == random)
            {
                Console.WriteLine("\nMcWin");
            }
            else
            {
                Console.WriteLine("\nMcPhail");
            }
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Methods m = new Methods();
            string guess;
            int random = m.getRandom();
            
            guess = Console.ReadLine();
            m.checkGuess(guess, random);

        }
    }
}
