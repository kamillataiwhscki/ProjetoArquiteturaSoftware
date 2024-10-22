using System;

namespace ManagerClassroom.classroom
{
	public class Classroom
	{
		public int Id { get; set; }
		public DateTime PlannedStart { get; set; }
		public DateTime PlannedEnd { get; set; }
		public DateTime? RealStart { get; set; }
		public DateTime? RealEnd { get; set; }

		private IManageClass _currentState;  
	
		public Classroom(int id, DateTime plannedStart, DateTime plannedEnd)
		{
			Id = id;
			PlannedStart = plannedStart;
			PlannedEnd = plannedEnd;
			_currentState = new PlanClass(this);  
		}

		public void SetState(IManageClass newState)
		{
			_currentState = newState;
		}

		public void CreateNewClassroom() => _currentState.CreateNewClassroom();
		public void BeginClass() => _currentState.BeginClass();
		public void EndClass() => _currentState.EndClass();
		public void CancelClass() => _currentState.CancelClass();
	}
}
