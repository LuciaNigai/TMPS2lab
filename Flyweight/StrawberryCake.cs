namespace Flyweight
{
    class StrawberryCake : Cake //клубничый
    {
        public StrawberryCake()
        {
            weight = 5;
        }
    
        public override void DecorType(int type)
        {
            Console.WriteLine("The cake was built with 5 kg weight and {0} type of decor", type);
        }
    }
}