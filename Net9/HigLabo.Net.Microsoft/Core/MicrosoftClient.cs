﻿using HigLabo.Core;
using HigLabo.Net.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HigLabo.Net.Microsoft;

public partial class MicrosoftClient : OAuthClient
{
    public event EventHandler<AccessTokenUpdatedEventArgs<RequestCodeResponse>>? AccessTokenUpdated;

    public RestApiDomainName DomainName { get; set; } = RestApiDomainName.Graph;
    public String TenantName { get; set; } = "";

    public String ApiDomain
    {
        get
        {
            switch (this.DomainName)
            {
                case RestApiDomainName.Graph: return "https://graph.microsoft.com/v1.0";
                case RestApiDomainName.Sharepoint: return $"https://{this.TenantName}.sharepoint.com/_api/v2.0";
                default: throw SwitchStatementNotImplementException.Create(this.DomainName);
            }
        }
    }

    public MicrosoftClient(HttpClient httpClient)
      : base(httpClient, new MicrosoftJsonConverter())
    {
    }
    public MicrosoftClient(HttpClient httpClient, OAuthSetting setting)
      : base(httpClient, new MicrosoftJsonConverter())
    {
        this.OAuthSetting = setting;
    }

    private HttpRequestMessage CreateHttpRequestMessage(String url, HttpMethod httpMethod, string consistencyLevel)
    {
        var mg = new HttpRequestMessage(httpMethod, url);
        mg.Headers.Authorization = new AuthenticationHeaderValue("Bearer", this.AccessToken);
        mg.Headers.TryAddWithoutValidation("Accept", "application/json");
        if (consistencyLevel.HasValue())
        {
            mg.Headers.TryAddWithoutValidation("ConsistencyLevel", consistencyLevel);
        }
        return mg;
    }

    public async ValueTask<TResponse> SendAsync<TResponse>(ODataNextLinkParameter parameter)
        where TResponse : RestApiResponse
    {
        return await SendAsync<TResponse>(parameter, CancellationToken.None);
    }
    public async ValueTask<TResponse> SendAsync<TResponse>(ODataNextLinkParameter parameter, CancellationToken cancellationToken)
        where TResponse : RestApiResponse
    {
        var consistencyLevel = "";
        var p = parameter;
        if (parameter is IQueryParameterProperty q)
        {
            consistencyLevel = q.Query.ConsistencyLevel;
        }
        try
        {
            return await this.SendAsync<TResponse>(this.CreateHttpRequestMessage(p.Url, new HttpMethod("GET"), consistencyLevel), cancellationToken);
        }
        catch
        {
            await this.ProcessAccessTokenAsync();
        }
        return await this.SendAsync<TResponse>(this.CreateHttpRequestMessage(p.Url, new HttpMethod("GET"), consistencyLevel), cancellationToken);
    }
    public override async ValueTask<TResponse> SendAsync<TParameter, TResponse>(TParameter parameter, CancellationToken cancellationToken)
    {
        var consistencyLevel = "";
        if (string.Equals(parameter.HttpMethod, "GET", StringComparison.OrdinalIgnoreCase))
        {
            var url = this.ApiDomain + parameter.ApiPath;
            if (parameter is IQueryParameterProperty q)
            {
                var queryString = q.Query.GetQueryString();
                if (queryString.IsNullOrEmpty() == false)
                {
                    url = url + "?" + queryString;
                }
                consistencyLevel = q.Query.ConsistencyLevel;
            }
            try
            {
                return await this.SendAsync<TResponse>(this.CreateHttpRequestMessage(url, new HttpMethod(parameter.HttpMethod), consistencyLevel), cancellationToken);
            }
            catch
            {
                await this.ProcessAccessTokenAsync();
            }
            return await this.SendAsync<TResponse>(this.CreateHttpRequestMessage(url, new HttpMethod(parameter.HttpMethod), consistencyLevel), cancellationToken);
        }
        else
        {
            try
            {
                return await this.SendJsonAsync<TResponse>(this.CreateHttpRequestMessage(this.ApiDomain + parameter.ApiPath, new HttpMethod(parameter.HttpMethod), consistencyLevel), parameter, cancellationToken);
            }
            catch
            {
                await this.ProcessAccessTokenAsync();
            }
            return await this.SendJsonAsync<TResponse>(this.CreateHttpRequestMessage(this.ApiDomain + parameter.ApiPath, new HttpMethod(parameter.HttpMethod), consistencyLevel), parameter, cancellationToken);
        }
    }
    public async ValueTask<Stream> DownloadStreamAsync(IRestApiParameter parameter, CancellationToken cancellationToken)
    {
        var p = parameter;
        var queryString = "";
        var consistencyLevel = "";
        if (parameter is IQueryParameterProperty q)
        {
            queryString = q.Query.GetQueryString();
            consistencyLevel = q.Query.ConsistencyLevel;
        }
        try
        {
            return await this.DownloadStreamAsync(this.CreateHttpRequestMessage(this.ApiDomain + p.ApiPath + "?" + queryString, new HttpMethod(p.HttpMethod), consistencyLevel), cancellationToken);
        }
        catch
        {
            await this.ProcessAccessTokenAsync();
        }
        return await this.DownloadStreamAsync(this.CreateHttpRequestMessage(this.ApiDomain + p.ApiPath + "?" + queryString, new HttpMethod(p.HttpMethod), consistencyLevel), cancellationToken);
    }

