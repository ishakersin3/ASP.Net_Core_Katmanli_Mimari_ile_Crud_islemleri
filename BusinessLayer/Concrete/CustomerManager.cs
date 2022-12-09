using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void InserT(Customer t)
        {
            _customerDal.Insert(t);           
        }

        public void DeleteT(Customer t)
        {
            _customerDal.Delete(t);
        }

        public List<Customer> GetCustomersListWithJob()
        {
            return _customerDal.GetCustomerListWithJob();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetList();
        }

        public void UpdateT(Customer t)
        {
            _customerDal.Update(t);
        }
    }
}
