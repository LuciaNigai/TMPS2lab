using System;

namespace Bridge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Worker partTime = new PartTimeWorker(new EastCooker());
            partTime.DoWork();
            partTime.EarnMoney();

            partTime.Order=new EuropeCooker();
            partTime.DoWork();
            partTime.EarnMoney();
        }
    }
}