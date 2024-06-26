﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/educationuser-list-rubrics?view=graph-rest-1.0
    /// </summary>
    public partial class EducationUserListRubricsParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Education_Me_Rubrics: return $"/education/me/rubrics";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
            CreatedBy,
            CreatedDateTime,
            Description,
            DisplayName,
            Grading,
            Id,
            LastModifiedBy,
            LastModifiedDateTime,
            Levels,
            Qualities,
        }
        public enum ApiPath
        {
            Education_Me_Rubrics,
        }

        public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
        string IRestApiParameter.ApiPath
        {
            get
            {
                return this.ApiPathSetting.GetApiPath();
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "GET";
        public QueryParameter<Field> Query { get; set; } = new QueryParameter<Field>();
        IQueryParameter IQueryParameterProperty.Query
        {
            get
            {
                return this.Query;
            }
        }
    }
    public partial class EducationUserListRubricsResponse : RestApiResponse
    {
        public EducationRubric[]? Value { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/educationuser-list-rubrics?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/educationuser-list-rubrics?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<EducationUserListRubricsResponse> EducationUserListRubricsAsync()
        {
            var p = new EducationUserListRubricsParameter();
            return await this.SendAsync<EducationUserListRubricsParameter, EducationUserListRubricsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/educationuser-list-rubrics?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<EducationUserListRubricsResponse> EducationUserListRubricsAsync(CancellationToken cancellationToken)
        {
            var p = new EducationUserListRubricsParameter();
            return await this.SendAsync<EducationUserListRubricsParameter, EducationUserListRubricsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/educationuser-list-rubrics?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<EducationUserListRubricsResponse> EducationUserListRubricsAsync(EducationUserListRubricsParameter parameter)
        {
            return await this.SendAsync<EducationUserListRubricsParameter, EducationUserListRubricsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/educationuser-list-rubrics?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<EducationUserListRubricsResponse> EducationUserListRubricsAsync(EducationUserListRubricsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<EducationUserListRubricsParameter, EducationUserListRubricsResponse>(parameter, cancellationToken);
        }
    }
}
