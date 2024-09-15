using System;

namespace Todoit.Core.DTOs
{
	public class JobLogQuery
	{
		public int JobId { get; set; }
		public DateTime? FromTimestamp { get; set; }
		public JobLogLevel MinLevel { get; set; } = JobLogLevel.Info;
		public string Message { get; set; }
		public string Exception { get; set; }

		public bool SortDesc { get; set; }
		public int PageSize { get; set; }
		public int PageNum { get; set; }
	}
}
