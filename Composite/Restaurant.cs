namespace Composite
{
class Composite :Component
{
    private List<Component> components = new List<Component>();
 
    public Composite(string name): base(name)
    {
    }
 
    public override void Add(Component component)
    {
        components.Add(component);
    }
 
    public override void Remove(Component component)
    {
        components.Remove(component);
    }
 
    public override void Print()
    {
        Console.WriteLine("Узел " + name);
        Console.WriteLine("Подузлы:");
        for(int i=0; i<components.Count;i++)
        {
            components[i].Print();
        }
    }
}
}