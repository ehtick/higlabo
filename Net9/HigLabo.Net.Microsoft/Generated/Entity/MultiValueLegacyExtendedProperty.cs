﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/multivaluelegacyextendedproperty?view=graph-rest-1.0
/// </summary>
public partial class MultiValueLegacyExtendedProperty
{
    public string? Id { get; set; }
    public string[]? Value { get; set; }
}
