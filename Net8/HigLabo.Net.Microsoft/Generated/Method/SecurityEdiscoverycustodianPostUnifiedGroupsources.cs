﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/security-ediscoverycustodian-post-unifiedgroupsources?view=graph-rest-1.0
/// </summary>
public partial class SecurityEDiscoverycustodianPostUnifiedGroupsourcesParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? EdiscoveryCaseId { get; set; }
        public string? CustodianId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Security_Cases_EdiscoveryCases_EdiscoveryCaseId_Custodians_CustodianId_UnifiedGroupSources: return $"/security/cases/ediscoveryCases/{EdiscoveryCaseId}/custodians/{CustodianId}/unifiedGroupSources";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum SecurityEDiscoverycustodianPostUnifiedGroupsourcesParameterSecuritySourceType
    {
        Mailbox,
        Site,
    }
    public enum UnifiedGroupSourceSecurityDataSourceHoldStatus
    {
        NotApplied,
        Applied,
        Applying,
        Removing,
        Partial,
    }
    public enum UnifiedGroupSourceSecuritySourceType
    {
        Mailbox,
        Site,
    }
    public enum ApiPath
    {
        Security_Cases_EdiscoveryCases_EdiscoveryCaseId_Custodians_CustodianId_UnifiedGroupSources,
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
    public SecurityEDiscoverycustodianPostUnifiedGroupsourcesParameterSecuritySourceType IncludedSources { get; set; }
    public string? Group { get; set; }
    public IdentitySet? CreatedBy { get; set; }
    public DateTimeOffset? CreatedDateTime { get; set; }
    public string? DisplayName { get; set; }
    public UnifiedGroupSourceSecurityDataSourceHoldStatus HoldStatus { get; set; }
    public string? Id { get; set; }
}
public partial class SecurityEDiscoverycustodianPostUnifiedGroupsourcesResponse : RestApiResponse
{
    public enum UnifiedGroupSourceSecurityDataSourceHoldStatus
    {
        NotApplied,
        Applied,
        Applying,
        Removing,
        Partial,
    }
    public enum UnifiedGroupSourceSecuritySourceType
    {
        Mailbox,
        Site,
    }

    public IdentitySet? CreatedBy { get; set; }
    public DateTimeOffset? CreatedDateTime { get; set; }
    public string? DisplayName { get; set; }
    public UnifiedGroupSourceSecurityDataSourceHoldStatus HoldStatus { get; set; }
    public string? Id { get; set; }
    public UnifiedGroupSourceSecuritySourceType IncludedSources { get; set; }
    public Group? Group { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/security-ediscoverycustodian-post-unifiedgroupsources?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/security-ediscoverycustodian-post-unifiedgroupsources?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<SecurityEDiscoverycustodianPostUnifiedGroupsourcesResponse> SecurityEDiscoverycustodianPostUnifiedGroupsourcesAsync()
    {
        var p = new SecurityEDiscoverycustodianPostUnifiedGroupsourcesParameter();
        return await this.SendAsync<SecurityEDiscoverycustodianPostUnifiedGroupsourcesParameter, SecurityEDiscoverycustodianPostUnifiedGroupsourcesResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/security-ediscoverycustodian-post-unifiedgroupsources?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<SecurityEDiscoverycustodianPostUnifiedGroupsourcesResponse> SecurityEDiscoverycustodianPostUnifiedGroupsourcesAsync(CancellationToken cancellationToken)
    {
        var p = new SecurityEDiscoverycustodianPostUnifiedGroupsourcesParameter();
        return await this.SendAsync<SecurityEDiscoverycustodianPostUnifiedGroupsourcesParameter, SecurityEDiscoverycustodianPostUnifiedGroupsourcesResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/security-ediscoverycustodian-post-unifiedgroupsources?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<SecurityEDiscoverycustodianPostUnifiedGroupsourcesResponse> SecurityEDiscoverycustodianPostUnifiedGroupsourcesAsync(SecurityEDiscoverycustodianPostUnifiedGroupsourcesParameter parameter)
    {
        return await this.SendAsync<SecurityEDiscoverycustodianPostUnifiedGroupsourcesParameter, SecurityEDiscoverycustodianPostUnifiedGroupsourcesResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/security-ediscoverycustodian-post-unifiedgroupsources?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<SecurityEDiscoverycustodianPostUnifiedGroupsourcesResponse> SecurityEDiscoverycustodianPostUnifiedGroupsourcesAsync(SecurityEDiscoverycustodianPostUnifiedGroupsourcesParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<SecurityEDiscoverycustodianPostUnifiedGroupsourcesParameter, SecurityEDiscoverycustodianPostUnifiedGroupsourcesResponse>(parameter, cancellationToken);
    }
}
