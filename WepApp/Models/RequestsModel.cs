using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace WepApp.Models
{
    public static class RequestsModel
    {
        static HttpClient client = new HttpClient();

        public static async Task<String> GetRequest(String url)
        {
            String results = null;
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                results = await response.Content.ReadAsStringAsync();
            }
            return results;
        }

    }
}