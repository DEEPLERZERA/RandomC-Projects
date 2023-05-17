using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());  //Declara desconto

            Dictionary<string, double> coffee = new Dictionary<string, double>();  //Criando dicionário que vai receber dois parâmetros
            coffee.Add("Americano", 50);  //Adicionando itens
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);

            Dictionary<string, double> updatedPrices = new Dictionary<string, double>();  //Criando outro dicionário com preços atualizados

        
            foreach (var item in coffee)  //Percorrendo array coffee
            {
                double discountedPrice = item.Value - discount;  //Gerando desconto
                updatedPrices[item.Key] = discountedPrice;
            }

     
            foreach (var item in updatedPrices)     //Percorrendo array com preços atualizados
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
