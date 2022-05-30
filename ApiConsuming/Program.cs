// See https://aka.ms/new-console-template for more information

using ApiConsuming.Models;
using Newtonsoft.Json;

var client = new HttpClient();

var response = await client.GetAsync("https://jsonplaceholder.typicode.com/users");

var content = await response.Content.ReadAsStringAsync();

var users = JsonConvert.DeserializeObject<User[]>(content);

foreach(var user in users) 
{
    Console.WriteLine($"Nome: {user.Name} - Email:{user.Email}");
}




