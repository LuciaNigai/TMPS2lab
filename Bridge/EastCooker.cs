namespace Bridge
{
    class EastCooker : IOrder
    {
        public void Get()
        {
            Console.WriteLine("Getting the order ");
        }

        public void Execute()
        {
            Console.WriteLine("Preparing the east food");
        }
    }
}