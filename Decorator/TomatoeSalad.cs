namespace Decorator
{
    class TomatoeSalad : SaladDecorator
    {
        public TomatoeSalad(Salad p) : base(p.Name+" , with tomatoes",p)
        {}
        public override double GetCost()
        {
            return salad.GetCost()+15;
        }
    }
}