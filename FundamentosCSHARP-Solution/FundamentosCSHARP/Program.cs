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

            //Insertamos nueva cerveza
            //{}: Creamos un microuniverso para que no se repita el objeto "cerveza" con la "cerveza" del foreach
            //Comentamos para que no inserte más cervezas
            /*
            {
                Cerveza cerveza = new Cerveza(15, "Insertar");
                cerveza.Marca = "Insertar";
                cerveza.Alcohol = 6;
                cervezaBD.Add(cerveza);
            }
            */

            //Editamos un registro en la Base de Datos
            //Comentamos para no editar más cervezas
            /*
            {
                Cerveza cerveza = new Cerveza(5, "Insertar");
                cerveza.Marca = "Insertar";
                cerveza.Alcohol = 5;
                cervezaBD.Edit(cerveza, 5);
            }
            */

            //Eliminamos un registro de la Base de Datos
            {
                cervezaBD.Delete(5);
            }

            //Obtener todas las cervezas de la Base de Datos
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
