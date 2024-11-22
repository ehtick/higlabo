﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/projectrome-put-activity?view=graph-rest-1.0
/// </summary>
public partial class ProjectromePutActivityParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? AppActivityId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Me_Activities_AppActivityId: return $"/me/activities/{AppActivityId}";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Me_Activities_AppActivityId,
    }

    public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
    string IRestApiParameter.ApiPath
    {
        get
        {
            return this.ApiPathSetting.GetApiPath();
        }
    }
    string IRestApiParameter.HttpMethod { get; } = "PUT";
}
public partial class ProjectromePutActivityResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/projectrome-put-activity?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/projectrome-put-activity?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ProjectromePutActivityResponse> ProjectromePutActivityAsync()
    {
        var p = new ProjectromePutActivityParameter();
        return await this.SendAsync<ProjectromePutActivityParameter, ProjectromePutActivityResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/projectrome-put-activity?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ProjectromePutActivityResponse> ProjectromePutActivityAsync(CancellationToken cancellationToken)
    {
        var p = new ProjectromePutActivityParameter();
        return await this.SendAsync<ProjectromePutActivityParameter, ProjectromePutActivityResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/projectrome-put-activity?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ProjectromePutActivityResponse> ProjectromePutActivityAsync(ProjectromePutActivityParameter parameter)
    {
        return await this.SendAsync<ProjectromePutActivityParameter, ProjectromePutActivityResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/projectrome-put-activity?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ProjectromePutActivityResponse> ProjectromePutActivityAsync(ProjectromePutActivityParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<ProjectromePutActivityParameter, ProjectromePutActivityResponse>(parameter, cancellationToken);
    }
}
