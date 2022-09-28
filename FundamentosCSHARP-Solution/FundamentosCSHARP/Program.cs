using FundamentosCSHARP.Models;
using System;
using System.Collections.Generic;

namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            var bebidaAlcoholica1 = new Cerveza(100);
            MostrarRecomendacion(bebidaAlcoholica1);
            var bebidaAlcoholica2 = new Vino(100);
            MostrarRecomendacion(bebidaAlcoholica2);

            //Para ver las interfaces que implementa la clase "List"
            List<string> hola = new List<string>();
        }

        static void MostrarRecomendacion(IBebidaAlcoholica bebida)
        {
            bebida.MaximoRecomendado();
        }
    }
}
