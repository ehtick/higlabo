﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/itemactivitystat?view=graph-rest-1.0
/// </summary>
public partial class ItemActivityStat
{
    public ItemActionStat? Access { get; set; }
    public ItemActionStat? Create { get; set; }
    public ItemActionStat? Delete { get; set; }
    public ItemActionStat? Edit { get; set; }
    public DateTimeOffset? EndDateTime { get; set; }
    public IncompleteData? IncompleteData { get; set; }
    public bool? IsTrending { get; set; }
    public ItemActionStat? Move { get; set; }
    public DateTimeOffset? StartDateTime { get; set; }
    public ItemActivity[]? Activities { get; set; }
}
