﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/oauth2permissiongrant-post?view=graph-rest-1.0
    /// </summary>
    public partial class Oauth2permissiongrantPostParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Oauth2PermissionGrants: return $"/oauth2PermissionGrants";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            Oauth2PermissionGrants,
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
        public string? ClientId { get; set; }
        public string? ConsentType { get; set; }
        public string? Id { get; set; }
        public string? PrincipalId { get; set; }
        public string? ResourceId { get; set; }
        public string? Scope { get; set; }
    }
    public partial class Oauth2permissiongrantPostResponse : RestApiResponse
    {
        public string? ClientId { get; set; }
        public string? ConsentType { get; set; }
        public string? Id { get; set; }
        public string? PrincipalId { get; set; }
        public string? ResourceId { get; set; }
        public string? Scope { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/oauth2permissiongrant-post?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/oauth2permissiongrant-post?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<Oauth2permissiongrantPostResponse> Oauth2permissiongrantPostAsync()
        {
            var p = new Oauth2permissiongrantPostParameter();
            return await this.SendAsync<Oauth2permissiongrantPostParameter, Oauth2permissiongrantPostResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/oauth2permissiongrant-post?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<Oauth2permissiongrantPostResponse> Oauth2permissiongrantPostAsync(CancellationToken cancellationToken)
        {
            var p = new Oauth2permissiongrantPostParameter();
            return await this.SendAsync<Oauth2permissiongrantPostParameter, Oauth2permissiongrantPostResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/oauth2permissiongrant-post?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<Oauth2permissiongrantPostResponse> Oauth2permissiongrantPostAsync(Oauth2permissiongrantPostParameter parameter)
        {
            return await this.SendAsync<Oauth2permissiongrantPostParameter, Oauth2permissiongrantPostResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/oauth2permissiongrant-post?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<Oauth2permissiongrantPostResponse> Oauth2permissiongrantPostAsync(Oauth2permissiongrantPostParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<Oauth2permissiongrantPostParameter, Oauth2permissiongrantPostResponse>(parameter, cancellationToken);
        }
    }
}
