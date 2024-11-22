﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/workbookapplication-get?view=graph-rest-1.0
/// </summary>
public partial class WorkbookApplicationGetParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? Id { get; set; }
        public string? ItemPath { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Me_Drive_Items_Id_Workbook_Application: return $"/me/drive/items/{Id}/workbook/application";
                case ApiPath.Me_Drive_Root_ItemPath_Workbook_Application: return $"/me/drive/root:/{ItemPath}:/workbook/application";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Me_Drive_Items_Id_Workbook_Application,
        Me_Drive_Root_ItemPath_Workbook_Application,
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
public partial class WorkbookApplicationGetResponse : RestApiResponse
{
    public enum WorkbookApplicationstring
    {
        Automatic,
        AutomaticExceptTables,
        Manual,
    }

    public WorkbookApplicationstring CalculationMode { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/workbookapplication-get?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/workbookapplication-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorkbookApplicationGetResponse> WorkbookApplicationGetAsync()
    {
        var p = new WorkbookApplicationGetParameter();
        return await this.SendAsync<WorkbookApplicationGetParameter, WorkbookApplicationGetResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/workbookapplication-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorkbookApplicationGetResponse> WorkbookApplicationGetAsync(CancellationToken cancellationToken)
    {
        var p = new WorkbookApplicationGetParameter();
        return await this.SendAsync<WorkbookApplicationGetParameter, WorkbookApplicationGetResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/workbookapplication-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorkbookApplicationGetResponse> WorkbookApplicationGetAsync(WorkbookApplicationGetParameter parameter)
    {
        return await this.SendAsync<WorkbookApplicationGetParameter, WorkbookApplicationGetResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/workbookapplication-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorkbookApplicationGetResponse> WorkbookApplicationGetAsync(WorkbookApplicationGetParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<WorkbookApplicationGetParameter, WorkbookApplicationGetResponse>(parameter, cancellationToken);
    }
}
