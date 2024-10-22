using System;

namespace ManagerClassroom.classroom
{
	public class PlanClass : IManageClass
	{
		private readonly Classroom _classroom;
		public DateTime DateTimePlanStart { get; private set; }
		public string ClassroomName { get; private set; }
		public DateTime DateTimePlanFinished { get; private set; }

		public PlanClass(Classroom classroom)
		{
			_classroom = classroom;
			ClassroomName = $"Sala de aula-{classroom.Id}";
			DateTimePlanStart = classroom.PlannedStart;
			DateTimePlanFinished = classroom.PlannedEnd;
		}

		public void CreateNewClassroom()
		{
			Console.WriteLine($"Sala de aula {ClassroomName} criada.");
			Console.WriteLine($"Início previsto: {DateTimePlanStart}.");
			Console.WriteLine($"Fim previsto: {DateTimePlanFinished}.");
			_classroom.SetState(new StartClass(_classroom));
		}

		public void BeginClass() => Console.WriteLine("Impossível iniciar uma sala de aula antes de ela ser criada!");
		public void EndClass() => Console.WriteLine("Impossível finalizar uma sala de aula antes de ela ser iniciada!");
		public void CancelClass() => Console.WriteLine("Impossível cancelar uma sala de aula antes de ela ser criada!");
	}
}
