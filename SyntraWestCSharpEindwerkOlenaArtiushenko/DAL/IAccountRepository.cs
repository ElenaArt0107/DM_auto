using DMAutoservice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IAccountRepository
    {
        public int CreateLogin(Account login);
        public void DeleteLogin(int id);
        public Account GetLogin(int id);
        public List<Account> GetLogins();
        public void UpdateLogin(Account login);
        //add rights per account
        public void AddRights(int id, List<int> rightIds);
    }
}
