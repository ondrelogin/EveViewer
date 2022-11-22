using System;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace EveViewer.Core.ViewModels
{
  /// <remarks>
  /// Not sure of my design, should this be an inner class of like, GalaxyViewModel.RegionViewModel?
  /// </remarks>
  public class GalaxyRegionViewModel : MvxViewModel
  {
    private readonly IMvxNavigationService _navSvc;

    public int Id { get; set; }
    public string Name { get; set; }
    public IMvxCommand ShowDetailsCommand => new MvxCommand(this.ShowDetails);

    public GalaxyRegionViewModel(IMvxNavigationService navSvc)
    {
      _navSvc = navSvc;

      this.Id = -1;
      this.Name = "unknown";
    }

    private void ShowDetails()
    {
      var childVm = Mvx.IoCProvider.Resolve<RegionViewModel>();
      childVm.RegionId = this.Id;
      childVm.Name = this.Name;

      _navSvc.Navigate(childVm);
    }
  }
}
