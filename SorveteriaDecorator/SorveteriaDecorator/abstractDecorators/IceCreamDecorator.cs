namespace SorveteriaDecorator.decorators
{
    public abstract class IceCreamDecorator : IIceCream
    {
        protected IIceCream _iceCream;

        public IceCreamDecorator(IIceCream sorvete)
        {
            _iceCream = sorvete;
        }

        public virtual string Description()
        {
            return _iceCream.Description();
        }

        public virtual double Expanse()
        {
            return _iceCream.Expanse();
        }
    }
}
