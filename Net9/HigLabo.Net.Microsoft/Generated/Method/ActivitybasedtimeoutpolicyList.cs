﻿using HigLabo.Net.OAuth;
using System.Runtime.CompilerServices;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/activitybasedtimeoutpolicy-list?view=graph-rest-1.0
/// </summary>
public partial class ActivitybasedtimeoutPolicyListParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Olicies_ActivityBasedTimeoutPolicies: return $"/olicies/activityBasedTimeoutPolicies";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Olicies_ActivityBasedTimeoutPolicies,
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
public partial class ActivitybasedtimeoutPolicyListResponse : RestApiResponse<ActivityBasedTimeoutPolicy>
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/activitybasedtimeoutpolicy-list?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/activitybasedtimeoutpolicy-list?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ActivitybasedtimeoutPolicyListResponse> ActivitybasedtimeoutPolicyListAsync()
    {
        var p = new ActivitybasedtimeoutPolicyListParameter();
        return await this.SendAsync<ActivitybasedtimeoutPolicyListParameter, ActivitybasedtimeoutPolicyListResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/activitybasedtimeoutpolicy-list?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ActivitybasedtimeoutPolicyListResponse> ActivitybasedtimeoutPolicyListAsync(CancellationToken cancellationToken)
    {
        var p = new ActivitybasedtimeoutPolicyListParameter();
        return await this.SendAsync<ActivitybasedtimeoutPolicyListParameter, ActivitybasedtimeoutPolicyListResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/activitybasedtimeoutpolicy-list?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ActivitybasedtimeoutPolicyListResponse> ActivitybasedtimeoutPolicyListAsync(ActivitybasedtimeoutPolicyListParameter parameter)
    {
        return await this.SendAsync<ActivitybasedtimeoutPolicyListParameter, ActivitybasedtimeoutPolicyListResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/activitybasedtimeoutpolicy-list?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ActivitybasedtimeoutPolicyListResponse> ActivitybasedtimeoutPolicyListAsync(ActivitybasedtimeoutPolicyListParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<ActivitybasedtimeoutPolicyListParameter, ActivitybasedtimeoutPolicyListResponse>(parameter, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/activitybasedtimeoutpolicy-list?view=graph-rest-1.0
    /// </summary>
    public async IAsyncEnumerable<ActivityBasedTimeoutPolicy> ActivitybasedtimeoutPolicyListEnumerateAsync(ActivitybasedtimeoutPolicyListParameter parameter, [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        var res = await this.SendAsync<ActivitybasedtimeoutPolicyListParameter, ActivitybasedtimeoutPolicyListResponse>(parameter, cancellationToken);
        if (res.Value != null)
        {
            foreach (var item in res.Value)
            {
                yield return item;
            }
            if (res.ODataNextLink.HasValue())
            {
                await foreach (var item in this.GetValueListAsync<ActivityBasedTimeoutPolicy>(res.ODataNextLink, cancellationToken))
                {
                    yield return item;
                }
            }
        }
    }
}
