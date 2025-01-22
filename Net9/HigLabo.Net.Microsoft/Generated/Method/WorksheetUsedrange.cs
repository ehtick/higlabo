﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/worksheet-usedrange?view=graph-rest-1.0
/// </summary>
public partial class WorksheetUsedrangeParameter : IRestApiParameter, IQueryParameterProperty
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
                case ApiPath.Me_Drive_Items_Id_Workbook_Worksheets_IdOrname_UsedRange: return $"/me/drive/items/{Id}/workbook/worksheets/{IdOrName}/usedRange";
                case ApiPath.Me_Drive_Root_ItemPath_Workbook_Worksheets_IdOrname_UsedRange: return $"/me/drive/root:/{ItemPath}:/workbook/worksheets/{IdOrName}/usedRange";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Me_Drive_Items_Id_Workbook_Worksheets_IdOrname_UsedRange,
        Me_Drive_Root_ItemPath_Workbook_Worksheets_IdOrname_UsedRange,
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
public partial class WorksheetUsedrangeResponse : RestApiResponse
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
/// https://learn.microsoft.com/en-us/graph/api/worksheet-usedrange?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/worksheet-usedrange?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorksheetUsedrangeResponse> WorksheetUsedrangeAsync()
    {
        var p = new WorksheetUsedrangeParameter();
        return await this.SendAsync<WorksheetUsedrangeParameter, WorksheetUsedrangeResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/worksheet-usedrange?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorksheetUsedrangeResponse> WorksheetUsedrangeAsync(CancellationToken cancellationToken)
    {
        var p = new WorksheetUsedrangeParameter();
        return await this.SendAsync<WorksheetUsedrangeParameter, WorksheetUsedrangeResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/worksheet-usedrange?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorksheetUsedrangeResponse> WorksheetUsedrangeAsync(WorksheetUsedrangeParameter parameter)
    {
        return await this.SendAsync<WorksheetUsedrangeParameter, WorksheetUsedrangeResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/worksheet-usedrange?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorksheetUsedrangeResponse> WorksheetUsedrangeAsync(WorksheetUsedrangeParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<WorksheetUsedrangeParameter, WorksheetUsedrangeResponse>(parameter, cancellationToken);
    }
}
