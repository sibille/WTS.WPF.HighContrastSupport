using System;
using System.Windows.Controls;

namespace WTS.WPF.HighContrastSupport.Contracts.Services
{
    public interface IPageService
    {
        Type GetPageType(string key);

        Page GetPage(string key);
    }
}
