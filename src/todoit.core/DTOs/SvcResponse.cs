namespace Todoit.Core.DTOs
{
	public class SvcResponse
	{
		public bool Success { get; set; } = true;
		public string Message { get; set; }

		public void Fail(string message)
		{
			Success = false;
			Message = message;
		}
	}

	public class SvcResponse<T> : SvcResponse
	{
		public T Data { get; set; }
	}
}
