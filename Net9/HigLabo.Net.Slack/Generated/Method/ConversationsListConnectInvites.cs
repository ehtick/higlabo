﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Slack;

public partial class ConversationsListConnectInvitesParameter : IRestApiParameter, IRestApiPagingParameter
{
    string IRestApiParameter.ApiPath { get; } = "conversations.listConnectInvites";
    string IRestApiParameter.HttpMethod { get; } = "POST";
    public int? Count { get; set; }
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
    public string? Team_Id { get; set; }
}
public partial class ConversationsListConnectInvitesResponse : RestApiResponse
{
}
/// <summary>
/// https://api.slack.com/methods/conversations.listConnectInvites
/// </summary>
public partial class SlackClient
{
    /// <summary>
    /// https://api.slack.com/methods/conversations.listConnectInvites
    /// </summary>
    public async ValueTask<ConversationsListConnectInvitesResponse> ConversationsListConnectInvitesAsync()
    {
        var p = new ConversationsListConnectInvitesParameter();
        return await this.SendAsync<ConversationsListConnectInvitesParameter, ConversationsListConnectInvitesResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/conversations.listConnectInvites
    /// </summary>
    public async ValueTask<ConversationsListConnectInvitesResponse> ConversationsListConnectInvitesAsync(CancellationToken cancellationToken)
    {
        var p = new ConversationsListConnectInvitesParameter();
        return await this.SendAsync<ConversationsListConnectInvitesParameter, ConversationsListConnectInvitesResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://api.slack.com/methods/conversations.listConnectInvites
    /// </summary>
    public async ValueTask<ConversationsListConnectInvitesResponse> ConversationsListConnectInvitesAsync(ConversationsListConnectInvitesParameter parameter)
    {
        return await this.SendAsync<ConversationsListConnectInvitesParameter, ConversationsListConnectInvitesResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/conversations.listConnectInvites
    /// </summary>
    public async ValueTask<ConversationsListConnectInvitesResponse> ConversationsListConnectInvitesAsync(ConversationsListConnectInvitesParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<ConversationsListConnectInvitesParameter, ConversationsListConnectInvitesResponse>(parameter, cancellationToken);
    }
    /// <summary>
    /// https://api.slack.com/methods/conversations.listConnectInvites
    /// </summary>
    public async ValueTask<List<ConversationsListConnectInvitesResponse>> ConversationsListConnectInvitesAsync(PagingContext<ConversationsListConnectInvitesResponse> context)
    {
        var p = new ConversationsListConnectInvitesParameter();
        return await this.SendBatchAsync(p, context, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/conversations.listConnectInvites
    /// </summary>
    public async ValueTask<List<ConversationsListConnectInvitesResponse>> ConversationsListConnectInvitesAsync(CancellationToken cancellationToken, PagingContext<ConversationsListConnectInvitesResponse> context)
    {
        var p = new ConversationsListConnectInvitesParameter();
        return await this.SendBatchAsync(p, context, cancellationToken);
    }
    /// <summary>
    /// https://api.slack.com/methods/conversations.listConnectInvites
    /// </summary>
    public async ValueTask<List<ConversationsListConnectInvitesResponse>> ConversationsListConnectInvitesAsync(ConversationsListConnectInvitesParameter parameter, PagingContext<ConversationsListConnectInvitesResponse> context)
    {
        return await this.SendBatchAsync(parameter, context, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/conversations.listConnectInvites
    /// </summary>
    public async ValueTask<List<ConversationsListConnectInvitesResponse>> ConversationsListConnectInvitesAsync(ConversationsListConnectInvitesParameter parameter, PagingContext<ConversationsListConnectInvitesResponse> context, CancellationToken cancellationToken)
    {
        return await this.SendBatchAsync(parameter, context, cancellationToken);
    }
}
