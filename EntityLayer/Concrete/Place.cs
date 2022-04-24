using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Place
    {
        [Key]
        public int PlaceID { get; set; }
        public string CityName { get; set; }
        public string PlaceName { get; set; }
        public string LocationUrl { get; set; }
        public bool PlaceStatus { get; set; }
        public DateTime CreatedDate { get; set; }

        public int CountryID { get; set; }
        public Country Country { get; set; }


        public List<Comment> Comments { get; set; }
        public List<Hotel> Hotels { get; set; }
        public List<Image> Images { get; set; }
        public List<Content> Contents { get; set; }
    }
}
