﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/domain-list-domainnamereferences?view=graph-rest-1.0
    /// </summary>
    public partial class DomainListDomainnamereferencesParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? Id { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Domains_Id_DomainNameReferences: return $"/domains/{Id}/domainNameReferences";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
            DeletedDateTime,
            Id,
        }
        public enum ApiPath
        {
            Domains_Id_DomainNameReferences,
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
    public partial class DomainListDomainnamereferencesResponse : RestApiResponse
    {
        public DirectoryObject[]? Value { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/domain-list-domainnamereferences?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/domain-list-domainnamereferences?view=graph-rest-1.0
        /// </summary>
        public async Task<DomainListDomainnamereferencesResponse> DomainListDomainnamereferencesAsync()
        {
            var p = new DomainListDomainnamereferencesParameter();
            return await this.SendAsync<DomainListDomainnamereferencesParameter, DomainListDomainnamereferencesResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/domain-list-domainnamereferences?view=graph-rest-1.0
        /// </summary>
        public async Task<DomainListDomainnamereferencesResponse> DomainListDomainnamereferencesAsync(CancellationToken cancellationToken)
        {
            var p = new DomainListDomainnamereferencesParameter();
            return await this.SendAsync<DomainListDomainnamereferencesParameter, DomainListDomainnamereferencesResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/domain-list-domainnamereferences?view=graph-rest-1.0
        /// </summary>
        public async Task<DomainListDomainnamereferencesResponse> DomainListDomainnamereferencesAsync(DomainListDomainnamereferencesParameter parameter)
        {
            return await this.SendAsync<DomainListDomainnamereferencesParameter, DomainListDomainnamereferencesResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/domain-list-domainnamereferences?view=graph-rest-1.0
        /// </summary>
        public async Task<DomainListDomainnamereferencesResponse> DomainListDomainnamereferencesAsync(DomainListDomainnamereferencesParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<DomainListDomainnamereferencesParameter, DomainListDomainnamereferencesResponse>(parameter, cancellationToken);
        }
    }
}
