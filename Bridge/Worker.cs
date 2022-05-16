namespace Bridge
{
    abstract class Worker
    {
        protected IOrder order;
        public IOrder Order
        {
            set {order=value;}
        }
        public Worker(IOrder kitch)
        {
            order=kitch;
        }
        public virtual void DoWork()
        {
            order.Get();
            order.Execute();
        }
        public abstract void EarnMoney();
    }
}