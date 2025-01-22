﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/userflowlanguagepage-put?view=graph-rest-1.0
/// </summary>
public partial class UserflowlanguagepagePutParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? B2xUserFlowsId { get; set; }
        public string? LanguagesId { get; set; }
        public string? OverridesPagesId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Identity_B2xUserFlows_Id_Languages_Id_OverridesPages_Id_value: return $"/identity/b2xUserFlows/{B2xUserFlowsId}/languages/{LanguagesId}/overridesPages/{OverridesPagesId}/$value";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Identity_B2xUserFlows_Id_Languages_Id_OverridesPages_Id_value,
    }

    public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
    string IRestApiParameter.ApiPath
    {
        get
        {
            return this.ApiPathSetting.GetApiPath();
        }
    }
    string IRestApiParameter.HttpMethod { get; } = "PUT";
}
public partial class UserflowlanguagepagePutResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/userflowlanguagepage-put?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/userflowlanguagepage-put?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<UserflowlanguagepagePutResponse> UserflowlanguagepagePutAsync()
    {
        var p = new UserflowlanguagepagePutParameter();
        return await this.SendAsync<UserflowlanguagepagePutParameter, UserflowlanguagepagePutResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/userflowlanguagepage-put?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<UserflowlanguagepagePutResponse> UserflowlanguagepagePutAsync(CancellationToken cancellationToken)
    {
        var p = new UserflowlanguagepagePutParameter();
        return await this.SendAsync<UserflowlanguagepagePutParameter, UserflowlanguagepagePutResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/userflowlanguagepage-put?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<UserflowlanguagepagePutResponse> UserflowlanguagepagePutAsync(UserflowlanguagepagePutParameter parameter)
    {
        return await this.SendAsync<UserflowlanguagepagePutParameter, UserflowlanguagepagePutResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/userflowlanguagepage-put?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<UserflowlanguagepagePutResponse> UserflowlanguagepagePutAsync(UserflowlanguagepagePutParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<UserflowlanguagepagePutParameter, UserflowlanguagepagePutResponse>(parameter, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/userflowlanguagepage-put?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<Stream> UserflowlanguagepagePutStreamAsync(UserflowlanguagepagePutParameter parameter, CancellationToken cancellationToken)
    {
        return await this.DownloadStreamAsync(parameter, cancellationToken);
    }
}
