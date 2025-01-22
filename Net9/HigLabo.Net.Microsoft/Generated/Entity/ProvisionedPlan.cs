﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/provisionedplan?view=graph-rest-1.0
/// </summary>
public partial class ProvisionedPlan
{
    public string? CapabilityStatus { get; set; }
    public string? ProvisioningStatus { get; set; }
    public string? Service { get; set; }
}
