using System;
using EveViewer.Core.Services;
using EveViewer.Core.ViewModels;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace EveViewer.Core
{
  public class App : MvxApplication, IMvxApplication
  {
    public override void Initialize()
    {
      Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IEveDataService, FakeEveDataService>();
      Mvx.IoCProvider.RegisterType<GalaxyRegionViewModel>();
      Mvx.IoCProvider.RegisterType<RegionViewModel>();

      //
      this.RegisterAppStart<GalaxyViewModel>();
    }
  }
}
