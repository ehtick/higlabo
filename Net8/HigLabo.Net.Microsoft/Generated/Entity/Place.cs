﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/place?view=graph-rest-1.0
/// </summary>
public partial class Place
{
    public PhysicalAddress? Address { get; set; }
    public string? DisplayName { get; set; }
    public OutlookGeoCoordinates? GeoCoordinates { get; set; }
    public string? Id { get; set; }
    public string? Phone { get; set; }
}
