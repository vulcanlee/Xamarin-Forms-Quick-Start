using NaviService.Helpers;
using NaviService.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NaviService
{
    public partial class App : Application
    {
        public INavigationService NavigationService { get; set; }
        public App()
        {
            InitializeComponent();

            NavigationService = new NavigationService();

            NavigationService.NavigateToAsync<LoginPageViewModel>(NavigateMode.Absolute);
            //MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
