namespace TextDecorator
{
	public class Palavra : ITexto
	{
		private string conteudo;

		public Palavra(string conteudo)
		{
			this.conteudo = conteudo;
		}

		public string Render()
		{
			return conteudo;
		}

		public string Text()
		{
			return conteudo;
		}
	}

}
