using MySql.Data.MySqlClient;
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
        }

        public bool Add(Clients clients)
        {
            return true;
        }

        public List<Clients> GetList()
        {
            string connection = "Server=localhost;Database=tappay;Uid=root;Pwd=masterkey";
            var config = new Database(connection);
            MySqlDataReader rdr = config.getAll();

            return rdr.Cast<Clients>().ToList();
        }
    }
}
