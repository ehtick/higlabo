﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/subjectrightsrequest-post-notes?view=graph-rest-1.0
    /// </summary>
    public partial class SubjectrightsrequestPostNotesParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? SubjectRightsRequestId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Privacy_SubjectRightsRequests_SubjectRightsRequestId_Notes: return $"/privacy/subjectRightsRequests/{SubjectRightsRequestId}/notes";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            Privacy_SubjectRightsRequests_SubjectRightsRequestId_Notes,
        }

        public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
        string IRestApiParameter.ApiPath
        {
            get
            {
                return this.ApiPathSetting.GetApiPath();
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public ItemBody? Content { get; set; }
        public Identity? Author { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
    }
    public partial class SubjectrightsrequestPostNotesResponse : RestApiResponse
    {
        public Identity? Author { get; set; }
        public ItemBody? Content { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/subjectrightsrequest-post-notes?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/subjectrightsrequest-post-notes?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<SubjectrightsrequestPostNotesResponse> SubjectrightsrequestPostNotesAsync()
        {
            var p = new SubjectrightsrequestPostNotesParameter();
            return await this.SendAsync<SubjectrightsrequestPostNotesParameter, SubjectrightsrequestPostNotesResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/subjectrightsrequest-post-notes?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<SubjectrightsrequestPostNotesResponse> SubjectrightsrequestPostNotesAsync(CancellationToken cancellationToken)
        {
            var p = new SubjectrightsrequestPostNotesParameter();
            return await this.SendAsync<SubjectrightsrequestPostNotesParameter, SubjectrightsrequestPostNotesResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/subjectrightsrequest-post-notes?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<SubjectrightsrequestPostNotesResponse> SubjectrightsrequestPostNotesAsync(SubjectrightsrequestPostNotesParameter parameter)
        {
            return await this.SendAsync<SubjectrightsrequestPostNotesParameter, SubjectrightsrequestPostNotesResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/subjectrightsrequest-post-notes?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<SubjectrightsrequestPostNotesResponse> SubjectrightsrequestPostNotesAsync(SubjectrightsrequestPostNotesParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<SubjectrightsrequestPostNotesParameter, SubjectrightsrequestPostNotesResponse>(parameter, cancellationToken);
        }
    }
}
