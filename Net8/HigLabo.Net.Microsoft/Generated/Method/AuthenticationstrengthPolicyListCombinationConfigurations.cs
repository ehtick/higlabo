﻿using HigLabo.Net.OAuth;
using System.Runtime.CompilerServices;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/authenticationstrengthpolicy-list-combinationconfigurations?view=graph-rest-1.0
/// </summary>
public partial class AuthenticationstrengthPolicyListCombinationConfigurationsParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? AuthenticationStrengthPolicyId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Identity_ConditionalAccess_AuthenticationStrength_Policies_AuthenticationStrengthPolicyId_CombinationConfigurations: return $"/identity/conditionalAccess/authenticationStrength/policies/{AuthenticationStrengthPolicyId}/combinationConfigurations";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Identity_ConditionalAccess_AuthenticationStrength_Policies_AuthenticationStrengthPolicyId_CombinationConfigurations,
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
public partial class AuthenticationstrengthPolicyListCombinationConfigurationsResponse : RestApiResponse<AuthenticationCombinationConfiguration>
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/authenticationstrengthpolicy-list-combinationconfigurations?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/authenticationstrengthpolicy-list-combinationconfigurations?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<AuthenticationstrengthPolicyListCombinationConfigurationsResponse> AuthenticationstrengthPolicyListCombinationConfigurationsAsync()
    {
        var p = new AuthenticationstrengthPolicyListCombinationConfigurationsParameter();
        return await this.SendAsync<AuthenticationstrengthPolicyListCombinationConfigurationsParameter, AuthenticationstrengthPolicyListCombinationConfigurationsResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/authenticationstrengthpolicy-list-combinationconfigurations?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<AuthenticationstrengthPolicyListCombinationConfigurationsResponse> AuthenticationstrengthPolicyListCombinationConfigurationsAsync(CancellationToken cancellationToken)
    {
        var p = new AuthenticationstrengthPolicyListCombinationConfigurationsParameter();
        return await this.SendAsync<AuthenticationstrengthPolicyListCombinationConfigurationsParameter, AuthenticationstrengthPolicyListCombinationConfigurationsResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/authenticationstrengthpolicy-list-combinationconfigurations?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<AuthenticationstrengthPolicyListCombinationConfigurationsResponse> AuthenticationstrengthPolicyListCombinationConfigurationsAsync(AuthenticationstrengthPolicyListCombinationConfigurationsParameter parameter)
    {
        return await this.SendAsync<AuthenticationstrengthPolicyListCombinationConfigurationsParameter, AuthenticationstrengthPolicyListCombinationConfigurationsResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/authenticationstrengthpolicy-list-combinationconfigurations?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<AuthenticationstrengthPolicyListCombinationConfigurationsResponse> AuthenticationstrengthPolicyListCombinationConfigurationsAsync(AuthenticationstrengthPolicyListCombinationConfigurationsParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<AuthenticationstrengthPolicyListCombinationConfigurationsParameter, AuthenticationstrengthPolicyListCombinationConfigurationsResponse>(parameter, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/authenticationstrengthpolicy-list-combinationconfigurations?view=graph-rest-1.0
    /// </summary>
    public async IAsyncEnumerable<AuthenticationCombinationConfiguration> AuthenticationstrengthPolicyListCombinationConfigurationsEnumerateAsync(AuthenticationstrengthPolicyListCombinationConfigurationsParameter parameter, [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        var res = await this.SendAsync<AuthenticationstrengthPolicyListCombinationConfigurationsParameter, AuthenticationstrengthPolicyListCombinationConfigurationsResponse>(parameter, cancellationToken);
        if (res.Value != null)
        {
            foreach (var item in res.Value)
            {
                yield return item;
            }
            if (res.ODataNextLink.HasValue())
            {
                await foreach (var item in this.GetValueListAsync<AuthenticationCombinationConfiguration>(res.ODataNextLink, cancellationToken))
                {
                    yield return item;
                }
            }
        }
    }
}
