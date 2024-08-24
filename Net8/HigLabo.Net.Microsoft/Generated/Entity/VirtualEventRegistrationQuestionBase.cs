﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/resources/virtualeventregistrationquestionbase?view=graph-rest-1.0
    /// </summary>
    public partial class VirtualEventRegistrationQuestionBase
    {
        public string? DisplayName { get; set; }
        public string? Id { get; set; }
        public bool? IsRequired { get; set; }
    }
}
