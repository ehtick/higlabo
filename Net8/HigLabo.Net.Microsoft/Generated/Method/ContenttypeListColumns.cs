﻿using HigLabo.Net.OAuth;
using System.Runtime.CompilerServices;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/contenttype-list-columns?view=graph-rest-1.0
    /// </summary>
    public partial class ContentTypeListColumnsParameter : IRestApiParameter, IQueryParameterProperty
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
                    case ApiPath.Sites_SiteId_ContentTypes_ContentTypeId_Columns: return $"/sites/{SiteId}/contentTypes/{ContentTypeId}/columns";
                    case ApiPath.Sites_SiteId_Lists_ListId_ContentTypes_ContentTypeId_Columns: return $"/sites/{SiteId}/lists/{ListId}/contentTypes/{ContentTypeId}/columns";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
        }
        public enum ApiPath
        {
            Sites_SiteId_ContentTypes_ContentTypeId_Columns,
            Sites_SiteId_Lists_ListId_ContentTypes_ContentTypeId_Columns,
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
    public partial class ContentTypeListColumnsResponse : RestApiResponse<ColumnDefinition>
    {
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/contenttype-list-columns?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/contenttype-list-columns?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ContentTypeListColumnsResponse> ContentTypeListColumnsAsync()
        {
            var p = new ContentTypeListColumnsParameter();
            return await this.SendAsync<ContentTypeListColumnsParameter, ContentTypeListColumnsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/contenttype-list-columns?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ContentTypeListColumnsResponse> ContentTypeListColumnsAsync(CancellationToken cancellationToken)
        {
            var p = new ContentTypeListColumnsParameter();
            return await this.SendAsync<ContentTypeListColumnsParameter, ContentTypeListColumnsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/contenttype-list-columns?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ContentTypeListColumnsResponse> ContentTypeListColumnsAsync(ContentTypeListColumnsParameter parameter)
        {
            return await this.SendAsync<ContentTypeListColumnsParameter, ContentTypeListColumnsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/contenttype-list-columns?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<ContentTypeListColumnsResponse> ContentTypeListColumnsAsync(ContentTypeListColumnsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<ContentTypeListColumnsParameter, ContentTypeListColumnsResponse>(parameter, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/contenttype-list-columns?view=graph-rest-1.0
        /// </summary>
        public async IAsyncEnumerable<ColumnDefinition> ContentTypeListColumnsEnumerateAsync(ContentTypeListColumnsParameter parameter, [EnumeratorCancellation] CancellationToken cancellationToken)
        {
            var res = await this.SendAsync<ContentTypeListColumnsParameter, ContentTypeListColumnsResponse>(parameter, cancellationToken);
            if (res.Value != null)
            {
                foreach (var item in res.Value)
                {
                    yield return item;
                }
                if (res.ODataNextLink.HasValue())
                {
                    await foreach (var item in this.GetValueListAsync<ColumnDefinition>(res.ODataNextLink, cancellationToken))
                    {
                        yield return item;
                    }
                }
            }
        }
    }
}
