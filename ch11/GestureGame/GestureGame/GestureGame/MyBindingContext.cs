using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace GestureGame
{
    public class MyBindingContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Message { get; set; }

        public Command<string> TapCommand { get; set; }
        public MyBindingContext()
        {
            TapCommand = new Command<string>(x =>
            {
                Message = x;
            });
        }
    }
}
