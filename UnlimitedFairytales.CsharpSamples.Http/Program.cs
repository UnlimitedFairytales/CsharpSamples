using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace UnlimitedFairytales.CsharpSamples.Http
{
    class Program
    {
        static readonly string BEARER = "Bearer";
        static readonly string ACCESS_TOKEN = "...";
        static readonly JsonSerializerOptions IGNORE_NULL_JSON_OPTION = new JsonSerializerOptions()
        {
            // Serializeする際、いかなる文字もUnicode Escape Sequenceに変換しない
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            // Serializeする際、それがdtoの場合、nullのプロパティやフィールドは無視する（Dictionaryの場合はnullでも無視されない）
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        };

        static StringContent GetUtf8JsonStringContent(object dto)
        {
            string json = JsonSerializer.Serialize(dto, IGNORE_NULL_JSON_OPTION);
            return GetUtf8JsonStringContent(json);
        }
        static StringContent GetUtf8JsonStringContent(Dictionary<string, string> parameters)
        {
            string json = JsonSerializer.Serialize(parameters, IGNORE_NULL_JSON_OPTION);
            return GetUtf8JsonStringContent(json);
        }
        static StringContent GetUtf8JsonStringContent(string json)
        {
            Console.WriteLine(json);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        static void Main(string[] args)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(BEARER, ACCESS_TOKEN);
            var endpoint = "http://unlimited-fairytales.com/";
            var parameters = new Dictionary<string, string>() { { "foo", "ほげ" }, { "bar", "ふが" }, { "baz", null } };

            // get sample
            {
                var queryString = (new FormUrlEncodedContent(parameters)).ReadAsStringAsync();
                var response = client.GetAsync(endpoint + "?" + queryString).Result;
                Console.WriteLine(((int)response.StatusCode).ToString() + " " + response.StatusCode.ToString());
                Console.WriteLine(response.Headers.ToString());
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.ReadKey();
            }

            // post sample
            {
                var content = GetUtf8JsonStringContent(parameters);
                var response = client.PostAsync(endpoint, content).Result;
                Console.WriteLine(((int)response.StatusCode).ToString() + " " + response.StatusCode.ToString());
                Console.WriteLine(response.Headers.ToString());
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.ReadKey();
            }
        }
    }
}
