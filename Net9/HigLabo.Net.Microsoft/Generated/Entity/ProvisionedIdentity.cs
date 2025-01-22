﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/provisionedidentity?view=graph-rest-1.0
/// </summary>
public partial class ProvisionedIdentity
{
    public DetailsInfo? Details { get; set; }
    public string? DisplayName { get; set; }
    public string? Id { get; set; }
    public string? IdentityType { get; set; }
}
