﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/callrecords-session-list?view=graph-rest-1.0
/// </summary>
public partial class CallrecordsSessionListParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? Id { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Communications_CallRecords_Id_Sessions: return $"/communications/callRecords/{Id}/sessions";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
        Callee,
        Caller,
        EndDateTime,
        FailureInfo,
        Id,
        Modalities,
        StartDateTime,
        Segments,
    }
    public enum ApiPath
    {
        Communications_CallRecords_Id_Sessions,
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
public partial class CallrecordsSessionListResponse : RestApiResponse
{
    public enum CallrecordsSessionCallRecordsModality
    {
        Unknown,
        Audio,
        Video,
        VideoBasedScreenSharing,
        Data,
        ScreenSharing,
        UnknownFutureValue,
    }

    public CallrecordsSession[]? Value { get; set; }
    public CallrecordsEndpoint? Callee { get; set; }
    public CallrecordsEndpoint? Caller { get; set; }
    public DateTimeOffset? EndDateTime { get; set; }
    public CallrecordsFailureinfo? FailureInfo { get; set; }
    public string? Id { get; set; }
    public CallrecordsSessionCallRecordsModality Modalities { get; set; }
    public DateTimeOffset? StartDateTime { get; set; }
    public CallrecordsSegment[]? Segments { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/callrecords-session-list?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/callrecords-session-list?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<CallrecordsSessionListResponse> CallrecordsSessionListAsync()
    {
        var p = new CallrecordsSessionListParameter();
        return await this.SendAsync<CallrecordsSessionListParameter, CallrecordsSessionListResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/callrecords-session-list?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<CallrecordsSessionListResponse> CallrecordsSessionListAsync(CancellationToken cancellationToken)
    {
        var p = new CallrecordsSessionListParameter();
        return await this.SendAsync<CallrecordsSessionListParameter, CallrecordsSessionListResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/callrecords-session-list?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<CallrecordsSessionListResponse> CallrecordsSessionListAsync(CallrecordsSessionListParameter parameter)
    {
        return await this.SendAsync<CallrecordsSessionListParameter, CallrecordsSessionListResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/callrecords-session-list?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<CallrecordsSessionListResponse> CallrecordsSessionListAsync(CallrecordsSessionListParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<CallrecordsSessionListParameter, CallrecordsSessionListResponse>(parameter, cancellationToken);
    }
}
