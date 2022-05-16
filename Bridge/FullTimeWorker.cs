namespace Bridge
{
    class FullTimeWorker : Worker
    {
        public FullTimeWorker(IOrder kitch) : base(kitch)
        {
        }
        public override void EarnMoney()
        {
            Console.WriteLine("Getting sallary in the end of the month \n");
        }
    }
}