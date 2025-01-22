﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/mailsearchfolder?view=graph-rest-1.0
/// </summary>
public partial class MailSearchFolder
{
    public string? FilterQuery { get; set; }
    public bool? IncludeNestedFolders { get; set; }
    public bool? IsSupported { get; set; }
    public String[]? SourceFolderIds { get; set; }
}
