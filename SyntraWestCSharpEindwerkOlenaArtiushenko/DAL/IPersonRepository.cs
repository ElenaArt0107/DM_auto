using DMAutoservice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IPersonRepository
    {
        public Person GetPerson(int id);
        public List<Person> GetPeople();
        public int CreatePerson(Person person);
        public void DeletePerson(int id);
        public void UpdatePerson(Person person);

    }
}
