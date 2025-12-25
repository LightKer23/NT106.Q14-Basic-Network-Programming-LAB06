using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Security.Policy;
using Client.Models;

namespace Client.Services
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonOptions;

        public ApiClient()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://www.postman.com/vietstockapi/public/request/mufpotv/vietstock?action=share&creator=11955308")
            };
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public async Task<ApiResult<T>> PostFromAsync<T>(string url, FormUrlEncodedContent content)
        {
            try
            {
                var response = await _httpClient.PostAsync(url, content);
                if (!response.IsSuccessStatusCode)
                {
                    return ApiResult<T>.Fail($"HTTP Error: {response.StatusCode}");
                }
                var responseData = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<T>(responseData, _jsonOptions);
                return ApiResult<T>.Ok(data);
            }
            catch (Exception ex)
            {
                return ApiResult<T>.Fail($"Exception: {ex.Message}");
            }
        }

    }
}
