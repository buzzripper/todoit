//using Microsoft.AspNetCore.Authentication;
//using System.Net.Http.Headers;
//using System.Text.Json;
//using System.Text.Json.Serialization;
//using System.Text;

//namespace GenesysCloudGateway.ApiClients
//{
//    public abstract class ApiClientBase
//    {
//        private readonly HttpClient _httpClient;
//        protected readonly ILogger _logger;

//        public ApiClientBase(IHttpClientFactory httpClientFactory, string baseUrl, IHttpContextAccessor httpContextAccessor, ILogger logger)
//        {
//            _httpClient = httpClientFactory.CreateClient();
//            _httpClient.BaseAddress = new Uri(baseUrl.TrimEnd());

//            var accessToken = httpContextAccessor.HttpContext.GetTokenAsync("access_token")?.GetAwaiter().GetResult();
//            if (string.IsNullOrWhiteSpace(accessToken))
//                throw new Exception($"{GetType().Name}: No access token found for ApiClient {baseUrl}.");

//            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
//            _logger = logger;
//        }

//        protected async Task<T> GetAsync<T>(string uri)
//        {
//            var httpResponse = await _httpClient.GetAsync(uri);

//            if (!httpResponse.IsSuccessStatusCode)
//                throw new HttpException((int)httpResponse.StatusCode, httpResponse.ReasonPhrase);

//            var responseString = await httpResponse.Content.ReadAsStringAsync();

//            var options = new JsonSerializerOptions
//            {
//                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
//                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
//            };
//            return JsonSerializer.Deserialize<T>(responseString, options);
//        }

//        protected async Task<T> PostAsync<T>(string uri, object payload)
//        {
//            var responseString = await PostAsync(uri, payload);
//            return JsonSerializer.Deserialize<T>(responseString);
//        }

//        protected async Task<string> PostAsync(string uri, object payload)
//        {
//            var options = new JsonSerializerOptions
//            {
//                WriteIndented = true,
//                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
//            };

//            var json = JsonSerializer.Serialize(payload, options);
//            using var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
//            var httpResponse = await _httpClient.PostAsync(uri, stringContent);

//            if (!httpResponse.IsSuccessStatusCode)
//                throw new HttpException((int)httpResponse.StatusCode, httpResponse.ReasonPhrase);

//            return await httpResponse.Content.ReadAsStringAsync();
//        }
//    }
//}
