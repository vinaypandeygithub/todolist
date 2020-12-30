using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ToDoUnitTests
{
    public class CommomFunctions
    {
        public async Task<T> GetJsonAsync<T>(string requestUri)
        {
            HttpClient httpClient = new HttpClient();
            var httpContent = await httpClient.GetAsync(requestUri);
            string jsonContent = httpContent.Content.ReadAsStringAsync().Result;
            T obj = JsonConvert.DeserializeObject<T>(jsonContent);
            httpContent.Dispose();
            httpClient.Dispose();
            return obj;
        }
    }
}
