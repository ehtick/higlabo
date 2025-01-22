﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/security-list-securescores?view=graph-rest-1.0
/// </summary>
public partial class SecurityListSecureScoresParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Security_SecureScores: return $"/security/secureScores";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Security_SecureScores,
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
public partial class SecurityListSecureScoresResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/security-list-securescores?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/security-list-securescores?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<SecurityListSecureScoresResponse> SecurityListSecureScoresAsync()
    {
        var p = new SecurityListSecureScoresParameter();
        return await this.SendAsync<SecurityListSecureScoresParameter, SecurityListSecureScoresResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/security-list-securescores?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<SecurityListSecureScoresResponse> SecurityListSecureScoresAsync(CancellationToken cancellationToken)
    {
        var p = new SecurityListSecureScoresParameter();
        return await this.SendAsync<SecurityListSecureScoresParameter, SecurityListSecureScoresResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/security-list-securescores?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<SecurityListSecureScoresResponse> SecurityListSecureScoresAsync(SecurityListSecureScoresParameter parameter)
    {
        return await this.SendAsync<SecurityListSecureScoresParameter, SecurityListSecureScoresResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/security-list-securescores?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<SecurityListSecureScoresResponse> SecurityListSecureScoresAsync(SecurityListSecureScoresParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<SecurityListSecureScoresParameter, SecurityListSecureScoresResponse>(parameter, cancellationToken);
    }
}
