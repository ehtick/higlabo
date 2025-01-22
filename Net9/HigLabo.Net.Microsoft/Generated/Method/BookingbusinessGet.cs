﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/bookingbusiness-get?view=graph-rest-1.0
/// </summary>
public partial class BookingBusinessGetParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? Id { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Solutions_BookingBusinesses_Id: return $"/solutions/bookingBusinesses/{Id}";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Solutions_BookingBusinesses_Id,
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
public partial class BookingBusinessGetResponse : RestApiResponse
{
    public PhysicalAddress? Address { get; set; }
    public BookingWorkHours[]? BusinessHours { get; set; }
    public string? BusinessType { get; set; }
    public string? DefaultCurrencyIso { get; set; }
    public string? DisplayName { get; set; }
    public string? Email { get; set; }
    public string? Id { get; set; }
    public bool? IsPublished { get; set; }
    public string? LanguageTag { get; set; }
    public string? Phone { get; set; }
    public string? PublicUrl { get; set; }
    public BookingSchedulingPolicy? SchedulingPolicy { get; set; }
    public string? WebSiteUrl { get; set; }
    public BookingAppointment[]? Appointments { get; set; }
    public BookingAppointment[]? CalendarView { get; set; }
    public BookingCustomer[]? Customers { get; set; }
    public BookingCustomQuestion[]? CustomQuestions { get; set; }
    public BookingService[]? Services { get; set; }
    public BookingStaffMember[]? StaffMembers { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/bookingbusiness-get?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/bookingbusiness-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<BookingBusinessGetResponse> BookingBusinessGetAsync()
    {
        var p = new BookingBusinessGetParameter();
        return await this.SendAsync<BookingBusinessGetParameter, BookingBusinessGetResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/bookingbusiness-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<BookingBusinessGetResponse> BookingBusinessGetAsync(CancellationToken cancellationToken)
    {
        var p = new BookingBusinessGetParameter();
        return await this.SendAsync<BookingBusinessGetParameter, BookingBusinessGetResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/bookingbusiness-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<BookingBusinessGetResponse> BookingBusinessGetAsync(BookingBusinessGetParameter parameter)
    {
        return await this.SendAsync<BookingBusinessGetParameter, BookingBusinessGetResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/bookingbusiness-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<BookingBusinessGetResponse> BookingBusinessGetAsync(BookingBusinessGetParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<BookingBusinessGetParameter, BookingBusinessGetResponse>(parameter, cancellationToken);
    }
}
