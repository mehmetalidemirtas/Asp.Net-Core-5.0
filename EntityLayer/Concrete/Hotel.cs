using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hotel
    {
        [Key]
        public int HotelID { get; set; }
        public string HotelName { get; set; }
        public string HotelLocation { get; set; }
        public string HotelPhone { get; set; }
        public string HotelImage { get; set; }
        public string Price { get; set; }
        public double Rate { get; set; }
        public bool HotelStatus { get; set; }

        public int PlaceID { get; set; }
        public Place Place { get; set; }
    }
}
