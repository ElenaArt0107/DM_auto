using System;
using System.Collections.Generic;
using Domain;
using Domain.models;
using System.Linq;

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
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public void DeleteAccount(int id)
        {
            Account a = GetAccount(id);
            _context.Accounts.Remove(a);
        }

        public Account GetAccount(int id)
        {
            Account a = _context.Accounts.Where(account => account.Id == id)
                .FirstOrDefault();

            return a;
        }

        public List<Account> GetAllAccounts()
        {
            List<Account> accounts = _context.Accounts.ToList();
            return accounts;
        }

        public void UpdateAccount(Account account, int idOmteVijwigen)
        {
            Account a = GetAccount(idOmteVijwigen);
            a.Gebruiksnaam = account.Gebruiksnaam;
            a.Adres = account.Adres;
            a.GeboorteDatum = account.GeboorteDatum;
            a.Wachtwoord = account.Wachtwoord;
            _context.SaveChanges();
        }
    }
}
