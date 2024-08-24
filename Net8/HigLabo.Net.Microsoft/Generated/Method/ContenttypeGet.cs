﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/contenttype-get?view=graph-rest-1.0
    /// </summary>
    public partial class ContentTypeGetParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? SiteId { get; set; }
            public string? ContentTypeId { get; set; }
            public string? ListId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Sites_SiteId_ContentTypes_ContentTypeId: return $"/sites/{SiteId}/contentTypes/{ContentTypeId}";
                    case ApiPath.Sites_SiteId_Lists_ListId_ContentTypes_ContentTypeId: return $"/sites/{SiteId}/lists/{ListId}/contentTypes/{ContentTypeId}";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            Sites_SiteId_ContentTypes_ContentTypeId,
            Sites_SiteId_Lists_ListId_ContentTypes_ContentTypeId,
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
    public partial class ContentTypeGetResponse : RestApiResponse
    {
        public String[]? AssociatedHubsUrls { get; set; }
        public string? Description { get; set; }
        public DocumentSet? DocumentSet { get; set; }
        public DocumentSetContent? DocumentTemplate { get; set; }
        public string? Group { get; set; }
        public bool? Hidden { get; set; }
        public string? Id { get; set; }
        public ItemReference? InheritedFrom { get; set; }
        public bool? IsBuiltIn { get; set; }
        public string? Name { get; set; }
        public ContentTypeOrder? Order { get; set; }
        public string? ParentId { get; set; }
        public bool? PropagateChanges { get; set; }
        public bool? ReadOnly { get; set; }
        public bool? Sealed { get; set; }
        public ContentType? Base { get; set; }
        public ColumnLink[]? ColumnLinks { get; set; }
        public ContentType[]? BaseTypes { get; set; }
        public ColumnDefinition[]? ColumnPositions { get; set; }
        public ColumnDefinition[]? Columns { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/contenttype-get?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/contenttype-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ContentTypeGetResponse> ContentTypeGetAsync()
        {
            var p = new ContentTypeGetParameter();
            return await this.SendAsync<ContentTypeGetParameter, ContentTypeGetResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/contenttype-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ContentTypeGetResponse> ContentTypeGetAsync(CancellationToken cancellationToken)
        {
            var p = new ContentTypeGetParameter();
            return await this.SendAsync<ContentTypeGetParameter, ContentTypeGetResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/contenttype-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ContentTypeGetResponse> ContentTypeGetAsync(ContentTypeGetParameter parameter)
        {
            return await this.SendAsync<ContentTypeGetParameter, ContentTypeGetResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/contenttype-get?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ContentTypeGetResponse> ContentTypeGetAsync(ContentTypeGetParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ContentTypeGetParameter, ContentTypeGetResponse>(parameter, cancellationToken);
        }
    }
}
