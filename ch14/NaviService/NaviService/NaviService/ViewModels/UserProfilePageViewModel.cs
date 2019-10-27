using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NaviService.ViewModels
{
    public class UserProfilePageViewModel : ViewModelBase
    {
        public string PreNaviPara { get; set; } = "";
        public string BackNaviPara { get; set; } = "";
        public string NaviPara { get; set; } = "";
        public Command GoNextCommand { get; set; }
        public Command GoSelfCommand { get; set; }
        public Command GoPreCommand { get; set; }
        public UserProfilePageViewModel()
        {
            GoSelfCommand = new Command(() =>
            {
                NavigationService.NavigateToAsync<UserProfilePageViewModel>(NaviPara);
            });
            GoNextCommand = new Command(() =>
            {
                NavigationService.NavigateToAsync<AboutPageViewModel>(NaviPara);
            });
            GoPreCommand = new Command(() =>
            {
                NavigationService.GoBackAsync(BackNaviPara);
            });
        }
        public override Task InitializeAsync(object navigationData)
        {
            PreNaviPara = navigationData as string;
            return base.InitializeAsync(navigationData);
        }
        public override Task ComeBackAsync(object navigationData)
        {
            BackNaviPara = navigationData as string;
            return base.ComeBackAsync(navigationData);
        }
    }
}
