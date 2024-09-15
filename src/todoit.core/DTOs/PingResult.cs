using System;

namespace Todoit.Core.DTOs
{
	public class PingResult
	{
		public PingResult()
		{ }

		public PingResult(string controllerName, string message)
		{
			ControllerName = controllerName;
			Message = message;
		}

		public string ControllerName { get; set; }
		public DateTime LocalTime { get; set; }
		public string Message { get; set; }
	}
}
