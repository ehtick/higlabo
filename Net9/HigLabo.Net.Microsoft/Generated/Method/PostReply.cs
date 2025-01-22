﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/post-reply?view=graph-rest-1.0
/// </summary>
public partial class PostReplyParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? GroupsId { get; set; }
        public string? ThreadsId { get; set; }
        public string? PostsId { get; set; }
        public string? ConversationsId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Groups_Id_Threads_Id_Posts_Id_Reply: return $"/groups/{GroupsId}/threads/{ThreadsId}/posts/{PostsId}/reply";
                case ApiPath.Groups_Id_Conversations_Id_Threads_Id_Posts_Id_Reply: return $"/groups/{GroupsId}/conversations/{ConversationsId}/threads/{ThreadsId}/posts/{PostsId}/reply";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Groups_Id_Threads_Id_Posts_Id_Reply,
        Groups_Id_Conversations_Id_Threads_Id_Posts_Id_Reply,
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
    public Post? Post { get; set; }
}
public partial class PostReplyResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/post-reply?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/post-reply?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PostReplyResponse> PostReplyAsync()
    {
        var p = new PostReplyParameter();
        return await this.SendAsync<PostReplyParameter, PostReplyResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/post-reply?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PostReplyResponse> PostReplyAsync(CancellationToken cancellationToken)
    {
        var p = new PostReplyParameter();
        return await this.SendAsync<PostReplyParameter, PostReplyResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/post-reply?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PostReplyResponse> PostReplyAsync(PostReplyParameter parameter)
    {
        return await this.SendAsync<PostReplyParameter, PostReplyResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/post-reply?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PostReplyResponse> PostReplyAsync(PostReplyParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<PostReplyParameter, PostReplyResponse>(parameter, cancellationToken);
    }
}
