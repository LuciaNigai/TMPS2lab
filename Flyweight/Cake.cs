namespace Flyweight
{
    abstract class Cake
    {
        protected int weight; // вес торта
    
        public abstract void DecorType(int type);//тип декора
    }
}