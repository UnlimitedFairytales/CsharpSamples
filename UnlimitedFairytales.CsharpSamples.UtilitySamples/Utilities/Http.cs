using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UnlimitedFairytales.CsharpSamples.UtilitySamples.Utilities
{
    public class Http
    {

        public static HttpClient Client { get; } = new HttpClient();

        public static async Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            return await Client.GetAsync(requestUri);
        }

        public static async Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content)
        {
            return await Client.PostAsync(requestUri, content);
        }
    }
}
