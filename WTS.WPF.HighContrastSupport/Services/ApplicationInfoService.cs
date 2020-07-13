using System;
using System.Diagnostics;
using System.Reflection;

using WTS.WPF.HighContrastSupport.Contracts.Services;

namespace WTS.WPF.HighContrastSupport.Services
{
    public class ApplicationInfoService : IApplicationInfoService
    {
        public ApplicationInfoService()
        {
        }

        public Version GetVersion()
        {
            // Set the app version in WTS.WPF.HighContrastSupport > Properties > Package > PackageVersion
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            var version = FileVersionInfo.GetVersionInfo(assemblyLocation).FileVersion;
            return new Version(version);
        }
    }
}
