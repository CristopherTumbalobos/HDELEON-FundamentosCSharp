using System;

namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            // TIPOS DE DATOS

            //TIPOS NUMERICOS ENTEROS

            // BYTE: De 0 a 255 (8 bits)
            byte numeroByte = 255;
            // BYTE: De -128 a 127 (8 bits)
            sbyte numeroSbyte = 127;
            // SHORT: De -32 768 a 32 767 (16 bits)
            short numeroShort = 32767;
            // USHORT: De 0 a 65.535 (16 bits)
            ushort numeroUshort = 65535;
            // INT: De -2.147.483.648 a 2.147.483.647 (32 bits)
            int numeroInt = 2147483647;
            // UINT: De 0 a 4.294.967.295 (bits)
            uint numeroUint = 4294967295;
            // LONG: De -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807 (64 bits)
            long numeroLong = 9223372036854775807;
            // ULONG: De 0 a 18.446.744.073.709.551.615	(64 bits)
            ulong numeroUlong = 18446744073709551615;

            // TIPOS NUMERICOS DE PUNTO FLOTANTE

            // FLOAT: Precisión de 6 a 9 dígitos aproximadamente (4 bytes)
            float numeroFloat = 1.111111111f;
            // DOUBLE: Precisión de 15 a 17 dígitos aproximadamente (8 bytes)
            double numeroDouble = 1.11111111111111111;
            // DECIMAL: Precisión de 28 a 29 dígitos (16 bytes)
            decimal numeroDecimal = 1.111111111111111111111111111111m;

            // CHAR: Almacena un caracter (Entre comillas simples ' ')
            char caracter = 'A';

            // STRING: Almacena secuencia de caracteres (Ente comillas dobles " ")
            string palabra = "Agua";

            // DATETIME: Almacena fechas (es una clase)
            DateTime fecha = DateTime.Now;

            // BOOL: True or False
            bool estado = true;

            // ENTERO POR DEFECTO: 0 (? NULLABLE: Int / Float / char / ...)
            int? numeroPorDefecto = null;

            // VAR: Solo funciona dentro de los métodos, no puede ser un atributo
            var nombre = "Hector";

            // OBJECT (CON VALORES ANONIMOS): Sin la necesidad de una clase
            object personaObject = new { nombre = "Albert", apellido = "Einstein" };
            Console.WriteLine(personaObject.nombre); //ERROR: No funciona porque un object pierde sus atributos cuando le asignas valores

            // TIPOS ANONIMOS (Usando VAR): Permite conservar sus atributos
            var personaVar = new { nombre = "Albert", apellido = "Einstein", edad = 50 };
            Console.WriteLine(personaVar.nombre);
        }
    }
}
