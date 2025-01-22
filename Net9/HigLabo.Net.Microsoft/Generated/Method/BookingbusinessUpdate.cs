﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/bookingbusiness-update?view=graph-rest-1.0
/// </summary>
public partial class BookingBusinessUpdateParameter : IRestApiParameter
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
    string IRestApiParameter.HttpMethod { get; } = "PATCH";
    public PhysicalAddress? Address { get; set; }
    public BookingWorkHours[]? BusinessHours { get; set; }
    public string? BusinessType { get; set; }
    public string? DefaultCurrencyIso { get; set; }
    public string? DisplayName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public BookingSchedulingPolicy? SchedulingPolicy { get; set; }
    public string? WebSiteUrl { get; set; }
}
public partial class BookingBusinessUpdateResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/bookingbusiness-update?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/bookingbusiness-update?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<BookingBusinessUpdateResponse> BookingBusinessUpdateAsync()
    {
        var p = new BookingBusinessUpdateParameter();
        return await this.SendAsync<BookingBusinessUpdateParameter, BookingBusinessUpdateResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/bookingbusiness-update?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<BookingBusinessUpdateResponse> BookingBusinessUpdateAsync(CancellationToken cancellationToken)
    {
        var p = new BookingBusinessUpdateParameter();
        return await this.SendAsync<BookingBusinessUpdateParameter, BookingBusinessUpdateResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/bookingbusiness-update?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<BookingBusinessUpdateResponse> BookingBusinessUpdateAsync(BookingBusinessUpdateParameter parameter)
    {
        return await this.SendAsync<BookingBusinessUpdateParameter, BookingBusinessUpdateResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/bookingbusiness-update?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<BookingBusinessUpdateResponse> BookingBusinessUpdateAsync(BookingBusinessUpdateParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<BookingBusinessUpdateParameter, BookingBusinessUpdateResponse>(parameter, cancellationToken);
    }
}
