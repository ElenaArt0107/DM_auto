using DMAutoservice.Domain;
using DMAutoservice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class PersonRepository : IPersonRepository
    {
        //dependency 
        private readonly DMAutoserviceContext _context;
        public PersonRepository(DMAutoserviceContext context)
        {
            _context = context;
        }
        // implementation
        public int CreatePerson(Person person)
        {
            _context.Add(person);
            _context.SaveChanges();
            return person.Id;
        }

        public void DeletePerson(int id)
        {
            Person person = GetPerson(id);
            _context.Remove(person);
            _context.SaveChanges();
        }

        public Person GetPerson(int id)
        {
            return _context.People.
                Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Person> GetPeople()
        {
            return _context.People.
                ToList();
        }

        public void UpdatePerson(Person person)
        {
            Person personToUpdate = GetPerson(person.Id);
            personToUpdate.PhoneNumber = person.PhoneNumber;
            personToUpdate.Name = person.Name;
            personToUpdate.Surname = person.Surname;
            personToUpdate.Email = person.Email;

            _context.SaveChanges();
        }
    }
}
