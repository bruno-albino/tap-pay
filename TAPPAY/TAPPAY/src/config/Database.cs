using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPPAY.src.config
{
    class Database
    {
        private MySqlConnection connection;
        private string connString;
        private MySqlCommand command;
        public Database()
        {

        }
        public Database(string connString)
        {
            this.connString = connString;
            this.connection = new MySqlConnection(this.connString);
            this.command = connection.CreateCommand();
        }

        //Aqui você substitui pelos seus dados
        //string connString = "Server=localhost;Database=test;Uid=usuario;Pwd=senha";
        //var connection = new MySqlConnection(this.connString);
        //var command = connection.CreateCommand();

        //try
        //{
        //    connection.Open();
        //    command.CommandText = "INSERT INTO TABELA1 (CAMPO1) VALUES ('VALOR1')";
        //    command.ExecuteNonQuery();
        //}
        //finally
        //{
        //    if(connection.State == ConnectionState.Open)
        //        connection.Close();            
        //}
    }
}
