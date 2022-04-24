using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }
        public string TextTitle { get; set; }
        public string Text { get; set; }
        public bool ContentStatus { get; set; }

        public int PlaceID { get; set; }
        public Place Place { get; set; }
    }
}
