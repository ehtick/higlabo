﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/bookingcustomerinformation?view=graph-rest-1.0
/// </summary>
public partial class BookingCustomerInformation
{
    public string? CustomerId { get; set; }
    public BookingQuestionAnswer[]? CustomQuestionAnswers { get; set; }
    public string? EmailAddress { get; set; }
    public Location? Location { get; set; }
    public string? Name { get; set; }
    public string? Notes { get; set; }
    public string? Phone { get; set; }
    public string? TimeZone { get; set; }
}
