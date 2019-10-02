using PlatformInfo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlatformInfo.Services
{
    public interface IPlatformInformation
    {
        PlatformInformationModel GetCurrentInformation();
    }
}
