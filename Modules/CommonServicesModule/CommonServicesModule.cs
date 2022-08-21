using Core;
using Prism.Ioc;
using Prism.Modularity;
using static Serilog.SerilogLoggerFactoryExtensions;
using static Serilog.ConsoleLoggerConfigurationExtensions;
using Microsoft.Extensions.Logging;

//using MicrosoftILogger = Microsoft.Extensions.Logging.ILogger;
//using MicrosoftILoggerFactory = Microsoft.Extensions.Logging.ILoggerFactory;

namespace SharedModule;

public class CommonServicesModule : IModule
{
    public void OnInitialized(IContainerProvider containerProvider)
    {
        Serilog.Log.Logger = new Serilog.LoggerConfiguration()
            .Enrich.FromLogContext()
            .WriteTo.Console()
            .CreateLogger();
    }

    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterSingleton<IMessageBoxService, MessageBoxService>();
        containerRegistry.RegisterSingleton<IFileDialogService, FileDialogService>();

        ILoggerFactory factory = new LoggerFactory();
        factory.AddSerilog();

        containerRegistry.RegisterSingleton<ILoggerFactory>(() => factory);

        containerRegistry.RegisterSingleton<ILogger>((IContainerProvider provider) =>
        {
            ILoggerFactory loggerFactory = provider.Resolve<ILoggerFactory>();
            return loggerFactory.CreateLogger<ILogger>();
        });

        // Find a way to solve the getting of the Generic logger
        //containerRegistry.Register(typeof(ILogger<>), (IContainerProvider provider) =>
        //{
        //    ILoggerFactory loggerFactory = provider.Resolve<ILoggerFactory>();
        //    return loggerFactory.CreateLogger<BaseViewModel>();
        //});
    }
}
