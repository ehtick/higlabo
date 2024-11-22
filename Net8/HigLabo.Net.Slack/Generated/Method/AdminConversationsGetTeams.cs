﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Slack;

public partial class AdminConversationsGetTeamsParameter : IRestApiParameter, IRestApiPagingParameter
{
    string IRestApiParameter.ApiPath { get; } = "admin.conversations.getTeams";
    string IRestApiParameter.HttpMethod { get; } = "POST";
    public string? Channel_Id { get; set; }
    public string? Cursor { get; set; }
    string? IRestApiPagingParameter.NextPageToken
    {
        get
        {
            return this.Cursor;
        }
        set
        {
            this.Cursor = value;
        }
    }
    public int? Limit { get; set; }
}
public partial class AdminConversationsGetTeamsResponse : RestApiResponse
{
}
/// <summary>
/// https://api.slack.com/methods/admin.conversations.getTeams
/// </summary>
public partial class SlackClient
{
    /// <summary>
    /// https://api.slack.com/methods/admin.conversations.getTeams
    /// </summary>
    public async ValueTask<AdminConversationsGetTeamsResponse> AdminConversationsGetTeamsAsync(string? channel_Id)
    {
        var p = new AdminConversationsGetTeamsParameter();
        p.Channel_Id = channel_Id;
        return await this.SendAsync<AdminConversationsGetTeamsParameter, AdminConversationsGetTeamsResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/admin.conversations.getTeams
    /// </summary>
    public async ValueTask<AdminConversationsGetTeamsResponse> AdminConversationsGetTeamsAsync(string? channel_Id, CancellationToken cancellationToken)
    {
        var p = new AdminConversationsGetTeamsParameter();
        p.Channel_Id = channel_Id;
        return await this.SendAsync<AdminConversationsGetTeamsParameter, AdminConversationsGetTeamsResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://api.slack.com/methods/admin.conversations.getTeams
    /// </summary>
    public async ValueTask<AdminConversationsGetTeamsResponse> AdminConversationsGetTeamsAsync(AdminConversationsGetTeamsParameter parameter)
    {
        return await this.SendAsync<AdminConversationsGetTeamsParameter, AdminConversationsGetTeamsResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/admin.conversations.getTeams
    /// </summary>
    public async ValueTask<AdminConversationsGetTeamsResponse> AdminConversationsGetTeamsAsync(AdminConversationsGetTeamsParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<AdminConversationsGetTeamsParameter, AdminConversationsGetTeamsResponse>(parameter, cancellationToken);
    }
    /// <summary>
    /// https://api.slack.com/methods/admin.conversations.getTeams
    /// </summary>
    public async ValueTask<List<AdminConversationsGetTeamsResponse>> AdminConversationsGetTeamsAsync(string? channel_Id, PagingContext<AdminConversationsGetTeamsResponse> context)
    {
        var p = new AdminConversationsGetTeamsParameter();
        p.Channel_Id = channel_Id;
        return await this.SendBatchAsync(p, context, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/admin.conversations.getTeams
    /// </summary>
    public async ValueTask<List<AdminConversationsGetTeamsResponse>> AdminConversationsGetTeamsAsync(string? channel_Id, PagingContext<AdminConversationsGetTeamsResponse> context, CancellationToken cancellationToken)
    {
        var p = new AdminConversationsGetTeamsParameter();
        p.Channel_Id = channel_Id;
        return await this.SendBatchAsync(p, context, cancellationToken);
    }
    /// <summary>
    /// https://api.slack.com/methods/admin.conversations.getTeams
    /// </summary>
    public async ValueTask<List<AdminConversationsGetTeamsResponse>> AdminConversationsGetTeamsAsync(AdminConversationsGetTeamsParameter parameter, PagingContext<AdminConversationsGetTeamsResponse> context)
    {
        return await this.SendBatchAsync(parameter, context, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/admin.conversations.getTeams
    /// </summary>
    public async ValueTask<List<AdminConversationsGetTeamsResponse>> AdminConversationsGetTeamsAsync(AdminConversationsGetTeamsParameter parameter, PagingContext<AdminConversationsGetTeamsResponse> context, CancellationToken cancellationToken)
    {
        return await this.SendBatchAsync(parameter, context, cancellationToken);
    }
}
