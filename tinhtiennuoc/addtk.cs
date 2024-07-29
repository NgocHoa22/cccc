using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhtiennuoc
{
    internal class addtk
    {
        private static List<Account> accounts = new List<Account>();

        public static void AddAccount(string username, string password)
        {
            accounts.Add(new Account { Username = username, Password = password });
        }

        public static bool ValidateAccount(string username, string password)
        {
            foreach (var account in accounts) 
            {
                if (account.Username == username && account.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
