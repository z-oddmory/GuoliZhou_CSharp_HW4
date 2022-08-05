using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuoliZhou_CSharp_HW4.Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        void Remove(T item);
        void Save(T item);
        IEnumerable<T> GetAll();
        T GetById(int id);

    }
}
