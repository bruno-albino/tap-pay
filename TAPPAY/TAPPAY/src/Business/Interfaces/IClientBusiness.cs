using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAPPAY.src.Domain.Models;

namespace TAPPAY.src.Business.Interfaces
{
    public interface IClientBusiness
    {
        void Add(Clients client);
        List<Clients> GetList();

        Clients FindByTAG(string TAG);

        void ReduceBeers(Clients client);
    }
}
