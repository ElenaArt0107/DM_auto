using DMAutoservice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IAccountService
    {
        public Account GetAccount(string username);
        public bool IsRegistered(string username);
        public bool IsPasswordCorrect(string username, string password);


        Account GetAccount(int userId);
        bool HasRight(string right, int userId);
        int CreateAccount(string username, string password);
        void AddReadRightsToAccount(int userId);
    }
}
