using Microsoft.Extensions.DependencyInjection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Common.Log;
using Lykke.Job.Dynamic.Core.Services;
using Lykke.Job.Dynamic.Settings.JobSettings;
using Lykke.Job.Dynamic.Services;
using Lykke.SettingsReader;

namespace Lykke.Job.Dynamic.Modules
{
    public class JobModule : Module
    {
        private readonly DynamicSettings _settings;
        private readonly IReloadingManager<DynamicSettings> _settingsManager;
        private readonly ILog _log;
        // NOTE: you can remove it if you don't need to use IServiceCollection extensions to register service specific dependencies
        private readonly IServiceCollection _services;

        public JobModule(DynamicSettings settings, IReloadingManager<DynamicSettings> settingsManager, ILog log)
        {
            _settings = settings;
            _log = log;
            _settingsManager = settingsManager;

            _services = new ServiceCollection();
        }

        protected override void Load(ContainerBuilder builder)
        {
            // NOTE: Do not register entire settings in container, pass necessary settings to services which requires them
            // ex:
            // builder.RegisterType<QuotesPublisher>()
            //  .As<IQuotesPublisher>()
            //  .WithParameter(TypedParameter.From(_settings.Rabbit.ConnectionString))

            builder.RegisterInstance(_log)
                .As<ILog>()
                .SingleInstance();

            builder.RegisterType<HealthService>()
                .As<IHealthService>()
                .SingleInstance();

            builder.RegisterType<StartupManager>()
                .As<IStartupManager>();

            builder.RegisterType<ShutdownManager>()
                .As<IShutdownManager>();

            // TODO: Add your dependencies here

            builder.Populate(_services);
        }
    }
}
