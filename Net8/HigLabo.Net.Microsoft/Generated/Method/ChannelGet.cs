﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/channel-get?view=graph-rest-1.0
    /// </summary>
    public partial class ChannelGetParameter : IRestApiParameter, IQueryParameterProperty
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
                    case ApiPath.Teams_TeamId_Channels_ChannelId: return $"/teams/{TeamId}/channels/{ChannelId}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            Teams_TeamId_Channels_ChannelId,
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
    public partial class ChannelGetResponse : RestApiResponse
    {
        public enum ChannelChannelMembershipType
        {
            Standard,
            Private,
            UnknownFutureValue,
            Shared,
        }

        public DateTimeOffset? CreatedDateTime { get; set; }
        public string? Description { get; set; }
        public string? DisplayName { get; set; }
        public string? Email { get; set; }
        public string? Id { get; set; }
        public bool? IsFavoriteByDefault { get; set; }
        public Channel? MembershipType { get; set; }
        public string? TenantId { get; set; }
        public string? WebUrl { get; set; }
        public DriveItem? FilesFolder { get; set; }
        public ConversationMember[]? Members { get; set; }
        public ChatMessage[]? Messages { get; set; }
        public TeamsASyncOperation[]? Operations { get; set; }
        public SharedWithChannelTeamInfo[]? SharedWithTeams { get; set; }
        public TeamsTab[]? Tabs { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/channel-get?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/channel-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ChannelGetResponse> ChannelGetAsync()
        {
            var p = new ChannelGetParameter();
            return await this.SendAsync<ChannelGetParameter, ChannelGetResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/channel-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ChannelGetResponse> ChannelGetAsync(CancellationToken cancellationToken)
        {
            var p = new ChannelGetParameter();
            return await this.SendAsync<ChannelGetParameter, ChannelGetResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/channel-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ChannelGetResponse> ChannelGetAsync(ChannelGetParameter parameter)
        {
            return await this.SendAsync<ChannelGetParameter, ChannelGetResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/channel-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ChannelGetResponse> ChannelGetAsync(ChannelGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ChannelGetParameter, ChannelGetResponse>(parameter, cancellationToken);
        }
    }
}
