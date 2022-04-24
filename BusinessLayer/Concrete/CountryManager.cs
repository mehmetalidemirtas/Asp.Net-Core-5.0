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
    public class CountryManager : ICountryService
    {
        ICountryDAL _countryDAL;

        public CountryManager(ICountryDAL countryDAL)
        {
            _countryDAL = countryDAL;
        }

        public Country GetByID(int id)
        {
            return _countryDAL.GetByID(id);
        }

        public List<Country> GetList()
        {
            return _countryDAL.GetListAll();
        }

        public void TAdd(Country t)
        {
            _countryDAL.Insert(t);
        }

        public void TDelete(Country t)
        {
            _countryDAL.Delete(t);
        }

        public void TUpdate(Country t)
        {
            _countryDAL.Update(t);
        }
    }
}
