using TextDecorator.abstractDecorators;

namespace TextDecorator.concreteDecorators
{
	public class Sublinhado : DecoratorTexto
	{
		public Sublinhado(ITexto texto) : base(texto) { }

		public override string Render()
		{
			return $"<u>{texto.Render()}</u>";
		}
	}

}
