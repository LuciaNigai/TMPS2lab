using System;
namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            while(true)
            {
            Console.WriteLine("Choose the currency");
            Console.WriteLine("1. MDL");
            Console.WriteLine("2. US");
            int c=Convert.ToInt32(Console.ReadLine());
            switch(c)
            {
                case 1:
                    //client
                    Console.WriteLine("Enter payment amount");
                    Client client = new Client();
                    //mdl
                    MDLCurrency mdl = new MDLCurrency();
                    //mdl
                    client.Pay(mdl);
                break;
                case 2:
                    Console.WriteLine("Enter payment amount");
                    //client
                    Client client2 = new Client();
                    //us need to convert to mdl
                    USCurrency dollar= new USCurrency();
                    //using adapter
                    IPay dollarpay =  new CurrencyToMDLAdapter(dollar);
                    //pay
                    client2.Pay(dollarpay);
                break;
            }
            }

        }
    }
}
