﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/unifiedroleeligibilityschedulerequest?view=graph-rest-1.0
/// </summary>
public partial class UnifiedRoleEligibilityScheduleRequest
{
    public enum UnifiedRoleEligibilityScheduleRequestUnifiedRoleScheduleRequestActions
    {
        AdminAssign,
        AdminUpdate,
        AdminRemove,
        SelfActivate,
        SelfDeactivate,
        AdminExtend,
        AdminRenew,
        SelfExtend,
        SelfRenew,
        UnknownFutureValue,
    }

    public UnifiedRoleEligibilityScheduleRequestUnifiedRoleScheduleRequestActions Action { get; set; }
    public string? ApprovalId { get; set; }
    public string? AppScopeId { get; set; }
    public DateTimeOffset? CompletedDateTime { get; set; }
    public IdentitySet? CreatedBy { get; set; }
    public DateTimeOffset? CreatedDateTime { get; set; }
    public string? CustomData { get; set; }
    public string? DirectoryScopeId { get; set; }
    public string? Id { get; set; }
    public bool? IsValidationOnly { get; set; }
    public string? Justification { get; set; }
    public string? PrincipalId { get; set; }
    public string? RoleDefinitionId { get; set; }
    public RequestSchedule? ScheduleInfo { get; set; }
    public string? Status { get; set; }
    public string? TargetScheduleId { get; set; }
    public TicketInfo? TicketInfo { get; set; }
    public AppScope? AppScope { get; set; }
    public DirectoryObject? DirectoryScope { get; set; }
    public DirectoryObject? Principal { get; set; }
    public UnifiedRoleDefinition? RoleDefinition { get; set; }
    public UnifiedRoleEligibilitySchedule? TargetSchedule { get; set; }
}
