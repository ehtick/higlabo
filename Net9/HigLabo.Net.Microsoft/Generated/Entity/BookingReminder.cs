﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/bookingreminder?view=graph-rest-1.0
/// </summary>
public partial class BookingReminder
{
    public enum BookingReminderBookingReminderRecipients
    {
        AllAttendees,
        Staff,
        Customer,
        UnknownFutureValue,
    }

    public string? Message { get; set; }
    public string? Offset { get; set; }
    public BookingReminderBookingReminderRecipients Recipients { get; set; }
}
