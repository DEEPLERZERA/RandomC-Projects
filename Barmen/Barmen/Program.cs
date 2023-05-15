// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int bebidas = Convert.ToInt32(Console.ReadLine());  //Pega input
                int mesas = Convert.ToInt32(Console.ReadLine());
                int z = bebidas / mesas;  //Calcula
                Console.WriteLine(z);

            }
            catch (DivideByZeroException e)  //Trata erro
            {
                Console.WriteLine("Pelo menos uma mesa!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Por favor coloque um inteiro!");
            }
        }
    }
}
