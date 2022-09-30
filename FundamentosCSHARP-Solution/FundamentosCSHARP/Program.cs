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
        //async: Para realizar otras acciones mientras esperamos la solicitud asincrona
        static async Task Main(string[] args)
        {
            //////HTTP POST
            ////Obteniendo el Json de un REST de prueba (jsonplaceholder)
            //string url = "https://jsonplaceholder.typicode.com/posts";
            //var client = new HttpClient();

            ////Creando el objeto post para enviar
            //Post post = new Post()
            //{
            //    UserId = 50,
            //    body = "Hola como estan",
            //    title = "Titulo de Saludo"
            //};

            ////Serializar el objeto "post" -> Json
            //var data = JsonSerializer.Serialize<Post>(post);
            ////Colocar el contenido en una cadena de texto respetando las tildes
            //HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            ////Esperando la respuesta a la solicitud POST
            //var httpResponse = await client.PostAsync(url, content);

            ////200(OK)
            //if (httpResponse.IsSuccessStatusCode)
            //{
            ////Leer el Json como una cadena de texto
            //    var result = await httpResponse.Content.ReadAsStringAsync();

            ////Deserializar el Json -> objeto
            //    var postResult = JsonSerializer.Deserialize<Post>(result);
            //}

            //////HTTP PUT
            ////Obteniendo el Json de un REST de prueba (jsonplaceholder)
            //string url = "https://jsonplaceholder.typicode.com/posts/99";
            //var client = new HttpClient();

            ////Creando el objeto post para editar
            //Post post = new Post()
            //{
            //    UserId = 50,
            //    body = "Body PUT",
            //    title = "Title PUT"
            //};

            ////Serializar el objeto "post" -> Json
            //var data = JsonSerializer.Serialize<Post>(post);
            ////Colocar el contenido en una cadena de texto respetando las tildes
            //HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            ////Esperando la respuesta a la solicitud PUT
            //var httpResponse = await client.PutAsync(url, content);

            ////200(OK)
            //if (httpResponse.IsSuccessStatusCode)
            //{
            ////Leer el Json como una cadena de texto
            //    var result = await httpResponse.Content.ReadAsStringAsync();

            ////Deserializar el Json -> objeto
            //    var postResult = JsonSerializer.Deserialize<Post>(result);
            //}

            ////HTTP DELETE
            //Obteniendo el Json de un REST de prueba (jsonplaceholder)
            string url = "https://jsonplaceholder.typicode.com/posts/99";
            var client = new HttpClient();

            //Esperando la respuesta a la solicitud DELETE
            var httpResponse = await client.DeleteAsync(url);

            //200(OK)
            if (httpResponse.IsSuccessStatusCode)
            {
                //Leer el Json como una cadena de texto
                var result = await httpResponse.Content.ReadAsStringAsync();
            }
        }
    }
}
