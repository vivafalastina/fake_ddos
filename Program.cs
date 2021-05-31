using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace fake_ddos
{
    class Program
    {
        //Main Method
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            //Ask if epic hacks should be done
            Console.WriteLine("Do you want to make epic and 1337 ddos attack? Y for yes(default), N for no");
            string input = Console.ReadLine();

            //If the answer is N then exit the program
            if (input == "N" || input == "n")
            {
                Environment.Exit(1);
            }

            //Else run the epic hacks
            else
            {
                EpicHackTime();
            }
        }

        //Method to determine epic hack site
        static void EpicHackTime()
        {
            Console.Clear();

            //Array for words
            string[] firstWordArray = { "jims", "bobs", "fbi", "cia", "interpol", "mi6", "mcdonalds", "harveys", "barney", "area51" };
            string[] secondWordArray = { "mainframe", "base", "admin", "headquaters", "friends", "mom", "burgers", "ip", "staff", "quantum" };
            string[] domainArray = { ".com", ".me", ".org", ".net", ".ca", ".gov", ".edu", ".int", ".mil", ".apra" };

            //Generate random numbers
            Random rnd = new Random();

            int rndFrst = rnd.Next(0, firstWordArray.Count());
            int rndSnd = rnd.Next(0, secondWordArray.Count());
            int rndDom = rnd.Next(0, domainArray.Count());

            //Assign strings to random
            string first = firstWordArray[rndFrst];
            string second = secondWordArray[rndSnd];
            string domain = domainArray[rndDom];

            //Print domain 500 times
            for(int i = 0; i < 500; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Sending ddos attack to");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{first, 10}{second}{domain}");
                Thread.Sleep(200);
            }
        }
    }
}
