namespace Adapter
{
        class MDLCurrency : IPay
        {
            public void Bill(double mdl)
            {
                Console.WriteLine("Client payed in MDL {0}",mdl);
            }
        }
}