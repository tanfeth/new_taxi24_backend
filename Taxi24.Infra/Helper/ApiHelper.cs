using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Common.IHelper;

namespace Taxi24.Infra.Handlers
{
    public class ApiHelper : IApiHelper
    {
        private readonly HttpClient httpClient;

        public ApiHelper()
        {
            httpClient = new HttpClient();
            Headers = new Dictionary<string, string>();
        }



        public async Task<TResponse> GetAsync<TResponse>(string url)
        {
            var result =  await httpClient.GetAsync(url);
            var response = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TResponse>(response);
        }
        public async Task<TResponse> PostAsync<TData, TResponse>(string url, TData entity)
        {
            foreach(var item in Headers)
            {
                httpClient.DefaultRequestHeaders.Add(item.Key, item.Value);
            }
            var json = JsonConvert.SerializeObject(entity);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var result = await httpClient.PostAsync(url, data);
            var response = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TResponse>(response);
        }


        public Dictionary<string, string> Headers { get; set; }
    }
}
