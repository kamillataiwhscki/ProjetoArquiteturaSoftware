using TextDecorator.abstractDecorators;

namespace TextDecorator.concreteDecorators
{
	public class Italico : DecoratorTexto
	{
		public Italico(ITexto texto) : base(texto) { }

		public override string Render()
		{
			return $"<i>{texto.Render()}</i>";
		}
	}
}