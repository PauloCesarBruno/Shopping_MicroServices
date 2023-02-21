using Microsoft.Net.Http.Headers;
using System.Text.Json;

namespace GeekShopping.Web.Utils
{
    // Tem que ser uma classe estatica.
    public static class HttpClientExtensions
    {
        private static MediaTypeHeaderValue contentType
            = new MediaTypeHeaderValue("application/json");

        public static async Task<T> ReadContentAs<T>(
            this HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode) throw
                   new ApplicationException(
                       $"Something went wrong calling the API: " +
                       $"{response.ReasonPhrase}");

            var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonSerializer.Deserialize<T>(dataAsString, new JsonSerializerOptions
            { PropertyNameCaseInsensitive = true });
        }

        public static Task<HttpResponseMessage> PostAsJson<T>(
            this HttpClient httpclient,
            string url,
            T data)
        {
            var dataAsString = JsonSerializer.Serialize(data);
            var content = new StringContent(dataAsString);
            //content.Headers.ContentType = contentType;
            return httpclient.PostAsJsonAsync(url, content);
        }

        public static Task<HttpResponseMessage> PutAsJson<T>(
            this HttpClient httpclient,
            string url,
            T data)
        {
            var dataAsString = JsonSerializer.Serialize(data);
            var content = new StringContent(dataAsString);
            //content.Headers.ContentType = contentType;
            return httpclient.PutAsJsonAsync(url, content);
        }
    }
}
