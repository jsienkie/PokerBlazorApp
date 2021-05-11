using PokerBlazorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerBlazorApp.Services
{
    public class RegisterService
    {
        static List<UserCredentials> Users { get; set; } = new List<UserCredentials>();

        public async void CreateUser(UserCredentials credentials)
        {
            Users.Add(credentials);
        }
        
    }
}
