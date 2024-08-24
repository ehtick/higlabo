﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/bookingstaffmember-update?view=graph-rest-1.0
    /// </summary>
    public partial class BookingStaffMemberUpdateParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? BookingBusinessesId { get; set; }
            public string? StaffMembersId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Solutions_BookingBusinesses_Id_StaffMembers_Id: return $"/solutions/bookingBusinesses/{BookingBusinessesId}/staffMembers/{StaffMembersId}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum BookingStaffMemberUpdateParameterBookingStaffRole
        {
            Guest,
            Administrator,
            Viewer,
            ExternalGuest,
            UnknownFutureValue,
            Scheduler,
            TeamMember,
        }
        public enum ApiPath
        {
            Solutions_BookingBusinesses_Id_StaffMembers_Id,
        }

        public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
        string IRestApiParameter.ApiPath
        {
            get
            {
                return this.ApiPathSetting.GetApiPath();
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "PATCH";
        public bool? AvailabilityIsAffectedByPersonalCalendar { get; set; }
        public string? DisplayName { get; set; }
        public string? EmailAddress { get; set; }
        public bool? IsEmailNotificationEnabled { get; set; }
        public BookingStaffMemberUpdateParameterBookingStaffRole Role { get; set; }
        public string? TimeZone { get; set; }
        public bool? UseBusinessHours { get; set; }
        public BookingWorkHours[]? WorkingHours { get; set; }
    }
    public partial class BookingStaffMemberUpdateResponse : RestApiResponse
    {
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/bookingstaffmember-update?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/bookingstaffmember-update?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<BookingStaffMemberUpdateResponse> BookingStaffMemberUpdateAsync()
        {
            var p = new BookingStaffMemberUpdateParameter();
            return await this.SendAsync<BookingStaffMemberUpdateParameter, BookingStaffMemberUpdateResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/bookingstaffmember-update?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<BookingStaffMemberUpdateResponse> BookingStaffMemberUpdateAsync(CancellationToken cancellationToken)
        {
            var p = new BookingStaffMemberUpdateParameter();
            return await this.SendAsync<BookingStaffMemberUpdateParameter, BookingStaffMemberUpdateResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/bookingstaffmember-update?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<BookingStaffMemberUpdateResponse> BookingStaffMemberUpdateAsync(BookingStaffMemberUpdateParameter parameter)
        {
            return await this.SendAsync<BookingStaffMemberUpdateParameter, BookingStaffMemberUpdateResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/bookingstaffmember-update?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<BookingStaffMemberUpdateResponse> BookingStaffMemberUpdateAsync(BookingStaffMemberUpdateParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<BookingStaffMemberUpdateParameter, BookingStaffMemberUpdateResponse>(parameter, cancellationToken);
        }
    }
}
