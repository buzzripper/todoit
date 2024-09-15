using System;

namespace Todoit.Core.DTOs
{
	public class JobLog
	{
		public int Id { get; set; }
		public int JobId { get; set; }
		public DateTime Timestamp { get; set; }
		public JobLogLevel Level { get; set; }
		public string Message { get; set; }
		public string Exception { get; set; }

		public DateTime LocalTimestamp
		{
			get { return Timestamp.ToLocalTime(); }
		}
	}

	public enum JobLogLevel
	{
		Info,
		Warning,
		Error
	}
}
