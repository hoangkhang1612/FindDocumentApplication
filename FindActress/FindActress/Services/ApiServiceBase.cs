using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FindActress.Helpers;
using FindActress.Models;
using Newtonsoft.Json;

namespace FindActress.Services
{
    public class ApiServiceBase
    {
        public async Task<ApiResponse<T>> GetWithOptionsAsync<T>(string path, Dictionary<string, string> query = null)
        {
            var queryString = string.Empty;
            if (query != null && query.Count > 0)
            {
                using (var content = new FormUrlEncodedContent(query))
                {
                    queryString = content.ReadAsStringAsync().Result;
                }
            }

            return await GetAsync<T>(path, queryString);
        }

        private HttpClient InitializeHttpClient(string baseAddress)
        {
            var client = new HttpClient();

            //var client = new HttpClient(new NativeMessageHandler())
            //{
            //    MaxResponseContentBufferSize = int.MaxValue,
            //    Timeout = TimeSpan.FromSeconds(Constants.NetworkTimeoutSeconds)
            //};
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Constants.ApplicationJsonMimeType));
            if (!string.IsNullOrEmpty(baseAddress))
                client.BaseAddress = new Uri(baseAddress);

            //var token = AppSettings.Current.AccessToken;
            //if (!string.IsNullOrEmpty(token))
            //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Constants.AuthorizationBearer, token);

            return client;
        }

        private async Task<ApiResponse<T>> GetAsync<T>(string path, string query = "")
        {
            SimpleLogger.Current.Debug($">>>>> GET: {path}\n\tQuery: {query}");
            try
            {
                var client = InitializeHttpClient(Constants.BaseUrl);

                var fullPath = string.IsNullOrEmpty(query) ? path : $"{path}?{query}";

                var response = await client.GetAsync(fullPath);

                var content = await response.Content.ReadAsStringAsync();

                SimpleLogger.Current.Debug($"<<<<< Response Body: {content}");

                return GenerateApiResponse<T>(response, content);
            }
            catch (Exception ex)
            {
                SimpleLogger.Current.Error(ex.Message, ex);

                return GetGenericError<T>($"{ex.Message} {path}");
            }
        }

        private static ApiResponse<T> GetGenericError<T>(string message)
        {
            return new ApiResponse<T>
            {
                //Code = 9999,
                Count = 0,
                Total = 0,
                Result = default,
                //Message = message,//"Something went wrong!",
                //IsSuccess = false
            };
        }

        public static T JsonToObject<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        private static ApiResponse<T> GenerateApiResponse<T>(HttpResponseMessage response, string content)
        {
            ApiResponse<T> result;

            try
            {
                if (response.StatusCode == HttpStatusCode.OK)
                    result = JsonToObject<ApiResponse<T>>(content);
                else
                    result = new ApiResponse<T>
                    {
                        //Code = (int)response.StatusCode,
                        Count = 0,
                        Total = 0,
                        Result = default,
                        //Message = response.ReasonPhrase,
                        //IsSuccess = false
                    };
            }
            catch (Exception ex)
            {
                SimpleLogger.Current.Error(ex.Message, ex);

                result = GetGenericError<T>($"Get Response {ex.Message} {response.RequestMessage.RequestUri.PathAndQuery}");
            }

            return result;
        }
    }
}
