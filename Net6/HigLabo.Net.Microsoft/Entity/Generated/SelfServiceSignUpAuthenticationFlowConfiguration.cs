﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/graph/api/resources/selfservicesignupauthenticationflowconfiguration?view=graph-rest-1.0
    /// </summary>
    public partial class SelfServiceSignUpAuthenticationFlowConfiguration
    {
        public bool? IsEnabled { get; set; }
    }
}