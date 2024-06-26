﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/unifiedroleassignmentscheduleinstance-filterbycurrentuser?view=graph-rest-1.0
    /// </summary>
    public partial class UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.RoleManagement_Directory_RoleAssignmentScheduleInstances_FilterByCurrentUser: return $"/roleManagement/directory/roleAssignmentScheduleInstances/filterByCurrentUser";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
            AppScopeId,
            AssignmentType,
            DirectoryScopeId,
            EndDateTime,
            Id,
            MemberType,
            PrincipalId,
            RoleAssignmentOriginId,
            RoleAssignmentScheduleId,
            RoleDefinitionId,
            StartDateTime,
            ActivatedUsing,
            AppScope,
            DirectoryScope,
            Principal,
            RoleDefinition,
        }
        public enum ApiPath
        {
            RoleManagement_Directory_RoleAssignmentScheduleInstances_FilterByCurrentUser,
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
    public partial class UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserResponse : RestApiResponse
    {
        public UnifiedRoleAssignmentScheduleInstance[]? Value { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/unifiedroleassignmentscheduleinstance-filterbycurrentuser?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/unifiedroleassignmentscheduleinstance-filterbycurrentuser?view=graph-rest-1.0
        /// </summary>
        public async Task<UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserResponse> UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserAsync()
        {
            var p = new UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserParameter();
            return await this.SendAsync<UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserParameter, UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/unifiedroleassignmentscheduleinstance-filterbycurrentuser?view=graph-rest-1.0
        /// </summary>
        public async Task<UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserResponse> UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserAsync(CancellationToken cancellationToken)
        {
            var p = new UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserParameter();
            return await this.SendAsync<UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserParameter, UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/unifiedroleassignmentscheduleinstance-filterbycurrentuser?view=graph-rest-1.0
        /// </summary>
        public async Task<UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserResponse> UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserAsync(UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserParameter parameter)
        {
            return await this.SendAsync<UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserParameter, UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/unifiedroleassignmentscheduleinstance-filterbycurrentuser?view=graph-rest-1.0
        /// </summary>
        public async Task<UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserResponse> UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserAsync(UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserParameter, UnifiedroleAssignmentscheduleinstanceFilterbycurrentUserResponse>(parameter, cancellationToken);
        }
    }
}
