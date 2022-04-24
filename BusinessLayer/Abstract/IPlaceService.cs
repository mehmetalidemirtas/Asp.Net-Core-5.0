using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPlaceService :IGenericService<Place>
    {        
        List<Place> GetPlaceWithCountry();
        List<Place> GetPlaceByCountry(int id);
        List<Place> GetPlaceByID(int id);
    }
}
