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

        public void Add(Cerveza cerveza)
        {
            //query = "Consulta SQL Server"
            string query
                = "insert into cerveza(nombre, marca, alcohol, cantidad) values(@nombre, @marca, @alcohol, @cantidad)";
            //Realizando la conexión a la Base de Datos (SQL Server)
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                //Agregamos a la Base de Datos los campos de la cerveza insertada
                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);

                connection.Open();
                //Para ejecutar el "insert" (Codigo del SQL Server)
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        //Id: Es buena practica que este como atributo, pero por didactica se coloca por separado
        public void Edit(Cerveza cerveza, int Id)
        {
            //query = "Consulta SQL Server"
            string query
                = "update cerveza set nombre=@nombre, marca=@marca, alcohol=@alcohol, cantidad=@cantidad where id=@id";
            //Realizando la conexión a la Base de Datos (SQL Server)
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                //Agregamos a la Base de Datos los campos de la cerveza actualizada
                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);
                command.Parameters.AddWithValue("@id", Id);

                connection.Open();
                //Para ejecutar el "update" (codigo del SQL Server)
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Delete(int Id)
        {
            //query = "Consulta SQL Server"
            string query
                = "delete from cerveza where id=@id";
            //Realizando la conexión a la Base de Datos (SQL Server)
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                //Agregamos a la Base de Datos los campos de la cerveza actualizada
                command.Parameters.AddWithValue("@id", Id);

                connection.Open();
                //Para ejecutar el "update" (codigo del SQL Server)
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
