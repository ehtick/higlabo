﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/contactfolder-delete?view=graph-rest-1.0
    /// </summary>
    public partial class ContactFolderDeleteParameter : IRestApiParameter
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
        string IRestApiParameter.HttpMethod { get; } = "DELETE";
    }
    public partial class ContactFolderDeleteResponse : RestApiResponse
    {
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/contactfolder-delete?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/contactfolder-delete?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ContactFolderDeleteResponse> ContactFolderDeleteAsync()
        {
            var p = new ContactFolderDeleteParameter();
            return await this.SendAsync<ContactFolderDeleteParameter, ContactFolderDeleteResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/contactfolder-delete?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ContactFolderDeleteResponse> ContactFolderDeleteAsync(CancellationToken cancellationToken)
        {
            var p = new ContactFolderDeleteParameter();
            return await this.SendAsync<ContactFolderDeleteParameter, ContactFolderDeleteResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/contactfolder-delete?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ContactFolderDeleteResponse> ContactFolderDeleteAsync(ContactFolderDeleteParameter parameter)
        {
            return await this.SendAsync<ContactFolderDeleteParameter, ContactFolderDeleteResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/contactfolder-delete?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ContactFolderDeleteResponse> ContactFolderDeleteAsync(ContactFolderDeleteParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ContactFolderDeleteParameter, ContactFolderDeleteResponse>(parameter, cancellationToken);
        }
    }
}
