﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/channel-get-members?view=graph-rest-1.0
/// </summary>
public partial class ChannelGetMembersParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? TeamId { get; set; }
        public string? ChannelId { get; set; }
        public string? MembershipId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Teams_TeamId_Channels_ChannelId_Members_MembershipId: return $"/teams/{TeamId}/channels/{ChannelId}/members/{MembershipId}";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Teams_TeamId_Channels_ChannelId_Members_MembershipId,
    }

    public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
    string IRestApiParameter.ApiPath
    {
        get
        {
            return this.ApiPathSetting.GetApiPath();
        }
    }
    string IRestApiParameter.HttpMethod { get; } = "GET";
    public QueryParameter<Field> Query { get; set; } = new QueryParameter<Field>();
    IQueryParameter IQueryParameterProperty.Query
    {
        get
        {
            return this.Query;
        }
    }
}
public partial class ChannelGetMembersResponse : RestApiResponse
{
    public string? DisplayName { get; set; }
    public string? Id { get; set; }
    public string[]? Roles { get; set; }
    public DateTimeOffset? VisibleHistoryStartDateTime { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/channel-get-members?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/channel-get-members?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChannelGetMembersResponse> ChannelGetMembersAsync()
    {
        var p = new ChannelGetMembersParameter();
        return await this.SendAsync<ChannelGetMembersParameter, ChannelGetMembersResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/channel-get-members?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChannelGetMembersResponse> ChannelGetMembersAsync(CancellationToken cancellationToken)
    {
        var p = new ChannelGetMembersParameter();
        return await this.SendAsync<ChannelGetMembersParameter, ChannelGetMembersResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/channel-get-members?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChannelGetMembersResponse> ChannelGetMembersAsync(ChannelGetMembersParameter parameter)
    {
        return await this.SendAsync<ChannelGetMembersParameter, ChannelGetMembersResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/channel-get-members?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChannelGetMembersResponse> ChannelGetMembersAsync(ChannelGetMembersParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<ChannelGetMembersParameter, ChannelGetMembersResponse>(parameter, cancellationToken);
    }
}
