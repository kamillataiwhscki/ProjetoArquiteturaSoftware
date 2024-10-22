using System;

namespace ManagerClassroom.classroom
{
	public class FinishedClass : IManageClass
	{
		private readonly Classroom _classroom;
		public string ClassroomName { get; private set; }
		public DateTime DateTimeFinished { get; private set; }

		public FinishedClass(Classroom classroom)
		{
			_classroom = classroom;
			ClassroomName = $"Classroom-{classroom.Id}";
			DateTimeFinished = DateTime.Now;
			_classroom.RealEnd = DateTimeFinished;
			Console.WriteLine($"Classroom {ClassroomName} finished at {DateTimeFinished}.");
			DeleteClassroom();
		}

		public void CreateNewClassroom() => Console.WriteLine("Esta sala de aula já foi finalizada!");
		public void BeginClass() => Console.WriteLine("Não é possível iniciar uma aula finalizada!");
		public void EndClass() => Console.WriteLine("Sala de aula já finalizada.");
		public void CancelClass() => Console.WriteLine("Impossível cancelar uma sala de aula previamente finalizada!");

		private void DeleteClassroom()
		{
			Console.WriteLine($"Sala de aula {ClassroomName} foi excluída.");
		}
	}
}
