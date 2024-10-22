using SorveteriaDecorator.decorators;

namespace SorveteriaDecorator.concreteDecorators
{
    public class Taca : IceCreamDecorator
    {
        public Taca(IIceCream iceCream) : base(iceCream) { }

        public override string Description()
        {
            return _iceCream.Description() + " na taça";
        }

        public override double Expanse()
        {
            return _iceCream.Expanse();
        }
    }
};

