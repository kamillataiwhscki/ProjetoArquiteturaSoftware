using SorveteriaDecorator.decorators;

namespace SorveteriaDecorator.concreteDecorators
{
	public class CoberturaChocolate : IceCreamDecorator
	{
		public CoberturaChocolate(IIceCream sorvete) : base(sorvete) { }

		public override string Description()
		{
			return _iceCream.Description() + " com cobertura de chocolate";
		}

		public override double Expanse()
		{
			return _iceCream.Expanse() + 0.50;
		}
	}

}