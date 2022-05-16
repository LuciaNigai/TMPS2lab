using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Salad salad1 = new ItalianPastaSalad();
            salad1=new CheeseSalad(salad1);
            Console.WriteLine("{0}",salad1.Name);
            Console.WriteLine("Price {0}",salad1.GetCost());

            Salad salad2 = new ChickenGardenSalad();
            salad2=new TomatoeSalad(salad2);
            salad2=new CheeseSalad(salad2);
            Console.WriteLine("{0}",salad2.Name);
            Console.WriteLine("Price {0}",salad2.GetCost());
        }

    }
}