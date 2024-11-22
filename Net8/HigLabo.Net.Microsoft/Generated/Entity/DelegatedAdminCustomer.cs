﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/delegatedadmincustomer?view=graph-rest-1.0
/// </summary>
public partial class DelegatedAdminCustomer
{
    public string? DisplayName { get; set; }
    public string? Id { get; set; }
    public string? TenantId { get; set; }
    public DelegatedAdminServiceManagementDetail[]? ServiceManagementDetails { get; set; }
}
