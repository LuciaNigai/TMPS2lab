using System;
namespace Adapter
{
        class USCurrency : ICurrency
        {
            public void Convert(double c)
            {
                double m;
                m=(c*18.66)*1.03;
                Console.WriteLine("Client Payed in US currency {0} what equals {1} in MDL",c,Math.Round(m,2));
            }
        }
}