﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/shiftpreferences-get?view=graph-rest-1.0
/// </summary>
public partial class ShiftpreferencesGetParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? UserId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Users_UserId_Settings_ShiftPreferences: return $"/users/{UserId}/settings/shiftPreferences";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Users_UserId_Settings_ShiftPreferences,
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
public partial class ShiftpreferencesGetResponse : RestApiResponse
{
    public ShiftAvailability[]? Availability { get; set; }
    public DateTimeOffset? CreatedDateTime { get; set; }
    public String? Id { get; set; }
    public IdentitySet? LastModifiedBy { get; set; }
    public DateTimeOffset? LastModifiedDateTime { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/shiftpreferences-get?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/shiftpreferences-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ShiftpreferencesGetResponse> ShiftpreferencesGetAsync()
    {
        var p = new ShiftpreferencesGetParameter();
        return await this.SendAsync<ShiftpreferencesGetParameter, ShiftpreferencesGetResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/shiftpreferences-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ShiftpreferencesGetResponse> ShiftpreferencesGetAsync(CancellationToken cancellationToken)
    {
        var p = new ShiftpreferencesGetParameter();
        return await this.SendAsync<ShiftpreferencesGetParameter, ShiftpreferencesGetResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/shiftpreferences-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ShiftpreferencesGetResponse> ShiftpreferencesGetAsync(ShiftpreferencesGetParameter parameter)
    {
        return await this.SendAsync<ShiftpreferencesGetParameter, ShiftpreferencesGetResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/shiftpreferences-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ShiftpreferencesGetResponse> ShiftpreferencesGetAsync(ShiftpreferencesGetParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<ShiftpreferencesGetParameter, ShiftpreferencesGetResponse>(parameter, cancellationToken);
    }
}
