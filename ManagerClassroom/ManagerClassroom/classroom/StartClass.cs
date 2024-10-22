using System;

namespace ManagerClassroom.classroom
{
	public class StartClass : IManageClass
	{
		private readonly Classroom _classroom;
		public string ClassroomName { get; private set; }
		public DateTime DateTimeStarted { get; private set; }

		public StartClass(Classroom classroom)
		{
			_classroom = classroom;
			ClassroomName = $"Sala de aula-{classroom.Id}";
		}

		public void BeginClass()
		{
			DateTimeStarted = DateTime.Now;
			_classroom.RealStart = DateTimeStarted;
			Console.WriteLine($"Sala de aula {ClassroomName} iniciada às {DateTimeStarted}.");
			_classroom.SetState(new FinishedClass(_classroom));
		}

		public void CreateNewClassroom() => Console.WriteLine("Sala de aula previamente criada!");
		public void EndClass() => Console.WriteLine("Não é possível finalizar uma sala de aula antes de ela iniciar!");
		public void CancelClass() => Console.WriteLine("Não é possível cancelar uma sala de aula após ela iniciar!");
	}
}
