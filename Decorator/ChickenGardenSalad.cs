namespace Decorator
{
    class ChickenGardenSalad : Salad
    {
        public ChickenGardenSalad() : base("Chicken Garden Salad")
        {}
        public override double GetCost()
        {
            return 100;
        }
    }
}