using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPEOPLE.Net.Models.Data;
using WebAppPEOPLE.Net.Models.Repo;

namespace WebAppPEOPLE.Net.Models.Repo
{
    public class InMemoryPeopleRepo : IPeopleRepo
    {

        List<Person> personList = new List<Person>();
        int idCounter = 0;

        public InMemoryPeopleRepo()
        {

            personList.Add(new Person() { id = 1,Name = "Peter", PhoneNumber = "00467389234", City = "Malmo" });
            personList.Add(new Person() { id = 2, Name = "Junior", PhoneNumber = "0023456781", City = "Kalmar" });
            personList.Add(new Person() {id = 3,  Name = "Frey", PhoneNumber = "009876543", City = "NewYork" });
            idCounter = 3;
        }

            public Person Create(Person person)
            {
            person.id = ++idCounter;
            personList.Add(person);

            return person;
            }
            public Person Read(int id)
        {
            foreach (Person item in personList)
                {
                if (item.id == id)
                {
                    return item;
                }
            }
            return null;

        }

            public List<Person> Read()
            {
            return personList;

            }

            public bool Delete(int id)
        {
            Person person = Read(id);

            if (person == null)
            {
                return false;
            }
            return personList.Remove(person);
        }

            
            }

           
            }
        

    }
}
