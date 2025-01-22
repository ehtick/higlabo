﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/group-post-conversations?view=graph-rest-1.0
/// </summary>
public partial class GroupPostConversationsParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? Id { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Groups_Id_Conversations: return $"/groups/{Id}/conversations";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Groups_Id_Conversations,
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
    public bool? HasAttachments { get; set; }
    public string? Id { get; set; }
    public DateTimeOffset? LastDeliveredDateTime { get; set; }
    public string? Preview { get; set; }
    public string? Topic { get; set; }
    public String[]? UniqueSenders { get; set; }
    public ConversationThread[]? Threads { get; set; }
}
public partial class GroupPostConversationsResponse : RestApiResponse
{
    public bool? HasAttachments { get; set; }
    public string? Id { get; set; }
    public DateTimeOffset? LastDeliveredDateTime { get; set; }
    public string? Preview { get; set; }
    public string? Topic { get; set; }
    public String[]? UniqueSenders { get; set; }
    public ConversationThread[]? Threads { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/group-post-conversations?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/group-post-conversations?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<GroupPostConversationsResponse> GroupPostConversationsAsync()
    {
        var p = new GroupPostConversationsParameter();
        return await this.SendAsync<GroupPostConversationsParameter, GroupPostConversationsResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/group-post-conversations?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<GroupPostConversationsResponse> GroupPostConversationsAsync(CancellationToken cancellationToken)
    {
        var p = new GroupPostConversationsParameter();
        return await this.SendAsync<GroupPostConversationsParameter, GroupPostConversationsResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/group-post-conversations?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<GroupPostConversationsResponse> GroupPostConversationsAsync(GroupPostConversationsParameter parameter)
    {
        return await this.SendAsync<GroupPostConversationsParameter, GroupPostConversationsResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/group-post-conversations?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<GroupPostConversationsResponse> GroupPostConversationsAsync(GroupPostConversationsParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<GroupPostConversationsParameter, GroupPostConversationsResponse>(parameter, cancellationToken);
    }
}
