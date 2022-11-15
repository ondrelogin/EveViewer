using System;
using System.Collections.ObjectModel;
using EveViewer.Core.Models;
using EveViewer.Core.Services;
using MvvmCross.ViewModels;

namespace EveViewer.Core.ViewModels
{
  public class GalaxyViewModel : MvxViewModel
  {
    private readonly IEveDataService _dataSvc;

    private ObservableCollection<RegionModel> _regions;

    public ObservableCollection<RegionModel> Regions => _regions;

    public GalaxyViewModel()
    {
      _dataSvc = new FakeEveDataService();
      _regions = new ObservableCollection<RegionModel>();
    }

    public async void OnLoadedAsync()
    {
      foreach (var reg in await _dataSvc.LoadAllRegionsAsync())
      {
        _regions.Add(reg);
      }
    }
  }
}
