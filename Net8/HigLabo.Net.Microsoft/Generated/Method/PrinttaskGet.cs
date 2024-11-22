﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/printtask-get?view=graph-rest-1.0
/// </summary>
public partial class PrinttaskGetParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? TaskDefinitionId { get; set; }
        public string? TaskId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Print_TaskDefinitions_TaskDefinitionId_Tasks_TaskId: return $"/print/taskDefinitions/{TaskDefinitionId}/tasks/{TaskId}";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Print_TaskDefinitions_TaskDefinitionId_Tasks_TaskId,
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
public partial class PrinttaskGetResponse : RestApiResponse
{
    public string? Id { get; set; }
    public PrintTaskStatus? Status { get; set; }
    public string? ParentUrl { get; set; }
    public PrintTaskDefinition? Definition { get; set; }
    public PrintTaskTrigger? Trigger { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/printtask-get?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/printtask-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PrinttaskGetResponse> PrinttaskGetAsync()
    {
        var p = new PrinttaskGetParameter();
        return await this.SendAsync<PrinttaskGetParameter, PrinttaskGetResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/printtask-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PrinttaskGetResponse> PrinttaskGetAsync(CancellationToken cancellationToken)
    {
        var p = new PrinttaskGetParameter();
        return await this.SendAsync<PrinttaskGetParameter, PrinttaskGetResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/printtask-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PrinttaskGetResponse> PrinttaskGetAsync(PrinttaskGetParameter parameter)
    {
        return await this.SendAsync<PrinttaskGetParameter, PrinttaskGetResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/printtask-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PrinttaskGetResponse> PrinttaskGetAsync(PrinttaskGetParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<PrinttaskGetParameter, PrinttaskGetResponse>(parameter, cancellationToken);
    }
}
