﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/unmuteparticipantoperation?view=graph-rest-1.0
/// </summary>
public partial class UnmuteParticipantOperation
{
    public string? ClientContext { get; set; }
    public string? Id { get; set; }
    public ResultInfo? ResultInfo { get; set; }
    public string? Status { get; set; }
}
