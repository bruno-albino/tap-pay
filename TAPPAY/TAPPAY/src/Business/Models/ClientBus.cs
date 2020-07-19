using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAPPAY.src.DAO;
using TAPPAY.src.Domain.Models;

namespace TAPPAY.src.Business.Models
{
    public class ClientBus
    {
        private ClientsDAO clientDAO;

        public ClientBus()
        {
            this.clientDAO = new ClientsDAO();
        }

        public void Insert(Clients client)
        {
            this.clientDAO.Insert(client);
        }

        public Clients FindByTAG(string TAG)
        {
            Clients client = clientDAO.GetByTAG(TAG);

            return client;
        }

        public void Update(Clients client)
        {
            this.clientDAO.Update(client.id, client);
        }

        public List<Clients> GetAll()
        {
            List<Clients> clients = this.clientDAO.GetAll();

            return clients;
        }
    }
}
