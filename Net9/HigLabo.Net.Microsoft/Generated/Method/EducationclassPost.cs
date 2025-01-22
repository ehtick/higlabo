﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/educationclass-post?view=graph-rest-1.0
/// </summary>
public partial class EducationClassPostParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Education_Classes: return $"/education/classes";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum EducationClassPostParameterEducationExternalSource
    {
        Sis,
        Manual,
    }
    public enum EducationClassEducationExternalSource
    {
        Sis,
        Manual,
    }
    public enum ApiPath
    {
        Education_Classes,
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
    public string? Id { get; set; }
    public string? DisplayName { get; set; }
    public string? MailNickname { get; set; }
    public string? Description { get; set; }
    public IdentitySet? CreatedBy { get; set; }
    public string? ClassCode { get; set; }
    public string? ExternalName { get; set; }
    public string? ExternalId { get; set; }
    public EducationClassPostParameterEducationExternalSource ExternalSource { get; set; }
    public string? ExternalSourceDetail { get; set; }
    public string? Grade { get; set; }
    public EducationTerm? Term { get; set; }
    public EducationAssignment[]? Assignments { get; set; }
    public EducationCategory[]? AssignmentCategories { get; set; }
    public EducationAssignmentDefaults[]? AssignmentDefaults { get; set; }
    public EducationAssignmentSettings[]? AssignmentSettings { get; set; }
    public Group? Group { get; set; }
    public EducationUser[]? Members { get; set; }
    public EducationSchool[]? Schools { get; set; }
    public EducationUser[]? Teachers { get; set; }
}
public partial class EducationClassPostResponse : RestApiResponse
{
    public enum EducationClassEducationExternalSource
    {
        Sis,
        Manual,
    }

    public string? ClassCode { get; set; }
    public IdentitySet? CreatedBy { get; set; }
    public string? Description { get; set; }
    public string? DisplayName { get; set; }
    public string? ExternalId { get; set; }
    public EducationClassEducationExternalSource ExternalSource { get; set; }
    public string? ExternalSourceDetail { get; set; }
    public string? ExternalName { get; set; }
    public string? Grade { get; set; }
    public string? Id { get; set; }
    public string? MailNickname { get; set; }
    public EducationTerm? Term { get; set; }
    public EducationAssignment[]? Assignments { get; set; }
    public EducationCategory[]? AssignmentCategories { get; set; }
    public EducationAssignmentDefaults[]? AssignmentDefaults { get; set; }
    public EducationAssignmentSettings[]? AssignmentSettings { get; set; }
    public Group? Group { get; set; }
    public EducationUser[]? Members { get; set; }
    public EducationSchool[]? Schools { get; set; }
    public EducationUser[]? Teachers { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/educationclass-post?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/educationclass-post?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<EducationClassPostResponse> EducationClassPostAsync()
    {
        var p = new EducationClassPostParameter();
        return await this.SendAsync<EducationClassPostParameter, EducationClassPostResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/educationclass-post?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<EducationClassPostResponse> EducationClassPostAsync(CancellationToken cancellationToken)
    {
        var p = new EducationClassPostParameter();
        return await this.SendAsync<EducationClassPostParameter, EducationClassPostResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/educationclass-post?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<EducationClassPostResponse> EducationClassPostAsync(EducationClassPostParameter parameter)
    {
        return await this.SendAsync<EducationClassPostParameter, EducationClassPostResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/educationclass-post?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<EducationClassPostResponse> EducationClassPostAsync(EducationClassPostParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<EducationClassPostParameter, EducationClassPostResponse>(parameter, cancellationToken);
    }
}
