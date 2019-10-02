using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace MVVMPattern.ViewModels
{
    public class HowOldAreYouViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; }
        public int Age { get; set; }
        public Color MyColor { get; set; }
        public string Message { get; set; }
        public Command SendCommand { get; set; }
        public HowOldAreYouViewModel()
        {
            SendCommand = new Command(() =>
            {
                Message = $"姓名:{Name} , 年紀:{Age}";
            });
        }
    }
}
