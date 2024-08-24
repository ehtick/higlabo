﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/notebook-getrecentnotebooks?view=graph-rest-1.0
    /// </summary>
    public partial class NotebookGetrecentnotebooksParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? IdOrUserPrincipalName { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Me_Onenote_Notebooks_GetRecentNotebooks: return $"/me/onenote/notebooks/getRecentNotebooks";
                    case ApiPath.Users_IdOrUserPrincipalName_Onenote_Notebooks_GetRecentNotebooks: return $"/users/{IdOrUserPrincipalName}/onenote/notebooks/getRecentNotebooks";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            Me_Onenote_Notebooks_GetRecentNotebooks,
            Users_IdOrUserPrincipalName_Onenote_Notebooks_GetRecentNotebooks,
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
    public partial class NotebookGetrecentnotebooksResponse : RestApiResponse
    {
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/notebook-getrecentnotebooks?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/notebook-getrecentnotebooks?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<NotebookGetrecentnotebooksResponse> NotebookGetrecentnotebooksAsync()
        {
            var p = new NotebookGetrecentnotebooksParameter();
            return await this.SendAsync<NotebookGetrecentnotebooksParameter, NotebookGetrecentnotebooksResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/notebook-getrecentnotebooks?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<NotebookGetrecentnotebooksResponse> NotebookGetrecentnotebooksAsync(CancellationToken cancellationToken)
        {
            var p = new NotebookGetrecentnotebooksParameter();
            return await this.SendAsync<NotebookGetrecentnotebooksParameter, NotebookGetrecentnotebooksResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/notebook-getrecentnotebooks?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<NotebookGetrecentnotebooksResponse> NotebookGetrecentnotebooksAsync(NotebookGetrecentnotebooksParameter parameter)
        {
            return await this.SendAsync<NotebookGetrecentnotebooksParameter, NotebookGetrecentnotebooksResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/notebook-getrecentnotebooks?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<NotebookGetrecentnotebooksResponse> NotebookGetrecentnotebooksAsync(NotebookGetrecentnotebooksParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<NotebookGetrecentnotebooksParameter, NotebookGetrecentnotebooksResponse>(parameter, cancellationToken);
        }
    }
}
