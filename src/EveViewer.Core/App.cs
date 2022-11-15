using System;
using EveViewer.Core.ViewModels;
using MvvmCross.ViewModels;

namespace EveViewer.Core
{
  public class App : MvxApplication, IMvxApplication
  {
    public override void Initialize()
    {
      //
      this.RegisterAppStart<GalaxyViewModel>();
    }
  }
}
