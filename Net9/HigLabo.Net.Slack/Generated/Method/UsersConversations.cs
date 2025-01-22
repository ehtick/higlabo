﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Slack;

public partial class UsersConversationsParameter : IRestApiParameter, IRestApiPagingParameter
{
    string IRestApiParameter.ApiPath { get; } = "users.conversations";
    string IRestApiParameter.HttpMethod { get; } = "GET";
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
    public bool? Exclude_Archived { get; set; }
    public double? Limit { get; set; }
    public string? Team_Id { get; set; }
    public string? Types { get; set; }
    public string? User { get; set; }
}
public partial class UsersConversationsResponse : RestApiResponse
{
}
/// <summary>
/// https://api.slack.com/methods/users.conversations
/// </summary>
public partial class SlackClient
{
    /// <summary>
    /// https://api.slack.com/methods/users.conversations
    /// </summary>
    public async ValueTask<UsersConversationsResponse> UsersConversationsAsync()
    {
        var p = new UsersConversationsParameter();
        return await this.SendAsync<UsersConversationsParameter, UsersConversationsResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/users.conversations
    /// </summary>
    public async ValueTask<UsersConversationsResponse> UsersConversationsAsync(CancellationToken cancellationToken)
    {
        var p = new UsersConversationsParameter();
        return await this.SendAsync<UsersConversationsParameter, UsersConversationsResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://api.slack.com/methods/users.conversations
    /// </summary>
    public async ValueTask<UsersConversationsResponse> UsersConversationsAsync(UsersConversationsParameter parameter)
    {
        return await this.SendAsync<UsersConversationsParameter, UsersConversationsResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/users.conversations
    /// </summary>
    public async ValueTask<UsersConversationsResponse> UsersConversationsAsync(UsersConversationsParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<UsersConversationsParameter, UsersConversationsResponse>(parameter, cancellationToken);
    }
    /// <summary>
    /// https://api.slack.com/methods/users.conversations
    /// </summary>
    public async ValueTask<List<UsersConversationsResponse>> UsersConversationsAsync(PagingContext<UsersConversationsResponse> context)
    {
        var p = new UsersConversationsParameter();
        return await this.SendBatchAsync(p, context, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/users.conversations
    /// </summary>
    public async ValueTask<List<UsersConversationsResponse>> UsersConversationsAsync(CancellationToken cancellationToken, PagingContext<UsersConversationsResponse> context)
    {
        var p = new UsersConversationsParameter();
        return await this.SendBatchAsync(p, context, cancellationToken);
    }
    /// <summary>
    /// https://api.slack.com/methods/users.conversations
    /// </summary>
    public async ValueTask<List<UsersConversationsResponse>> UsersConversationsAsync(UsersConversationsParameter parameter, PagingContext<UsersConversationsResponse> context)
    {
        return await this.SendBatchAsync(parameter, context, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/users.conversations
    /// </summary>
    public async ValueTask<List<UsersConversationsResponse>> UsersConversationsAsync(UsersConversationsParameter parameter, PagingContext<UsersConversationsResponse> context, CancellationToken cancellationToken)
    {
        return await this.SendBatchAsync(parameter, context, cancellationToken);
    }
}
