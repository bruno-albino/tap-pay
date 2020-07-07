using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAPPAY.src.Domain.Models;
using TAPPAY.src.Repository.Base;

namespace TAPPAY.src.Repository.Models
{
    public class ClientsRepository : Repository<Clients>
    {
        private IList<Clients> Client;

        public ClientsRepository()
        {
            Client = new List<Clients>();
        }
    }
}
