namespace Bridge
{
    class PartTimeWorker : Worker
    {
        public PartTimeWorker(IOrder lang) : base(lang)
        {

        }
        public override void EarnMoney()
        {
            Console.WriteLine("Getting payed for hours \n");
        }
    }
}