﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/unifiedroleassignmentscheduleinstance-get?view=graph-rest-1.0
    /// </summary>
    public partial class UnifiedroleAssignmentScheduleinstanceGetParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? UnifiedRoleAssignmentScheduleInstanceId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.RoleManagement_Directory_RoleAssignmentScheduleInstances_UnifiedRoleAssignmentScheduleInstanceId: return $"/roleManagement/directory/roleAssignmentScheduleInstances/{UnifiedRoleAssignmentScheduleInstanceId}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            RoleManagement_Directory_RoleAssignmentScheduleInstances_UnifiedRoleAssignmentScheduleInstanceId,
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
    public partial class UnifiedroleAssignmentScheduleinstanceGetResponse : RestApiResponse
    {
        public string? AppScopeId { get; set; }
        public string? AssignmentType { get; set; }
        public string? DirectoryScopeId { get; set; }
        public DateTimeOffset? EndDateTime { get; set; }
        public string? Id { get; set; }
        public string? MemberType { get; set; }
        public string? PrincipalId { get; set; }
        public string? RoleAssignmentOriginId { get; set; }
        public string? RoleAssignmentScheduleId { get; set; }
        public string? RoleDefinitionId { get; set; }
        public DateTimeOffset? StartDateTime { get; set; }
        public UnifiedRoleEligibilityScheduleInstance? ActivatedUsing { get; set; }
        public AppScope? AppScope { get; set; }
        public DirectoryObject? DirectoryScope { get; set; }
        public DirectoryObject? Principal { get; set; }
        public UnifiedRoleDefinition? RoleDefinition { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/unifiedroleassignmentscheduleinstance-get?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/unifiedroleassignmentscheduleinstance-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<UnifiedroleAssignmentScheduleinstanceGetResponse> UnifiedroleAssignmentScheduleinstanceGetAsync()
        {
            var p = new UnifiedroleAssignmentScheduleinstanceGetParameter();
            return await this.SendAsync<UnifiedroleAssignmentScheduleinstanceGetParameter, UnifiedroleAssignmentScheduleinstanceGetResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/unifiedroleassignmentscheduleinstance-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<UnifiedroleAssignmentScheduleinstanceGetResponse> UnifiedroleAssignmentScheduleinstanceGetAsync(CancellationToken cancellationToken)
        {
            var p = new UnifiedroleAssignmentScheduleinstanceGetParameter();
            return await this.SendAsync<UnifiedroleAssignmentScheduleinstanceGetParameter, UnifiedroleAssignmentScheduleinstanceGetResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/unifiedroleassignmentscheduleinstance-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<UnifiedroleAssignmentScheduleinstanceGetResponse> UnifiedroleAssignmentScheduleinstanceGetAsync(UnifiedroleAssignmentScheduleinstanceGetParameter parameter)
        {
            return await this.SendAsync<UnifiedroleAssignmentScheduleinstanceGetParameter, UnifiedroleAssignmentScheduleinstanceGetResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/unifiedroleassignmentscheduleinstance-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<UnifiedroleAssignmentScheduleinstanceGetResponse> UnifiedroleAssignmentScheduleinstanceGetAsync(UnifiedroleAssignmentScheduleinstanceGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<UnifiedroleAssignmentScheduleinstanceGetParameter, UnifiedroleAssignmentScheduleinstanceGetResponse>(parameter, cancellationToken);
        }
    }
}
