﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/reportroot-getoffice365groupsactivityfilecounts?view=graph-rest-1.0
/// </summary>
public partial class ReportRootGetoffice365GroupsActivityfilecountsParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Reports_GetOffice365GroupsActivityFileCounts: return $"/reports/getOffice365GroupsActivityFileCounts";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Reports_GetOffice365GroupsActivityFileCounts,
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
public partial class ReportRootGetoffice365GroupsActivityfilecountsResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/reportroot-getoffice365groupsactivityfilecounts?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getoffice365groupsactivityfilecounts?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ReportRootGetoffice365GroupsActivityfilecountsResponse> ReportRootGetoffice365GroupsActivityfilecountsAsync()
    {
        var p = new ReportRootGetoffice365GroupsActivityfilecountsParameter();
        return await this.SendAsync<ReportRootGetoffice365GroupsActivityfilecountsParameter, ReportRootGetoffice365GroupsActivityfilecountsResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getoffice365groupsactivityfilecounts?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ReportRootGetoffice365GroupsActivityfilecountsResponse> ReportRootGetoffice365GroupsActivityfilecountsAsync(CancellationToken cancellationToken)
    {
        var p = new ReportRootGetoffice365GroupsActivityfilecountsParameter();
        return await this.SendAsync<ReportRootGetoffice365GroupsActivityfilecountsParameter, ReportRootGetoffice365GroupsActivityfilecountsResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getoffice365groupsactivityfilecounts?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ReportRootGetoffice365GroupsActivityfilecountsResponse> ReportRootGetoffice365GroupsActivityfilecountsAsync(ReportRootGetoffice365GroupsActivityfilecountsParameter parameter)
    {
        return await this.SendAsync<ReportRootGetoffice365GroupsActivityfilecountsParameter, ReportRootGetoffice365GroupsActivityfilecountsResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getoffice365groupsactivityfilecounts?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ReportRootGetoffice365GroupsActivityfilecountsResponse> ReportRootGetoffice365GroupsActivityfilecountsAsync(ReportRootGetoffice365GroupsActivityfilecountsParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<ReportRootGetoffice365GroupsActivityfilecountsParameter, ReportRootGetoffice365GroupsActivityfilecountsResponse>(parameter, cancellationToken);
    }
}
