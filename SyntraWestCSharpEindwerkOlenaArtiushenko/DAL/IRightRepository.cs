using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMAutoservice.Domain.Models;


namespace DAL
{
    public interface IRightRepository
    {
        IQueryable<Right> GetRights();
    }
}
