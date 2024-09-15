using System;
using System.Text.Json.Serialization;

namespace Todoit.Core.DTOs
{
	public class Job
	{
		public int Id { get; set; }
		[JsonConverter(typeof(JsonStringEnumConverter))]
		public JobType JobType { get; set; }
		public string ServerName { get; set; }
		public string Version { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime? EndTime { get; set; }
		[JsonConverter(typeof(JsonStringEnumConverter))]
		public JobStatus Status { get; set; }

		public override string ToString()
		{
			var version = string.IsNullOrEmpty(Version) ? string.Empty : $"({Version})";
			return $"[{StartTime:d}] {JobType} {version}";
		}
	}

	public enum JobStatus
	{
		Running = 0,
		Success = 1,
		Warning = 2,
		Error = 3
	}

	public enum JobType
	{
		Start,
		Stop,
		Deploy,
		FullDeploy
	}
}
