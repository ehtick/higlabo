﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/serviceannouncementattachment?view=graph-rest-1.0
/// </summary>
public partial class ServiceAnnouncementAttachment
{
    public Stream? Content { get; set; }
    public string? ContentType { get; set; }
    public string? Id { get; set; }
    public DateTimeOffset? LastModifiedDateTime { get; set; }
    public string? Name { get; set; }
    public Int32? Size { get; set; }
}
