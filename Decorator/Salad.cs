namespace Decorator
{
    abstract class Salad
    {
        public Salad(string n)
        {
            this.Name=n;
        }
        public string Name {get; protected set;}
        public abstract double GetCost();
    }
}