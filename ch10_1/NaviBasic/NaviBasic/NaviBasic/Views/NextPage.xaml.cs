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
    public partial class NextPage : ContentPage
    {
        NextPageViewModel nextPageViewModel;
        public NextPage()
        {
            InitializeComponent();
        }

        public NextPage(string message)
        {
            InitializeComponent();
            nextPageViewModel = BindingContext as NextPageViewModel;
            nextPageViewModel.Message = message;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}