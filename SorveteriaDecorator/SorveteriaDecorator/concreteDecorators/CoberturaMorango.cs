using SorveteriaDecorator.decorators;

namespace SorveteriaDecorator.concreteDecorators
{
	public class CoberturaMorango : IceCreamDecorator
	{
		public CoberturaMorango(IIceCream sorvete) : base(sorvete) { }

		public override string Description()
		{
			return _iceCream.Description() + " com cobertura de morango";
		}

		public override double Expanse()
		{
			return _iceCream.Expanse() + 0.50;
		}
	}
}