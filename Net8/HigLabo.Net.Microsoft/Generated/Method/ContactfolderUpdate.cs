﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/contactfolder-update?view=graph-rest-1.0
/// </summary>
public partial class ContactFolderUpdateParameter : IRestApiParameter
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
                case ApiPath.Me_ContactFolders_Id: return $"/me/contactFolders/{Id}";
                case ApiPath.Users_IdOrUserPrincipalName_ContactFolders_Id: return $"/users/{IdOrUserPrincipalName}/contactFolders/{Id}";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Me_ContactFolders_Id,
        Users_IdOrUserPrincipalName_ContactFolders_Id,
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
    public string? DisplayName { get; set; }
    public string? ParentFolderId { get; set; }
}
public partial class ContactFolderUpdateResponse : RestApiResponse
{
    public string? DisplayName { get; set; }
    public string? Id { get; set; }
    public string? ParentFolderId { get; set; }
    public ContactFolder[]? ChildFolders { get; set; }
    public Contact[]? Contacts { get; set; }
    public MultiValueLegacyExtendedProperty[]? MultiValueExtendedProperties { get; set; }
    public SingleValueLegacyExtendedProperty[]? SingleValueExtendedProperties { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/contactfolder-update?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/contactfolder-update?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ContactFolderUpdateResponse> ContactFolderUpdateAsync()
    {
        var p = new ContactFolderUpdateParameter();
        return await this.SendAsync<ContactFolderUpdateParameter, ContactFolderUpdateResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/contactfolder-update?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ContactFolderUpdateResponse> ContactFolderUpdateAsync(CancellationToken cancellationToken)
    {
        var p = new ContactFolderUpdateParameter();
        return await this.SendAsync<ContactFolderUpdateParameter, ContactFolderUpdateResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/contactfolder-update?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ContactFolderUpdateResponse> ContactFolderUpdateAsync(ContactFolderUpdateParameter parameter)
    {
        return await this.SendAsync<ContactFolderUpdateParameter, ContactFolderUpdateResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/contactfolder-update?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ContactFolderUpdateResponse> ContactFolderUpdateAsync(ContactFolderUpdateParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<ContactFolderUpdateParameter, ContactFolderUpdateResponse>(parameter, cancellationToken);
    }
}
