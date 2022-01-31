using DAL;
using DMAutoservice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class RightService : IRightService
    {
        private readonly IRightRepository _rightRepository;

        public RightService(IRightRepository rightRepository)
        {
            _rightRepository = rightRepository;
        }

        public Right GetRightByCode(string rightCode)
        {
            return _rightRepository.GetRights()
                .Where(x => x.InternalCode == rightCode)
                .FirstOrDefault();
        }
    }
}
