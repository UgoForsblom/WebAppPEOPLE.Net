using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebAppPEOPLE.Net.Models.Data;



namespace WebAppPEOPLE.Net.Models.ViewModel.CreatePersonViewModel
{
    public class CreatePersonViewModel
    {
         
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }
        
      
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string City { get; set; }//

           
        }
    }

  