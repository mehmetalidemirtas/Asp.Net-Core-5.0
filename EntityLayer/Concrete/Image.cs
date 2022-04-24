using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Image
    {
        [Key]
        public int ImageID { get; set; }
        public string ImageUrl { get; set; }
        public bool ImageStatus { get; set; }

        public int PlaceID { get; set; }
        public Place Place { get; set; }
    }
}
