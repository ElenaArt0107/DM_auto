using System;
using System.Collections.Generic;
using Domain;


namespace DataAccess 
{
    public class AccountRepository : IAccountRepository
    {
        private readonly LoginContext _context;

        public AccountRepository(LoginContext context)
        {
            _context = context;
        }

        public void CreateAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount(int Id)
        {
            throw new NotImplementedException();
        }

        public Account GetAccount(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetAllAccounts()
        {
            throw new NotImplementedException();
        }

        public void UpdateAccount(Account account, int idOmteVijwigen)
        {
            throw new NotImplementedException();
        }
    }
}
