using FundamentosCSHARP.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Linq;
using FundamentosCSHARP.Service;
using FundamentosCSHARP.Errors;

namespace FundamentosCSHARP
{
    class Program
    {
        //DELEGADOS: Para agregar funcionalidad a nuestras funcionalidades
        //public delegate void Mostrar(string cadena);
        //public delegate string Mostrar(string cadena);

        //async: Para realizar otras acciones mientras esperamos
        static async Task Main(string[] args)
        {
            //FUNC: Regresa el ultimo generico(parametro)
            //Func<string, int> mostrar = Show;
            //Mostrar mostrar = Show;
            //HacerAlgo(mostrar);

            //ACTION: No regresa nada
            //=>: Funcion anonima (por si solo se usa una vez)
            Action<string, string> mostrar = (a, b) => Console.WriteLine(a+b);
            HacerAlgo(mostrar);
        }

        public static void HacerAlgo(Action<string, string> funcionFinal)
        {
            Console.WriteLine("Antes");
            //funcionFinal("Se envio desde otra función");
            funcionFinal("Se envio desde otra función", " Otra cadena");
            Console.WriteLine("Despues");
        }

        //public static void Show(string cad, string cad2)
        //{
        //    Console.WriteLine(cad+cad2);
        //}

        //public static void Show(string cad)
        //{
        //    Console.WriteLine("Hola, soy un delegado" + cad);
        //}

        //public static string Show(string cad)
        //{
        //    return cad.ToUpper();
        //}

        //public static int Show(string cad)
        //{
        //    return cad.Count();
        //}
    }
}
