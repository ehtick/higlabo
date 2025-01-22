﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/unifiedroleeligibilityscheduleinstance-get?view=graph-rest-1.0
/// </summary>
public partial class UnifiedroleeligibilityScheduleinstanceGetParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? UnifiedRoleEligibilityScheduleInstanceId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.RoleManagement_Directory_RoleEligibilityScheduleInstances_UnifiedRoleEligibilityScheduleInstanceId: return $"/roleManagement/directory/roleEligibilityScheduleInstances/{UnifiedRoleEligibilityScheduleInstanceId}";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        RoleManagement_Directory_RoleEligibilityScheduleInstances_UnifiedRoleEligibilityScheduleInstanceId,
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
public partial class UnifiedroleeligibilityScheduleinstanceGetResponse : RestApiResponse
{
    public string? AppScopeId { get; set; }
    public string? DirectoryScopeId { get; set; }
    public DateTimeOffset? EndDateTime { get; set; }
    public string? Id { get; set; }
    public string? MemberType { get; set; }
    public string? PrincipalId { get; set; }
    public string? RoleDefinitionId { get; set; }
    public string? RoleEligibilityScheduleId { get; set; }
    public DateTimeOffset? StartDateTime { get; set; }
    public AppScope? AppScope { get; set; }
    public DirectoryObject? DirectoryScope { get; set; }
    public DirectoryObject? Principal { get; set; }
    public UnifiedRoleDefinition? RoleDefinition { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/unifiedroleeligibilityscheduleinstance-get?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/unifiedroleeligibilityscheduleinstance-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<UnifiedroleeligibilityScheduleinstanceGetResponse> UnifiedroleeligibilityScheduleinstanceGetAsync()
    {
        var p = new UnifiedroleeligibilityScheduleinstanceGetParameter();
        return await this.SendAsync<UnifiedroleeligibilityScheduleinstanceGetParameter, UnifiedroleeligibilityScheduleinstanceGetResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/unifiedroleeligibilityscheduleinstance-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<UnifiedroleeligibilityScheduleinstanceGetResponse> UnifiedroleeligibilityScheduleinstanceGetAsync(CancellationToken cancellationToken)
    {
        var p = new UnifiedroleeligibilityScheduleinstanceGetParameter();
        return await this.SendAsync<UnifiedroleeligibilityScheduleinstanceGetParameter, UnifiedroleeligibilityScheduleinstanceGetResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/unifiedroleeligibilityscheduleinstance-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<UnifiedroleeligibilityScheduleinstanceGetResponse> UnifiedroleeligibilityScheduleinstanceGetAsync(UnifiedroleeligibilityScheduleinstanceGetParameter parameter)
    {
        return await this.SendAsync<UnifiedroleeligibilityScheduleinstanceGetParameter, UnifiedroleeligibilityScheduleinstanceGetResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/unifiedroleeligibilityscheduleinstance-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<UnifiedroleeligibilityScheduleinstanceGetResponse> UnifiedroleeligibilityScheduleinstanceGetAsync(UnifiedroleeligibilityScheduleinstanceGetParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<UnifiedroleeligibilityScheduleinstanceGetParameter, UnifiedroleeligibilityScheduleinstanceGetResponse>(parameter, cancellationToken);
    }
}
