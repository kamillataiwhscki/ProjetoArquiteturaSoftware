using SorveteriaDecorator.decorators;

namespace SorveteriaDecorator.concreteDecorators
{
	
	public class CoberturaCaramelo : IceCreamDecorator
	{
		public CoberturaCaramelo(IIceCream sorvete) : base(sorvete) { }

		public override string Description()
		{
			return _iceCream.Description() + " com cobertura de caramelo";
		}

		public override double Expanse()
		{
			return _iceCream.Expanse() + 0.50;
		}
	}

}