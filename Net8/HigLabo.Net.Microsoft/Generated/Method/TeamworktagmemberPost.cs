﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/teamworktagmember-post?view=graph-rest-1.0
/// </summary>
public partial class TeamworktagMemberPostParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? TeamId { get; set; }
        public string? TeamworkTagId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Teams_TeamId_Tags_TeamworkTagId_Members: return $"/teams/{TeamId}/tags/{TeamworkTagId}/members";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Teams_TeamId_Tags_TeamworkTagId_Members,
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
    public string? UserId { get; set; }
    public string? DisplayName { get; set; }
    public string? Id { get; set; }
    public string? TenantId { get; set; }
}
public partial class TeamworktagMemberPostResponse : RestApiResponse
{
    public string? DisplayName { get; set; }
    public string? Id { get; set; }
    public string? TenantId { get; set; }
    public string? UserId { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/teamworktagmember-post?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/teamworktagmember-post?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TeamworktagMemberPostResponse> TeamworktagMemberPostAsync()
    {
        var p = new TeamworktagMemberPostParameter();
        return await this.SendAsync<TeamworktagMemberPostParameter, TeamworktagMemberPostResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/teamworktagmember-post?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TeamworktagMemberPostResponse> TeamworktagMemberPostAsync(CancellationToken cancellationToken)
    {
        var p = new TeamworktagMemberPostParameter();
        return await this.SendAsync<TeamworktagMemberPostParameter, TeamworktagMemberPostResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/teamworktagmember-post?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TeamworktagMemberPostResponse> TeamworktagMemberPostAsync(TeamworktagMemberPostParameter parameter)
    {
        return await this.SendAsync<TeamworktagMemberPostParameter, TeamworktagMemberPostResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/teamworktagmember-post?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TeamworktagMemberPostResponse> TeamworktagMemberPostAsync(TeamworktagMemberPostParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<TeamworktagMemberPostParameter, TeamworktagMemberPostResponse>(parameter, cancellationToken);
    }
}
