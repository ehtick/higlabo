﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/print-update-settings?view=graph-rest-1.0
/// </summary>
public partial class PrintUpdateSettingsParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Print_Settings: return $"/print/settings";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Print_Settings,
    }

    public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
    string IRestApiParameter.ApiPath
    {
        get
        {
            return this.ApiPathSetting.GetApiPath();
        }
    }
    string IRestApiParameter.HttpMethod { get; } = "PATCH";
    public bool? DocumentConversionEnabled { get; set; }
}
public partial class PrintUpdateSettingsResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/print-update-settings?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/print-update-settings?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PrintUpdateSettingsResponse> PrintUpdateSettingsAsync()
    {
        var p = new PrintUpdateSettingsParameter();
        return await this.SendAsync<PrintUpdateSettingsParameter, PrintUpdateSettingsResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/print-update-settings?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PrintUpdateSettingsResponse> PrintUpdateSettingsAsync(CancellationToken cancellationToken)
    {
        var p = new PrintUpdateSettingsParameter();
        return await this.SendAsync<PrintUpdateSettingsParameter, PrintUpdateSettingsResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/print-update-settings?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PrintUpdateSettingsResponse> PrintUpdateSettingsAsync(PrintUpdateSettingsParameter parameter)
    {
        return await this.SendAsync<PrintUpdateSettingsParameter, PrintUpdateSettingsResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/print-update-settings?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PrintUpdateSettingsResponse> PrintUpdateSettingsAsync(PrintUpdateSettingsParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<PrintUpdateSettingsParameter, PrintUpdateSettingsResponse>(parameter, cancellationToken);
    }
}
