using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP.Models
{
    public class Bebida
    {
        // ATRIBUTOS
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        // CONSTRUCTOR: Mismo nombre de la clase / No tiene un tipo / Si no hay constructor hay un por defecto (no recibe ningun parametro)
        public Bebida(string Name, int Cant)
        {
            //THIS: Hace referencia a los atributos de la clase
            this.Nombre = Name;
            this.Cantidad = Cant;
        }

        //METODO
        public void Beberse(int CuantoBebio)
        {
            this.Cantidad -= CuantoBebio;
        }

        // MODIFICADORES DE ACCESO:

        // PRIVATE: Solo accedido por los miembros de la misma clase
        // INTERNAL: Atributo no puede ser accedido desde otro dll (paquetes compilados en C# para almacenar librerias/clases encapsuladas)
        // PROTECTED: Solo acceden a ella las clases derivadas de esta

    }
}