    public async IAsyncEnumerable<T> GetValueListAsync<T>(string nextLink, [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        if (nextLink.HasValue())
        {
            var url = nextLink;
            while (true)
            {
                var res1 = await this.SendAsync<RestApiResponse<T>>(new ODataNextLinkParameter(url));
                if (res1.Value == null) { yield break; }

                foreach (var item in res1.Value)
                {
                    yield return item;
                }
                url = res1.ODataNextLink;
                if (url.IsNullOrEmpty()) { yield break; }
            }
        }
    }

    protected async ValueTask ProcessAccessTokenAsync()
    {
        var result = await this.UpdateAccessTokenAsync();
        if (((IRestApiResponse)result).StatusCode == HttpStatusCode.OK)
        {
            this.AccessToken = result.Access_Token;
            this.RefreshToken = result.Refresh_Token;
        }
    }
    public async ValueTask<RequestCodeResponse> RequestCodeAsync(string code)
    {
        if (this.OAuthSetting == null)
        { throw new InvalidOperationException("AuthorizationUrlBuilder property is null. Please set MicrosoftClient.OAuthSetting property."); }

        var cl = this.HttpClient;
        var b = (OAuthSetting)this.OAuthSetting;
        var req = new HttpRequestMessage(HttpMethod.Post, "https://login.microsoftonline.com/common/oauth2/v2.0/token");

        var d = new Dictionary<string, string>();
        d["code"] = code;
        d["grant_type"] = "authorization_code";
        d["access_type"] = "offline";
        d["client_id"] = b.ClientId;
        d["client_secret"] = b.ClientSecret;
        d["redirect_uri"] = b.RedirectUrl;
        req.Content = new FormUrlEncodedContent(d);

        var res = await cl.SendAsync(req);
        var bodyText = await res.Content.ReadAsStringAsync();
        var o = this.ParseRequestCodeResponse<RequestCodeResponse>(d, req, res, bodyText);
        if (res.StatusCode != HttpStatusCode.OK)
        {
            throw new RestApiException(o);
        }
        return o;
    }
    public async ValueTask<RequestCodeResponse> UpdateAccessTokenAsync()
    {
        if (this.OAuthSetting == null)
        { throw new InvalidOperationException("AuthorizationUrlBuilder property is null. Please set MicrosoftClient.OAuthSetting property."); }

        var cl = this.HttpClient;
        var b = (OAuthSetting)this.OAuthSetting;
        var req = new HttpRequestMessage(HttpMethod.Post, "https://login.microsoftonline.com/common/oauth2/v2.0/token");

        var d = new Dictionary<string, string>();
        d["client_id"] = b.ClientId;
        d["client_secret"] = b.ClientSecret;
        d["grant_type"] = "refresh_token";
        d["refresh_token"] = this.RefreshToken;
        d["scope"] = String.Join(" ", b.ScopeList.Select(el => el.GetScopeName()));
        d["redirect_uri"] = b.RedirectUrl;
        req.Content = new FormUrlEncodedContent(d);

        var res = await cl.SendAsync(req);
        var bodyText = await res.Content.ReadAsStringAsync();
        var o = this.ParseRequestCodeResponse<RequestCodeResponse>(d, req, res, bodyText);
        if (o is IRestApiResponse iRes && iRes.StatusCode == HttpStatusCode.OK)
        {
            this.OnAccessTokenUpdated(new AccessTokenUpdatedEventArgs<RequestCodeResponse>(o));
        }
        else
        {
            throw new RestApiException(o);
        }
        return o;
    }
    public async ValueTask<RequestCodeResponse> RequestClientCredentialsAsync()
    {
        if (this.OAuthSetting == null)
        { throw new InvalidOperationException("AuthorizationUrlBuilder property is null. Please set MicrosoftClient.OAuthSetting property."); }

        var cl = this.HttpClient;
        var b = (OAuthSetting)this.OAuthSetting;
        var req = new HttpRequestMessage(HttpMethod.Post, "https://login.microsoftonline.com/common/oauth2/v2.0/token");

        var d = new Dictionary<string, string>();
        d["client_id"] = b.ClientId;
        d["client_secret"] = b.ClientSecret;
        d["grant_type"] = "client_credentials";
        d["scope"] = "https://graph.microsoft.com/.default";
        d["redirect_uri"] = b.RedirectUrl;
        req.Content = new FormUrlEncodedContent(d);

        var res = await cl.SendAsync(req);
        var bodyText = await res.Content.ReadAsStringAsync();
        var o = this.ParseRequestCodeResponse<RequestCodeResponse>(d, req, res, bodyText);
        if (o is IRestApiResponse iRes && iRes.StatusCode == HttpStatusCode.OK)
        {
            this.OnAccessTokenUpdated(new AccessTokenUpdatedEventArgs<RequestCodeResponse>(o));
        }
        else
        {
            throw new RestApiException(o);
        }
        return o;
    }

    protected void OnAccessTokenUpdated(AccessTokenUpdatedEventArgs<RequestCodeResponse> e)
    {
        this.AccessTokenUpdated?.Invoke(this, e);
    }
}
