using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAPPAY.src.Repository.Interfaces;

namespace TAPPAY.src.Repository.Base
{
    public abstract class Repository<T> : IRepository<T>
    {
        private static List<T> _list;
        private static object _syncObj = new object();

        public bool Add(T obj)
        {
            _list.Add(obj);
            return true;
        }

        public List<T> GetList()
        {
            return _list;
        }
    }
}
