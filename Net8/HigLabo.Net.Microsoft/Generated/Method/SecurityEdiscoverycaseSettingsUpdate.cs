﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/security-ediscoverycasesettings-update?view=graph-rest-1.0
    /// </summary>
    public partial class SecurityEDiscoverycaseSettingsUpdateParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? EdiscoveryCaseId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Security_Cases_EdiscoveryCases_EdiscoveryCaseId_Settings: return $"/security/cases/ediscoveryCases/{EdiscoveryCaseId}/settings";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            Security_Cases_EdiscoveryCases_EdiscoveryCaseId_Settings,
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
        public RedundancyDetectionSettings? RedundancyDetection { get; set; }
        public TopicModelingSettings? TopicModeling { get; set; }
        public OcrSettings? Ocr { get; set; }
    }
    public partial class SecurityEDiscoverycaseSettingsUpdateResponse : RestApiResponse
    {
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/security-ediscoverycasesettings-update?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/security-ediscoverycasesettings-update?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<SecurityEDiscoverycaseSettingsUpdateResponse> SecurityEDiscoverycaseSettingsUpdateAsync()
        {
            var p = new SecurityEDiscoverycaseSettingsUpdateParameter();
            return await this.SendAsync<SecurityEDiscoverycaseSettingsUpdateParameter, SecurityEDiscoverycaseSettingsUpdateResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/security-ediscoverycasesettings-update?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<SecurityEDiscoverycaseSettingsUpdateResponse> SecurityEDiscoverycaseSettingsUpdateAsync(CancellationToken cancellationToken)
        {
            var p = new SecurityEDiscoverycaseSettingsUpdateParameter();
            return await this.SendAsync<SecurityEDiscoverycaseSettingsUpdateParameter, SecurityEDiscoverycaseSettingsUpdateResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/security-ediscoverycasesettings-update?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<SecurityEDiscoverycaseSettingsUpdateResponse> SecurityEDiscoverycaseSettingsUpdateAsync(SecurityEDiscoverycaseSettingsUpdateParameter parameter)
        {
            return await this.SendAsync<SecurityEDiscoverycaseSettingsUpdateParameter, SecurityEDiscoverycaseSettingsUpdateResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/security-ediscoverycasesettings-update?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<SecurityEDiscoverycaseSettingsUpdateResponse> SecurityEDiscoverycaseSettingsUpdateAsync(SecurityEDiscoverycaseSettingsUpdateParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<SecurityEDiscoverycaseSettingsUpdateParameter, SecurityEDiscoverycaseSettingsUpdateResponse>(parameter, cancellationToken);
        }
    }
}
