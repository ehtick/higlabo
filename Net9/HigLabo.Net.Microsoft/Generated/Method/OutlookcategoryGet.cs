﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/outlookcategory-get?view=graph-rest-1.0
/// </summary>
public partial class OutlookCategoryGetParameter : IRestApiParameter, IQueryParameterProperty
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
                case ApiPath.Me_Outlook_MasterCategories_Id: return $"/me/outlook/masterCategories/{Id}";
                case ApiPath.Users_IdOruserPrincipalName_Outlook_MasterCategories_Id: return $"/users/{IdOrUserPrincipalName}/outlook/masterCategories/{Id}";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Me_Outlook_MasterCategories_Id,
        Users_IdOruserPrincipalName_Outlook_MasterCategories_Id,
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
public partial class OutlookCategoryGetResponse : RestApiResponse
{
    public string? Color { get; set; }
    public string? DisplayName { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/outlookcategory-get?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/outlookcategory-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<OutlookCategoryGetResponse> OutlookCategoryGetAsync()
    {
        var p = new OutlookCategoryGetParameter();
        return await this.SendAsync<OutlookCategoryGetParameter, OutlookCategoryGetResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/outlookcategory-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<OutlookCategoryGetResponse> OutlookCategoryGetAsync(CancellationToken cancellationToken)
    {
        var p = new OutlookCategoryGetParameter();
        return await this.SendAsync<OutlookCategoryGetParameter, OutlookCategoryGetResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/outlookcategory-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<OutlookCategoryGetResponse> OutlookCategoryGetAsync(OutlookCategoryGetParameter parameter)
    {
        return await this.SendAsync<OutlookCategoryGetParameter, OutlookCategoryGetResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/outlookcategory-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<OutlookCategoryGetResponse> OutlookCategoryGetAsync(OutlookCategoryGetParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<OutlookCategoryGetParameter, OutlookCategoryGetResponse>(parameter, cancellationToken);
    }
}
