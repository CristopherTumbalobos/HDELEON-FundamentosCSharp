using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP.Models
{
    public class Vino : Bebida, IBebidaAlcoholica
    {
        // IMPLEMENTANDO LOS MIEMBROS DE LA INTERFAZ
        public int Alcohol { get; set; }

        //Especificar el metodo
        public void MaximoRecomendado()
        {
            Console.WriteLine("El maximo es 3 copas");
        }

        // CONSTRUCTOR

        //public Cerveza () : base("Cervezita", 400)
        //{
        //}

        //public Cerveza(string Name, int Cant) : base(Name, Cant)
        //{
        //}

        // RECOMENDACION: Los parametros opcionales siempre al final
        public Vino(int Cantidad, string Nombre = "Vino Por Defecto") : base(Nombre, Cantidad)
        {

        }

        //ATRIBUTO DE LA INTERFAZ POR DEFECTO
        //public int Alcohol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}
