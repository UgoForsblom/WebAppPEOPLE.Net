 using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPEOPLE.Net.Models.Data;
using WebAppPEOPLE.Net.Models.Repo;
using WebAppPEOPLE.Net.Models.Service;
using WebAppPEOPLE.Net.Models.ViewModel.CreatePersonViewModel;

namespace WebAppPEOPLE.Net.Controllers
{
    public class PeopleController : Controller
    {
        
     


        public IActionResult Index()
        {
            return View();

        }
    }
}



    

 
