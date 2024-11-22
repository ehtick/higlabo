﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/channel-post-members?view=graph-rest-1.0
/// </summary>
public partial class ChannelPostMembersParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? TeamId { get; set; }
        public string? ChannelId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Teams_TeamId_Channels_ChannelId_Members: return $"/teams/{TeamId}/channels/{ChannelId}/members";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Teams_TeamId_Channels_ChannelId_Members,
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
    public string[]? Roles { get; set; }
    public User? User { get; set; }
    public string? DisplayName { get; set; }
    public string? Id { get; set; }
    public DateTimeOffset? VisibleHistoryStartDateTime { get; set; }
}
public partial class ChannelPostMembersResponse : RestApiResponse
{
    public string? DisplayName { get; set; }
    public string? Id { get; set; }
    public string[]? Roles { get; set; }
    public DateTimeOffset? VisibleHistoryStartDateTime { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/channel-post-members?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/channel-post-members?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChannelPostMembersResponse> ChannelPostMembersAsync()
    {
        var p = new ChannelPostMembersParameter();
        return await this.SendAsync<ChannelPostMembersParameter, ChannelPostMembersResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/channel-post-members?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChannelPostMembersResponse> ChannelPostMembersAsync(CancellationToken cancellationToken)
    {
        var p = new ChannelPostMembersParameter();
        return await this.SendAsync<ChannelPostMembersParameter, ChannelPostMembersResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/channel-post-members?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChannelPostMembersResponse> ChannelPostMembersAsync(ChannelPostMembersParameter parameter)
    {
        return await this.SendAsync<ChannelPostMembersParameter, ChannelPostMembersResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/channel-post-members?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChannelPostMembersResponse> ChannelPostMembersAsync(ChannelPostMembersParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<ChannelPostMembersParameter, ChannelPostMembersResponse>(parameter, cancellationToken);
    }
}
