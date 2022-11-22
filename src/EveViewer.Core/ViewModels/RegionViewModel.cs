using System;
using System.Collections.ObjectModel;
using EveViewer.Core.Models;
using EveViewer.Core.Services;
using MvvmCross.ViewModels;

namespace EveViewer.Core.ViewModels
{
  internal class RegionViewModel : MvxViewModel
  {
    private readonly IEveDataService _dataSvc;
    
    private int _regionId;
    private string _name;
    private readonly ObservableCollection<PlanetViewModel> _planets;

    public int RegionId
    {
      get => _regionId;
      set
      {
        if (_regionId != value)
        {
          this.SetProperty(ref _regionId, value, nameof(this.RegionId));
        }
      }
    }
    public string Name
    {
      get => _name;
      set
      {
        if (_name != value)
        {
          this.SetProperty(ref _name, value, nameof(this.Name));
        }
      }
    }

    public ObservableCollection<PlanetViewModel> Planets => _planets;

    public RegionViewModel(IEveDataService dataSvc)
    {
      _dataSvc = dataSvc;
      _planets = new ObservableCollection<PlanetViewModel>();

      _regionId = -1;
      _name = "unknown";
    }
  }

  internal class PlanetViewModel : MvxViewModel
  {

  }
}
