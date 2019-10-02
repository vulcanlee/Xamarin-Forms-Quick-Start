using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BindConverter
{
    public class MyBindingContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Account { get; set; } = "";
        public int MyCounter { get; set; } = 0;
    }
}
