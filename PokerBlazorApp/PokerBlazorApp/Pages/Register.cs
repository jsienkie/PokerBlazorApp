using Microsoft.AspNetCore.Components;
using PokerBlazorApp.Model;
using PokerBlazorApp.Services;

namespace PokerBlazorApp.Pages
{
    public partial class Register
    {
        public UserCredentials UserCredentials { get; set; } = new UserCredentials();

        [Inject]
        public IUserService UserService { get; set; }
        [Inject]
        public NavigationManager NavManager { get; set; }
        private async void HandleValidSubmit()
        {
            var user = new UserCredentials()
            {
                UserName = UserCredentials.UserName,
                Email = UserCredentials.Email,
                Password = UserCredentials.Password
            };

            UserService.CreateUser(user);
            NavManager.NavigateTo("/login");
        }
    }
}
