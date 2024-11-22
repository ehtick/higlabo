﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/plannerplan-delete?view=graph-rest-1.0
/// </summary>
public partial class PlannerplanDeleteParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? Id { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Planner_Plans_Id: return $"/planner/plans/{Id}";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Planner_Plans_Id,
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
public partial class PlannerplanDeleteResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/plannerplan-delete?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/plannerplan-delete?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PlannerplanDeleteResponse> PlannerplanDeleteAsync()
    {
        var p = new PlannerplanDeleteParameter();
        return await this.SendAsync<PlannerplanDeleteParameter, PlannerplanDeleteResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/plannerplan-delete?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PlannerplanDeleteResponse> PlannerplanDeleteAsync(CancellationToken cancellationToken)
    {
        var p = new PlannerplanDeleteParameter();
        return await this.SendAsync<PlannerplanDeleteParameter, PlannerplanDeleteResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/plannerplan-delete?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PlannerplanDeleteResponse> PlannerplanDeleteAsync(PlannerplanDeleteParameter parameter)
    {
        return await this.SendAsync<PlannerplanDeleteParameter, PlannerplanDeleteResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/plannerplan-delete?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PlannerplanDeleteResponse> PlannerplanDeleteAsync(PlannerplanDeleteParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<PlannerplanDeleteParameter, PlannerplanDeleteResponse>(parameter, cancellationToken);
    }
}
