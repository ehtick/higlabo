﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/group-unsubscribebymail?view=graph-rest-1.0
/// </summary>
public partial class GroupUnsubscribebymailParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? Id { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Groups_Id_UnsubscribeByMail: return $"/groups/{Id}/unsubscribeByMail";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Groups_Id_UnsubscribeByMail,
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
public partial class GroupUnsubscribebymailResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/group-unsubscribebymail?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/group-unsubscribebymail?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<GroupUnsubscribebymailResponse> GroupUnsubscribebymailAsync()
    {
        var p = new GroupUnsubscribebymailParameter();
        return await this.SendAsync<GroupUnsubscribebymailParameter, GroupUnsubscribebymailResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/group-unsubscribebymail?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<GroupUnsubscribebymailResponse> GroupUnsubscribebymailAsync(CancellationToken cancellationToken)
    {
        var p = new GroupUnsubscribebymailParameter();
        return await this.SendAsync<GroupUnsubscribebymailParameter, GroupUnsubscribebymailResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/group-unsubscribebymail?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<GroupUnsubscribebymailResponse> GroupUnsubscribebymailAsync(GroupUnsubscribebymailParameter parameter)
    {
        return await this.SendAsync<GroupUnsubscribebymailParameter, GroupUnsubscribebymailResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/group-unsubscribebymail?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<GroupUnsubscribebymailResponse> GroupUnsubscribebymailAsync(GroupUnsubscribebymailParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<GroupUnsubscribebymailParameter, GroupUnsubscribebymailResponse>(parameter, cancellationToken);
    }
}
