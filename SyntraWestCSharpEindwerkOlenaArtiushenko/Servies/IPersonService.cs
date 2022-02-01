using DMAutoservice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IPersonService
    {
        public Person GetPerson(string ProperName);
        public Person GetPerson(int id);
        public List<Person> GetPeopleSortedOnSurname();
        public void CreatePerson(Person person);
        public void DeletePerson(int id);
        public void UpdatePerson(Person person);
        List<Person> GetAllPeople();
    }
}
