﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/channel-get-filesfolder?view=graph-rest-1.0
/// </summary>
public partial class ChannelGetFilesFolderParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? TeamsId { get; set; }
        public string? ChannelsId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Teams_Id_Channels_Id_FilesFolder: return $"/teams/{TeamsId}/channels/{ChannelsId}/filesFolder";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Teams_Id_Channels_Id_FilesFolder,
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
public partial class ChannelGetFilesFolderResponse : RestApiResponse
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
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/channel-get-filesfolder?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/channel-get-filesfolder?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChannelGetFilesFolderResponse> ChannelGetFilesFolderAsync()
    {
        var p = new ChannelGetFilesFolderParameter();
        return await this.SendAsync<ChannelGetFilesFolderParameter, ChannelGetFilesFolderResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/channel-get-filesfolder?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChannelGetFilesFolderResponse> ChannelGetFilesFolderAsync(CancellationToken cancellationToken)
    {
        var p = new ChannelGetFilesFolderParameter();
        return await this.SendAsync<ChannelGetFilesFolderParameter, ChannelGetFilesFolderResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/channel-get-filesfolder?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChannelGetFilesFolderResponse> ChannelGetFilesFolderAsync(ChannelGetFilesFolderParameter parameter)
    {
        return await this.SendAsync<ChannelGetFilesFolderParameter, ChannelGetFilesFolderResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/channel-get-filesfolder?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ChannelGetFilesFolderResponse> ChannelGetFilesFolderAsync(ChannelGetFilesFolderParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<ChannelGetFilesFolderParameter, ChannelGetFilesFolderResponse>(parameter, cancellationToken);
    }
}
