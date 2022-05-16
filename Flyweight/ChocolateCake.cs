namespace Flyweight
{
    class ChocolateCake : Cake//шоколадный
    {
        public ChocolateCake()
        {
            weight = 4;
        }
    
        public override void DecorType(int type)
        {
            Console.WriteLine("The cake was built with 4 kg weight and {0} type of decor", type);
        }
    }
}