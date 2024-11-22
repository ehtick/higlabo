﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/scoredemailaddress?view=graph-rest-1.0
/// </summary>
public partial class ScoredEmailAddress
{
    public string? Address { get; set; }
    public Double? RelevanceScore { get; set; }
}
