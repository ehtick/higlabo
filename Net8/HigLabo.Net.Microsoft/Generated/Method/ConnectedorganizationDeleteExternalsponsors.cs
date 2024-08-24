﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/connectedorganization-delete-externalsponsors?view=graph-rest-1.0
    /// </summary>
    public partial class ConnectedOrganizationDeleteExternalsponsorsParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? ConnectedOrganizationId { get; set; }
            public string? Id { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.IdentityGovernance_EntitlementManagement_ConnectedOrganizations_ConnectedOrganizationId_ExternalSponsors_Id_ref: return $"/identityGovernance/entitlementManagement/connectedOrganizations/{ConnectedOrganizationId}/externalSponsors/{Id}/$ref";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            IdentityGovernance_EntitlementManagement_ConnectedOrganizations_ConnectedOrganizationId_ExternalSponsors_Id_ref,
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
    public partial class ConnectedOrganizationDeleteExternalsponsorsResponse : RestApiResponse
    {
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/connectedorganization-delete-externalsponsors?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/connectedorganization-delete-externalsponsors?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ConnectedOrganizationDeleteExternalsponsorsResponse> ConnectedOrganizationDeleteExternalsponsorsAsync()
        {
            var p = new ConnectedOrganizationDeleteExternalsponsorsParameter();
            return await this.SendAsync<ConnectedOrganizationDeleteExternalsponsorsParameter, ConnectedOrganizationDeleteExternalsponsorsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/connectedorganization-delete-externalsponsors?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ConnectedOrganizationDeleteExternalsponsorsResponse> ConnectedOrganizationDeleteExternalsponsorsAsync(CancellationToken cancellationToken)
        {
            var p = new ConnectedOrganizationDeleteExternalsponsorsParameter();
            return await this.SendAsync<ConnectedOrganizationDeleteExternalsponsorsParameter, ConnectedOrganizationDeleteExternalsponsorsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/connectedorganization-delete-externalsponsors?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ConnectedOrganizationDeleteExternalsponsorsResponse> ConnectedOrganizationDeleteExternalsponsorsAsync(ConnectedOrganizationDeleteExternalsponsorsParameter parameter)
        {
            return await this.SendAsync<ConnectedOrganizationDeleteExternalsponsorsParameter, ConnectedOrganizationDeleteExternalsponsorsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/connectedorganization-delete-externalsponsors?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ConnectedOrganizationDeleteExternalsponsorsResponse> ConnectedOrganizationDeleteExternalsponsorsAsync(ConnectedOrganizationDeleteExternalsponsorsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ConnectedOrganizationDeleteExternalsponsorsParameter, ConnectedOrganizationDeleteExternalsponsorsResponse>(parameter, cancellationToken);
        }
    }
}
