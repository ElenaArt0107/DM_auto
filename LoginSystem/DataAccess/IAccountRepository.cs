using System;
using System.Collections.Generic;
using System.Text;
using Domain.models;

namespace DataAccess
{
    interface IAccountRepository
    {
        Account GetAccount(int Id);
        List<Account> GetAllAccounts();

        void CreateAccount(Account account);

        void DeleteAccount(int Id);
        void UpdateAccount(Account account, int idOmteVijwigen);

    }
}
