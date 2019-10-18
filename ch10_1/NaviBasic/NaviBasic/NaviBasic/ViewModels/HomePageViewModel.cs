using NaviBasic.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace NaviBasic.ViewModels
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Message { get; set; }
        public Command GoNextCommand { get; set; }
        public HomePageViewModel()
        {
            GoNextCommand = new Command(() =>
            {
                INavigation navigation = (App.Current.MainPage as NavigationPage).Navigation;
                Page page = new NextPage(Message);
                navigation.PushAsync(page);
            });
        }
    }
}
