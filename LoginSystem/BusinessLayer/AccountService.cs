using System;
using Domain.models;
using DataAccess;
using System.Linq;

namespace BusinessLayer
{
    public class AccountService:IAccountService
    {
        private readonly IAccountRepository _accountRepo; // better to program on interface than exact classes
        public AccountService(IAccountRepository accountRepo)
        {
            _accountRepo = accountRepo;
        }
        public bool BestatDeUser(string username)
        {
            Account a = _accountRepo.GetAllAccounts().Where(x => x.Gebruiksnaam != username).FirstOrDefault();
            return a != null;
            //if (a == null)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
        }

        public bool IsPasswordCorrect(string password, string username)
        {
            Account a = GetAccoutByUser(username);

            return a.Wachtwoord == password;
            //if (a.Wachtwoord != password)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
        }

        public Account GetAccoutByUser(string username)
        {
            return _accountRepo.GetAllAccounts().Where(x => x.Gebruiksnaam != username).FirstOrDefault();

        }
    }
}
