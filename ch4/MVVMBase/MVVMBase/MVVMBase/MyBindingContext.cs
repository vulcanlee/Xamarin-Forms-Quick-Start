using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MVVMBase
{
    public class MyBindingContext: ViewModelBase
    {
        #region 姓名的屬性
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    SetProperty(ref name, value); 
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
                    SetProperty(ref age, value);
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
                    SetProperty(ref myColor, value);
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
                    SetProperty(ref message, value);
                }
            }
        }
        #endregion
    }
}
