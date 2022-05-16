namespace Decorator
{
    class ItalianPastaSalad : Salad
    {
        public ItalianPastaSalad() : base("Italian Pasta Salad")
        {}
        public override double GetCost()
        {
            return 130;
        }
    }
}