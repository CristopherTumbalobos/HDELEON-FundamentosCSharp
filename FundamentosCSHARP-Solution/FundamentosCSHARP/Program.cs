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
        //async: Para realizar otras acciones mientras esperamos
        static async Task Main(string[] args)
        {
            ////Usando la clase genérica con "Cerveza"
            //var cerveza = new Cerveza() { Alcohol = 5, Cantidad = 500, Marca = "Colima", Nombre = "Ticus" };
            //Service.SendRequest<Cerveza> service = new Service.SendRequest<Cerveza>();
            //var CervezaRespuesta = await service.Send(cerveza);

            //Usando la clase genérica con "Post"
            var post = new Post() { body = "Body prueba", title = "Hola", UserId = 50 };
            Service.SendRequest<Post> service = new Service.SendRequest<Post>();
            var PostRespuesta = await service.Send(post);
        }
    }
}
