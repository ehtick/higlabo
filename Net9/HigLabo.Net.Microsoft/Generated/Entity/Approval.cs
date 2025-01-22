﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/approval?view=graph-rest-1.0
/// </summary>
public partial class Approval
{
    public string? Id { get; set; }
    public ApprovalStage[]? Stages { get; set; }
}
