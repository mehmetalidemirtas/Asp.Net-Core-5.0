using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class PlaceRepositoryEF : GenericRepository<Place>, IPlaceDAL
    {
        public List<Place> GetListWithCountry()
        {
            using(var c = new Context())
            {
                return c.Places.Include(x => x.Country).ToList();
            }
        }       
    }
}
