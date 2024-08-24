﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/resources/usersignininsight?view=graph-rest-1.0
    /// </summary>
    public partial class UserSignInInsight
    {
        public DateTimeOffset? LastSignInDateTime { get; set; }
        public DateTimeOffset? InsightCreatedDateTime { get; set; }
    }
}
