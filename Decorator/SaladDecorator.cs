namespace Decorator
{
    abstract class SaladDecorator : Salad
    {
        protected Salad salad;
        public SaladDecorator(string n, Salad salad) : base(n)
        {
            this.salad=salad;
        }
    }
}