using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;
using Todoit.Core.DTOs;
using Todoit.Core.Config;
using Todoit.Core.ApiClients;
using System.Threading.Tasks;
using System.Net.Http;
using System;

namespace Todoit.Core.ApiClients
{
	public interface IApiClientBase
	{
		Task<PingResult> Ping();
	}

	public abstract class ApiClientBase : IApiClientBase
	{
		private readonly HttpClient _httpClient;
		private JsonSerializerOptions _serializerOptions;

		protected string UrlPrefix { get; private set; }

		public ApiClientBase(ClientConfig clientConfig, IHttpClientFactory httpClientFactory)
		{
			_httpClient = httpClientFactory.CreateClient();
			_httpClient.DefaultRequestHeaders.Add("ApiKey", clientConfig.ApiKey);
			_httpClient.BaseAddress = new Uri($"{clientConfig.ApiBaseUrl.TrimEnd()}/api/{CalcServiceName()}/");

			_serializerOptions = new JsonSerializerOptions
			{
				DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
				PropertyNamingPolicy = JsonNamingPolicy.CamelCase
			};
		}

		private string CalcServiceName()
		{
			var className = GetType().Name;
			return className.Substring(0, className.Length - "ApiClient".Length);
		}

		#region Get

		protected async Task<T> GetAsync<T>(string uri)
		{
			var httpResponse = await _httpClient.GetAsync(uri);

			if (!httpResponse.IsSuccessStatusCode)
				throw new HttpException((int)httpResponse.StatusCode, httpResponse.ReasonPhrase);

			var responseString = await GetAsyncString(uri);

			var svcResponse = JsonSerializer.Deserialize<SvcResponse<T>>(responseString, _serializerOptions);
			if (svcResponse != null && svcResponse.Success)
				return svcResponse.Data;
			else
				throw new ApplicationException(svcResponse.Message);
		}

		protected async Task GetAsync(string uri)
		{
			var httpResponse = await _httpClient.GetAsync(uri);

			if (!httpResponse.IsSuccessStatusCode)
				throw new HttpException((int)httpResponse.StatusCode, httpResponse.ReasonPhrase);

			await httpResponse.Content.ReadAsStringAsync();
		}

		private async Task<string> GetAsyncString(string uri)
		{
			var httpResponse = await _httpClient.GetAsync(uri);

			if (!httpResponse.IsSuccessStatusCode)
				throw new HttpException((int)httpResponse.StatusCode, httpResponse.ReasonPhrase);

			return await httpResponse.Content.ReadAsStringAsync();
		}

		#endregion

		protected async Task PostAsync(string uri, object payload)
		{
			var responseStr = await PostAsyncStr(uri, payload);

			var svcResponse = JsonSerializer.Deserialize<SvcResponse>(responseStr, _serializerOptions);

			if (svcResponse == null || !svcResponse.Success)
				throw new ApplicationException(svcResponse.Message);
		}

		protected async Task<T> PostAsync<T>(string uri, object payload)
		{
			var responseStr = await PostAsyncStr(uri, payload);

			var svcResponse = JsonSerializer.Deserialize<SvcResponse<T>>(responseStr, _serializerOptions);

			if (svcResponse != null && svcResponse.Success)
				return svcResponse.Data;
			else
				throw new ApplicationException(svcResponse.Message);
		}

		protected async Task<string> PostAsyncStr(string uri, object payload)
		{
			var options = new JsonSerializerOptions
			{
				WriteIndented = true,
				PropertyNamingPolicy = JsonNamingPolicy.CamelCase
			};

			var json = JsonSerializer.Serialize(payload, options);

			using var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

			var httpResponse = await _httpClient.PostAsync(uri, stringContent);

			if (!httpResponse.IsSuccessStatusCode)
				throw new HttpException((int)httpResponse.StatusCode, httpResponse.ReasonPhrase);

			return await httpResponse.Content.ReadAsStringAsync();
		}

		public async Task<PingResult> Ping()
		{
			return await GetAsync<PingResult>(nameof(Ping));
		}
	}
}
