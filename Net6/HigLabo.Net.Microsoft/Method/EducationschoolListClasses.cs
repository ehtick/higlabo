﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class EducationSchoolListClassesParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? EducationSchoolId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Education_Schools_EducationSchoolId_Classes: return $"/education/schools/{EducationSchoolId}/classes";
                    case ApiPath.Ttps__Graphmicrosoftcom_V10_Groups: return $"/ttps://graph.microsoft.com/v1.0/groups";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
            Id,
            DisplayName,
            MailNickname,
            Description,
            CreatedBy,
            ClassCode,
            ExternalName,
            ExternalId,
            ExternalSource,
            ExternalSourceDetail,
            Grade,
            Term,
            Assignments,
            Group,
            Members,
            Schools,
            Teachers,
            AssignmentCategories,
            AssignmentDefaults,
            AssignmentSettings,
        }
        public enum ApiPath
        {
            Education_Schools_EducationSchoolId_Classes,
            Ttps__Graphmicrosoftcom_V10_Groups,
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
    public partial class EducationSchoolListClassesResponse : RestApiResponse
    {
        public EducationClass[]? Value { get; set; }
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/educationschool-list-classes?view=graph-rest-1.0
        /// </summary>
        public async Task<EducationSchoolListClassesResponse> EducationSchoolListClassesAsync()
        {
            var p = new EducationSchoolListClassesParameter();
            return await this.SendAsync<EducationSchoolListClassesParameter, EducationSchoolListClassesResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/educationschool-list-classes?view=graph-rest-1.0
        /// </summary>
        public async Task<EducationSchoolListClassesResponse> EducationSchoolListClassesAsync(CancellationToken cancellationToken)
        {
            var p = new EducationSchoolListClassesParameter();
            return await this.SendAsync<EducationSchoolListClassesParameter, EducationSchoolListClassesResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/educationschool-list-classes?view=graph-rest-1.0
        /// </summary>
        public async Task<EducationSchoolListClassesResponse> EducationSchoolListClassesAsync(EducationSchoolListClassesParameter parameter)
        {
            return await this.SendAsync<EducationSchoolListClassesParameter, EducationSchoolListClassesResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/educationschool-list-classes?view=graph-rest-1.0
        /// </summary>
        public async Task<EducationSchoolListClassesResponse> EducationSchoolListClassesAsync(EducationSchoolListClassesParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<EducationSchoolListClassesParameter, EducationSchoolListClassesResponse>(parameter, cancellationToken);
        }
    }
}