using NaviService.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NaviService.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        protected readonly INavigationService NavigationService;

        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModelBase()
        {
            NavigationService = (Application.Current as App).NavigationService;
        }

        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }

        public virtual Task ComeBackAsync()
        {
            return Task.FromResult(false);
        }

        public virtual Task ComeBackAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}
