﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/insights-shared?view=graph-rest-1.0
/// </summary>
public partial class SharedInsight
{
    public string? Id { get; set; }
    public SharingDetail? LastShared { get; set; }
    public ResourceReference? ResourceReference { get; set; }
    public ResourceVisualization? ResourceVisualization { get; set; }
    public Entity[]? Resource { get; set; }
}
