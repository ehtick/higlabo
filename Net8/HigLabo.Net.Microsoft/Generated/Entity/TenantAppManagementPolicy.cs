﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/tenantappmanagementpolicy?view=graph-rest-1.0
/// </summary>
public partial class TenantAppManagementPolicy
{
    public AppManagementConfiguration? ApplicationRestrictions { get; set; }
    public string? Description { get; set; }
    public string? DisplayName { get; set; }
    public string? Id { get; set; }
    public bool? IsEnabled { get; set; }
    public AppManagementConfiguration? ServicePrincipalRestrictions { get; set; }
}
