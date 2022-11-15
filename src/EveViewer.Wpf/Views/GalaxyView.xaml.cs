using System;
using System.Windows;
using EveViewer.Core.ViewModels;
using MvvmCross.Platforms.Wpf.Views;

namespace EveViewer.Wpf.Views
{
  /// <summary>
  /// Interaction logic for GuestBookView.xaml
  /// </summary>
  public partial class GalaxyView : MvxWpfView
  {
    public GalaxyView()
    {
      this.InitializeComponent();
    }

    private void View_Loaded(object sender, RoutedEventArgs e)
    {
      var asVm = this.DataContext as GalaxyViewModel;
      if (asVm != null) { asVm.OnLoadedAsync(); }
    }
  }
}