using SorveteriaDecorator.decorators;

namespace SorveteriaDecorator.concreteDecorators;
public class Copo : IceCreamDecorator
{
    public Copo(IIceCream iceCream) : base(iceCream) { }

    public override string Description()
    {
        return _iceCream.Description() + " no copo";
    }

    public override double Expanse()
    {
        return _iceCream.Expanse() + 0.20;
    }
}