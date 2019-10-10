using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace StatusBars
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Command StatusBarSwitchCommand { get; set; }
        public bool IsOn { get; set; } = true;
        public MainPageViewModel()
        {
            StatusBarSwitchCommand = new Command(() =>
            {
                IsOn = !IsOn;
                MessagingCenter.Send<StatusBarEvent, bool>(new StatusBarEvent(), "TurnOnOff", IsOn);
            });
        }
    }
}
