using FundamentosCSHARP.Models;
using System;
using System.Collections.Generic;

namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARREGLOS

            int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //int numero = numeros[0];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Posicion: " + i + " - Elemento: " + numeros[i]);
            }

            Console.WriteLine("");

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("******************************************");

            // COLA (QUEUE): First input First Output (FIFO)
            // PILA: Last Input First Output (LIFO)

            // LISTAS

            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            lista.Add(9);
            lista.Add(10);

            lista.Remove(2);

            foreach (var numero in lista)
            {
                Console.WriteLine("Elemento de la lista: " + numero);
            }

            Console.WriteLine("*****************************************");

            List<Cerveza> cervezas = new List<Cerveza>() { new Cerveza(10, "Cerveza 1") };
            cervezas.Add(new Cerveza(50, "Cerveza 2"));

            Cerveza erdinger = new Cerveza(500, "Cerveza 3");
            cervezas.Add(erdinger);

            foreach (var cerveza in cervezas)
            {
                Console.WriteLine("Cerveza: " + cerveza.Nombre);
            }

            Console.ReadLine();
        }
    }
}
