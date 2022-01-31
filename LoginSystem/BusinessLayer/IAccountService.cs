using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Domain.models;

namespace BusinessLayer
{
    public interface IAccountService
    {
        bool BestatDeUser(string username);
        bool IsPasswordCorrect(string password, string username);
        Account GetAccoutByUser(string username);
    }
}
