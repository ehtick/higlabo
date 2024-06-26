﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/securescore-get?view=graph-rest-1.0
    /// </summary>
    public partial class SecurescoreGetParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? Id { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Security_SecureScores_Id: return $"/security/secureScores/{Id}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            Security_SecureScores_Id,
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
    public partial class SecurescoreGetResponse : RestApiResponse
    {
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/securescore-get?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/securescore-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<SecurescoreGetResponse> SecurescoreGetAsync()
        {
            var p = new SecurescoreGetParameter();
            return await this.SendAsync<SecurescoreGetParameter, SecurescoreGetResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/securescore-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<SecurescoreGetResponse> SecurescoreGetAsync(CancellationToken cancellationToken)
        {
            var p = new SecurescoreGetParameter();
            return await this.SendAsync<SecurescoreGetParameter, SecurescoreGetResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/securescore-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<SecurescoreGetResponse> SecurescoreGetAsync(SecurescoreGetParameter parameter)
        {
            return await this.SendAsync<SecurescoreGetParameter, SecurescoreGetResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/securescore-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<SecurescoreGetResponse> SecurescoreGetAsync(SecurescoreGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<SecurescoreGetParameter, SecurescoreGetResponse>(parameter, cancellationToken);
        }
    }
}
