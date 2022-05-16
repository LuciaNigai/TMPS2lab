namespace Adapter
{
        class Client
        {
            public void Pay(IPay money)
            {
                int b =Convert.ToInt32(Console.ReadLine());
                money.Bill(b);
            }
        }
}