﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/workbookapplication-calculate?view=graph-rest-1.0
/// </summary>
public partial class WorkbookApplicationCalculateParameter : IRestApiParameter
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
                case ApiPath.Me_Drive_Items_Id_Workbook_Application_Calculate: return $"/me/drive/items/{Id}/workbook/application/calculate";
                case ApiPath.Me_Drive_Root_ItemPath_Workbook_Application_Calculate: return $"/me/drive/root:/{ItemPath}:/workbook/application/calculate";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum WorkbookApplicationCalculateParameterstring
    {
        Recalculate,
        Full,
        FullRebuild,
    }
    public enum ApiPath
    {
        Me_Drive_Items_Id_Workbook_Application_Calculate,
        Me_Drive_Root_ItemPath_Workbook_Application_Calculate,
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
    public WorkbookApplicationCalculateParameterstring CalculationType { get; set; }
}
public partial class WorkbookApplicationCalculateResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/workbookapplication-calculate?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/workbookapplication-calculate?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorkbookApplicationCalculateResponse> WorkbookApplicationCalculateAsync()
    {
        var p = new WorkbookApplicationCalculateParameter();
        return await this.SendAsync<WorkbookApplicationCalculateParameter, WorkbookApplicationCalculateResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/workbookapplication-calculate?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorkbookApplicationCalculateResponse> WorkbookApplicationCalculateAsync(CancellationToken cancellationToken)
    {
        var p = new WorkbookApplicationCalculateParameter();
        return await this.SendAsync<WorkbookApplicationCalculateParameter, WorkbookApplicationCalculateResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/workbookapplication-calculate?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorkbookApplicationCalculateResponse> WorkbookApplicationCalculateAsync(WorkbookApplicationCalculateParameter parameter)
    {
        return await this.SendAsync<WorkbookApplicationCalculateParameter, WorkbookApplicationCalculateResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/workbookapplication-calculate?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorkbookApplicationCalculateResponse> WorkbookApplicationCalculateAsync(WorkbookApplicationCalculateParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<WorkbookApplicationCalculateParameter, WorkbookApplicationCalculateResponse>(parameter, cancellationToken);
    }
}
