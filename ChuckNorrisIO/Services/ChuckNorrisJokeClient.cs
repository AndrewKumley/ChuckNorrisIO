using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;

namespace ChuckNorrisIO.Services
{
    public class ChuckNorrisJokeClient
    {
        public IEnumerable<string> Categories()
        {
            System.Net.Http.HttpClient httpClient = new HttpClient();
            System.Net.Http.HttpResponseMessage response = httpClient.GetAsync("https://api.chucknorris.io/jokes/categories").Result;
            string content = response.Content.ReadAsStringAsync().Result;

            string[] result = Newtonsoft.Json.JsonConvert.DeserializeObject<string[]>(content);

            response.Dispose();
            httpClient.Dispose();

            return result;
        }

        public IEnumerable<string> Random()
        {
            System.Net.Http.HttpClient httpClient = new HttpClient();
            System.Net.Http.HttpResponseMessage response = httpClient.GetAsync("https://api.chucknorris.io/jokes/categories").Result;
            string content = response.Content.ReadAsStringAsync().Result;

            Joke result = Newtonsoft.Json.JsonConvert.DeserializeObject<Joke>(content);

            response.Dispose();
            httpClient.Dispose();

            return new string[] { result.Value };
        }

        private string GetContent(string uri)
        {
            System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();
            System.Net.Http.HttpResponseMessage response = httpClient.GetAsync(uri).Result;
            string content = response.Content.ReadAsStringAsync().Result;
            response.Dispose();
            httpClient.Dispose();

            return content;
        }

        private class Joke
        {
            public string[] Categories { get; set; }
            public string Value { get; set; }
        }
    }
}
