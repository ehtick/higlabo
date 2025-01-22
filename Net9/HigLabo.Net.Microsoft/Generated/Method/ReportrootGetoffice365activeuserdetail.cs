﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/reportroot-getoffice365activeuserdetail?view=graph-rest-1.0
/// </summary>
public partial class ReportRootGetoffice365activeUserdetailParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Reports_GetOffice365ActiveUserDetail: return $"/reports/getOffice365ActiveUserDetail";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Reports_GetOffice365ActiveUserDetail,
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
public partial class ReportRootGetoffice365activeUserdetailResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/reportroot-getoffice365activeuserdetail?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getoffice365activeuserdetail?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ReportRootGetoffice365activeUserdetailResponse> ReportRootGetoffice365activeUserdetailAsync()
    {
        var p = new ReportRootGetoffice365activeUserdetailParameter();
        return await this.SendAsync<ReportRootGetoffice365activeUserdetailParameter, ReportRootGetoffice365activeUserdetailResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getoffice365activeuserdetail?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ReportRootGetoffice365activeUserdetailResponse> ReportRootGetoffice365activeUserdetailAsync(CancellationToken cancellationToken)
    {
        var p = new ReportRootGetoffice365activeUserdetailParameter();
        return await this.SendAsync<ReportRootGetoffice365activeUserdetailParameter, ReportRootGetoffice365activeUserdetailResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getoffice365activeuserdetail?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ReportRootGetoffice365activeUserdetailResponse> ReportRootGetoffice365activeUserdetailAsync(ReportRootGetoffice365activeUserdetailParameter parameter)
    {
        return await this.SendAsync<ReportRootGetoffice365activeUserdetailParameter, ReportRootGetoffice365activeUserdetailResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getoffice365activeuserdetail?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ReportRootGetoffice365activeUserdetailResponse> ReportRootGetoffice365activeUserdetailAsync(ReportRootGetoffice365activeUserdetailParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<ReportRootGetoffice365activeUserdetailParameter, ReportRootGetoffice365activeUserdetailResponse>(parameter, cancellationToken);
    }
}
