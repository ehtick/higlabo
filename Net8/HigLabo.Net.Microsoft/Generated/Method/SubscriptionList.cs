﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/subscription-list?view=graph-rest-1.0
    /// </summary>
    public partial class SubscriptionListParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Subscriptions: return $"/subscriptions";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            Subscriptions,
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
    public partial class SubscriptionListResponse : RestApiResponse
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
    /// https://learn.microsoft.com/en-us/graph/api/subscription-list?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/subscription-list?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<SubscriptionListResponse> SubscriptionListAsync()
        {
            var p = new SubscriptionListParameter();
            return await this.SendAsync<SubscriptionListParameter, SubscriptionListResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/subscription-list?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<SubscriptionListResponse> SubscriptionListAsync(CancellationToken cancellationToken)
        {
            var p = new SubscriptionListParameter();
            return await this.SendAsync<SubscriptionListParameter, SubscriptionListResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/subscription-list?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<SubscriptionListResponse> SubscriptionListAsync(SubscriptionListParameter parameter)
        {
            return await this.SendAsync<SubscriptionListParameter, SubscriptionListResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/subscription-list?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<SubscriptionListResponse> SubscriptionListAsync(SubscriptionListParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<SubscriptionListParameter, SubscriptionListResponse>(parameter, cancellationToken);
        }
    }
}
