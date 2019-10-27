using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace DataBindTraditional
{
    public class MyBindingContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region 姓名的屬性
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    NotifyPropertyChanged();
                }
            }
        }
        #endregion

        #region 年紀的屬性
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (age != value)
                {
                    age = value;
                    NotifyPropertyChanged();
                }
            }
        }
        #endregion

        #region 心情顏色
        private Color myColor;

        public Color MyColor
        {
            get { return myColor; }
            set
            {
                if (myColor != value)
                {
                    myColor = value;
                    NotifyPropertyChanged();
                }
            }
        }
        #endregion

        #region 彙總訊息
        private string message;

        public string Message
        {
            get { return message; }
            set
            {
                if (message != value)
                {
                    message = value;
                    NotifyPropertyChanged();
                }
            }
        }
        #endregion
    }
}
