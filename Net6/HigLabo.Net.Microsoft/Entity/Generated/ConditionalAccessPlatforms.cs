﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/conditionalaccessplatforms?view=graph-rest-1.0
    /// </summary>
    public partial class ConditionalAccessPlatforms
    {
        public enum ConditionalAccessPlatformsConditionalAccessDevicePlatform
        {
            Android,
            IOS,
            Windows,
            WindowsPhone,
            MacOS,
            Linux,
            All,
            UnknownFutureValue,
        }

        public ConditionalAccessPlatformsConditionalAccessDevicePlatform IncludePlatforms { get; set; }
        public ConditionalAccessPlatformsConditionalAccessDevicePlatform ExcludePlatforms { get; set; }
    }
}