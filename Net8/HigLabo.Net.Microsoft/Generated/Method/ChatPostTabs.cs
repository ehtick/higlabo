﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/chat-post-tabs?view=graph-rest-1.0
/// </summary>
public partial class ChatPostTabsParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? ChatId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Chats_ChatId_Tabs: return $"/chats/{ChatId}/tabs";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Chats_ChatId_Tabs,
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
    public TeamsTabConfiguration? Configuration { get; set; }
    public string? DisplayName { get; set; }
    public string? Id { get; set; }
    public string? WebUrl { get; set; }
    public TeamsApp? TeamsApp { get; set; }
}
public partial class ChatPostTabsResponse : RestApiResponse
{
    public TeamsTabConfiguration? Configuration { get; set; }
    public string? DisplayName { get; set; }
    public string? Id { get; set; }
    public string? WebUrl { get; set; }
    public TeamsApp? TeamsApp { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/chat-post-tabs?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/chat-post-tabs?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChatPostTabsResponse> ChatPostTabsAsync()
    {
        var p = new ChatPostTabsParameter();
        return await this.SendAsync<ChatPostTabsParameter, ChatPostTabsResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/chat-post-tabs?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChatPostTabsResponse> ChatPostTabsAsync(CancellationToken cancellationToken)
    {
        var p = new ChatPostTabsParameter();
        return await this.SendAsync<ChatPostTabsParameter, ChatPostTabsResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/chat-post-tabs?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChatPostTabsResponse> ChatPostTabsAsync(ChatPostTabsParameter parameter)
    {
        return await this.SendAsync<ChatPostTabsParameter, ChatPostTabsResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/chat-post-tabs?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChatPostTabsResponse> ChatPostTabsAsync(ChatPostTabsParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<ChatPostTabsParameter, ChatPostTabsResponse>(parameter, cancellationToken);
    }
}
