using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
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
            //this.getAll();
        }

        public MySqlDataReader getAll()
        {
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM clients";
                Console.WriteLine("Deu certo");

                return command.ExecuteReader();
                //while(rdr.Read())
                //{
                    
                //    Console.WriteLine("{0} {1} {2} {3}", rdr.GetInt32(0).ToString(), rdr.GetString(1).ToString(), rdr.GetString(2).ToString(), rdr.GetString(3).ToString(), rdr.GetString(4).ToString());
                //}
                //for (int i = 0; i < columns; i ++)
                //{
                //    for(int j = 0; j < rows; j ++)
                //    {
                //        Console.WriteLine(test.);
                //    }
                //}
                
                
                //command.ExecuteReader();
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROOOOOOOOOOOO");
                Console.WriteLine(e.Message);
                throw e;
            }
            finally
            {
                //if (this.connection.State == ConnectionState.Open)
                //    connection.Close();
            }
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
