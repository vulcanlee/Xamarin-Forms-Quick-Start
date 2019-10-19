using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NaviService.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        public string PageName { get; set; }
        public string NaviPara { get; set; } = "";
        public string BackNaviPara { get; set; } = "";
        public Command GoNextCommand { get; set; }
        public HomePageViewModel()
        {
            GoNextCommand = new Command(() =>
            {
                NavigationService.NavigateToAsync<UserProfilePageViewModel>(NaviPara);
            });
        }
        public override Task InitializeAsync(object navigationData)
        {
            PageName = "首頁頁面(ViewModel 初始自動設定)";
            return base.InitializeAsync(navigationData);
        }
        public override Task ComeBackAsync(object navigationData)
        {
            BackNaviPara = navigationData as string;
            return base.ComeBackAsync(navigationData);
        }
    }
}
