// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taking values
            string name1 = Console.ReadLine();    
            int points1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);

            //Printing values
            DancerPoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
        }
    }

    //Creating a class
    class DancerPoints
    {
        public string name;
        public int points;
        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public string Name { get; set; }
        public int Points { get; set; }

        //overload the + operator

        public static DancerPoints operator +(DancerPoints a, DancerPoints b)
        {
            string n = a.name + " & " + b.name;
            int p = a.points + b.points;
            DancerPoints res = new DancerPoints(n, p);
            return res;
        }
    }
}