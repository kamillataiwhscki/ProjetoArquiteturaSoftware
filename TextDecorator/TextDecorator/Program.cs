using TextDecorator.concreteDecorators;
using TextDecorator;

public class Program
{
	public static void Main(string[] args)
	{
		ITexto palavra1 = new Palavra("normal");
		ITexto palavra2 = new Negrito(new Palavra("negrito"));
		ITexto palavra3 = new Italico(new Palavra("itálico"));
		ITexto palavra4 = new Sublinhado(new Palavra("sublinhado"));
		ITexto palavra5 = new Negrito(new Italico(new Palavra("negrito e itálico")));
		ITexto palavra6 = new Italico(new Sublinhado(new Palavra("itálico sublinhado")));

		Console.WriteLine("Renderizações:");
		Console.WriteLine(palavra1.Render());
		Console.WriteLine(palavra2.Render());
		Console.WriteLine(palavra3.Render());
		Console.WriteLine(palavra4.Render());
		Console.WriteLine(palavra5.Render());
		Console.WriteLine(palavra6.Render());

		Console.WriteLine("\nTextos simples:");
		Console.WriteLine(palavra1.Text());
		Console.WriteLine(palavra2.Text());
		Console.WriteLine(palavra3.Text());
		Console.WriteLine(palavra4.Text());
		Console.WriteLine(palavra5.Text());
		Console.WriteLine(palavra6.Text());
	}
}
