﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/unifiedrole?view=graph-rest-1.0
/// </summary>
public partial class UnifiedRole
{
    public string? RoleDefinitionId { get; set; }
}
