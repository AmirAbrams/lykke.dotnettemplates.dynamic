﻿using Lykke.SettingsReader.Attributes;

namespace Lykke.Job.Dynamic.Settings.JobSettings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }
    }
}
