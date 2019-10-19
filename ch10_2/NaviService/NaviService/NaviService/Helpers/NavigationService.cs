using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NaviService.ViewModels;
using NaviService.Views;
using Xamarin.Forms;

namespace NaviService.Helpers
{
    public class NavigationService : INavigationService
    {
        public ViewModelBase PreviousPageViewModel
        {
            get
            {
                var mainPage = Application.Current.MainPage as NaviPage;
                var viewModel = mainPage.Navigation.NavigationStack[mainPage.Navigation.NavigationStack.Count - 2].BindingContext;
                return viewModel as ViewModelBase;
            }
        }

        ViewModelBase INavigationService.PreviousPageViewModel => throw new NotImplementedException();

        public NavigationService()
        {
        }

        public Task InitializeAsync()
        {
            //NavigateToAsync<LoginViewModel>();
            return Task.FromResult(false);
        }


        public Task NavigateToAsync<TViewModel>(NavigateMode navigateMode = NavigateMode.Relative) where TViewModel : ViewModelBase
        {
            return InternalNavigateToAsync(typeof(TViewModel), null, navigateMode);
        }

        public Task NavigateToAsync<TViewModel>(object parameter, NavigateMode navigateMode = NavigateMode.Relative) where TViewModel : ViewModelBase
        {
            return InternalNavigateToAsync(typeof(TViewModel), parameter, navigateMode);
        }

        public Task RemoveLastFromBackStackAsync()
        {
            var mainPage = Application.Current.MainPage as NaviPage;

            if (mainPage != null)
            {
                mainPage.Navigation.RemovePage(
                    mainPage.Navigation.NavigationStack[mainPage.Navigation.NavigationStack.Count - 2]);
            }

            return Task.FromResult(true);
        }

        public Task RemoveNoneRootAsync()
        {
            var mainPage = Application.Current.MainPage as NaviPage;

            if (mainPage != null)
            {
                var needStackLength = mainPage.Navigation.NavigationStack.Count - 2;

                for (int i = 0; i < needStackLength; i++)
                {
                    var page = mainPage.Navigation.NavigationStack[1];
                    mainPage.Navigation.RemovePage(page);
                }
            }

            return Task.FromResult(true);
        }

        public Task RemoveBackStackAsync()
        {
            var mainPage = Application.Current.MainPage as NaviPage;

            if (mainPage != null)
            {
                var needStackLength = mainPage.Navigation.NavigationStack.Count - 2;

                for (int i = 0; i < needStackLength; i++)
                {
                    var page = mainPage.Navigation.NavigationStack[0];
                    mainPage.Navigation.RemovePage(page);
                }
            }

            return Task.FromResult(true);
        }

        private async Task InternalNavigateToAsync(Type viewModelType, object parameter,
            NavigateMode navigateMode = NavigateMode.Relative)
        {
            Page page = CreatePage(viewModelType, parameter);

            //if (page is LoginView)
            //{
            //    Application.Current.MainPage = new CustomNavigationView(page);
            //}
            //else
            //{
            if (navigateMode == NavigateMode.Relative)
            {
                var navigationPage = Application.Current.MainPage as NaviPage;
                if (navigationPage != null)
                {
                    await navigationPage.PushAsync(page);
                }
                else
                {
                    Application.Current.MainPage = new NaviPage(page);
                }
            }
            else
            {
                Application.Current.MainPage = page;
            }
            //}

            await (page.BindingContext as ViewModelBase).InitializeAsync(parameter);
        }

        private Type GetPageTypeForViewModel(Type viewModelType)
        {
            var viewName = viewModelType.FullName
                .Replace(".ViewModels.", ".Views.")
                .Replace("ViewModel", string.Empty);
            var viewModelAssemblyName = viewModelType.GetTypeInfo().Assembly.FullName;
            var viewAssemblyName = string.Format(CultureInfo.InvariantCulture, "{0}, {1}", viewName, viewModelAssemblyName);
            var viewType = Type.GetType(viewAssemblyName);
            return viewType;
        }

        private Page CreatePage(Type viewModelType, object parameter)
        {
            Type pageType = GetPageTypeForViewModel(viewModelType);
            if (pageType == null)
            {
                throw new Exception($"Cannot locate page type for {viewModelType}");
            }

            Page page = Activator.CreateInstance(pageType) as Page;
            return page;
        }

        public async Task GoBackAsync()
        {
            var navigationPage = Application.Current.MainPage as NaviPage;
            if (navigationPage != null)
            {
                await PreviousPageViewModel.ComeBackAsync();
                await navigationPage.PopAsync();
            }
        }

        public async Task GoBackAsync(object parameter)
        {
            var navigationPage = Application.Current.MainPage as NaviPage;
            if (navigationPage != null)
            {
                await PreviousPageViewModel.ComeBackAsync(parameter);
                await navigationPage.PopAsync();
            }
        }
    }
}
