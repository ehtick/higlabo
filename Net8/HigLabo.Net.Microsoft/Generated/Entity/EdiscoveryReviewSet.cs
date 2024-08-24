﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/resources/security-ediscoveryreviewset?view=graph-rest-1.0
    /// </summary>
    public partial class EDiscoveryReviewSet
    {
        public IdentitySet? CreatedBy { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string? DisplayName { get; set; }
        public string? Id { get; set; }
        public EDiscoveryReviewSetQuery[]? Queries { get; set; }
    }
}
