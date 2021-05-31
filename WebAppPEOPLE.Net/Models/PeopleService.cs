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
  
       public PeopleService()
        {
            _peopleRepo = new InMemoryPeopleRepo();

        }
        public Person Add(CreatePersonViewModel personViewModel)
        {
            Person person = new Person();

            person.Name =personViewModel.Name;
            person.PhoneNumber = personViewModel.PhoneNumber;
            person.City = personViewModel.City;

            person = _peopleRepo.Create(person);

            return person;
        }

        public PeopleViewModel All()

        {
            PeopleViewModel peopleViewModel = new PeopleViewModel();
            peopleViewModel.PersonList = _peopleRepo.Read();

            return peopleViewModel;
        }

        public Person Edit(int id,Person person)
        {
            Person originalPerson = FindBy(id);

            if (originalPerson == null)
            {
                return null;
            }
            originalPerson.Name = person.Name;
            originalPerson.PhoneNumber = person.PhoneNumber;
            originalPerson.City = person.City;

            originalPerson = _peopleRepo.Update(originalPerson);

            return originalPerson;

        }

        public PeopleViewModel FindBySearch(PeopleViewModel search)
        {

            foreach (Person item in _peopleRepo.Read())
            {
                if (item.Name.Contains(search.Search))
                {
                    search.PersonList.Add(item);
                }
            }
            return search;
        }

        public Person FindBy(int id)
        {
            return _peopleRepo.Read(id);
        }

        public bool Remove(int id)
        {
            return _peopleRepo.Delete(FindBy(id)) ;//Find person by id and delete
  
        }
    }
}
