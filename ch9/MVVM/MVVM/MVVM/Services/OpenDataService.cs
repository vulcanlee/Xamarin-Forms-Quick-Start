using MVVM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Services
{
    public class OpenDataService
    {
        public async Task<List<OpenDataItem>> Get()
        {
            var result = new List<OpenDataItem>();
            HttpClient client = new HttpClient();
            var content = await client.GetStringAsync("https://lobworkshop.azurewebsites.net/open.json");
            result = JsonConvert.DeserializeObject<List<OpenDataItem>>(content);
            return result;
        }
    }
}
