using DAL;
using DMAutoservice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class PersonService: IPersonService
    {
        private readonly IPersonRepository _personRepo;
        public PersonService(IPersonRepository personRepo)
        {
            _personRepo = personRepo;
        }

        public void CreatePerson(Person person)
        {
            _personRepo.CreatePerson(person);
        }

        public void DeletePerson(int id)
        {
            _personRepo.DeletePerson(id);
        }

        public List<Person> GetPeopleSortedOnSurname()
        {
            return _personRepo.GetPeople().OrderBy(x=> x.Surname).ToList();
        }

        public Person GetPerson(string ProperName)
        {
            int id = 0;
            var allPeople = GetPeopleSortedOnSurname();
            foreach (var p in allPeople)
            {
                if (ProperName == p.ProperName)
                {
                    id = p.Id;
                }

            }
            return _personRepo.GetPerson(id);
        }

        public Person GetPerson(int id)
        {
            return _personRepo.GetPerson(id);
        }

        public void UpdatePerson(Person person)
        {
            _personRepo.UpdatePerson(person);
        }
    }
}
