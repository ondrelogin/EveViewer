using System;
using EveViewer.Core.Models;

namespace EveViewer.Core.Services
{
  /// <summary>
  /// Will eventually use HttpClient and https://esi.evetech.net/ui/
  /// and with a combo of some local cache of items.
  /// </summary>
  public interface IEveDataService
  {
    Task<IList<RegionModel>> LoadAllRegionsAsync();
  }
}