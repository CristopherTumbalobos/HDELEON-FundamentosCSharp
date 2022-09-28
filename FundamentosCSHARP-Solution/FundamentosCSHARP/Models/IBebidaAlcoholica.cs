using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP.Models
{
    interface IBebidaAlcoholica
    {
        //ATRIBUTO DE LA INTERFAZ
        public int Alcohol { get; set; }

        //FIRMA DEL METODO
        public void MaximoRecomendado();

    }
}
