﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/workforceintegration-delete?view=graph-rest-1.0
/// </summary>
public partial class WorkforceintegrationDeleteParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? WorkforceIntegrationId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Teamwork_WorkforceIntegrations_WorkforceIntegrationId: return $"/teamwork/workforceIntegrations/{WorkforceIntegrationId}";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Teamwork_WorkforceIntegrations_WorkforceIntegrationId,
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
public partial class WorkforceintegrationDeleteResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/workforceintegration-delete?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/workforceintegration-delete?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorkforceintegrationDeleteResponse> WorkforceintegrationDeleteAsync()
    {
        var p = new WorkforceintegrationDeleteParameter();
        return await this.SendAsync<WorkforceintegrationDeleteParameter, WorkforceintegrationDeleteResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/workforceintegration-delete?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorkforceintegrationDeleteResponse> WorkforceintegrationDeleteAsync(CancellationToken cancellationToken)
    {
        var p = new WorkforceintegrationDeleteParameter();
        return await this.SendAsync<WorkforceintegrationDeleteParameter, WorkforceintegrationDeleteResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/workforceintegration-delete?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorkforceintegrationDeleteResponse> WorkforceintegrationDeleteAsync(WorkforceintegrationDeleteParameter parameter)
    {
        return await this.SendAsync<WorkforceintegrationDeleteParameter, WorkforceintegrationDeleteResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/workforceintegration-delete?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorkforceintegrationDeleteResponse> WorkforceintegrationDeleteAsync(WorkforceintegrationDeleteParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<WorkforceintegrationDeleteParameter, WorkforceintegrationDeleteResponse>(parameter, cancellationToken);
    }
}
