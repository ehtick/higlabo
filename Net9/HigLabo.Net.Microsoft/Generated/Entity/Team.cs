﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/team?view=graph-rest-1.0
/// </summary>
public partial class Team
{
    public string? Id { get; set; }
    public string? Classification { get; set; }
    public TeamClassSettings? ClassSettings { get; set; }
    public DateTimeOffset? CreatedDateTime { get; set; }
    public string? Description { get; set; }
    public string? DisplayName { get; set; }
    public TeamFunSettings? FunSettings { get; set; }
    public TeamGuestSettings? GuestSettings { get; set; }
    public string? InternalId { get; set; }
    public bool? IsArchived { get; set; }
    public TeamMemberSettings? MemberSettings { get; set; }
    public TeamMessagingSettings? MessagingSettings { get; set; }
    public TeamSpecialization? Specialization { get; set; }
    public TeamSummary? Summary { get; set; }
    public string? TenantId { get; set; }
    public TeamVisibilityType? Visibility { get; set; }
    public string? WebUrl { get; set; }
    public Channel[]? AllChannels { get; set; }
    public Channel[]? Channels { get; set; }
    public Channel[]? IncomingChannels { get; set; }
    public TeamsAppInstallation[]? InstalledApps { get; set; }
    public ConversationMember[]? Members { get; set; }
    public TeamsASyncOperation[]? Operations { get; set; }
    public ProfilePhoto? Photo { get; set; }
    public Channel? PrimaryChannel { get; set; }
    public Schedule? Schedule { get; set; }
    public TeamworkTag[]? Tags { get; set; }
    public TeamsTemplate? Template { get; set; }
}
