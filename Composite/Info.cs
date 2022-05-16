namespace Composite
{
    class Info : Component
    {
        public int c=0;
        public Info(string name)
                : base(name)
        { 
            c++;
        }
    }
}