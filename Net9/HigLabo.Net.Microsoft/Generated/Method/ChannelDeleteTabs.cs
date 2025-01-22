﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/channel-delete-tabs?view=graph-rest-1.0
/// </summary>
public partial class ChannelDeleteTabsParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? TeamId { get; set; }
        public string? ChannelId { get; set; }
        public string? TabId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Teams_TeamId_Channels_ChannelId_Tabs_TabId: return $"/teams/{TeamId}/channels/{ChannelId}/tabs/{TabId}";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Teams_TeamId_Channels_ChannelId_Tabs_TabId,
    }

    public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
    string IRestApiParameter.ApiPath
    {
        get
        {
            return this.ApiPathSetting.GetApiPath();
        }
    }
    string IRestApiParameter.HttpMethod { get; } = "DELETE";
}
public partial class ChannelDeleteTabsResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/channel-delete-tabs?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/channel-delete-tabs?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChannelDeleteTabsResponse> ChannelDeleteTabsAsync()
    {
        var p = new ChannelDeleteTabsParameter();
        return await this.SendAsync<ChannelDeleteTabsParameter, ChannelDeleteTabsResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/channel-delete-tabs?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChannelDeleteTabsResponse> ChannelDeleteTabsAsync(CancellationToken cancellationToken)
    {
        var p = new ChannelDeleteTabsParameter();
        return await this.SendAsync<ChannelDeleteTabsParameter, ChannelDeleteTabsResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/channel-delete-tabs?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChannelDeleteTabsResponse> ChannelDeleteTabsAsync(ChannelDeleteTabsParameter parameter)
    {
        return await this.SendAsync<ChannelDeleteTabsParameter, ChannelDeleteTabsResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/channel-delete-tabs?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChannelDeleteTabsResponse> ChannelDeleteTabsAsync(ChannelDeleteTabsParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<ChannelDeleteTabsParameter, ChannelDeleteTabsResponse>(parameter, cancellationToken);
    }
}
