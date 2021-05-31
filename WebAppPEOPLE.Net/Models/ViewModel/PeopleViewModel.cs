using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebAppPEOPLE.Net.Models.Data;
using WebAppPEOPLE.Net.Models.ViewModel.CreatePersonViewModel;

using WebAppPEOPLE.Net.Models.Repo;




namespace WebAppPEOPLE.Net.Models
{
    public class PeopleViewModel
    {
        public  Person  person { get; set; }

        public List<Person> Person { get; set; }

        public string FilterText{ get; set; }

       public List <Person> PersonList { get; set; }

        public char Search { get; set; }
        
    }
}
