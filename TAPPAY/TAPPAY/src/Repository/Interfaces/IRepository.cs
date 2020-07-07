using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPPAY.src.Repository.Interfaces
{
    public interface IRepository<T>
    {
        bool Add(T obj);

        //List<T> GetList(string sql);
        List<T> GetList();

        //string SendData();
    }
}
