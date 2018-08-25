using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.Dynamic.Settings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }
    }
}
