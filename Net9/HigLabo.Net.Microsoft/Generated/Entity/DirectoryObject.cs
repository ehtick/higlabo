﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/directoryobject?view=graph-rest-1.0
/// </summary>
public partial class DirectoryObject
{
    public DateTimeOffset? DeletedDateTime { get; set; }
    public string? Id { get; set; }
}
