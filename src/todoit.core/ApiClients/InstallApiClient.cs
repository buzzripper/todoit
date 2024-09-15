using Serilog;
using System.Net.Http;
using System.Threading.Tasks;
using Todoit.Core.Config;
using Todoit.Core.DTOs;

namespace Todoit.Core.ApiClients
{
	public interface IInstallApiClient : IApiClientBase
	{
		Task<CommandResponse> StartApplication();
		Task<CommandResponse> StopApplication();
		Task<CommandResponse> Deploy(string version);
	}

	public class InstallApiClient : ApiClientBase, IInstallApiClient
	{
		public InstallApiClient(ClientConfig clientConfig, IHttpClientFactory httpClientFactory)
			: base(clientConfig, httpClientFactory)
		{ }

		public async Task<CommandResponse> StartApplication()
		{
			return await PostAsync<CommandResponse>(nameof(StartApplication), null);
		}

		public async Task<CommandResponse> StopApplication()
		{
			return await PostAsync<CommandResponse>(nameof(StopApplication), null);
		}

		public async Task<CommandResponse> Deploy(string version)
		{
			return await PostAsync<CommandResponse>($"{nameof(Deploy)}/{version}", null);
		}

	}
}
