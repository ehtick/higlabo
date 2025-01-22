﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/keyvaluepair?view=graph-rest-1.0
/// </summary>
public partial class KeyValuePair
{
    public string? Name { get; set; }
    public string? Value { get; set; }
}
