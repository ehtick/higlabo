﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/educationassignmentsettings?view=graph-rest-1.0
/// </summary>
public partial class EducationAssignmentSettings
{
    public string? Id { get; set; }
    public bool? SubmissionAnimationDisabled { get; set; }
}
