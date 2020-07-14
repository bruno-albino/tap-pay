using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPPAY.src.config
{
        /// 
        /// Interface com todos os métodos necessários para uma classe de DAO
        /// 
        /// tipo do objeto que será manipulador pela DAO
    public interface IDatabase<T> where T : new ()
    {
        T Get(int id);

        void Insert(T obj);

        void Update(int id, T obj);

        void Delete(int id);
    }
}
