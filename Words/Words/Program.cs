// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {   //List of words
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();  //Input

            bool found = false;

            //your code goes here

            foreach (string n in words)  //Enter inside of the array
            {
                if (n.Contains(letter))   //Verify if letter contains
                {
                    Console.WriteLine(n);
                    found = true;
                }
            }

            if (found == false)
            {
                Console.WriteLine("No match");
            }


        }
    }
}
