using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeService
    {
        ISubscribeDAL _subscribeDAL;

        public SubscribeManager(ISubscribeDAL subscribeDAL)
        {
            _subscribeDAL = subscribeDAL;
        }

        public Subscribe GetByID(int id)
        {
            return _subscribeDAL.GetByID(id);
        }

        public List<Subscribe> GetList()
        {
            return _subscribeDAL.GetListAll();
        }

        public void TAdd(Subscribe t)
        {
            _subscribeDAL.Insert(t);
        }

        public void TDelete(Subscribe t)
        {
            _subscribeDAL.Delete(t);
        }

        public void TUpdate(Subscribe t)
        {
            _subscribeDAL.Update(t);
        }
        
    }
}
