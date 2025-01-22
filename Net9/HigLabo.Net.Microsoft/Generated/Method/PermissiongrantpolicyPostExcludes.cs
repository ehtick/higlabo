﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/permissiongrantpolicy-post-excludes?view=graph-rest-1.0
/// </summary>
public partial class PermissiongrantPolicyPostExcludesParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? Id { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Policies_PermissionGrantPolicies_Id_Excludes: return $"/policies/permissionGrantPolicies/{Id}/excludes";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum PermissionGrantConditionSetPermissionType
    {
        Application,
        Delegated,
        DelegatedUserConsentable,
    }
    public enum ApiPath
    {
        Policies_PermissionGrantPolicies_Id_Excludes,
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
    public bool? ClientApplicationsFromVerifiedPublisherOnly { get; set; }
    public String[]? ClientApplicationIds { get; set; }
    public String[]? ClientApplicationPublisherIds { get; set; }
    public String[]? ClientApplicationTenantIds { get; set; }
    public string? Id { get; set; }
    public string? PermissionClassification { get; set; }
    public String[]? Permissions { get; set; }
    public PermissionGrantConditionSetPermissionType PermissionType { get; set; }
    public string? ResourceApplication { get; set; }
}
public partial class PermissiongrantPolicyPostExcludesResponse : RestApiResponse
{
    public enum PermissionGrantConditionSetPermissionType
    {
        Application,
        Delegated,
        DelegatedUserConsentable,
    }

    public bool? ClientApplicationsFromVerifiedPublisherOnly { get; set; }
    public String[]? ClientApplicationIds { get; set; }
    public String[]? ClientApplicationPublisherIds { get; set; }
    public String[]? ClientApplicationTenantIds { get; set; }
    public string? Id { get; set; }
    public string? PermissionClassification { get; set; }
    public String[]? Permissions { get; set; }
    public PermissionGrantConditionSetPermissionType PermissionType { get; set; }
    public string? ResourceApplication { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/permissiongrantpolicy-post-excludes?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/permissiongrantpolicy-post-excludes?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PermissiongrantPolicyPostExcludesResponse> PermissiongrantPolicyPostExcludesAsync()
    {
        var p = new PermissiongrantPolicyPostExcludesParameter();
        return await this.SendAsync<PermissiongrantPolicyPostExcludesParameter, PermissiongrantPolicyPostExcludesResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/permissiongrantpolicy-post-excludes?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PermissiongrantPolicyPostExcludesResponse> PermissiongrantPolicyPostExcludesAsync(CancellationToken cancellationToken)
    {
        var p = new PermissiongrantPolicyPostExcludesParameter();
        return await this.SendAsync<PermissiongrantPolicyPostExcludesParameter, PermissiongrantPolicyPostExcludesResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/permissiongrantpolicy-post-excludes?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PermissiongrantPolicyPostExcludesResponse> PermissiongrantPolicyPostExcludesAsync(PermissiongrantPolicyPostExcludesParameter parameter)
    {
        return await this.SendAsync<PermissiongrantPolicyPostExcludesParameter, PermissiongrantPolicyPostExcludesResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/permissiongrantpolicy-post-excludes?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<PermissiongrantPolicyPostExcludesResponse> PermissiongrantPolicyPostExcludesAsync(PermissiongrantPolicyPostExcludesParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<PermissiongrantPolicyPostExcludesParameter, PermissiongrantPolicyPostExcludesResponse>(parameter, cancellationToken);
    }
}
