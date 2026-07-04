using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Makaan_Entity
{
    public class WhoWeAre
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public string Image { get; set; }

        public List<Employment> Employments { get; set; }
    }
}
