using FundamentosCSHARP.Models;
using System;
using System.Collections.Generic;

namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            CervezaBD cervezaBD = new CervezaBD();
            var cervezas = cervezaBD.Get();

            foreach (var cerveza in cervezas)
            {
                Console.WriteLine(cerveza.Nombre);
                Console.WriteLine(cerveza.Marca);
                Console.WriteLine(cerveza.Alcohol);
                Console.WriteLine(cerveza.Cantidad);
            }
        }
    }
}
