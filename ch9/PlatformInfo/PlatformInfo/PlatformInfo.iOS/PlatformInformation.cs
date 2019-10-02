using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using PlatformInfo.Models;
using PlatformInfo.Services;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(PlatformInfo.iOS.PlatformInformation))]
namespace PlatformInfo.iOS
{
    public class PlatformInformation : IPlatformInformation
    {
        public PlatformInformationModel GetCurrentInformation()
        {
            UIDevice device = new UIDevice();
            return new PlatformInformationModel()
            {
                Model = $"{device.Model}",
                Version = $"{device.SystemName} {device.SystemVersion}" 
            };
        }
    }
}