﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/calendarpermission?view=graph-rest-1.0
/// </summary>
public partial class CalendarPermission
{
    public enum CalendarPermissionCalendarRoleType
    {
        None,
        FreeBusyRead,
        LimitedRead,
        Read,
        Write,
        DelegateWithoutPrivateEventAccess,
        DelegateWithPrivateEventAccess,
        Custom,
    }

    public CalendarPermissionCalendarRoleType AllowedRoles { get; set; }
    public EmailAddress? EmailAddress { get; set; }
    public string? Id { get; set; }
    public bool? IsInsideOrganization { get; set; }
    public bool? IsRemovable { get; set; }
    public CalendarRoleType? Role { get; set; }
}
