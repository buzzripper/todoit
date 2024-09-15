using System.Diagnostics;
using System.Text.Json.Serialization;

namespace Todoit.Core.DTOs
{
	public class AppInfo
	{
		public string ServerName { get; set; }
		public AppVersionInfo AppVersion { get; set; }
		public Job CurrentJob { get; set; }
		[JsonConverter(typeof(JsonStringEnumConverter))]
		public ReleaseServiceMode ReleaseServiceMode { get; set; }
	}

	public class AppVersionInfo
	{
		public AppVersionInfo()
		{ }

		public AppVersionInfo(FileVersionInfo fileVersionInfo)
		{
			Version = fileVersionInfo.FileVersion;
			ShaVersion = fileVersionInfo.ProductName;
			DbVersion = fileVersionInfo.ProductVersion;
		}

		public string Version { get; set; }
		public string ShaVersion { get; set; }
		public string DbVersion { get; set; }
	}

	public enum ReleaseServiceMode
	{
		File,
		S3
	}
}
