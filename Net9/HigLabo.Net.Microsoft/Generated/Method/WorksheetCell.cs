﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/worksheet-cell?view=graph-rest-1.0
/// </summary>
public partial class WorksheetCellParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? Id { get; set; }
        public string? IdOrName { get; set; }
        public string? ItemPath { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Me_Drive_Items_Id_Workbook_Worksheets_IdOrname_Cell: return $"/me/drive/items/{Id}/workbook/worksheets/{IdOrName}/cell";
                case ApiPath.Me_Drive_Root_ItemPath_Workbook_Worksheets_IdOrname_Cell: return $"/me/drive/root:/{ItemPath}:/workbook/worksheets/{IdOrName}/cell";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Me_Drive_Items_Id_Workbook_Worksheets_IdOrname_Cell,
        Me_Drive_Root_ItemPath_Workbook_Worksheets_IdOrname_Cell,
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
public partial class WorksheetCellResponse : RestApiResponse
{
    public enum RangeJson
    {
        Unknown,
        Empty,
        String,
        Integer,
        Double,
        Boolean,
        Error,
    }

    public string? Address { get; set; }
    public string? AddressLocal { get; set; }
    public int? CellCount { get; set; }
    public int? ColumnCount { get; set; }
    public bool? ColumnHidden { get; set; }
    public int? ColumnIndex { get; set; }
    public Json? Formulas { get; set; }
    public Json? FormulasLocal { get; set; }
    public Json? FormulasR1C1 { get; set; }
    public bool? Hidden { get; set; }
    public Json? NumberFormat { get; set; }
    public int? RowCount { get; set; }
    public bool? RowHidden { get; set; }
    public int? RowIndex { get; set; }
    public Json? Text { get; set; }
    public RangeJson ValueTypes { get; set; }
    public Json? Values { get; set; }
    public RangeFormat? Format { get; set; }
    public RangeSort? Sort { get; set; }
    public Worksheet? Worksheet { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/worksheet-cell?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/worksheet-cell?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorksheetCellResponse> WorksheetCellAsync()
    {
        var p = new WorksheetCellParameter();
        return await this.SendAsync<WorksheetCellParameter, WorksheetCellResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/worksheet-cell?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorksheetCellResponse> WorksheetCellAsync(CancellationToken cancellationToken)
    {
        var p = new WorksheetCellParameter();
        return await this.SendAsync<WorksheetCellParameter, WorksheetCellResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/worksheet-cell?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorksheetCellResponse> WorksheetCellAsync(WorksheetCellParameter parameter)
    {
        return await this.SendAsync<WorksheetCellParameter, WorksheetCellResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/worksheet-cell?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorksheetCellResponse> WorksheetCellAsync(WorksheetCellParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<WorksheetCellParameter, WorksheetCellResponse>(parameter, cancellationToken);
    }
}
