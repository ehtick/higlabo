﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/driveitem-checkout?view=graph-rest-1.0
/// </summary>
public partial class DriveItemCheckoutParameter : IRestApiParameter
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
                case ApiPath.Drives_DriveId_Items_ItemId_Checkout: return $"/drives/{DriveId}/items/{ItemId}/checkout";
                case ApiPath.Groups_GroupId_Drive_Items_ItemId_Checkout: return $"/groups/{GroupId}/drive/items/{ItemId}/checkout";
                case ApiPath.Me_Drive_Items_ItemId_Checkout: return $"/me/drive/items/{ItemId}/checkout";
                case ApiPath.Sites_SiteId_Drive_Items_ItemId_Checkout: return $"/sites/{SiteId}/drive/items/{ItemId}/checkout";
                case ApiPath.Users_UserId_Drive_Items_ItemId_Checkout: return $"/users/{UserId}/drive/items/{ItemId}/checkout";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Drives_DriveId_Items_ItemId_Checkout,
        Groups_GroupId_Drive_Items_ItemId_Checkout,
        Me_Drive_Items_ItemId_Checkout,
        Sites_SiteId_Drive_Items_ItemId_Checkout,
        Users_UserId_Drive_Items_ItemId_Checkout,
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
}
public partial class DriveItemCheckoutResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/driveitem-checkout?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/driveitem-checkout?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<DriveItemCheckoutResponse> DriveItemCheckoutAsync()
    {
        var p = new DriveItemCheckoutParameter();
        return await this.SendAsync<DriveItemCheckoutParameter, DriveItemCheckoutResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/driveitem-checkout?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<DriveItemCheckoutResponse> DriveItemCheckoutAsync(CancellationToken cancellationToken)
    {
        var p = new DriveItemCheckoutParameter();
        return await this.SendAsync<DriveItemCheckoutParameter, DriveItemCheckoutResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/driveitem-checkout?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<DriveItemCheckoutResponse> DriveItemCheckoutAsync(DriveItemCheckoutParameter parameter)
    {
        return await this.SendAsync<DriveItemCheckoutParameter, DriveItemCheckoutResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/driveitem-checkout?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<DriveItemCheckoutResponse> DriveItemCheckoutAsync(DriveItemCheckoutParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<DriveItemCheckoutParameter, DriveItemCheckoutResponse>(parameter, cancellationToken);
    }
}
