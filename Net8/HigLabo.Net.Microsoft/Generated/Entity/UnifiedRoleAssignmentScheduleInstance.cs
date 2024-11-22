﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/unifiedroleassignmentscheduleinstance?view=graph-rest-1.0
/// </summary>
public partial class UnifiedRoleAssignmentScheduleInstance
{
    public string? AppScopeId { get; set; }
    public string? AssignmentType { get; set; }
    public string? DirectoryScopeId { get; set; }
    public DateTimeOffset? EndDateTime { get; set; }
    public string? Id { get; set; }
    public string? MemberType { get; set; }
    public string? PrincipalId { get; set; }
    public string? RoleAssignmentOriginId { get; set; }
    public string? RoleAssignmentScheduleId { get; set; }
    public string? RoleDefinitionId { get; set; }
    public DateTimeOffset? StartDateTime { get; set; }
    public UnifiedRoleEligibilityScheduleInstance? ActivatedUsing { get; set; }
    public AppScope? AppScope { get; set; }
    public DirectoryObject? DirectoryScope { get; set; }
    public DirectoryObject? Principal { get; set; }
    public UnifiedRoleDefinition? RoleDefinition { get; set; }
}
