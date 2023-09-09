using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica3.EF.Logic
{
    public interface ILogic<T>
    {
        IEnumerable<T> GetAll();
        long Insert(T dto);
        void Update(T dto);
        void Delete(long ID);
    }
}
