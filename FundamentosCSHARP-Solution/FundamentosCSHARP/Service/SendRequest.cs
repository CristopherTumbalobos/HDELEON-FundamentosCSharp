using FundamentosCSHARP.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FundamentosCSHARP.Service
{
    //T: Para trabajar con cualquier clase
    //where: Para limitar el acceso a la clase genérica, solo para los que implementen la interface "IRequestable"
    //Se puede agregar más genéricos (T,U,V,C,X,...), así como limitar el acceso de cada una de ellas con otros "where"
    public class SendRequest<T> where T: IRequestable
    {
        private HttpClient _client = new HttpClient();

        //async: Para poder realizar otras tareas mientras se completa el proceso
        public async Task<T> Send(T model)
        {
            //Para obtener Json de REST de prueba (jsonplaceholder)
            string url = "https://jsonplaceholder.typicode.com/posts/";

            //Para convertir a Json el objeto "model"
            var data = JsonSerializer.Serialize<T>(model);
            //Para que "data" use correctamente las tildes
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");
            //Esperamos a que se realice la solicitud
            var httpResponse = await _client.PostAsync(url, content);

            //200(OK)
            if (httpResponse.IsSuccessStatusCode)
            {
                //Leer la respuesta como una cadena de texto
                var result = await httpResponse.Content.ReadAsStringAsync();

                //Convertir cadena de texto a un objeto "postResult"
                var postResult = JsonSerializer.Deserialize<T>(result);
                return postResult;
            }

            //Para retornar objetos que sean o no sean nulos
            return default(T);
        }
    }
}
