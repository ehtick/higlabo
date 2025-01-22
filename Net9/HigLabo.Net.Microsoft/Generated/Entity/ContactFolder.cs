﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/contactfolder?view=graph-rest-1.0
/// </summary>
public partial class ContactFolder
{
    public string? DisplayName { get; set; }
    public string? Id { get; set; }
    public string? ParentFolderId { get; set; }
    public ContactFolder[]? ChildFolders { get; set; }
    public Contact[]? Contacts { get; set; }
    public MultiValueLegacyExtendedProperty[]? MultiValueExtendedProperties { get; set; }
    public SingleValueLegacyExtendedProperty[]? SingleValueExtendedProperties { get; set; }
}
