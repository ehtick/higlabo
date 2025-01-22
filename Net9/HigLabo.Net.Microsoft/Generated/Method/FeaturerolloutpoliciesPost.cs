﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/featurerolloutpolicies-post?view=graph-rest-1.0
/// </summary>
public partial class FeaturerolloutpoliciesPostParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Policies_FeatureRolloutPolicies: return $"/policies/featureRolloutPolicies";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum FeatureRolloutPolicystring
    {
        PassthroughAuthentication,
        SeamlessSso,
        PasswordHashSync,
        EmailAsAlternateId,
        UnknownFutureValue,
    }
    public enum ApiPath
    {
        Policies_FeatureRolloutPolicies,
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
    public string? DisplayName { get; set; }
    public string? Feature { get; set; }
    public string? IsEnabled { get; set; }
    public string? Description { get; set; }
    public string? Id { get; set; }
    public bool? IsAppliedToOrganization { get; set; }
    public DirectoryObject[]? AppliesTo { get; set; }
}
public partial class FeaturerolloutpoliciesPostResponse : RestApiResponse
{
    public enum FeatureRolloutPolicystring
    {
        PassthroughAuthentication,
        SeamlessSso,
        PasswordHashSync,
        EmailAsAlternateId,
        UnknownFutureValue,
    }

    public string? Description { get; set; }
    public string? DisplayName { get; set; }
    public FeatureRolloutPolicystring Feature { get; set; }
    public string? Id { get; set; }
    public bool? IsAppliedToOrganization { get; set; }
    public bool? IsEnabled { get; set; }
    public DirectoryObject[]? AppliesTo { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/featurerolloutpolicies-post?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/featurerolloutpolicies-post?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<FeaturerolloutpoliciesPostResponse> FeaturerolloutpoliciesPostAsync()
    {
        var p = new FeaturerolloutpoliciesPostParameter();
        return await this.SendAsync<FeaturerolloutpoliciesPostParameter, FeaturerolloutpoliciesPostResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/featurerolloutpolicies-post?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<FeaturerolloutpoliciesPostResponse> FeaturerolloutpoliciesPostAsync(CancellationToken cancellationToken)
    {
        var p = new FeaturerolloutpoliciesPostParameter();
        return await this.SendAsync<FeaturerolloutpoliciesPostParameter, FeaturerolloutpoliciesPostResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/featurerolloutpolicies-post?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<FeaturerolloutpoliciesPostResponse> FeaturerolloutpoliciesPostAsync(FeaturerolloutpoliciesPostParameter parameter)
    {
        return await this.SendAsync<FeaturerolloutpoliciesPostParameter, FeaturerolloutpoliciesPostResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/featurerolloutpolicies-post?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<FeaturerolloutpoliciesPostResponse> FeaturerolloutpoliciesPostAsync(FeaturerolloutpoliciesPostParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<FeaturerolloutpoliciesPostParameter, FeaturerolloutpoliciesPostResponse>(parameter, cancellationToken);
    }
}
