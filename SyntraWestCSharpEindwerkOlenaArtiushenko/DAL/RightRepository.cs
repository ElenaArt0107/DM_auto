using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMAutoservice.Domain;
using DMAutoservice.Domain.Models;


namespace DAL
{
    public class RightRepository : IRightRepository
    {
        private readonly DMAutoserviceContext _context;
        public RightRepository(DMAutoserviceContext context)
        {
            _context = context;
        }

        public IQueryable<Right> GetRights()
        {
            return _context.Rights;
        }
    }
}
