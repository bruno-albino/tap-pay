using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAPPAY.src.Business.Interfaces;
using TAPPAY.src.config;
using TAPPAY.src.Domain.Models;
using TAPPAY.src.Repository.Models;

namespace TAPPAY.src.Business.Models
{
    public class ClientBusiness : IClientBusiness
    {
        ClientsRepository _clientRepository;

        public ClientBusiness()
        {
            _clientRepository = new ClientsRepository();
            this.LoadClients();
        }

        private void LoadClients()
        {
            Database database = new Database();
            MySqlDataReader rdr = database.getAllClients();

            while (rdr.Read())
            {
                _clientRepository.Add(new Clients()
                {
                    id = Convert.ToInt32(rdr["id"]),
                    name = rdr["name"].ToString(),
                    TAG = rdr["TAG"].ToString(),
                    beers = rdr["beers"].ToString(),
                    phone = rdr["phone"].ToString()
                });
            }

            rdr.Close();

        }

        public bool Add(Clients clients)
        {
            return true;
        }

        public List<Clients> GetList()
        {
            return _clientRepository.GetList();
        }

        public Clients findByTAG(string TAG)
        {
            List<Clients> clients = _clientRepository.GetList();

            Clients client = clients.Find(child => child.TAG == TAG);

            return client;
        }

        public void reduceBeers(Clients client)
        {
            
        }
    }
}
