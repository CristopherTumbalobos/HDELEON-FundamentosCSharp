using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP.Models
{
    // HERENCIA: Cerveza hereda de la clase Bebida
    // IMPLEMENTACIÓN: Cerveza implementa la interfaz IBebidaAlcoholica 

    public class Cerveza : Bebida, IBebidaAlcoholica
    {
        // IMPLEMENTANDO LOS MIEMBROS DE LA INTERFAZ
        public int Alcohol { get; set; }
        public string Marca { get; set; }

        //Especificar el metodo
        public void MaximoRecomendado()
        {
            Console.WriteLine("El maximo es 10 botellas");
        }

        // CONSTRUCTOR

        //public Cerveza () : base("Cervezita", 400)
        //{
        //}

        //public Cerveza(string Name, int Cant) : base(Name, Cant)
        //{
        //}

        // RECOMENDACION: Los parametros opcionales siempre al final
        public Cerveza(int Cantidad, string Nombre = "Por Defecto") : base(Nombre, Cantidad)
        {

        }

        //ATRIBUTO DE LA INTERFAZ POR DEFECTO
        //public int Alcohol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}
