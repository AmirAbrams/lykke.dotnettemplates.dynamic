using JetBrains.Annotations;
using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.Dynamic.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class DynamicSettings
    {
        public DbSettings Db { get; set; }
    }
}
