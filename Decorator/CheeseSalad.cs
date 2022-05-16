namespace Decorator
{
    class CheeseSalad : SaladDecorator
    {
        public CheeseSalad(Salad p) : base (p.Name +" , with cheese",p)
        {}
        public override double GetCost()
        {
            return salad.GetCost()+20;
        }
    }
}