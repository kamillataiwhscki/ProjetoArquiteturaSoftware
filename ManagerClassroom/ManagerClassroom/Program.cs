using ManagerClassroom.classroom;
using System;

public class ManagementClass
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Primeiro teste: Aula criada, iniciada e finalizada.");
		var classroom1 = new Classroom(1, DateTime.Now.AddHours(-4), DateTime.Now.AddHours(-1));

		classroom1.CreateNewClassroom(); 
		classroom1.BeginClass();  
		classroom1.EndClass(); 
		Console.WriteLine();
		Console.WriteLine("----------------------------------------------------");
		Console.WriteLine();

		Console.WriteLine("Segundo teste: Aula criada, iniciada e tentativa de cancelamento.");
		var classroom2 = new Classroom(2, DateTime.Now.AddHours(-4), DateTime.Now.AddHours(-1));

		classroom2.CreateNewClassroom();
		classroom2.BeginClass(); 
		classroom2.CancelClass();   
		Console.WriteLine();
		Console.WriteLine("----------------------------------------------------");
		Console.WriteLine();

		Console.WriteLine("Terceiro teste: Aula criada e cancelada logo após a criação.");
		var classroom3 = new Classroom(3, DateTime.Now.AddHours(-4), DateTime.Now.AddHours(-1));

		classroom3.CreateNewClassroom();
		classroom3.CancelClass();
		Console.WriteLine();
		Console.WriteLine("----------------------------------------------------");
		Console.WriteLine();

		Console.WriteLine("Quarto teste: Aula criada e tentativa de finalizar antes de iniciar.");
		var classroom4 = new Classroom(4, DateTime.Now.AddHours(-4), DateTime.Now.AddHours(-1));

		classroom4.CreateNewClassroom();
		classroom4.EndClass();
		Console.WriteLine();
		Console.WriteLine("----------------------------------------------------");
		Console.WriteLine();

		Console.WriteLine("Quinto teste: Aula criada, iniciada, finalizada e tentativa de cancelamento");
		var classroom5 = new Classroom(5, DateTime.Now.AddHours(-4), DateTime.Now.AddHours(-1));

		classroom5.CreateNewClassroom();
		classroom5.BeginClass();
		classroom5.EndClass();
		classroom5.CancelClass();
		Console.WriteLine();
		Console.WriteLine("----------------------------------------------------");
		Console.WriteLine();
	}
}
