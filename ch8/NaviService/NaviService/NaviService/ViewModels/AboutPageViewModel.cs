﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NaviService.ViewModels
{
    public class AboutPageViewModel : ViewModelBase
    {
        public string PreNaviPara { get; set; } = "";
        public string BackNaviPara { get; set; } = "";
        public Command GoRootCommand { get; set; }
        public Command GoPreCommand { get; set; }
        public AboutPageViewModel()
        {
            GoRootCommand = new Command(() =>
            {
                NavigationService.RemoveLastFromBackStackAsync();
                NavigationService.GoBackAsync(BackNaviPara);
            });
            GoPreCommand = new Command(() =>
            {
                NavigationService.GoBackAsync(BackNaviPara);
            });
        }
        public override Task InitializeAsync(object navigationData)
        {
            PreNaviPara = navigationData as string;
            return base.InitializeAsync(navigationData);
        }
    }
}
