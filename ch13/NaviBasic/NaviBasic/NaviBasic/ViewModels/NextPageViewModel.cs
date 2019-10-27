using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace NaviBasic.ViewModels
{
    public class NextPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Message { get; set; }
        public Command GoPreCommand { get; set; }
        public NextPageViewModel()
        {
            GoPreCommand = new Command(() =>
            {
                INavigation navigation = (App.Current.MainPage as NavigationPage).Navigation;
                navigation.PopAsync();
            });
        }
    }
}
