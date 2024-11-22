﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Slack;

public partial class TeamIntegrationLogsParameter : IRestApiParameter
{
    string IRestApiParameter.ApiPath { get; } = "team.integrationLogs";
    string IRestApiParameter.HttpMethod { get; } = "GET";
    public string? App_Id { get; set; }
    public string? Change_Type { get; set; }
    public string? Count { get; set; }
    public string? Page { get; set; }
    public string? Service_Id { get; set; }
    public string? Team_Id { get; set; }
    public string? User { get; set; }
}
public partial class TeamIntegrationLogsResponse : RestApiResponse
{
}
/// <summary>
/// https://api.slack.com/methods/team.integrationLogs
/// </summary>
public partial class SlackClient
{
    /// <summary>
    /// https://api.slack.com/methods/team.integrationLogs
    /// </summary>
    public async ValueTask<TeamIntegrationLogsResponse> TeamIntegrationLogsAsync()
    {
        var p = new TeamIntegrationLogsParameter();
        return await this.SendAsync<TeamIntegrationLogsParameter, TeamIntegrationLogsResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/team.integrationLogs
    /// </summary>
    public async ValueTask<TeamIntegrationLogsResponse> TeamIntegrationLogsAsync(CancellationToken cancellationToken)
    {
        var p = new TeamIntegrationLogsParameter();
        return await this.SendAsync<TeamIntegrationLogsParameter, TeamIntegrationLogsResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://api.slack.com/methods/team.integrationLogs
    /// </summary>
    public async ValueTask<TeamIntegrationLogsResponse> TeamIntegrationLogsAsync(TeamIntegrationLogsParameter parameter)
    {
        return await this.SendAsync<TeamIntegrationLogsParameter, TeamIntegrationLogsResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/team.integrationLogs
    /// </summary>
    public async ValueTask<TeamIntegrationLogsResponse> TeamIntegrationLogsAsync(TeamIntegrationLogsParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<TeamIntegrationLogsParameter, TeamIntegrationLogsResponse>(parameter, cancellationToken);
    }
}
