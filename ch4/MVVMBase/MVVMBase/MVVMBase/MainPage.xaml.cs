using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMBase
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        MyBindingContext MyContext = new MyBindingContext();
        public MainPage()
        {
            InitializeComponent();

            BindingContext = MyContext;
        }

        private void btnSend_Clicked(object sender, EventArgs e)
        {
            MyContext.Message = $"姓名:{MyContext.Name} , 年紀:{MyContext.Age}";
            if (MyContext.Age <= 20)
                MyContext.MyColor = Color.Red;
            else if (MyContext.Age <= 40)
                MyContext.MyColor = Color.Green;
            else if (MyContext.Age <= 60)
                MyContext.MyColor = Color.Blue;
            else
                MyContext.MyColor = Color.Black;
        }
    }
}
