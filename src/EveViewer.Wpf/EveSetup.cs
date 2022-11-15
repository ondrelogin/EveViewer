using System;
using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Wpf.Core;
using Serilog;
using Serilog.Extensions.Logging;

namespace EveViewer.Wpf
{
  public class EveSetup : MvxWpfSetup<EveViewer.Core.App>
  {
    protected override ILoggerProvider? CreateLogProvider()
    {
      return new SerilogLoggerProvider();
    }

    protected override ILoggerFactory? CreateLogFactory()
    {
      // serilog configuration
      Log.Logger = new LoggerConfiguration()
          .MinimumLevel.Debug()
          .WriteTo.Trace()
          .CreateLogger();

      return new SerilogLoggerFactory();
    }
  }
}
