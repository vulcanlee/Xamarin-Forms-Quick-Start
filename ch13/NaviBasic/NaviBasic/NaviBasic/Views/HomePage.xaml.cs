using NaviBasic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NaviBasic.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        HomePageViewModel homePageViewModel;
        public HomePage()
        {
            InitializeComponent();
            homePageViewModel = this.BindingContext as HomePageViewModel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Page page = new NextPage(homePageViewModel.Message);
            this.Navigation.PushAsync(page);
        }
    }
}