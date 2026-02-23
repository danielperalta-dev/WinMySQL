using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace WinMySQL.Clases
{
    internal class Datos
    {
        string cadenaConexion = "server=localhost; database=winmysql";
        MySqlConnection conexion;
        public void conectar()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        public void desconectar()
        {
            try
            {
                if(conexion!= null)
                { 
                conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al desconectar de la base de datos: " + ex.Message);
            }
        }
        public MySqlConnection getConexion()
        {
            return conexion;
        }
    }
}
