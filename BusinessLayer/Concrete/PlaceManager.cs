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
    public class PlaceManager : IPlaceService
    {
        IPlaceDAL _placeDAL;

        public PlaceManager(IPlaceDAL placeDAL)
        {
            _placeDAL = placeDAL;
        }

        public Place GetByID(int id)
        {
            return _placeDAL.GetByID(id);
        }

        public List<Place> GetList()
        {
            return _placeDAL.GetListAll();
        }

        public List<Place> GetPlaceWithCountry()
        {
            return _placeDAL.GetListWithCountry();
        }

        public void TAdd(Place t)
        {
            _placeDAL.Insert(t);
        }

        public void TDelete(Place t)
        {
            _placeDAL.Delete(t);
        }

        public void TUpdate(Place t)
        {
            _placeDAL.Update(t);
        }

        //Ülke id ye göre yerleri listele
        public List<Place> GetPlaceByCountry(int id)
        {
            return _placeDAL.GetListAll(x => x.CountryID == id);
        }

        //Detayları getiriyor.
        public List<Place> GetPlaceByID(int id)
        {
            return _placeDAL.GetListAll(x => x.PlaceID == id);
        }



        //    public Place GetByID(int id)
        //    {
        //        return _placeDAL.GetByID(id);
        //    }

        //    public List<Place> GetList()
        //    {
        //        return _placeDAL.GetListAll();
        //    }

        //    public List<Place> GetPlaceWithCountry()
        //    {
        //        return _placeDAL.GetListWithCountry();
        //    }

        //    public void PlaceAdd(Place place)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void PlaceDelete(Place place)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void PlaceUpdate(Place place)
        //    {
        //        throw new NotImplementedException();
        //    }
    }
}
