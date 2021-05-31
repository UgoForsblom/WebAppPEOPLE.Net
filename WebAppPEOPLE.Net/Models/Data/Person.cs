using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPEOPLE.Net.Models.Data
{
    public class Person
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string City { get; set; }
    }
}
