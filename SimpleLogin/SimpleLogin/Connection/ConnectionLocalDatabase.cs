using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLogin.Connection
{
    class ConnectionLocalDatabase
    {
        string Usr;
        string Pass;
        public ConnectionLocalDatabase(string User, String Password)
        {
            Usr = User;
            Pass = Password;
        }
        //Vamos a usar un String Builder para crear una cadena con información de la conexion
        MySqlConnectionStringBuilder Builder = new MySqlConnectionStringBuilder();
        //creamos un bool para crear la conexion.
        public bool TryConnection(out string Error)
        {
            // Damos valores a nuestra variable Build.
            Builder.Port = 3306;
            Builder.Server = "";   // Dominio o IP de su servidor MySQL
            Builder.Database = "AuthenticationLogin"; // Nombre de base de datos
            Builder.UserID = Usr;  // Nombre de usuario de la base de datos
            Builder.Password = Pass; //Contraseña del usuario
            try
            {
                //Ahora declaramos un MySQLconnection para abrir nuestra conexion
                MySqlConnection ms = new MySqlConnection(Builder.ToString());
                ms.Open(); //Abrimos nuestra conexion
                Error = "";
                return true; //Regresa verdadero si no hubo errores
            }
            catch (Exception ex)
            {
                Error = ex.ToString();
                return false; //Regresa Falso si hay errores
            }
        }
    }
}
