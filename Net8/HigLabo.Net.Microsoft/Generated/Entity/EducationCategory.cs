﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/educationcategory?view=graph-rest-1.0
/// </summary>
public partial class EducationCategory
{
    public string? DisplayName { get; set; }
    public string? Id { get; set; }
}
