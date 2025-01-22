﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/b2xidentityuserflow-post-identityproviders?view=graph-rest-1.0
/// </summary>
public partial class B2xidentityUserflowPostIdentityProvidersParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? Id { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Identity_B2xUserFlows_Id_IdentityProviders_ref: return $"/identity/b2xUserFlows/{Id}/identityProviders/$ref";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Identity_B2xUserFlows_Id_IdentityProviders_ref,
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
}
public partial class B2xidentityUserflowPostIdentityProvidersResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/b2xidentityuserflow-post-identityproviders?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/b2xidentityuserflow-post-identityproviders?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<B2xidentityUserflowPostIdentityProvidersResponse> B2xidentityUserflowPostIdentityProvidersAsync()
    {
        var p = new B2xidentityUserflowPostIdentityProvidersParameter();
        return await this.SendAsync<B2xidentityUserflowPostIdentityProvidersParameter, B2xidentityUserflowPostIdentityProvidersResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/b2xidentityuserflow-post-identityproviders?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<B2xidentityUserflowPostIdentityProvidersResponse> B2xidentityUserflowPostIdentityProvidersAsync(CancellationToken cancellationToken)
    {
        var p = new B2xidentityUserflowPostIdentityProvidersParameter();
        return await this.SendAsync<B2xidentityUserflowPostIdentityProvidersParameter, B2xidentityUserflowPostIdentityProvidersResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/b2xidentityuserflow-post-identityproviders?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<B2xidentityUserflowPostIdentityProvidersResponse> B2xidentityUserflowPostIdentityProvidersAsync(B2xidentityUserflowPostIdentityProvidersParameter parameter)
    {
        return await this.SendAsync<B2xidentityUserflowPostIdentityProvidersParameter, B2xidentityUserflowPostIdentityProvidersResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/b2xidentityuserflow-post-identityproviders?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<B2xidentityUserflowPostIdentityProvidersResponse> B2xidentityUserflowPostIdentityProvidersAsync(B2xidentityUserflowPostIdentityProvidersParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<B2xidentityUserflowPostIdentityProvidersParameter, B2xidentityUserflowPostIdentityProvidersResponse>(parameter, cancellationToken);
    }
}
