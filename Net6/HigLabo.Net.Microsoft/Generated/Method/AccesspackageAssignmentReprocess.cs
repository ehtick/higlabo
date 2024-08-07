﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/accesspackageassignment-reprocess?view=graph-rest-1.0
    /// </summary>
    public partial class AccesspackageAssignmentReprocessParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? Id { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.IdentityGovernance_EntitlementManagement_Assignments_Id_Reprocess: return $"/identityGovernance/entitlementManagement/assignments/{Id}/reprocess";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum AccessPackageAssignmentAccessPackageAssignmentState
        {
            Delivering,
            PartiallyDelivered,
            Delivered,
            Expired,
            DeliveryFailed,
            UnknownFutureValue,
            Eq,
        }
        public enum ApiPath
        {
            IdentityGovernance_EntitlementManagement_Assignments_Id_Reprocess,
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
        public DateTimeOffset? ExpiredDateTime { get; set; }
        public string? Id { get; set; }
        public EntitlementManagementSchedule? Schedule { get; set; }
        public AccessPackageAssignmentAccessPackageAssignmentState State { get; set; }
        public string? Status { get; set; }
        public AccessPackage? AccessPackage { get; set; }
        public AccessPackageSubject? Target { get; set; }
        public AccessPackageAssignmentPolicy? AssignmentPolicy { get; set; }
    }
    public partial class AccesspackageAssignmentReprocessResponse : RestApiResponse
    {
        public enum AccessPackageAssignmentAccessPackageAssignmentState
        {
            Delivering,
            PartiallyDelivered,
            Delivered,
            Expired,
            DeliveryFailed,
            UnknownFutureValue,
            Eq,
        }

        public DateTimeOffset? ExpiredDateTime { get; set; }
        public string? Id { get; set; }
        public EntitlementManagementSchedule? Schedule { get; set; }
        public AccessPackageAssignmentAccessPackageAssignmentState State { get; set; }
        public string? Status { get; set; }
        public AccessPackage? AccessPackage { get; set; }
        public AccessPackageSubject? Target { get; set; }
        public AccessPackageAssignmentPolicy? AssignmentPolicy { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/accesspackageassignment-reprocess?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/accesspackageassignment-reprocess?view=graph-rest-1.0
        /// </summary>
        public async Task<AccesspackageAssignmentReprocessResponse> AccesspackageAssignmentReprocessAsync()
        {
            var p = new AccesspackageAssignmentReprocessParameter();
            return await this.SendAsync<AccesspackageAssignmentReprocessParameter, AccesspackageAssignmentReprocessResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/accesspackageassignment-reprocess?view=graph-rest-1.0
        /// </summary>
        public async Task<AccesspackageAssignmentReprocessResponse> AccesspackageAssignmentReprocessAsync(CancellationToken cancellationToken)
        {
            var p = new AccesspackageAssignmentReprocessParameter();
            return await this.SendAsync<AccesspackageAssignmentReprocessParameter, AccesspackageAssignmentReprocessResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/accesspackageassignment-reprocess?view=graph-rest-1.0
        /// </summary>
        public async Task<AccesspackageAssignmentReprocessResponse> AccesspackageAssignmentReprocessAsync(AccesspackageAssignmentReprocessParameter parameter)
        {
            return await this.SendAsync<AccesspackageAssignmentReprocessParameter, AccesspackageAssignmentReprocessResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/accesspackageassignment-reprocess?view=graph-rest-1.0
        /// </summary>
        public async Task<AccesspackageAssignmentReprocessResponse> AccesspackageAssignmentReprocessAsync(AccesspackageAssignmentReprocessParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<AccesspackageAssignmentReprocessParameter, AccesspackageAssignmentReprocessResponse>(parameter, cancellationToken);
        }
    }
}
