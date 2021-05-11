using Microsoft.AspNetCore.Components;
using PokerBlazorApp.Model;
using PokerBlazorApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerBlazorApp.Pages
{
    public partial class Login
    {
        public UserCredentials UserCredentials { get; set; } = new UserCredentials();

        [Inject]
        public IUserService UserService { get; set; }
        [Inject]
        public NavigationManager NavManager { get; set; }

        private async void HandleValidSubmit()
        {
            if (UserService.LoginUser(UserCredentials))
            {
                NavManager.NavigateTo("/play");
            }
        }
    }
}
