﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getskypeforbusinesspeertopeeractivityminutecounts?view=graph-rest-1.0
    /// </summary>
    public partial class ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Reports_GetSkypeForBusinessPeerToPeerActivityMinuteCounts: return $"/reports/getSkypeForBusinessPeerToPeerActivityMinuteCounts";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            Reports_GetSkypeForBusinessPeerToPeerActivityMinuteCounts,
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
    public partial class ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsResponse : RestApiResponse
    {
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/reportroot-getskypeforbusinesspeertopeeractivityminutecounts?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/reportroot-getskypeforbusinesspeertopeeractivityminutecounts?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsResponse> ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsAsync()
        {
            var p = new ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsParameter();
            return await this.SendAsync<ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsParameter, ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/reportroot-getskypeforbusinesspeertopeeractivityminutecounts?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsResponse> ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsAsync(CancellationToken cancellationToken)
        {
            var p = new ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsParameter();
            return await this.SendAsync<ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsParameter, ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/reportroot-getskypeforbusinesspeertopeeractivityminutecounts?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsResponse> ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsAsync(ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsParameter parameter)
        {
            return await this.SendAsync<ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsParameter, ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/reportroot-getskypeforbusinesspeertopeeractivityminutecounts?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsResponse> ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsAsync(ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsParameter, ReportRootGetSkypeforBusinesspeertopeerActivityminutecountsResponse>(parameter, cancellationToken);
        }
    }
}
