﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/directoryobject-getmembergroups?view=graph-rest-1.0
/// </summary>
public partial class DirectoryObjectGetMemberGroupsParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? Id { get; set; }
        public string? IdOrUserPrincipalName { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.DirectoryObjects_Id_GetMemberGroups: return $"/directoryObjects/{Id}/getMemberGroups";
                case ApiPath.Me_GetMemberGroups: return $"/me/getMemberGroups";
                case ApiPath.Users_IdOrUserPrincipalName_GetMemberGroups: return $"/users/{IdOrUserPrincipalName}/getMemberGroups";
                case ApiPath.Groups_Id_GetMemberGroups: return $"/groups/{Id}/getMemberGroups";
                case ApiPath.ServicePrincipals_Id_GetMemberGroups: return $"/servicePrincipals/{Id}/getMemberGroups";
                case ApiPath.Contacts_Id_GetMemberGroups: return $"/contacts/{Id}/getMemberGroups";
                case ApiPath.Devices_Id_GetMemberGroups: return $"/devices/{Id}/getMemberGroups";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        DirectoryObjects_Id_GetMemberGroups,
        Me_GetMemberGroups,
        Users_IdOrUserPrincipalName_GetMemberGroups,
        Groups_Id_GetMemberGroups,
        ServicePrincipals_Id_GetMemberGroups,
        Contacts_Id_GetMemberGroups,
        Devices_Id_GetMemberGroups,
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
    public bool? SecurityEnabledOnly { get; set; }
}
public partial class DirectoryObjectGetMemberGroupsResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/directoryobject-getmembergroups?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/directoryobject-getmembergroups?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<DirectoryObjectGetMemberGroupsResponse> DirectoryObjectGetMemberGroupsAsync()
    {
        var p = new DirectoryObjectGetMemberGroupsParameter();
        return await this.SendAsync<DirectoryObjectGetMemberGroupsParameter, DirectoryObjectGetMemberGroupsResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/directoryobject-getmembergroups?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<DirectoryObjectGetMemberGroupsResponse> DirectoryObjectGetMemberGroupsAsync(CancellationToken cancellationToken)
    {
        var p = new DirectoryObjectGetMemberGroupsParameter();
        return await this.SendAsync<DirectoryObjectGetMemberGroupsParameter, DirectoryObjectGetMemberGroupsResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/directoryobject-getmembergroups?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<DirectoryObjectGetMemberGroupsResponse> DirectoryObjectGetMemberGroupsAsync(DirectoryObjectGetMemberGroupsParameter parameter)
    {
        return await this.SendAsync<DirectoryObjectGetMemberGroupsParameter, DirectoryObjectGetMemberGroupsResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/directoryobject-getmembergroups?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<DirectoryObjectGetMemberGroupsResponse> DirectoryObjectGetMemberGroupsAsync(DirectoryObjectGetMemberGroupsParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<DirectoryObjectGetMemberGroupsParameter, DirectoryObjectGetMemberGroupsResponse>(parameter, cancellationToken);
    }
}
