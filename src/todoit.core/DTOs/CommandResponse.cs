namespace Todoit.Core.DTOs
{
	public class CommandResponse
	{
		public CommandResponse() { }

		public CommandResponse(CommandResponseCode responseCode, int jobId)
		{
			ResponseCode = responseCode;
			NewJobId = jobId;
		}

		public CommandResponse(CommandResponseCode responseCode, Job currentlyRunningJob = null)
		{
			ResponseCode = responseCode;
			CurrentlyRunningJob = currentlyRunningJob;
		}

		public CommandResponseCode ResponseCode { get; set; }
		public int NewJobId { get; set; }
		public Job CurrentlyRunningJob { get; set; }    // Only set if response code is JobAlreadyRunning
	}

	public enum CommandResponseCode
	{
		Success,
		JobAlreadyRunning,
		Error
	}
}
