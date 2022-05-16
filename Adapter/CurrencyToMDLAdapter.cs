namespace Adapter
{
        class CurrencyToMDLAdapter : IPay
        {
            USCurrency Dollars;
            public CurrencyToMDLAdapter(USCurrency d)
            {
                Dollars=d;
            }

            public void Bill(double c)
            {
                Dollars.Convert(c);
            }
        }
}