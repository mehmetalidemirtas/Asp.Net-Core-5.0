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
    public class ContentManager : IContentService
    {
        IContentDAL _contentDAL;

        public ContentManager(IContentDAL contentDAL)
        {
            _contentDAL = contentDAL;
        }

        public Content GetByID(int id)
        {
            return _contentDAL.GetByID(id);
        }

        public List<Content> GetList()
        {
            return _contentDAL.GetListAll();
        }

        public void TAdd(Content t)
        {
            _contentDAL.Insert(t);
        }

        public void TDelete(Content t)
        {
            _contentDAL.Delete(t);
        }

        public void TUpdate(Content t)
        {
            _contentDAL.Update(t);
        }

        public List<Content> GetList(int id)
        {
            return _contentDAL.GetListAll(x => x.PlaceID == id);
        }
    }
}
