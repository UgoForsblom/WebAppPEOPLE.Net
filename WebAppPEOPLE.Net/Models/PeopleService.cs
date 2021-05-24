using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPEOPLE.Net.Models.Data;
using WebAppPEOPLE.Net.Models.Repo;
using WebAppPEOPLE.Net.Models.ViewModel.CreatePersonViewModel;
using WebAppPEOPLE.Net.Models.Service;



namespace WebAppPEOPLE.Net.Models.Service
{
    public class PeopleService : IPeopleService
    {
        IPeopleRepo _peopleRepo;//storage for person data
  
       )
        public Person Add(CreatePersonViewModel person)
        {
            Person person = new Person();

            person.Name = CreatePersonViewModel.Name;
            person.PhoneNumber = CreatePersonViewModel.PhoneNumber;
            person.City = CreatePersonViewModel.City;
        }

        public PeopleViewModel All()
        {
            throw new NotImplementedException();
        }

        public Person Edit(int id, Person person)
        {
            throw new NotImplementedException();
        }

        public PeopleViewModel FindBy(PeopleViewModel search)
        {
            throw new NotImplementedException();
        }

        public Person FindBy(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotFiniteNumberException ();
        }

    }
}
