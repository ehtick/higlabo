﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/serviceplaninfo?view=graph-rest-1.0
/// </summary>
public partial class ServicePlanInfo
{
    public string? AppliesTo { get; set; }
    public string? ProvisioningStatus { get; set; }
    public Guid? ServicePlanId { get; set; }
    public string? ServicePlanName { get; set; }
}
