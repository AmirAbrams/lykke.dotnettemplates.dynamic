using JetBrains.Annotations;
using Lykke.Sdk.Settings;

namespace Lykke.Service.Dynamic.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class AppSettings : BaseAppSettings
    {
        public DynamicSettings DynamicService { get; set; }        
    }
}
