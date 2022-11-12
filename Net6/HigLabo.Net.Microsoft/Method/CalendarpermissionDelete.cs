﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    public partial class CalendarpermissionDeleteParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? UsersId { get; set; }
            public string? CalendarPermissionsId { get; set; }
            public string? GroupsId { get; set; }
            public string? EventsId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Users_Id_Calendar_CalendarPermissions_Id: return $"/users/{UsersId}/calendar/calendarPermissions/{CalendarPermissionsId}";
                    case ApiPath.Groups_Id_Calendar_CalendarPermissions_Id: return $"/groups/{GroupsId}/calendar/calendarPermissions/{CalendarPermissionsId}";
                    case ApiPath.Users_Id_Events_Id_Calendar_CalendarPermissions_Id: return $"/users/{UsersId}/events/{EventsId}/calendar/calendarPermissions/{CalendarPermissionsId}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            Users_Id_Calendar_CalendarPermissions_Id,
            Groups_Id_Calendar_CalendarPermissions_Id,
            Users_Id_Events_Id_Calendar_CalendarPermissions_Id,
        }

        public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
        string IRestApiParameter.ApiPath
        {
            get
            {
                return this.ApiPathSetting.GetApiPath();
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "DELETE";
    }
    public partial class CalendarpermissionDeleteResponse : RestApiResponse
    {
    }
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/calendarpermission-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<CalendarpermissionDeleteResponse> CalendarpermissionDeleteAsync()
        {
            var p = new CalendarpermissionDeleteParameter();
            return await this.SendAsync<CalendarpermissionDeleteParameter, CalendarpermissionDeleteResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/calendarpermission-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<CalendarpermissionDeleteResponse> CalendarpermissionDeleteAsync(CancellationToken cancellationToken)
        {
            var p = new CalendarpermissionDeleteParameter();
            return await this.SendAsync<CalendarpermissionDeleteParameter, CalendarpermissionDeleteResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/calendarpermission-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<CalendarpermissionDeleteResponse> CalendarpermissionDeleteAsync(CalendarpermissionDeleteParameter parameter)
        {
            return await this.SendAsync<CalendarpermissionDeleteParameter, CalendarpermissionDeleteResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/graph/api/calendarpermission-delete?view=graph-rest-1.0
        /// </summary>
        public async Task<CalendarpermissionDeleteResponse> CalendarpermissionDeleteAsync(CalendarpermissionDeleteParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<CalendarpermissionDeleteParameter, CalendarpermissionDeleteResponse>(parameter, cancellationToken);
        }
    }
}