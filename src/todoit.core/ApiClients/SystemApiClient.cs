using Serilog;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Todoit.Core.Config;
using Todoit.Core.DTOs;

namespace Todoit.Core.ApiClients
{
	public interface ISystemApiClient : IApiClientBase
	{
		Task<AppInfo> GetAppInfo();
		Task<List<string>> GetAvailableReleases();
		Task<List<string>> GetArchivedReleases();
		Task<List<JobLog>> QueryJobLogs(JobLogQuery jobLogQuery);
		Task<Job> GetCurrentJob();
		Task<List<Job>> GetJobs();
		Task<Job> GetJob(int jobId);
	}

	public class SystemApiClient : ApiClientBase, ISystemApiClient
	{
		public SystemApiClient(ClientConfig clientConfig, IHttpClientFactory httpClientFactory, ILogger logger)
			: base(clientConfig, httpClientFactory)
		{ }

		public async Task<AppInfo> GetAppInfo()
		{
			return await GetAsync<AppInfo>(nameof(GetAppInfo));
		}

		public async Task<List<string>> GetAvailableReleases()
		{
			return await GetAsync<List<string>>(nameof(GetAvailableReleases));
		}

		public async Task<List<string>> GetArchivedReleases()
		{
			return await GetAsync<List<string>>(nameof(GetArchivedReleases));
		}

		public async Task<List<JobLog>> QueryJobLogs(JobLogQuery jobLogQuery)
		{
			return await PostAsync<List<JobLog>>(nameof(QueryJobLogs), jobLogQuery);
		}

		public async Task<Job> GetCurrentJob()
		{
			return await GetAsync<Job>(nameof(GetCurrentJob));
		}

		public async Task<List<Job>> GetJobs()
		{
			return await GetAsync<List<Job>>(nameof(GetJobs));
		}

		public async Task<Job> GetJob(int jobId)
		{
			return await GetAsync<Job>($"{nameof(GetJob)}/{jobId}");
		}
	}
}
