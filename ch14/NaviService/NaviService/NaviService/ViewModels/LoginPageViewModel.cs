using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NaviService.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        public string PageName { get; set; } = "登入頁面";
        public string Account { get; set; } = "";
        public string Password { get; set; } = "";
        public Command LoginCommand { get; set; }
        public bool IsShowMessage { get; set; } = false;
        public string ErrorMessage { get; set; }
        public LoginPageViewModel()
        {
#if DEBUG
            Account = "vulcan";
            Password = "123";
#endif
            LoginCommand = new Command(() =>
            {
                IsShowMessage = false;
                ErrorMessage = "";
                if (Account == "vulcan" && Password == "123")
                {
                    NavigationService.NavigateToAsync<HomePageViewModel>();
                }
                else
                {
                    IsShowMessage = true;
                    ErrorMessage = "帳號密碼不正確，請重新輸入";
                }
            });
        }
    }
}
