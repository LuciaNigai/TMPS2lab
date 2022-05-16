namespace Bridge
{
    class EuropeCooker : IOrder
    {
        public void Get()
        {
            Console.WriteLine("Getting the order for european kitchen food");
        }

        public  void Execute()
        {
            Console.WriteLine("Prepare the european food");
        }
    }
}