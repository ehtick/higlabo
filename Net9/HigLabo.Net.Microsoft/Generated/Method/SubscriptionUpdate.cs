﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/subscription-update?view=graph-rest-1.0
/// </summary>
public partial class SubscriptionUpdateParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? Id { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Subscriptions_Id: return $"/subscriptions/{Id}";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Subscriptions_Id,
    }

    public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
    string IRestApiParameter.ApiPath
    {
        get
        {
            return this.ApiPathSetting.GetApiPath();
        }
    }
    string IRestApiParameter.HttpMethod { get; } = "PATCH";
    public DateTimeOffset? ExpirationDateTime { get; set; }
}
public partial class SubscriptionUpdateResponse : RestApiResponse
{
    public string? ApplicationId { get; set; }
    public string? ChangeType { get; set; }
    public string? ClientState { get; set; }
    public string? CreatorId { get; set; }
    public string? EncryptionCertificate { get; set; }
    public string? EncryptionCertificateId { get; set; }
    public DateTimeOffset? ExpirationDateTime { get; set; }
    public string? Id { get; set; }
    public bool? IncludeResourceData { get; set; }
    public string? LatestSupportedTlsVersion { get; set; }
    public string? LifecycleNotificationUrl { get; set; }
    public string? NotificationQueryOptions { get; set; }
    public string? NotificationUrl { get; set; }
    public string? NotificationUrlAppId { get; set; }
    public string? Resource { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/subscription-update?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/subscription-update?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<SubscriptionUpdateResponse> SubscriptionUpdateAsync()
    {
        var p = new SubscriptionUpdateParameter();
        return await this.SendAsync<SubscriptionUpdateParameter, SubscriptionUpdateResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/subscription-update?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<SubscriptionUpdateResponse> SubscriptionUpdateAsync(CancellationToken cancellationToken)
    {
        var p = new SubscriptionUpdateParameter();
        return await this.SendAsync<SubscriptionUpdateParameter, SubscriptionUpdateResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/subscription-update?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<SubscriptionUpdateResponse> SubscriptionUpdateAsync(SubscriptionUpdateParameter parameter)
    {
        return await this.SendAsync<SubscriptionUpdateParameter, SubscriptionUpdateResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/subscription-update?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<SubscriptionUpdateResponse> SubscriptionUpdateAsync(SubscriptionUpdateParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<SubscriptionUpdateParameter, SubscriptionUpdateResponse>(parameter, cancellationToken);
    }
}
