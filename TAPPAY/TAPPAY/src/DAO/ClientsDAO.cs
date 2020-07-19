using EO.Internal;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAPPAY.src.config;
using TAPPAY.src.Domain.Models;

namespace TAPPAY.src.DAO
{
    public class ClientsDAO : IDatabase<Clients>
    {
        private DatabaseHelper databaseHelper;
        public ClientsDAO()
        {
            databaseHelper = DatabaseHelper.Create();
        }

        public Clients Get(int id)
        {
            Clients client = new Clients();
            MySqlDataReader reader = null;
            try
            {
                string query = "SELECT * FROM clients WHERE id = @id";
                reader = databaseHelper.ExecuteDataReader(query, new MySqlParameter("id", id));
                while (reader.Read())
                {
                    client.name = reader["name"].ToString();
                    client.phone = reader["phone"].ToString();
                    client.TAG = reader["TAG"].ToString();
                    client.id = Convert.ToInt32(reader["nome"]);
                    client.beers = reader["beers"].ToString();
                }
                reader.Close();
                this.databaseHelper.CloseConection();
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                this.databaseHelper.CloseConection();
            }
            return client;
        }

        public void Insert(Clients client)
        {
            string query = "INSERT INTO clients (name, TAG, beers, phone) VALUES(@name, @TAG, @beers, @phone)";
            this.databaseHelper
            .ExecuteNonQuery(query,
                new MySqlParameter("name", client.name),
                new MySqlParameter("TAG", client.TAG),
                new MySqlParameter("beers", "0"),
                new MySqlParameter("phone", client.phone)
            );
        }

        public void Update(int id, Clients client)
        {
            string query = "UPDATE clients SET name=@name, beers=@beers, phone=@phone, TAG=@TAG WHERE id=@id";
            try
            {
                this.databaseHelper.OpenConnection();
                this.databaseHelper.ExecuteNonQuery(query,
                    new MySqlParameter("id", id),
                    new MySqlParameter("name", client.name),
                    new MySqlParameter("TAG", client.TAG),
                    new MySqlParameter("beers", client.beers),
                    new MySqlParameter("phone", client.phone)
                );

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.databaseHelper.CloseConection();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Clients GetByTAG(string TAG)
        {
            string query = "SELECT * FROM clients WHERE TAG = @TAG LIMIT 1";
            MySqlDataReader reader = this.databaseHelper.ExecuteDataReader(query, new MySqlParameter("TAG", TAG));

            Clients client = reader.HasRows ? new Clients() : null;
            while (reader.Read())
            {
                client.id = Convert.ToInt32(reader["id"]);
                client.name = reader["name"].ToString();
                client.beers = reader["beers"].ToString();
                client.phone = reader["phone"].ToString();
                client.TAG = reader["TAG"].ToString();
            }

            if(reader != null)
            {
                reader.Close();
            }

            return client;
        }

        public List<Clients> GetAll()
        {
            string query = "SELECT * FROM clients";
            List<Clients> clients = new List<Clients>();

            MySqlDataReader reader = this.databaseHelper.ExecuteDataReader(query);

            while(reader.Read())
            {
                clients.Add(new Clients()
                {
                    id = Convert.ToInt32(reader["id"]),
                    name = reader["name"].ToString(),
                    beers = reader["beers"].ToString(),
                    phone = reader["phone"].ToString(),
                    TAG = reader["TAG"].ToString()
                });
            }

            if(!reader.IsClosed)
            {
                reader.Close();
            }

            return clients;
        }

    }
}
