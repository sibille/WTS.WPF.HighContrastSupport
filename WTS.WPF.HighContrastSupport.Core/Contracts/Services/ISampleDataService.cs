using System.Collections.Generic;
using System.Threading.Tasks;

using WTS.WPF.HighContrastSupport.Core.Models;

namespace WTS.WPF.HighContrastSupport.Core.Contracts.Services
{
    public interface ISampleDataService
    {
        Task<IEnumerable<SampleOrder>> GetMasterDetailDataAsync();
    }
}
