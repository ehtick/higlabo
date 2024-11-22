﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/application-addpassword?view=graph-rest-1.0
/// </summary>
public partial class ApplicationAddpasswordParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? Id { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Applications_Id_AddPassword: return $"/applications/{Id}/addPassword";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum ApiPath
    {
        Applications_Id_AddPassword,
    }

    public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
    string IRestApiParameter.ApiPath
    {
        get
        {
            return this.ApiPathSetting.GetApiPath();
        }
    }
    string IRestApiParameter.HttpMethod { get; } = "POST";
    public string? DisplayName { get; set; }
    public DateTimeOffset? EndDateTime { get; set; }
    public DateTimeOffset? StartDateTime { get; set; }
    public string? CustomKeyIdentifier { get; set; }
    public string? Hint { get; set; }
    public Guid? KeyId { get; set; }
    public string? SecretText { get; set; }
}
public partial class ApplicationAddpasswordResponse : RestApiResponse
{
    public string? CustomKeyIdentifier { get; set; }
    public string? DisplayName { get; set; }
    public DateTimeOffset? EndDateTime { get; set; }
    public string? Hint { get; set; }
    public Guid? KeyId { get; set; }
    public string? SecretText { get; set; }
    public DateTimeOffset? StartDateTime { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/application-addpassword?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/application-addpassword?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ApplicationAddpasswordResponse> ApplicationAddpasswordAsync()
    {
        var p = new ApplicationAddpasswordParameter();
        return await this.SendAsync<ApplicationAddpasswordParameter, ApplicationAddpasswordResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/application-addpassword?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ApplicationAddpasswordResponse> ApplicationAddpasswordAsync(CancellationToken cancellationToken)
    {
        var p = new ApplicationAddpasswordParameter();
        return await this.SendAsync<ApplicationAddpasswordParameter, ApplicationAddpasswordResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/application-addpassword?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ApplicationAddpasswordResponse> ApplicationAddpasswordAsync(ApplicationAddpasswordParameter parameter)
    {
        return await this.SendAsync<ApplicationAddpasswordParameter, ApplicationAddpasswordResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/application-addpassword?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<ApplicationAddpasswordResponse> ApplicationAddpasswordAsync(ApplicationAddpasswordParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<ApplicationAddpasswordParameter, ApplicationAddpasswordResponse>(parameter, cancellationToken);
    }
}
