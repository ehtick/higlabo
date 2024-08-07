﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/userflowlanguageconfiguration-list-overridespages?view=graph-rest-1.0
    /// </summary>
    public partial class UserflowlanguageConfigurationListOverridespagesParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? B2xUserFlowsId { get; set; }
            public string? LanguagesId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Identity_B2xUserFlows_Id_Languages_Id_OverridesPages: return $"/identity/b2xUserFlows/{B2xUserFlowsId}/languages/{LanguagesId}/overridesPages";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
            Id,
        }
        public enum ApiPath
        {
            Identity_B2xUserFlows_Id_Languages_Id_OverridesPages,
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
    public partial class UserflowlanguageConfigurationListOverridespagesResponse : RestApiResponse
    {
        public UserFlowLanguagePage[]? Value { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/userflowlanguageconfiguration-list-overridespages?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/userflowlanguageconfiguration-list-overridespages?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<UserflowlanguageConfigurationListOverridespagesResponse> UserflowlanguageConfigurationListOverridespagesAsync()
        {
            var p = new UserflowlanguageConfigurationListOverridespagesParameter();
            return await this.SendAsync<UserflowlanguageConfigurationListOverridespagesParameter, UserflowlanguageConfigurationListOverridespagesResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/userflowlanguageconfiguration-list-overridespages?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<UserflowlanguageConfigurationListOverridespagesResponse> UserflowlanguageConfigurationListOverridespagesAsync(CancellationToken cancellationToken)
        {
            var p = new UserflowlanguageConfigurationListOverridespagesParameter();
            return await this.SendAsync<UserflowlanguageConfigurationListOverridespagesParameter, UserflowlanguageConfigurationListOverridespagesResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/userflowlanguageconfiguration-list-overridespages?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<UserflowlanguageConfigurationListOverridespagesResponse> UserflowlanguageConfigurationListOverridespagesAsync(UserflowlanguageConfigurationListOverridespagesParameter parameter)
        {
            return await this.SendAsync<UserflowlanguageConfigurationListOverridespagesParameter, UserflowlanguageConfigurationListOverridespagesResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/userflowlanguageconfiguration-list-overridespages?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<UserflowlanguageConfigurationListOverridespagesResponse> UserflowlanguageConfigurationListOverridespagesAsync(UserflowlanguageConfigurationListOverridespagesParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<UserflowlanguageConfigurationListOverridespagesParameter, UserflowlanguageConfigurationListOverridespagesResponse>(parameter, cancellationToken);
        }
    }
}
