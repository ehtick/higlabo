﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/sharinglink?view=graph-rest-1.0
/// </summary>
public partial class SharingLink
{
    public Identity? Application { get; set; }
    public bool? PreventsDownload { get; set; }
    public string? Scope { get; set; }
    public string? Type { get; set; }
    public string? WebHtml { get; set; }
    public string? WebUrl { get; set; }
}
