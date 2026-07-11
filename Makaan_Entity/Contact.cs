using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Makaan_Entity
{
    public class Contact
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string Text { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(15)]
        public string Phone { get; set; }
        [StringLength(200)]
        public string Email { get; set; }
        public string Location { get; set; }
    }
}
