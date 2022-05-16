namespace Flyweight
{
    class CakeFactory
    {
        Dictionary<string, Cake> cakes = new Dictionary<string, Cake>();
        public CakeFactory()
        {
            cakes.Add("Strawbery", new StrawberryCake());
            cakes.Add("Chocolate", new ChocolateCake());
        }
    
        public Cake GetCake(string key)
        {
            if (cakes.ContainsKey(key))
                return  cakes[key];
            else
                return null;
        }
    }
}