﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/auditactivityinitiator?view=graph-rest-1.0
/// </summary>
public partial class AuditActivityInitiator
{
    public AppIdentity? App { get; set; }
    public UserIdentity? User { get; set; }
}
