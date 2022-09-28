using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP.Models
{
    public class Cerveza : Bebida
    {
        // CONSTRUCTOR

        //public Cerveza () : base("Cervezita", 400)
        //{
        //}

        //public Cerveza(string Name, int Cant) : base(Name, Cant)
        //{
        //}

        //RECOMENDACION: Los parametros opcionales siempre al final
        public Cerveza(int Cantidad, string Nombre = "Por Defecto") : base(Nombre, Cantidad)
        {

        }
    }
}
