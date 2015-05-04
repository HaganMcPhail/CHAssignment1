using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAssignment1
{
    public class RandomGame
    {
        public void Run()
        {
            int random = GetRandomNumber();
            string guess = Console.ReadLine();

            CheckGuess(guess, random);
        }

        private int GetRandomNumber()
        {
            Random random = new Random();
            int randomInt = random.Next(0, 5);

            Console.Write("Random Number: " + randomInt + "\n\n");

            return randomInt;
        }

        private void CheckGuess(string guess, int random)
        {
            if (ValidateGuess(guess) == random)
            {
                Console.WriteLine("\nMcWin");
            }
            else
            {
                Console.WriteLine("\nMcPhail");
            }

            Console.ReadLine();
        }

        private int ValidateGuess(string guess)
        {
            int checkedNumber = -1;

            try
            {
                checkedNumber = int.Parse(guess);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nNot a valid Number \n");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nNot a valid Number \n");
            }

            return checkedNumber;
        }
    }
}
