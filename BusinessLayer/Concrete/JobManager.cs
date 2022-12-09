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
    public class JobManager : IJobService
    {
        IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }

        public void InserT(Job t)
        {
            _jobDal.Insert(t);
        }

        public void DeleteT(Job t)
        {
            _jobDal.Delete(t);
        }

        public Job TGetById(int id)
        {
            return _jobDal.GetById(id);
        }

        public List<Job> TGetList()
        {
           return _jobDal.GetList();  
        }

        public void UpdateT(Job t)
        {
            _jobDal.Update(t);  
        }
    }
}
