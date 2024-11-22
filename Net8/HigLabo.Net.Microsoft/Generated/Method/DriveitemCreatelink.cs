﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/driveitem-createlink?view=graph-rest-1.0
/// </summary>
public partial class DriveItemCreatelinkParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? DriveId { get; set; }
        public string? ItemId { get; set; }
        public string? GroupId { get; set; }
        public string? SiteId { get; set; }
        public string? UserId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Drives_DriveId_Items_ItemId_CreateLink: return $"/drives/{DriveId}/items/{ItemId}/createLink";
                case ApiPath.Groups_GroupId_Drive_Items_ItemId_CreateLink: return $"/groups/{GroupId}/drive/items/{ItemId}/createLink";
                case ApiPath.Me_Drive_Items_ItemId_CreateLink: return $"/me/drive/items/{ItemId}/createLink";
                case ApiPath.Sites_SiteId_Drive_Items_ItemId_CreateLink: return $"/sites/{SiteId}/drive/items/{ItemId}/createLink";
                case ApiPath.Users_UserId_Drive_Items_ItemId_CreateLink: return $"/users/{UserId}/drive/items/{ItemId}/createLink";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Drives_DriveId_Items_ItemId_CreateLink,
        Groups_GroupId_Drive_Items_ItemId_CreateLink,
        Me_Drive_Items_ItemId_CreateLink,
        Sites_SiteId_Drive_Items_ItemId_CreateLink,
        Users_UserId_Drive_Items_ItemId_CreateLink,
    }

    public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
    string IRestApiParameter.ApiPath
    {
        get
        {
            return this.ApiPathSetting.GetApiPath();
        }
    }
    string IRestApiParameter.HttpMethod { get; } = "POST";
    public string? Type { get; set; }
    public string? Password { get; set; }
    public string? ExpirationDateTime { get; set; }
    public bool? RetainInheritedPermissions { get; set; }
    public string? Scope { get; set; }
    public string? Id { get; set; }
    public bool? HasPassword { get; set; }
    public SharePointIdentitySet[]? GrantedToIdentitiesV2 { get; set; }
    public SharePointIdentitySet? GrantedToV2 { get; set; }
    public ItemReference? InheritedFrom { get; set; }
    public SharingInvitation? Invitation { get; set; }
    public SharingLink? Link { get; set; }
    public string[]? Roles { get; set; }
    public string? ShareId { get; set; }
}
public partial class DriveItemCreatelinkResponse : RestApiResponse
{
    public DateTimeOffset? ExpirationDateTime { get; set; }
    public string? Id { get; set; }
    public bool? HasPassword { get; set; }
    public SharePointIdentitySet[]? GrantedToIdentitiesV2 { get; set; }
    public SharePointIdentitySet? GrantedToV2 { get; set; }
    public ItemReference? InheritedFrom { get; set; }
    public SharingInvitation? Invitation { get; set; }
    public SharingLink? Link { get; set; }
    public string[]? Roles { get; set; }
    public string? ShareId { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/driveitem-createlink?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/driveitem-createlink?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<DriveItemCreatelinkResponse> DriveItemCreatelinkAsync()
    {
        var p = new DriveItemCreatelinkParameter();
        return await this.SendAsync<DriveItemCreatelinkParameter, DriveItemCreatelinkResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/driveitem-createlink?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<DriveItemCreatelinkResponse> DriveItemCreatelinkAsync(CancellationToken cancellationToken)
    {
        var p = new DriveItemCreatelinkParameter();
        return await this.SendAsync<DriveItemCreatelinkParameter, DriveItemCreatelinkResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/driveitem-createlink?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<DriveItemCreatelinkResponse> DriveItemCreatelinkAsync(DriveItemCreatelinkParameter parameter)
    {
        return await this.SendAsync<DriveItemCreatelinkParameter, DriveItemCreatelinkResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/driveitem-createlink?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<DriveItemCreatelinkResponse> DriveItemCreatelinkAsync(DriveItemCreatelinkParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<DriveItemCreatelinkParameter, DriveItemCreatelinkResponse>(parameter, cancellationToken);
    }
}
