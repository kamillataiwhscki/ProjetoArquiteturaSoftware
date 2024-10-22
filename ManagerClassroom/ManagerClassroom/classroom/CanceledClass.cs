
namespace ManagerClassroom.classroom
{
	public class CanceledClass : IManageClass
	{
		private readonly Classroom _classroom;
		public string ClassroomName { get; private set; }

		public CanceledClass(Classroom classroom)
		{
			_classroom = classroom;
			ClassroomName = $"Sala de aula-{classroom.Id}";
			Console.WriteLine($"Sala de aula {ClassroomName} foi cancelada pelo professor.");
			DeleteClassroom();
		}

		public void CreateNewClassroom() => Console.WriteLine("Não é possível criar uma aula previamente cancelada!");
		public void BeginClass() => Console.WriteLine("Não é possível iniciar uma aula cancelada!");
		public void EndClass() => Console.WriteLine("Não é possível finalizar uma aula cancelada!");
		public void CancelClass() => Console.WriteLine("Esta aula já foi cancelada.");

		private void DeleteClassroom()
		{
			Console.WriteLine($"Sala de aula {ClassroomName} foi excluída.");
		}
	}
}
