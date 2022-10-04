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
        //async: Para realizar otras acciones mientras esperamos
        static async Task Main(string[] args)
        {
            try
            {
                var searcherBeer = new SearcherBeer();
                var cantidad = searcherBeer.GetCantidad("Stoasdsaut");
                Console.WriteLine("TRY: Todo bien");
            }
            catch (FieldAccessException ex)
            {
                Console.WriteLine("CATCH: Si te he encontrado");           
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("CATCH: Ha caido en una operacion inválida");           
            }
            catch(BeerNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Exception: Excepcion general
            catch(Exception ex)
            {
                Console.WriteLine("CATCH: Una excepcion general");
            }
            //Finally: Siempre se ejecuta
            finally
            {
                Console.WriteLine("FINALLY: Esto siempre se ejecuta");
            }




        }
    }
}
