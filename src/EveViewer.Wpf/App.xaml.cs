﻿using System;
using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Views;

namespace EveViewer.Wpf
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : MvxApplication
  {
    protected override void RegisterSetup()
    {
      this.RegisterSetupType<EveSetup>();
    }
  }
}
