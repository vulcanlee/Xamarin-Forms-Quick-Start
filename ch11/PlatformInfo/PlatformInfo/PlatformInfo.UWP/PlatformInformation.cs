using PlatformInfo.Models;
using PlatformInfo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.ExchangeActiveSyncProvisioning;

[assembly: Xamarin.Forms.Dependency(typeof(PlatformInfo.UWP.PlatformInformation))]
namespace PlatformInfo.UWP
{
    public class PlatformInformation : IPlatformInformation
    {
        public PlatformInformationModel GetCurrentInformation()
        {
            EasClientDeviceInformation devInfo = new EasClientDeviceInformation();
            return new PlatformInformationModel()
            {
                Model = $"{devInfo.SystemManufacturer} {devInfo.SystemProductName}",
                Version = $"{devInfo.OperatingSystem}"
            };
        }
    }
}
