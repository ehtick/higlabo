﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/serviceprincipal-delete-owners?view=graph-rest-1.0
    /// </summary>
    public partial class ServicePrincipalDeleteOwnersParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? ServiceprincipalsId { get; set; }
            public string? OwnersId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Serviceprincipals_Id_Owners_Id_ref: return $"/serviceprincipals/{ServiceprincipalsId}/owners/{OwnersId}/$ref";
                    case ApiPath.ServicePrincipals: return $"/servicePrincipals";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            Serviceprincipals_Id_Owners_Id_ref,
            ServicePrincipals,
        }

        public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
        string IRestApiParameter.ApiPath
        {
            get
            {
                return this.ApiPathSetting.GetApiPath();
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "DELETE";
    }
    public partial class ServicePrincipalDeleteOwnersResponse : RestApiResponse
    {
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/serviceprincipal-delete-owners?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/serviceprincipal-delete-owners?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ServicePrincipalDeleteOwnersResponse> ServicePrincipalDeleteOwnersAsync()
        {
            var p = new ServicePrincipalDeleteOwnersParameter();
            return await this.SendAsync<ServicePrincipalDeleteOwnersParameter, ServicePrincipalDeleteOwnersResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/serviceprincipal-delete-owners?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ServicePrincipalDeleteOwnersResponse> ServicePrincipalDeleteOwnersAsync(CancellationToken cancellationToken)
        {
            var p = new ServicePrincipalDeleteOwnersParameter();
            return await this.SendAsync<ServicePrincipalDeleteOwnersParameter, ServicePrincipalDeleteOwnersResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/serviceprincipal-delete-owners?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ServicePrincipalDeleteOwnersResponse> ServicePrincipalDeleteOwnersAsync(ServicePrincipalDeleteOwnersParameter parameter)
        {
            return await this.SendAsync<ServicePrincipalDeleteOwnersParameter, ServicePrincipalDeleteOwnersResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/serviceprincipal-delete-owners?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ServicePrincipalDeleteOwnersResponse> ServicePrincipalDeleteOwnersAsync(ServicePrincipalDeleteOwnersParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ServicePrincipalDeleteOwnersParameter, ServicePrincipalDeleteOwnersResponse>(parameter, cancellationToken);
        }
    }
}
