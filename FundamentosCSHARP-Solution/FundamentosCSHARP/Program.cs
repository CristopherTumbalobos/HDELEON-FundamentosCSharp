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
            //Creando lista de bares con sus propias cervezas
            List<Bar> bares = new List<Bar>()
            {
                new Bar("El bar 1")
                {
                    cervezas = new List<Cerveza>
                    {
                        new Cerveza() { Alcohol=7, Cantidad=10, Nombre="Pale Ale", Marca="Minerva"},
                        new Cerveza() { Alcohol=8, Cantidad=5, Nombre="Ticús", Marca="Colima"},
                        new Cerveza() { Alcohol=7, Cantidad=8, Nombre="Stout", Marca="Minerva"},
                    }
                },
                new Bar("El bar 2")
                {
                    cervezas = new List<Cerveza>
                    {
                        new Cerveza() { Alcohol=7, Cantidad=8, Nombre="Stout", Marca="Minerva"},
                        new Cerveza() { Alcohol=6, Cantidad=100, Nombre="Piedra Lisa", Marca="Colima"}
                    }
                },
                new Bar("El bar nuevo")
            };

            //Busca en que bares se encuentran cervezas con nombre "Ticús"
            //var bar = (from d in bares
            //          where d.cervezas.Where(c => c.Nombre == "Ticús").Count() > 0
            //          select d).ToList();

            //Busca en que bares se encuentran cervezas con nombre "Stout"
            //var bar = (from d in bares
            //          where d.cervezas.Where(c => c.Nombre == "Stout").Count() > 0
            //          select d).ToList();

            //LINQ: Puedes crear objetos complejos
            //LINQ: Puedes realizar consultas sobre consultas
            //Busca en que bares se encuentran cervezas con nombre "Stout", asimismo nos muestra las bebidas que se encuentran en dichos bares mostrandonos sus atributos
            var bar = (from d in bares
                      where d.cervezas.Where(c => c.Nombre == "Stout").Count() > 0
                      select new BarData(d.Nombre)
                      {
                          bebidas = (from b in d.cervezas
                                        select new Bebida(b.Nombre, b.Cantidad)
                                        ).ToList()
                      }
                      ).ToList();
        }
    }
}
