using Lykke.Job.Dynamic.Settings.JobSettings;
using Lykke.Job.Dynamic.Settings.SlackNotifications;
using Lykke.SettingsReader.Attributes;

namespace Lykke.Job.Dynamic.Settings
{
    public class AppSettings
    {
        public DynamicSettings DynamicJob { get; set; }

        public SlackNotificationsSettings SlackNotifications { get; set; }

        [Optional]
        public MonitoringServiceClientSettings MonitoringServiceClient { get; set; }
    }
}
