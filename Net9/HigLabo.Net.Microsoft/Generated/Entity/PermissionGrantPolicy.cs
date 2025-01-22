﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/permissiongrantpolicy?view=graph-rest-1.0
/// </summary>
public partial class PermissionGrantPolicy
{
    public string? DisplayName { get; set; }
    public string? Description { get; set; }
    public PermissionGrantConditionSet[]? Excludes { get; set; }
    public string? Id { get; set; }
    public PermissionGrantConditionSet[]? Includes { get; set; }
}
