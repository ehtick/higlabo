﻿using HigLabo.Net.OAuth;
using System.Runtime.CompilerServices;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/directoryrole-list-members?view=graph-rest-1.0
    /// </summary>
    public partial class DirectoryroleListMembersParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? RoleId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.DirectoryRoles_RoleId_Members: return $"/directoryRoles/{RoleId}/members";
                    case ApiPath.DirectoryRoles: return $"/directoryRoles";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            DirectoryRoles_RoleId_Members,
            DirectoryRoles,
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
    public partial class DirectoryroleListMembersResponse : RestApiResponse<DirectoryObject>
    {
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/directoryrole-list-members?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/directoryrole-list-members?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<DirectoryroleListMembersResponse> DirectoryroleListMembersAsync()
        {
            var p = new DirectoryroleListMembersParameter();
            return await this.SendAsync<DirectoryroleListMembersParameter, DirectoryroleListMembersResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/directoryrole-list-members?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<DirectoryroleListMembersResponse> DirectoryroleListMembersAsync(CancellationToken cancellationToken)
        {
            var p = new DirectoryroleListMembersParameter();
            return await this.SendAsync<DirectoryroleListMembersParameter, DirectoryroleListMembersResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/directoryrole-list-members?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<DirectoryroleListMembersResponse> DirectoryroleListMembersAsync(DirectoryroleListMembersParameter parameter)
        {
            return await this.SendAsync<DirectoryroleListMembersParameter, DirectoryroleListMembersResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/directoryrole-list-members?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<DirectoryroleListMembersResponse> DirectoryroleListMembersAsync(DirectoryroleListMembersParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<DirectoryroleListMembersParameter, DirectoryroleListMembersResponse>(parameter, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/directoryrole-list-members?view=graph-rest-1.0
        /// </summary>
        public async IAsyncEnumerable<DirectoryObject> DirectoryroleListMembersEnumerateAsync(DirectoryroleListMembersParameter parameter, [EnumeratorCancellation] CancellationToken cancellationToken)
        {
            var res = await this.SendAsync<DirectoryroleListMembersParameter, DirectoryroleListMembersResponse>(parameter, cancellationToken);
            if (res.Value != null)
            {
                foreach (var item in res.Value)
                {
                    yield return item;
                }
                if (res.ODataNextLink.HasValue())
                {
                    await foreach (var item in this.GetValueListAsync<DirectoryObject>(res.ODataNextLink, cancellationToken))
                    {
                        yield return item;
                    }
                }
            }
        }
    }
}
