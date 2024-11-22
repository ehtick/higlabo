﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/servicehealthissue-get?view=graph-rest-1.0
/// </summary>
public partial class ServicehealthissueGetParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? ServiceHealthIssueId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Admin_ServiceAnnouncement_Issues_ServiceHealthIssueId: return $"/admin/serviceAnnouncement/issues/{ServiceHealthIssueId}";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Admin_ServiceAnnouncement_Issues_ServiceHealthIssueId,
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
public partial class ServicehealthissueGetResponse : RestApiResponse
{
    public enum ServiceHealthIssueServiceHealthClassificationType
    {
        Advisory,
        Incident,
        UnknownFutureValue,
    }
    public enum ServiceHealthIssueServiceHealthOrigin
    {
        Microsoft,
        ThirdParty,
        Customer,
        UnknownFutureValue,
    }
    public enum ServiceHealthIssueServiceHealthStatus
    {
        ServiceOperational,
        Investigating,
        RestoringService,
        VerifyingService,
        ServiceRestored,
        PostIncidentReviewPublished,
        ServiceDegradation,
        ServiceInterruption,
        ExtendedRecovery,
        FalsePositive,
        InvestigationSuspended,
        Resolved,
        MitigatedExternal,
        Mitigated,
        ResolvedExternal,
        Confirmed,
        Reported,
        UnknownFutureValue,
    }

    public ServiceHealthIssueServiceHealthClassificationType Classification { get; set; }
    public KeyValuePair[]? Details { get; set; }
    public DateTimeOffset? EndDateTime { get; set; }
    public string? Feature { get; set; }
    public string? FeatureGroup { get; set; }
    public string? Id { get; set; }
    public string? ImpactDescription { get; set; }
    public bool? IsResolved { get; set; }
    public DateTimeOffset? LastModifiedDateTime { get; set; }
    public ServiceHealthIssueServiceHealthOrigin Origin { get; set; }
    public ServiceHealthIssuePost[]? Posts { get; set; }
    public string? Service { get; set; }
    public DateTimeOffset? StartDateTime { get; set; }
    public ServiceHealthIssueServiceHealthStatus Status { get; set; }
    public string? Title { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/servicehealthissue-get?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/servicehealthissue-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ServicehealthissueGetResponse> ServicehealthissueGetAsync()
    {
        var p = new ServicehealthissueGetParameter();
        return await this.SendAsync<ServicehealthissueGetParameter, ServicehealthissueGetResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/servicehealthissue-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ServicehealthissueGetResponse> ServicehealthissueGetAsync(CancellationToken cancellationToken)
    {
        var p = new ServicehealthissueGetParameter();
        return await this.SendAsync<ServicehealthissueGetParameter, ServicehealthissueGetResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/servicehealthissue-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ServicehealthissueGetResponse> ServicehealthissueGetAsync(ServicehealthissueGetParameter parameter)
    {
        return await this.SendAsync<ServicehealthissueGetParameter, ServicehealthissueGetResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/servicehealthissue-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ServicehealthissueGetResponse> ServicehealthissueGetAsync(ServicehealthissueGetParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<ServicehealthissueGetParameter, ServicehealthissueGetResponse>(parameter, cancellationToken);
    }
}
