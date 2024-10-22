namespace SorveteriaDecorator
{
	public class SimpleIceCream : IIceCream
	{
		private string _flavor;
		private double _expanse;

		public SimpleIceCream(string flavor)
		{
			_flavor = flavor;

			if (_flavor == "Chocolate Diet")
				_expanse = 2.00;
			else
				_expanse = 1.50;
		}

		public string Description()
		{
			return $"Sorvete de {_flavor}";
		}

		public double Expanse()
		{
			return _expanse;
		}
	}
}
