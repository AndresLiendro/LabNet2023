using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica3.EF.Logic
{
    public interface ILogic<T>
    {
        List<T> GetAll();
        bool Insert(T dto);
        bool Update(T dto);
        bool Delete(int ID);
    }
}
