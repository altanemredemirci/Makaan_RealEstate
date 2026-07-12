using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Makaan_Entity
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }

      
        public int ProductDetailId { get; set; }
     
        public ProductDetail ProductDetail { get; set; }
    }
}
