using SorveteriaDecorator;
using SorveteriaDecorator.concreteDecorators;
using System;
using System.Collections.Generic;

public class Program
{
	public static void Main(string[] args)
	{

		ExibirCardapio();

		IIceCream pedido = new SimpleIceCream("Chocolate");
		pedido = new Casquinha(pedido);
		pedido = new CoberturaChocolate(pedido);

		Console.WriteLine();
		Console.WriteLine("*************PEDIDO ESCOLHIDO*************");
		Console.WriteLine(pedido.Description()); 
		Console.WriteLine($"Custo total: R$ {pedido.Expanse():0.00}");
	}

	public static void ExibirCardapio()
	{
		Console.WriteLine("=== Cardápio de Sorvetes ===");
		Console.WriteLine("Sabores:");
		var sabores = new Dictionary<string, double>()
		{
			{ "Chocolate", 1.50 },
			{ "Morango", 1.50 },
			{ "Flocos", 1.50 },
			{ "Pavê", 1.50 },
			{ "Napolitano", 1.50 },
			{ "Chocolate Diet", 2.00 }
		};

		foreach (var sabor in sabores)
		{
			Console.WriteLine($"{sabor.Key}: R$ {sabor.Value}");
		}

		Console.WriteLine("Tipos:");
		var tipoSorvete = new Dictionary<string, double>()
		{
			{ "Copo", 0.20},
			{ "Taça", 0.00 },
			{ "Casquinha Diet", 1.50 }
		};

		foreach (var tipo in tipoSorvete)
		{
			Console.WriteLine($"{tipo.Key}: R$ {tipo.Value}");
		}

		Console.WriteLine("Coberturas:");
		var coberturas = new Dictionary<string, double>()
		{
			{ "Sem cobertura", 0.00 },
			{ "Cobertura de Chocolate", 0.50},
			{ "Cobertura de Caramelo", 0.50},
			{ "Cobertura de Morango", 0.50 }
		};
		
		foreach (var cover in coberturas)
		{
			Console.WriteLine($"{cover.Key}: R$ {cover.Value}");
		}

		Console.WriteLine("=============================");
		Console.WriteLine();

		Console.WriteLine("=== Possíveis Combinações de Pedidos ===");
		foreach (var sabor in sabores)
		{
			foreach (var tipo in tipoSorvete)
			{
				foreach (var cover in coberturas)
				{
					IIceCream sorvete = new SimpleIceCream(sabor.Key);

					if (tipo.Key == "Copo")
						sorvete = new Copo(sorvete);
					else if (tipo.Key == "Taça")
						sorvete = new Taca(sorvete);
					else
						sorvete = new Casquinha(sorvete);

					if (cover.Key == "Cobertura de Chocolate")
						sorvete = new CoberturaChocolate(sorvete);
					else if (cover.Key == "Cobertura de Caramelo")
						sorvete = new CoberturaCaramelo(sorvete);
					else if (cover.Key == "Cobertura de Morango")
						sorvete = new CoberturaMorango(sorvete);

					Console.WriteLine($"{sorvete.Description()} - Custo total: R$ {sorvete.Expanse():0.00}");
				}
			}
		}
		
	}
}
