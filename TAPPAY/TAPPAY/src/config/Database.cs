using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public MySqlDataReader GetAllClients()
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

        public void UpdateClient(Clients client)
        {
            try
            {
                connection.Open();
                command.CommandText = "UPDATE clients SET name=@name, TAG=@TAG, beers=@beers, phone=@phone WHERE id=@id";
                command.Parameters.AddWithValue("name", client.name);
                command.Parameters.AddWithValue("TAG", client.TAG);
                command.Parameters.AddWithValue("beers", client.beers);
                command.Parameters.AddWithValue("phone", client.phone);
                command.Parameters.AddWithValue("id", client.id);
                command.ExecuteNonQuery();

            } catch(Exception e)
            {
                throw e;
            } finally
            {
                CloseConnection();
            }
        }

        private void CloseConnection()
        {
            if (ConnectionState.Open == connection.State)
            {
                connection.Close();
            }
        }

        public void CreateClient(Clients client)
        {
            try
            {

                connection.Open();
                command.CommandText = "INSERT INTO clients(name, TAG, beers, phone) VALUES(@name, @TAG, @beers, @phone)";
                command.Parameters.AddWithValue("name", client.name);
                command.Parameters.AddWithValue("TAG", client.TAG);
                command.Parameters.AddWithValue("beers", client.beers);
                command.Parameters.AddWithValue("phone", client.phone);
                command.Prepare();
                command.ExecuteNonQuery();


            } catch(Exception e)
            {
                throw e;
            }
        }
    }
}
