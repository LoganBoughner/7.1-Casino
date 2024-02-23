using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Casino
{
    internal class Program
    {
        static void Main(string[] args)
        {//Logan Boughner
            Random generator;
            int money, bet, randNum;
            string guess;
            money = 20;
            Console.WriteLine("Welcome to the casino we currently only have one game which is heads or tails");
            while (money >
                0)
            {
                Console.WriteLine("you currently have " + money + "$" + " How much would you like to bet?");
                bet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("heads or tails?");
                guess = Console.ReadLine();
                generator = new Random();
                randNum = generator.Next (0, 3);
                if ((randNum == 1) && (guess == "heads"))
                {
                Console.WriteLine("Correct");
                    money = (money + bet);
                }
                else if ((randNum == 2) && (guess == "tails")) 
                {
                    Console.WriteLine("Correct");
                    money = (money + bet);
                }
                else
                {
                    Console.WriteLine("wrong");
                    money = (money - bet);
                }
            } 
            
            {

            }
        }
    }
}
