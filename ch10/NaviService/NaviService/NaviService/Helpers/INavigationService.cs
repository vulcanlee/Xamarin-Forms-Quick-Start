using NaviService.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NaviService.Helpers
{
    public enum NavigateMode
    {
        Absolute,
        Relative
    }
    public interface INavigationService
    {
        ViewModelBase PreviousPageViewModel { get; }

        Task InitializeAsync();

        Task NavigateToAsync<TViewModel>(NavigateMode navigateMode= NavigateMode.Relative) where TViewModel : ViewModelBase;

        Task NavigateToAsync<TViewModel>(object parameter, NavigateMode navigateMode = NavigateMode.Relative) where TViewModel : ViewModelBase;

        Task RemoveLastFromBackStackAsync();

        Task RemoveBackStackAsync();

        Task GoBackAsync();

        Task GoBackAsync(object parameter);
    }
}
