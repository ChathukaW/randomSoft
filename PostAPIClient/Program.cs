using PostAPIClient.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace PostAPIClient
{
    class Program
    {
        private static async Task<List<Post>> PostRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var streamTask = client.GetStreamAsync("https://60ab5f655a4de40017cc9eda.mockapi.io/Post");
            var repositories = await JsonSerializer.DeserializeAsync<List<Post>>(await streamTask);

            return repositories;
        }

        private static async Task<List<Person>> PersonRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var streamTask = client.GetStreamAsync("https://60ab5f655a4de40017cc9eda.mockapi.io/Person");
            var repositories = await JsonSerializer.DeserializeAsync<List<Person>>(await streamTask);

            return repositories;
        }
        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            var postRepo = await PostRepositories();
            var personRepo = await PersonRepositories();

            foreach (var repo in postRepo)
            {
                Console.WriteLine("Id "+ repo.Id);
                Console.WriteLine("Title "+ repo.Title);
                Console.WriteLine("Image URL " + repo.ImageUrl);
                Console.WriteLine("Created Time " + repo.CreatedTime);
                Console.WriteLine("Author's Name " + repo.AuthorName);
                Console.WriteLine("Total Likes" + repo.TotalLikes);
                Console.WriteLine("         ");
            }

            foreach (var repo in personRepo)
            {
                Console.WriteLine("Id " + repo.Id);
                Console.WriteLine(repo.FirstName);
                Console.WriteLine(repo.LastName);
                Console.WriteLine(repo.Email);
                Console.WriteLine("         ");
            }

        }
    }
}
