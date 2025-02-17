﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/virtualevent?view=graph-rest-1.0
/// </summary>
public partial class VirtualEvent
{
    public enum VirtualEventVirtualEventStatus
    {
        Draft,
        Published,
        Canceled,
        UnknownFutureValue,
    }

    public CommunicationsIdentitySet? CreatedBy { get; set; }
    public ItemBody? Description { get; set; }
    public string? DisplayName { get; set; }
    public DateTimeTimeZone? EndDateTime { get; set; }
    public string? Id { get; set; }
    public VirtualEventSettings? Settings { get; set; }
    public DateTimeTimeZone? StartDateTime { get; set; }
    public VirtualEventVirtualEventStatus Status { get; set; }
    public VirtualEventPresenter[]? Presenters { get; set; }
    public VirtualEventSession[]? Sessions { get; set; }
}
