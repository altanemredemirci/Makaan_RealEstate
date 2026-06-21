using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Makaan_Entity
{
    public class District
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
    }
}
