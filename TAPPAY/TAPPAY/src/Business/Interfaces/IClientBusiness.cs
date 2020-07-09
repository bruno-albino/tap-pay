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
        bool Add(Clients clients);
        List<Clients> GetList();

        Clients findByTAG(string TAG);
    }
}
