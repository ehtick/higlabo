﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/conditionalaccesspolicy-get?view=graph-rest-1.0
    /// </summary>
    public partial class ConditionalAccessPolicyGetParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? Id { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Identity_ConditionalAccess_Policies_Id: return $"/identity/conditionalAccess/policies/{Id}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            Identity_ConditionalAccess_Policies_Id,
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
    public partial class ConditionalAccessPolicyGetResponse : RestApiResponse
    {
        public enum ConditionalAccessPolicyConditionalAccessPolicyState
        {
            Enabled,
            Disabled,
            EnabledForReportingButNotEnforced,
        }

        public ConditionalAccessConditionSet? Conditions { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string? DisplayName { get; set; }
        public ConditionalAccessGrantControls? GrantControls { get; set; }
        public string? Id { get; set; }
        public DateTimeOffset? ModifiedDateTime { get; set; }
        public ConditionalAccessSessionControls? SessionControls { get; set; }
        public ConditionalAccessPolicyConditionalAccessPolicyState State { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/conditionalaccesspolicy-get?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/conditionalaccesspolicy-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ConditionalAccessPolicyGetResponse> ConditionalAccessPolicyGetAsync()
        {
            var p = new ConditionalAccessPolicyGetParameter();
            return await this.SendAsync<ConditionalAccessPolicyGetParameter, ConditionalAccessPolicyGetResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/conditionalaccesspolicy-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ConditionalAccessPolicyGetResponse> ConditionalAccessPolicyGetAsync(CancellationToken cancellationToken)
        {
            var p = new ConditionalAccessPolicyGetParameter();
            return await this.SendAsync<ConditionalAccessPolicyGetParameter, ConditionalAccessPolicyGetResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/conditionalaccesspolicy-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ConditionalAccessPolicyGetResponse> ConditionalAccessPolicyGetAsync(ConditionalAccessPolicyGetParameter parameter)
        {
            return await this.SendAsync<ConditionalAccessPolicyGetParameter, ConditionalAccessPolicyGetResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/conditionalaccesspolicy-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ConditionalAccessPolicyGetResponse> ConditionalAccessPolicyGetAsync(ConditionalAccessPolicyGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ConditionalAccessPolicyGetParameter, ConditionalAccessPolicyGetResponse>(parameter, cancellationToken);
        }
    }
}
