using SorveteriaDecorator.decorators;

namespace SorveteriaDecorator.concreteDecorators
{
    public class Casquinha : IceCreamDecorator
    {
        public Casquinha(IIceCream iceCream) : base(iceCream) { }

        public override string Description()
        {
            return _iceCream.Description() + " na casquinha";
        }

        public override double Expanse()
        {
            return _iceCream.Expanse() + 1.50;
        }
    }

}
