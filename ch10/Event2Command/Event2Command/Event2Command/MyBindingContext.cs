using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Event2Command
{
    public class MyBindingContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        double maxLength = 300;
        public double SliderValue { get; set; }
        public double CurrentValue { get; set; }
        public Command<ValueChangedEventArgs> SliderChangeCommand { get; set; }
        public MyBindingContext()
        {
            SliderChangeCommand = new Command<ValueChangedEventArgs>(x =>
            {
                CurrentValue = maxLength * x.NewValue;
            });
        }
    }
}
