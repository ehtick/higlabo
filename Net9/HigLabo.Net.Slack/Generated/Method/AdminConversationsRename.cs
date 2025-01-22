﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Slack;

public partial class AdminConversationsRenameParameter : IRestApiParameter
{
    string IRestApiParameter.ApiPath { get; } = "admin.conversations.rename";
    string IRestApiParameter.HttpMethod { get; } = "POST";
    public string? Channel_Id { get; set; }
    public string? Name { get; set; }
}
public partial class AdminConversationsRenameResponse : RestApiResponse
{
}
/// <summary>
/// https://api.slack.com/methods/admin.conversations.rename
/// </summary>
public partial class SlackClient
{
    /// <summary>
    /// https://api.slack.com/methods/admin.conversations.rename
    /// </summary>
    public async ValueTask<AdminConversationsRenameResponse> AdminConversationsRenameAsync(string? channel_Id, string? name)
    {
        var p = new AdminConversationsRenameParameter();
        p.Channel_Id = channel_Id;
        p.Name = name;
        return await this.SendAsync<AdminConversationsRenameParameter, AdminConversationsRenameResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/admin.conversations.rename
    /// </summary>
    public async ValueTask<AdminConversationsRenameResponse> AdminConversationsRenameAsync(string? channel_Id, string? name, CancellationToken cancellationToken)
    {
        var p = new AdminConversationsRenameParameter();
        p.Channel_Id = channel_Id;
        p.Name = name;
        return await this.SendAsync<AdminConversationsRenameParameter, AdminConversationsRenameResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://api.slack.com/methods/admin.conversations.rename
    /// </summary>
    public async ValueTask<AdminConversationsRenameResponse> AdminConversationsRenameAsync(AdminConversationsRenameParameter parameter)
    {
        return await this.SendAsync<AdminConversationsRenameParameter, AdminConversationsRenameResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/admin.conversations.rename
    /// </summary>
    public async ValueTask<AdminConversationsRenameResponse> AdminConversationsRenameAsync(AdminConversationsRenameParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<AdminConversationsRenameParameter, AdminConversationsRenameResponse>(parameter, cancellationToken);
    }
}
