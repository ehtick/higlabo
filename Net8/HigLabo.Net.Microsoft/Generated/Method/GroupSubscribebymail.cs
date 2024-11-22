﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/group-subscribebymail?view=graph-rest-1.0
/// </summary>
public partial class GroupSubscribebymailParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? Id { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Groups_Id_SubscribeByMail: return $"/groups/{Id}/subscribeByMail";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Groups_Id_SubscribeByMail,
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
}
public partial class GroupSubscribebymailResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/group-subscribebymail?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/group-subscribebymail?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<GroupSubscribebymailResponse> GroupSubscribebymailAsync()
    {
        var p = new GroupSubscribebymailParameter();
        return await this.SendAsync<GroupSubscribebymailParameter, GroupSubscribebymailResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/group-subscribebymail?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<GroupSubscribebymailResponse> GroupSubscribebymailAsync(CancellationToken cancellationToken)
    {
        var p = new GroupSubscribebymailParameter();
        return await this.SendAsync<GroupSubscribebymailParameter, GroupSubscribebymailResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/group-subscribebymail?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<GroupSubscribebymailResponse> GroupSubscribebymailAsync(GroupSubscribebymailParameter parameter)
    {
        return await this.SendAsync<GroupSubscribebymailParameter, GroupSubscribebymailResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/group-subscribebymail?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<GroupSubscribebymailResponse> GroupSubscribebymailAsync(GroupSubscribebymailParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<GroupSubscribebymailParameter, GroupSubscribebymailResponse>(parameter, cancellationToken);
    }
}
