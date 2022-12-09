using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        public void InserT(T t);
        public void DeleteT(T t);
        public void UpdateT(T t);
        public List<T> TGetList();
        public T TGetById(int id);
    }
}
