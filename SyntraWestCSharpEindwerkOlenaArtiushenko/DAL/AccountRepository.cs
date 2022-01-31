using DMAutoservice.Domain;
using DMAutoservice.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class AccountRepository : IAccountRepository
    {
        //dependency 
        private readonly DMAutoserviceContext _context;
        public AccountRepository(DMAutoserviceContext context)
        {
            _context = context;
        }

        //add rights per account
        public void AddRights(int id, List<int> rightIds)
        {
            var account = GetLogin(id);

            foreach (var rightId in rightIds)
            {
                account.AccountRights.Add(new AccountRights
                {
                    AccountId = id,
                    RightId = rightId
                });
            }

            _context.SaveChanges();
        }

        public int CreateLogin(Account login)
        {
            _context.Add(login);
            _context.SaveChanges();
            return login.Id;
        }

        public void DeleteLogin(int id)
        {
            Account login = GetLogin(id);
            _context.Remove(login);
            _context.SaveChanges();
        }

        public Account GetLogin(int id)
        {
            return _context.Accounts.
           Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Account> GetLogins()
        {
            //return _context.Accounts.ToList();
            List<Account> alleAccounts = _context.Accounts
                .Include(x => x.AccountRights)
                .ThenInclude(x => x.Right)
                .ToList();

            return alleAccounts;
        }

        public void UpdateLogin(Account login)
        {
            Account logToUpdate = GetLogin(login.Id);
            logToUpdate.LoginName = login.LoginName;
            logToUpdate.Password = login.Password;
            _context.SaveChanges();
        }
    }
}
 //i lost chrome me too, just a sec

