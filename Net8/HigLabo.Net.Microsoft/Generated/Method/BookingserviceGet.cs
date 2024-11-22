﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/bookingservice-get?view=graph-rest-1.0
/// </summary>
public partial class BookingServiceGetParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? BookingBusinessesId { get; set; }
        public string? ServicesId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Solutions_BookingBusinesses_Id_Services_Id: return $"/solutions/bookingBusinesses/{BookingBusinessesId}/services/{ServicesId}";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Solutions_BookingBusinesses_Id_Services_Id,
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
public partial class BookingServiceGetResponse : RestApiResponse
{
    public enum BookingServiceBookingPriceType
    {
        Undefined,
        FixedPrice,
        StartingAt,
        Hourly,
        Free,
        PriceVaries,
        CallUs,
        NotSet,
        UnknownFutureValue,
    }

    public string? AdditionalInformation { get; set; }
    public BookingQuestionAssignment[]? CustomQuestions { get; set; }
    public string? DefaultDuration { get; set; }
    public Location? DefaultLocation { get; set; }
    public Double? DefaultPrice { get; set; }
    public BookingServiceBookingPriceType DefaultPriceType { get; set; }
    public BookingReminder[]? DefaultReminders { get; set; }
    public string? Description { get; set; }
    public string? DisplayName { get; set; }
    public string? Id { get; set; }
    public bool? IsAnonymousJoinEnabled { get; set; }
    public bool? IsHiddenFromCustomers { get; set; }
    public bool? IsLocationOnline { get; set; }
    public string? LanguageTag { get; set; }
    public Int32? MaximumAttendeesCount { get; set; }
    public string? Notes { get; set; }
    public string? PostBuffer { get; set; }
    public string? PreBuffer { get; set; }
    public BookingSchedulingPolicy? SchedulingPolicy { get; set; }
    public bool? SmsNotificationsEnabled { get; set; }
    public String[]? StaffMemberIds { get; set; }
    public string? WebUrl { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/bookingservice-get?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/bookingservice-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<BookingServiceGetResponse> BookingServiceGetAsync()
    {
        var p = new BookingServiceGetParameter();
        return await this.SendAsync<BookingServiceGetParameter, BookingServiceGetResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/bookingservice-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<BookingServiceGetResponse> BookingServiceGetAsync(CancellationToken cancellationToken)
    {
        var p = new BookingServiceGetParameter();
        return await this.SendAsync<BookingServiceGetParameter, BookingServiceGetResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/bookingservice-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<BookingServiceGetResponse> BookingServiceGetAsync(BookingServiceGetParameter parameter)
    {
        return await this.SendAsync<BookingServiceGetParameter, BookingServiceGetResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/bookingservice-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<BookingServiceGetResponse> BookingServiceGetAsync(BookingServiceGetParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<BookingServiceGetParameter, BookingServiceGetResponse>(parameter, cancellationToken);
    }
}
