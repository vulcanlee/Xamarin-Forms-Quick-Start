using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace FodyBase
{
    public class MyBindingContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; }
        public int Age { get; set; }
        public Color MyColor { get; set; }
        public string Message { get; set; }
    }
}
