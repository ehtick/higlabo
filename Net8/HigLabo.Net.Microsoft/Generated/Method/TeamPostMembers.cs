﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/team-post-members?view=graph-rest-1.0
/// </summary>
public partial class TeamPostMembersParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? TeamId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Teams_TeamId_Members: return $"/teams/{TeamId}/members";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Teams_TeamId_Members,
    }

    public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
    string IRestApiParameter.ApiPath
    {
        get
        {
            return this.ApiPathSetting.GetApiPath();
        }
    }
    string IRestApiParameter.HttpMethod { get; } = "POST";
    public string? DisplayName { get; set; }
    public string? Id { get; set; }
    public string[]? Roles { get; set; }
    public DateTimeOffset? VisibleHistoryStartDateTime { get; set; }
}
public partial class TeamPostMembersResponse : RestApiResponse
{
    public string? DisplayName { get; set; }
    public string? Id { get; set; }
    public string[]? Roles { get; set; }
    public DateTimeOffset? VisibleHistoryStartDateTime { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/team-post-members?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/team-post-members?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TeamPostMembersResponse> TeamPostMembersAsync()
    {
        var p = new TeamPostMembersParameter();
        return await this.SendAsync<TeamPostMembersParameter, TeamPostMembersResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/team-post-members?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TeamPostMembersResponse> TeamPostMembersAsync(CancellationToken cancellationToken)
    {
        var p = new TeamPostMembersParameter();
        return await this.SendAsync<TeamPostMembersParameter, TeamPostMembersResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/team-post-members?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TeamPostMembersResponse> TeamPostMembersAsync(TeamPostMembersParameter parameter)
    {
        return await this.SendAsync<TeamPostMembersParameter, TeamPostMembersResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/team-post-members?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TeamPostMembersResponse> TeamPostMembersAsync(TeamPostMembersParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<TeamPostMembersParameter, TeamPostMembersResponse>(parameter, cancellationToken);
    }
}
