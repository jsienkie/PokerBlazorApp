using Microsoft.AspNetCore.Components;
using PokerBlazorApp.Model;
using PokerBlazorApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerBlazorApp.Pages
{
    public partial class Register
    {
        public UserCredentials UserCredentials { get; set; } = new UserCredentials();

        [Inject]
        public IRegisterService RegisterService { get; set; }


        private async void HandleValidSubmit()
        {

        }
    }
}
