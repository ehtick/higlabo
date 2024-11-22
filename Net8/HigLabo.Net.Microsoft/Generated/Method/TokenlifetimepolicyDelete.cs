﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/tokenlifetimepolicy-delete?view=graph-rest-1.0
/// </summary>
public partial class TokenlifetimePolicyDeleteParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? Id { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Policies_TokenLifetimePolicies_Id: return $"/policies/tokenLifetimePolicies/{Id}";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Policies_TokenLifetimePolicies_Id,
    }

    public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
    string IRestApiParameter.ApiPath
    {
        get
        {
            return this.ApiPathSetting.GetApiPath();
        }
    }
    string IRestApiParameter.HttpMethod { get; } = "DELETE";
}
public partial class TokenlifetimePolicyDeleteResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/tokenlifetimepolicy-delete?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/tokenlifetimepolicy-delete?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TokenlifetimePolicyDeleteResponse> TokenlifetimePolicyDeleteAsync()
    {
        var p = new TokenlifetimePolicyDeleteParameter();
        return await this.SendAsync<TokenlifetimePolicyDeleteParameter, TokenlifetimePolicyDeleteResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/tokenlifetimepolicy-delete?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TokenlifetimePolicyDeleteResponse> TokenlifetimePolicyDeleteAsync(CancellationToken cancellationToken)
    {
        var p = new TokenlifetimePolicyDeleteParameter();
        return await this.SendAsync<TokenlifetimePolicyDeleteParameter, TokenlifetimePolicyDeleteResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/tokenlifetimepolicy-delete?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TokenlifetimePolicyDeleteResponse> TokenlifetimePolicyDeleteAsync(TokenlifetimePolicyDeleteParameter parameter)
    {
        return await this.SendAsync<TokenlifetimePolicyDeleteParameter, TokenlifetimePolicyDeleteResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/tokenlifetimepolicy-delete?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TokenlifetimePolicyDeleteResponse> TokenlifetimePolicyDeleteAsync(TokenlifetimePolicyDeleteParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<TokenlifetimePolicyDeleteParameter, TokenlifetimePolicyDeleteResponse>(parameter, cancellationToken);
    }
}
