using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Makaan_Entity
{
    public class ProductType
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Icon { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public bool Status { get; set; }

        public List<Product> Products { get; set; }
    }
}
