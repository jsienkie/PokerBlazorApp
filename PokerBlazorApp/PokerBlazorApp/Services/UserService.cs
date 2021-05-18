using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using PokerBlazorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PokerBlazorApp.Services
{
    public class UserService : IUserService
    {
        static List<UserCredentials> Users { get; set; } = new List<UserCredentials>();
        public HttpClient Client { get; }
        public UserService(HttpClient client)
        {
            Client = client;
        }
        public async void CreateUser(UserCredentials credentials)
        {
            Users.Add(credentials);
        }
        public bool LoginUser(UserCredentials credentials)
        {
            var valid = Users.Any(u => u.UserName == credentials.UserName && u.Password == credentials.Password);
            return valid;
        }
        
    }
}
