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

      // adding artificial delay to mimic real life, was using await Task.Delay but
      //   that hung the process.
      System.Threading.Thread.Sleep(5);
      
      return list;
    }
  }
}
