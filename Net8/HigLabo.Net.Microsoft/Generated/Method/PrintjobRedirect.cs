﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/printjob-redirect?view=graph-rest-1.0
    /// </summary>
    public partial class PrintJobRedirectParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? PrinterId { get; set; }
            public string? PrintJobId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Print_Printers_PrinterId_Jobs_PrintJobId_Redirect: return $"/print/printers/{PrinterId}/jobs/{PrintJobId}/redirect";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            Print_Printers_PrinterId_Jobs_PrintJobId_Redirect,
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
        public string? DestinationPrinterId { get; set; }
        public PrintJobConfiguration? Configuration { get; set; }
        public UserIdentity? CreatedBy { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string? Id { get; set; }
        public Boolean? IsFetchable { get; set; }
        public String? RedirectedFrom { get; set; }
        public String? RedirectedTo { get; set; }
        public PrintJobStatus? Status { get; set; }
        public PrintDocument[]? Documents { get; set; }
        public PrintTask[]? Tasks { get; set; }
    }
    public partial class PrintJobRedirectResponse : RestApiResponse
    {
        public PrintJobConfiguration? Configuration { get; set; }
        public UserIdentity? CreatedBy { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string? Id { get; set; }
        public Boolean? IsFetchable { get; set; }
        public String? RedirectedFrom { get; set; }
        public String? RedirectedTo { get; set; }
        public PrintJobStatus? Status { get; set; }
        public PrintDocument[]? Documents { get; set; }
        public PrintTask[]? Tasks { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/printjob-redirect?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/printjob-redirect?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<PrintJobRedirectResponse> PrintJobRedirectAsync()
        {
            var p = new PrintJobRedirectParameter();
            return await this.SendAsync<PrintJobRedirectParameter, PrintJobRedirectResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/printjob-redirect?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<PrintJobRedirectResponse> PrintJobRedirectAsync(CancellationToken cancellationToken)
        {
            var p = new PrintJobRedirectParameter();
            return await this.SendAsync<PrintJobRedirectParameter, PrintJobRedirectResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/printjob-redirect?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<PrintJobRedirectResponse> PrintJobRedirectAsync(PrintJobRedirectParameter parameter)
        {
            return await this.SendAsync<PrintJobRedirectParameter, PrintJobRedirectResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/printjob-redirect?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<PrintJobRedirectResponse> PrintJobRedirectAsync(PrintJobRedirectParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<PrintJobRedirectParameter, PrintJobRedirectResponse>(parameter, cancellationToken);
        }
    }
}
