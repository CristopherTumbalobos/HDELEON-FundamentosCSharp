using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace FundamentosCSHARP.Models
{
    public class CervezaBD
    {
        //Estableciendo la cadena de conección a la Base de Datos (SQL Server)
        //~ 4 parámetros: Servidor / Base de Datos / User / Password
        public string connectionString
            = "Data Source=DESKTOP-VI9GEC1;Initial Catalog=FundamentosCSharp;User=sa;Password=#y754afLP";

        //Metodo para obtener info de la Base de Datos
        public List<Cerveza> Get()
        {
            List<Cerveza> cervezas = new List<Cerveza>();

            //query = "Consulta SQL Server"
            string query = "select nombre, marca, alcohol, cantidad from cerveza";

            //using: Especificar un microuniverso
            //Realizando la conexión a la Base de Datos (SQL Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //SqlCommand: Para mandar consultas
                SqlCommand command = new SqlCommand(query, connection);

                //Abriendo la conexión "connection" a la Base de Datos
                connection.Open();
                //ExecuteReader: Obtener registros
                SqlDataReader reader = command.ExecuteReader();

                //Read: Leer los registros 1 por 1
                while (reader.Read())
                {
                    //Atributos recibidos por el constructor de "Cerveza"
                    int Cantidad = reader.GetInt32(3);
                    string Nombre = reader.GetString(0);
                    Cerveza cerveza = new Cerveza(Cantidad, Nombre);
                    //Atributos no recibidos por el constructor de "Cerveza"
                    cerveza.Alcohol = reader.GetInt32(2);
                    cerveza.Marca = reader.GetString(1);

                    //Agregando las cervezas obtenidas de la Base de Datos al objeto "cervezas"
                    cervezas.Add(cerveza);
                }
                //Cerrando el "reader"
                reader.Close();

                //Cerrando la conexión "connection" a la Base de Datos
                connection.Close();
            }

            return cervezas;
        }
    }
}
