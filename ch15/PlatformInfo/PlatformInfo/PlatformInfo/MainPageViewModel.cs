using PlatformInfo.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PlatformInfo
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Model { get; set; }
        public string Version { get; set; }
        public Command GetInformationCommand { get; set; }
        public MainPageViewModel()
        {
            GetInformationCommand = new Command(() =>
            {
                IPlatformInformation platformInformation = DependencyService.Get<IPlatformInformation>();
                var info = platformInformation.GetCurrentInformation();
                Model = info.Model;
                Version = info.Version;
            });
        }
    }
}
