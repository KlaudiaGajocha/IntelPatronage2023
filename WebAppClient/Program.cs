// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Reflection.Metadata.Ecma335;
using WebAppClient;

HttpClient client = new();
client.BaseAddress = new Uri("https://localhost:7119");
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

HttpResponseMessage response = await client.GetAsync("api/book");
HttpResponseMessage response2 = await client.GetAsync("api/author");

response.EnsureSuccessStatusCode();

if (response.IsSuccessStatusCode)
{
    var books = await response.Content.ReadFromJsonAsync <IEnumerable<BookDto>> ();
    foreach (var book in books)
        {
        Console.WriteLine(book.Id);
        Console.WriteLine(book.Title);
        Console.WriteLine(book.Description);
        Console.WriteLine(book.Rating);
        Console.WriteLine(book.ISBN);
        Console.WriteLine(book.PublicationDate);
    }
}
else
{
    Console.WriteLine("No results");
}

response2.EnsureSuccessStatusCode();

if (response2.IsSuccessStatusCode)
{
    var authors = await response.Content.ReadFromJsonAsync<IEnumerable<AuthorDto>>();
    foreach (var author in authors)
    {
        Console.WriteLine(author.Id);
        Console.WriteLine(author.FirstName);
        Console.WriteLine(author.LastName);
        Console.WriteLine(author.BirthDate);
        Console.WriteLine(author.Gender);
        
    }
}
else
{
    Console.WriteLine("No results");
}

Console.ReadLine();



