using FundamentosCSHARP.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FundamentosCSHARP
{
    class Program
    {
        //async: Para realizar otras acciones mientras esperamos la solicitud
        static async Task Main(string[] args)
        {
            //Para obtener el Json de un REST de prueba (jsonplaceholder)
            string url = "https://jsonplaceholder.typicode.com/posts";
            HttpClient client = new HttpClient();

            //await: Esperar a que termina para continuar
            //Para obtener la respuesta de la solicitud
            var httpResponse = await client.GetAsync(url);

            //IsSuccessStatusCode: Todo OK (200)
            if (httpResponse.IsSuccessStatusCode)
            {
                //Para leer la respuesta como un string
                var content = await httpResponse.Content.ReadAsStringAsync();
                //Deserializando Json a una lista de "Post"
                var posts = JsonSerializer.Deserialize<List<Post>>(content);
            }
        }
    }
}
