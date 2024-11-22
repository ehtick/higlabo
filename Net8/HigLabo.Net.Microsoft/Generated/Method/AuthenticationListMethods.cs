﻿using HigLabo.Net.OAuth;
using System.Runtime.CompilerServices;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/authentication-list-methods?view=graph-rest-1.0
/// </summary>
public partial class AuthenticationListMethodsParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? IdOrUserPrincipalName { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Me_Authentication_Methods: return $"/me/authentication/methods";
                case ApiPath.Users_IdOrUserPrincipalName_Authentication_Methods: return $"/users/{IdOrUserPrincipalName}/authentication/methods";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Me_Authentication_Methods,
        Users_IdOrUserPrincipalName_Authentication_Methods,
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
public partial class AuthenticationListMethodsResponse : RestApiResponse<AuthenticationMethod>
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/authentication-list-methods?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/authentication-list-methods?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<AuthenticationListMethodsResponse> AuthenticationListMethodsAsync()
    {
        var p = new AuthenticationListMethodsParameter();
        return await this.SendAsync<AuthenticationListMethodsParameter, AuthenticationListMethodsResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/authentication-list-methods?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<AuthenticationListMethodsResponse> AuthenticationListMethodsAsync(CancellationToken cancellationToken)
    {
        var p = new AuthenticationListMethodsParameter();
        return await this.SendAsync<AuthenticationListMethodsParameter, AuthenticationListMethodsResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/authentication-list-methods?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<AuthenticationListMethodsResponse> AuthenticationListMethodsAsync(AuthenticationListMethodsParameter parameter)
    {
        return await this.SendAsync<AuthenticationListMethodsParameter, AuthenticationListMethodsResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/authentication-list-methods?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<AuthenticationListMethodsResponse> AuthenticationListMethodsAsync(AuthenticationListMethodsParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<AuthenticationListMethodsParameter, AuthenticationListMethodsResponse>(parameter, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/authentication-list-methods?view=graph-rest-1.0
    /// </summary>
    public async IAsyncEnumerable<AuthenticationMethod> AuthenticationListMethodsEnumerateAsync(AuthenticationListMethodsParameter parameter, [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        var res = await this.SendAsync<AuthenticationListMethodsParameter, AuthenticationListMethodsResponse>(parameter, cancellationToken);
        if (res.Value != null)
        {
            foreach (var item in res.Value)
            {
                yield return item;
            }
            if (res.ODataNextLink.HasValue())
            {
                await foreach (var item in this.GetValueListAsync<AuthenticationMethod>(res.ODataNextLink, cancellationToken))
                {
                    yield return item;
                }
            }
        }
    }
}
