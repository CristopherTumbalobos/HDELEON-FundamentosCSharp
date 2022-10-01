using FundamentosCSHARP.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Linq;

namespace FundamentosCSHARP
{
    class Program
    {
        //async: Para realizar otras acciones mientras esperamos
        static async Task Main(string[] args)
        {
            List<int> numeros = new List<int>() {64, 1, 4, 5, 6, 7, 2, 3 };

            //FUNCIONES DE EXTENSION DE LINQ
            //Funcion para filtrar
            var numero7 = numeros.Where(x => x == 7).FirstOrDefault();
            var numero79 = numeros.Where(x => x == 79).FirstOrDefault();
            Console.WriteLine(numero7);
            Console.WriteLine(numero79);

            //Funcion para ordenar de LINQ
            var numerosOrdenados = numeros.OrderBy(x => x);
            foreach (var numero in numerosOrdenados)
            {
                Console.WriteLine(numero);
            }

            //Funcion de suma de LINQ
            var total = numeros.Sum(x => x);
            Console.WriteLine(total);

            //Funcion de promedio de LINQ
            var promedio = numeros.Average(x => x);
            Console.WriteLine(promedio);

            List<Cerveza> cervezas = new List<Cerveza>()
            {
                new Cerveza() { Alcohol=7, Cantidad=10, Nombre="Pale Ale", Marca="Minerva"},
                new Cerveza() { Alcohol=8, Cantidad=5, Nombre="Ticús", Marca="Colima"},
                new Cerveza() { Alcohol=7, Cantidad=8, Nombre="Stout", Marca="Minerva"},
                new Cerveza() { Alcohol=6, Cantidad=100, Nombre="Piedra Lisa", Marca="Colima"}
            };

            // SINTAXIS INTEGRADA DE LINQ: Parecido a SQL Server
            var cervezasOrdenadas = from x in cervezas
                                    where x.Nombre == "Pale Ale" && x.Marca == "Minerva"
                                    orderby x.Nombre
                                    select x;
            foreach (var cerveza in cervezasOrdenadas)
            {
                Console.WriteLine($"{cerveza.Nombre} {cerveza.Marca}");
            }
        }
    }
}
