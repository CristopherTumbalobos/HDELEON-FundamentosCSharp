using FundamentosCSHARP.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            //SERIALIZACION: Objeto -> Json
            //Cerveza cerveza = new Cerveza(10, "Cerveza");
            //string miJson = JsonSerializer.Serialize(cerveza);
            //File.WriteAllText("objeto.txt",miJson);

            //DESERIALIZACION: Json -> Objeto
            string miJson = File.ReadAllText("objeto.txt");
            Cerveza cerveza = JsonSerializer.Deserialize<Cerveza>(miJson);

        }
    }
}
