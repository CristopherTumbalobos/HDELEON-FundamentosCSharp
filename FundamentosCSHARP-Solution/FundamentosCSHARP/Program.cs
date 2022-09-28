using FundamentosCSHARP.Models;
using System;

namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida = new Bebida("Coca Cola", 1000);
            bebida.Beberse(500);

            Console.WriteLine("Queda " + bebida.Cantidad);

            Cerveza cerveza = new Cerveza(300, "Cristal");
            cerveza.Beberse(100);
        }
    }
}
