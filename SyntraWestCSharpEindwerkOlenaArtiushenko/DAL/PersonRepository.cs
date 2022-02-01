using DMAutoservice.Domain;
using DMAutoservice.Domain.Models;
using Microsoft.EntityFrameworkCore;
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
            return _context.People
                .Where(x => x.Id == id)
                .Include(x => x.Brands)
                .FirstOrDefault();
        }

        public List<Person> GetPeople()
        {
            return _context.People
                .Include(p => p.Brands)
                .ToList();
        }

        public void UpdatePerson(Person person)
        {
            _context.Update(person);
            _context.SaveChanges();
        }
    }
}
