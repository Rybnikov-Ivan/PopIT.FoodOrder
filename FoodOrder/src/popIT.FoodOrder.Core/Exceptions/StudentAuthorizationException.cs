using System;
using System.Collections.Generic;
using System.Text;

namespace popIT.FoodOrder.Core.Exceptions
{
	public class StudentAuthorizationException : FoodOrderException
	{
		public StudentAuthorizationException(string studentTicket)
		{
			StudentTicket = studentTicket;
		}

		public string StudentTicket { get; }
		public override string Message => $"Student with ticket {StudentTicket} not found.";
	}
}
