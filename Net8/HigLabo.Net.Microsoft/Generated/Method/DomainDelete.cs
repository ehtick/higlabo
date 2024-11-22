﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/domain-delete?view=graph-rest-1.0
/// </summary>
public partial class DomainDeleteParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? Id { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Domains_Id: return $"/domains/{Id}";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Domains_Id,
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
public partial class DomainDeleteResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/domain-delete?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/domain-delete?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<DomainDeleteResponse> DomainDeleteAsync()
    {
        var p = new DomainDeleteParameter();
        return await this.SendAsync<DomainDeleteParameter, DomainDeleteResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/domain-delete?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<DomainDeleteResponse> DomainDeleteAsync(CancellationToken cancellationToken)
    {
        var p = new DomainDeleteParameter();
        return await this.SendAsync<DomainDeleteParameter, DomainDeleteResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/domain-delete?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<DomainDeleteResponse> DomainDeleteAsync(DomainDeleteParameter parameter)
    {
        return await this.SendAsync<DomainDeleteParameter, DomainDeleteResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/domain-delete?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<DomainDeleteResponse> DomainDeleteAsync(DomainDeleteParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<DomainDeleteParameter, DomainDeleteResponse>(parameter, cancellationToken);
    }
}
