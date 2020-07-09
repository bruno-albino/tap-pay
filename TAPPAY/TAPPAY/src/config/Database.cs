using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAPPAY.src.Domain.Models;

namespace TAPPAY.src.config
{
    class Database
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        public Database()
        {
            try
            {   
                string strConnectionString = ConfigurationManager.ConnectionStrings["ConexaoMYSQL"].ToString();
                this.connection = new MySqlConnection(strConnectionString);
                this.command = connection.CreateCommand();

            } catch(Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
                throw e;
            }
        }

        public MySqlDataReader getAllClients()
        {
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM clients";
                return command.ExecuteReader();
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
                throw e;
            }
        }

        public void getClientByID(int ID)
        {
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM clients WHERE id = @ID";
                command.Parameters.AddWithValue("ID", ID);
                command.Prepare();
                MySqlDataReader rdr = command.ExecuteReader();
                
                //if(!rdr.HasRows)
                //{
                //    return false;
                //}
                //int beers = int.Parse(rdr["beers"].ToString());

                //if(beers == 0)
                //{

                //}

                //command.CommandText = "UPDATE clients SET beers"


            } catch(Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
                throw e;
            }
        }
    }
}
