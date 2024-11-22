﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/projectrome-get-activities?view=graph-rest-1.0
/// </summary>
public partial class ProjectromeGetActivitiesParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Me_Activities: return $"/me/activities";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Me_Activities,
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
public partial class ProjectromeGetActivitiesResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/projectrome-get-activities?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/projectrome-get-activities?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ProjectromeGetActivitiesResponse> ProjectromeGetActivitiesAsync()
    {
        var p = new ProjectromeGetActivitiesParameter();
        return await this.SendAsync<ProjectromeGetActivitiesParameter, ProjectromeGetActivitiesResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/projectrome-get-activities?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ProjectromeGetActivitiesResponse> ProjectromeGetActivitiesAsync(CancellationToken cancellationToken)
    {
        var p = new ProjectromeGetActivitiesParameter();
        return await this.SendAsync<ProjectromeGetActivitiesParameter, ProjectromeGetActivitiesResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/projectrome-get-activities?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ProjectromeGetActivitiesResponse> ProjectromeGetActivitiesAsync(ProjectromeGetActivitiesParameter parameter)
    {
        return await this.SendAsync<ProjectromeGetActivitiesParameter, ProjectromeGetActivitiesResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/projectrome-get-activities?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ProjectromeGetActivitiesResponse> ProjectromeGetActivitiesAsync(ProjectromeGetActivitiesParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<ProjectromeGetActivitiesParameter, ProjectromeGetActivitiesResponse>(parameter, cancellationToken);
    }
}
