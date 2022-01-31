using DAL;
using DMAutoservice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _loginRepo;
        private readonly IRightService _rightService;
        public AccountService(IAccountRepository loginRepo, IRightService rightService)
        {
            _loginRepo = loginRepo;
            _rightService = rightService;
        }
     
        public bool IsRegistered(string username)
        {
            var account = GetAccount(username);
            return account != null;
        }
        public bool IsPasswordCorrect(string username, string password)
        {
            var account = GetAccount(username);
            return account.Password == password;
        }

        public Account GetAccount(string username)
        {
            return _loginRepo.GetLogins().
                Where(x=>x.LoginName == username).
                FirstOrDefault();
        }

        public void AddReadRightsToAccount(int userId)
        {
            var showDetailsVeilingRightId = _rightService.GetRightByCode(RightsList.ShowDetailsAccount).Id;
            var showVeilingRightId = _rightService.GetRightByCode(RightsList.ShowBrandDetails).Id;

            _loginRepo.AddRights(userId, new List<int> { showDetailsVeilingRightId, showVeilingRightId });
        }

        public Account GetAccount(int userId)
        {
            return _loginRepo
                .GetLogins()
                .Where(x => x.Id == userId)
                .FirstOrDefault();
        }

        public bool HasRight(string rightCode, int userId)
        {
            var account = GetAccount(userId);

            var right = account.AccountRights
                .Where(x => x.Right.InternalCode == rightCode)
                .FirstOrDefault();

            return right != null;
        }

        public int CreateAccount(string username, string password)
        {
            var userId = _loginRepo.CreateLogin(new Account
            {
                LoginName = username,
                Password = password
            });

            return userId;
        }
    }
}
