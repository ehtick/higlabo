﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/team-put-schedule?view=graph-rest-1.0
/// </summary>
public partial class TeamPutScheduleParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? TeamId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Teams_TeamId_Schedule: return $"/teams/{TeamId}/schedule";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Teams_TeamId_Schedule,
    }

    public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
    string IRestApiParameter.ApiPath
    {
        get
        {
            return this.ApiPathSetting.GetApiPath();
        }
    }
    string IRestApiParameter.HttpMethod { get; } = "PUT";
}
public partial class TeamPutScheduleResponse : RestApiResponse
{
    public enum ScheduleOperationStatus
    {
        NotStarted,
        Running,
        Completed,
        Failed,
    }

    public bool? Enabled { get; set; }
    public string? Id { get; set; }
    public bool? OfferShiftRequestsEnabled { get; set; }
    public bool? OpenShiftsEnabled { get; set; }
    public ScheduleOperationStatus ProvisionStatus { get; set; }
    public string? ProvisionStatusCode { get; set; }
    public bool? SwapShiftsRequestsEnabled { get; set; }
    public bool? TimeClockEnabled { get; set; }
    public bool? TimeOffRequestsEnabled { get; set; }
    public string? TimeZone { get; set; }
    public OpenShiftChangeRequest[]? OpenShiftChangeRequests { get; set; }
    public OpenShift[]? OpenShifts { get; set; }
    public SchedulingGroup[]? SchedulingGroups { get; set; }
    public Shift[]? Shifts { get; set; }
    public SwapShiftsChangeRequest[]? SwapShiftChangeRequests { get; set; }
    public TimeOff[]? TimesOff { get; set; }
    public TimeOffReason[]? TimeOffReasons { get; set; }
    public TimeOffRequest[]? Timeoffrequest { get; set; }
    public WorkforceIntegration[]? WorkforceIntegrations { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/team-put-schedule?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/team-put-schedule?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TeamPutScheduleResponse> TeamPutScheduleAsync()
    {
        var p = new TeamPutScheduleParameter();
        return await this.SendAsync<TeamPutScheduleParameter, TeamPutScheduleResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/team-put-schedule?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TeamPutScheduleResponse> TeamPutScheduleAsync(CancellationToken cancellationToken)
    {
        var p = new TeamPutScheduleParameter();
        return await this.SendAsync<TeamPutScheduleParameter, TeamPutScheduleResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/team-put-schedule?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TeamPutScheduleResponse> TeamPutScheduleAsync(TeamPutScheduleParameter parameter)
    {
        return await this.SendAsync<TeamPutScheduleParameter, TeamPutScheduleResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/team-put-schedule?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TeamPutScheduleResponse> TeamPutScheduleAsync(TeamPutScheduleParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<TeamPutScheduleParameter, TeamPutScheduleResponse>(parameter, cancellationToken);
    }
}
