using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PlatformInfo.Models;
using PlatformInfo.Services;

[assembly: Xamarin.Forms.Dependency(typeof(PlatformInfo.Droid.PlatformInformation))]
namespace PlatformInfo.Droid
{
    public class PlatformInformation : IPlatformInformation
    {
        public PlatformInformationModel GetCurrentInformation()
        {
            return new PlatformInformationModel()
            {
                Model = $"{Build.Manufacturer} {Build.Model}",
                Version = Build.VERSION.Release.ToString(),
            };
        }
    }
}