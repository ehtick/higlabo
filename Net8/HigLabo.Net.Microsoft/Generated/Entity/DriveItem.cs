﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/driveitem?view=graph-rest-1.0
/// </summary>
public partial class DriveItem
{
    public Audio? Audio { get; set; }
    public Bundle? Bundle { get; set; }
    public Stream? Content { get; set; }
    public IdentitySet? CreatedBy { get; set; }
    public DateTimeOffset? CreatedDateTime { get; set; }
    public string? CTag { get; set; }
    public Deleted? Deleted { get; set; }
    public string? Description { get; set; }
    public string? ETag { get; set; }
    public File? File { get; set; }
    public FileSystemInfo? FileSystemInfo { get; set; }
    public Folder? Folder { get; set; }
    public string? Id { get; set; }
    public Image? Image { get; set; }
    public IdentitySet? LastModifiedBy { get; set; }
    public DateTimeOffset? LastModifiedDateTime { get; set; }
    public GeoCoordinates? Location { get; set; }
    public Malware? Malware { get; set; }
    public string? Name { get; set; }
    public Package? Package { get; set; }
    public ItemReference? ParentReference { get; set; }
    public PendingOperations? PendingOperations { get; set; }
    public Photo? Photo { get; set; }
    public PublicationFacet? Publication { get; set; }
    public RemoteItem? RemoteItem { get; set; }
    public Root? Root { get; set; }
    public SearchResult? SearchResult { get; set; }
    public Shared? Shared { get; set; }
    public SharePointIds? SharepointIds { get; set; }
    public Int64? Size { get; set; }
    public SpecialFolder? SpecialFolder { get; set; }
    public Video? Video { get; set; }
    public string? WebDavUrl { get; set; }
    public string? WebUrl { get; set; }
    public ItemActivity[]? Activities { get; set; }
    public ItemAnalytics? Analytics { get; set; }
    public DriveItem[]? Children { get; set; }
    public User? CreatedByUser { get; set; }
    public User? LastModifiedByUser { get; set; }
    public ListItem? ListItem { get; set; }
    public Permission[]? Permissions { get; set; }
    public Subscription[]? Subscriptions { get; set; }
    public ThumbnailSet[]? Thumbnails { get; set; }
    public DriveItemVersion[]? Versions { get; set; }
    public Workbook? Workbook { get; set; }
}
