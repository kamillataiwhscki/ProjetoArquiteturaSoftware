using TextDecorator.abstractDecorators;

namespace TextDecorator.concreteDecorators
{
	public class Negrito : DecoratorTexto
	{
		public Negrito(ITexto texto) : base(texto) { }

		public override string Render()
		{
			return $"<b>{texto.Render()}</b>";
		}
	}
}