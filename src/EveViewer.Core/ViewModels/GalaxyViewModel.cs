using System;
using System.Collections.ObjectModel;
using EveViewer.Core.Services;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace EveViewer.Core.ViewModels
{
  public class GalaxyViewModel : MvxViewModel
  {
    private readonly IEveDataService _dataSvc;
    private readonly ObservableCollection<GalaxyRegionViewModel> _regions;

    public ObservableCollection<GalaxyRegionViewModel> Regions => _regions;
    
    public GalaxyViewModel(IEveDataService dataSvc)
    {
      _dataSvc = dataSvc;
      _regions = new ObservableCollection<GalaxyRegionViewModel>();
    }

    public override async Task Initialize()
    {
      await base.Initialize();

      var list = await _dataSvc.LoadAllRegionsAsync();
      foreach (var reg in list)
      {
        var vm = Mvx.IoCProvider.Resolve<GalaxyRegionViewModel>();
        vm.Id = reg.Id;
        vm.Name = reg.Name;
        _regions.Add(vm);
      }
    }
  }
}