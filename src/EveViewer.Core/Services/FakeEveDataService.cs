using System;
using System.Collections.Generic;
using EveViewer.Core.Models;

namespace EveViewer.Core.Services
{
  public class FakeEveDataService : IEveDataService
  {
    public async Task<IList<RegionModel>> LoadAllRegionsAsync()
    {
      var list = new List<RegionModel>();

      // hardcoded for now
      list.Add(new RegionModel
      {
        Id = 10000001,
        Name = "Derelik"
      });
      list.Add(new RegionModel
      {
        Id = 10000002,
        Name = "The Forge"
      });

      await Task.Delay(5);

      return list;
    }
  }
}
