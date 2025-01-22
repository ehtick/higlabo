﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/rolemanagement?view=graph-rest-1.0
/// </summary>
public partial class RoleManagement
{
    public RbacApplication? Directory { get; set; }
    public RbacApplication? EntitlementManagement { get; set; }
}
