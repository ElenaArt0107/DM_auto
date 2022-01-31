using Newtonsoft.Json;
using Presentation.DMAutoservice.Models.SessionModels;

namespace Presentation.Website
{
    public static class AccountSessionHelper
    {
        public const string SessionKey = "AccountSession";

        public static string AccountSessionString { get; set; }
        public static AccountSession Account
        {
            get
            {
                if (string.IsNullOrEmpty(AccountSessionString))
                {
                    return null;
                }

                return JsonConvert.DeserializeObject<AccountSession>(AccountSessionString);
            }
        }

        public static bool IsLoggedIn => Account != null;
        public static bool HasRight(string rightCode)
        {
            if (!IsLoggedIn)
            {
                return false;
            }

            return Account.Rights.Contains(rightCode);
        }
    }
}
