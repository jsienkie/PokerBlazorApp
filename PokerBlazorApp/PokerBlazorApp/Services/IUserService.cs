using PokerBlazorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerBlazorApp.Services
{
    public interface IUserService
    {
        void CreateUser(UserCredentials credentials);
        bool LoginUser(UserCredentials userCredentials);
    }
}
