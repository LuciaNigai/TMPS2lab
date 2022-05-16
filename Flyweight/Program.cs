using System;
namespace Flyweight 
{
    class Program
    {
        static void Main(string[] args)
        {
            CakeFactory cakeFactory = new CakeFactory();
            for (int i = 1; i < 5;i++)
            {
                Cake strawberyCake = cakeFactory.GetCake("Strawbery");
                if (strawberyCake != null)
                    strawberyCake.DecorType(i);
            }
            Console.WriteLine("/n");
            for (int i = 1; i < 5;i++)
            {
                Cake chocolateCake = cakeFactory.GetCake("Chocolate");
                if (chocolateCake != null)
                    chocolateCake.DecorType(i);
            }
        }
    }
}