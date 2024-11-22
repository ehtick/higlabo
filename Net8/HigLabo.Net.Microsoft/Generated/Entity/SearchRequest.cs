﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/searchrequest?view=graph-rest-1.0
/// </summary>
public partial class SearchRequest
{
    public enum SearchRequestEntityType
    {
        List,
        Site,
        ListItem,
        Message,
        Event,
        Drive,
        DriveItem,
        ExternalItem,
    }

    public String[]? AggregationFilters { get; set; }
    public AggregationOption[]? Aggregations { get; set; }
    public String[]? ContentSources { get; set; }
    public bool? EnableTopResults { get; set; }
    public SearchRequestEntityType EntityTypes { get; set; }
    public String[]? Fields { get; set; }
    public Int32? From { get; set; }
    public SearchQuery? Query { get; set; }
    public SearchAlterationOptions? QueryAlterationOptions { get; set; }
    public string? Region { get; set; }
    public ResultTemplateOption[]? ResultTemplateOptions { get; set; }
    public SharePointOneDriveOptions? SharePointOneDriveOptions { get; set; }
    public Int32? Size { get; set; }
    public SortProperty[]? SortProperties { get; set; }
}
