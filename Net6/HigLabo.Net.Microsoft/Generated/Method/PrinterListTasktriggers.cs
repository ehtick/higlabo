﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/printer-list-tasktriggers?view=graph-rest-1.0
    /// </summary>
    public partial class PrinterListTasktriggersParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? PrinterId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Print_Printers_PrinterId_TaskTriggers: return $"/print/printers/{PrinterId}/taskTriggers";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            Print_Printers_PrinterId_TaskTriggers,
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
    public partial class PrinterListTasktriggersResponse : RestApiResponse
    {
        public PrintTaskTrigger[]? Value { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/printer-list-tasktriggers?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/printer-list-tasktriggers?view=graph-rest-1.0
        /// </summary>
        public async Task<PrinterListTasktriggersResponse> PrinterListTasktriggersAsync()
        {
            var p = new PrinterListTasktriggersParameter();
            return await this.SendAsync<PrinterListTasktriggersParameter, PrinterListTasktriggersResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/printer-list-tasktriggers?view=graph-rest-1.0
        /// </summary>
        public async Task<PrinterListTasktriggersResponse> PrinterListTasktriggersAsync(CancellationToken cancellationToken)
        {
            var p = new PrinterListTasktriggersParameter();
            return await this.SendAsync<PrinterListTasktriggersParameter, PrinterListTasktriggersResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/printer-list-tasktriggers?view=graph-rest-1.0
        /// </summary>
        public async Task<PrinterListTasktriggersResponse> PrinterListTasktriggersAsync(PrinterListTasktriggersParameter parameter)
        {
            return await this.SendAsync<PrinterListTasktriggersParameter, PrinterListTasktriggersResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/printer-list-tasktriggers?view=graph-rest-1.0
        /// </summary>
        public async Task<PrinterListTasktriggersResponse> PrinterListTasktriggersAsync(PrinterListTasktriggersParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<PrinterListTasktriggersParameter, PrinterListTasktriggersResponse>(parameter, cancellationToken);
        }
    }
}
