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
    public class ImageManager : IImageService
    {
        IImageDAL _imageDAL;

        public ImageManager(IImageDAL imageDAL)
        {
            _imageDAL = imageDAL;
        }

        public Image GetByID(int id)
        {
            return _imageDAL.GetByID(id);
        }

        public List<Image> GetList()
        {
            return _imageDAL.GetListAll();
        }

        public void TAdd(Image t)
        {
            _imageDAL.Insert(t);
        }

        public void TDelete(Image t)
        {
            _imageDAL.Delete(t);
        }

        public void TUpdate(Image t)
        {
            _imageDAL.Update(t);
        }

        public List<Image> GetList(int id)
        {
            return _imageDAL.GetListAll(x => x.PlaceID == id);
        }

        //public void ImageAdd(Image image)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Image> GetImageByID(int id)
        //{
        //    return _imageDAL.GetListAll(x=>x.PlaceID==id);
        //}


    }
}
