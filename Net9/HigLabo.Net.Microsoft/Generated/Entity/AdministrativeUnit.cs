﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/administrativeunit?view=graph-rest-1.0
/// </summary>
public partial class AdministrativeUnit
{
    public string? Description { get; set; }
    public string? DisplayName { get; set; }
    public string? Id { get; set; }
    public string? Visibility { get; set; }
    public DirectoryObject[]? Members { get; set; }
    public Extension[]? Extensions { get; set; }
    public ScopedRoleMembership[]? ScopedRoleMembers { get; set; }
}
