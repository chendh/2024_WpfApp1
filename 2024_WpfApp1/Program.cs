﻿namespace _2024_WpfApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drink drink1 = new Drink();
            drink1.Name = "Coke";
            drink1.Size = "Medium";
            drink1.Price = 30;

            Drink drink2 = new Drink();
            drink2.Name = "Pepsi";
            drink2.Size = "Large";
            drink2.Price = 40;

            Console.WriteLine("Drink 1: " + drink1.Name + " " + drink1.Size + " " + drink1.Price);
            Console.WriteLine("Drink 2: " + drink2.Name + " " + drink2.Size + " " + drink2.Price);
        }
    }
}
