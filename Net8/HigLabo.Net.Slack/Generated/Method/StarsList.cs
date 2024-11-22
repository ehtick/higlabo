﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Slack;

public partial class StarsListParameter : IRestApiParameter, IRestApiPagingParameter
{
    string IRestApiParameter.ApiPath { get; } = "stars.list";
    string IRestApiParameter.HttpMethod { get; } = "GET";
    public int? Count { get; set; }
    public string? Cursor { get; set; }
    string? IRestApiPagingParameter.NextPageToken
    {
        get
        {
            return this.Cursor;
        }
        set
        {
            this.Cursor = value;
        }
    }
    public int? Limit { get; set; }
    public int? Page { get; set; }
    public string? Team_Id { get; set; }
}
public partial class StarsListResponse : RestApiResponse
{
}
/// <summary>
/// https://api.slack.com/methods/stars.list
/// </summary>
public partial class SlackClient
{
    /// <summary>
    /// https://api.slack.com/methods/stars.list
    /// </summary>
    public async ValueTask<StarsListResponse> StarsListAsync()
    {
        var p = new StarsListParameter();
        return await this.SendAsync<StarsListParameter, StarsListResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/stars.list
    /// </summary>
    public async ValueTask<StarsListResponse> StarsListAsync(CancellationToken cancellationToken)
    {
        var p = new StarsListParameter();
        return await this.SendAsync<StarsListParameter, StarsListResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://api.slack.com/methods/stars.list
    /// </summary>
    public async ValueTask<StarsListResponse> StarsListAsync(StarsListParameter parameter)
    {
        return await this.SendAsync<StarsListParameter, StarsListResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/stars.list
    /// </summary>
    public async ValueTask<StarsListResponse> StarsListAsync(StarsListParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<StarsListParameter, StarsListResponse>(parameter, cancellationToken);
    }
    /// <summary>
    /// https://api.slack.com/methods/stars.list
    /// </summary>
    public async ValueTask<List<StarsListResponse>> StarsListAsync(PagingContext<StarsListResponse> context)
    {
        var p = new StarsListParameter();
        return await this.SendBatchAsync(p, context, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/stars.list
    /// </summary>
    public async ValueTask<List<StarsListResponse>> StarsListAsync(CancellationToken cancellationToken, PagingContext<StarsListResponse> context)
    {
        var p = new StarsListParameter();
        return await this.SendBatchAsync(p, context, cancellationToken);
    }
    /// <summary>
    /// https://api.slack.com/methods/stars.list
    /// </summary>
    public async ValueTask<List<StarsListResponse>> StarsListAsync(StarsListParameter parameter, PagingContext<StarsListResponse> context)
    {
        return await this.SendBatchAsync(parameter, context, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/stars.list
    /// </summary>
    public async ValueTask<List<StarsListResponse>> StarsListAsync(StarsListParameter parameter, PagingContext<StarsListResponse> context, CancellationToken cancellationToken)
    {
        return await this.SendBatchAsync(parameter, context, cancellationToken);
    }
}
