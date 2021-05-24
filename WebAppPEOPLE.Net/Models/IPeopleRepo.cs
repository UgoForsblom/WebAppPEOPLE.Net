using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPEOPLE.Net.Models.Data;
using WebAppPEOPLE.Net.Models.Repo;

    
namespace WebAppPEOPLE.Net.Models.Repo
{
    interface IPeopleRepo
    {
        //C.R.U.D.
        Person Create(string Name, int PhoneNumber, string City);

        List<Person> Read();//GetAll

        Person Read(int id);// Finf By Id

        Person Update(Person person);

        bool Delete(Person person);
    }
}
