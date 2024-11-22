﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/educationschool-post-classes?view=graph-rest-1.0
/// </summary>
public partial class EducationSchoolPostClassesParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? Id { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Education_Schools_Id_Classes_ref: return $"/education/schools/{Id}/classes/$ref";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum EducationClassEducationExternalSource
    {
        Sis,
        Manual,
    }
    public enum ApiPath
    {
        Education_Schools_Id_Classes_ref,
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
public partial class EducationSchoolPostClassesResponse : RestApiResponse
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
/// https://learn.microsoft.com/en-us/graph/api/educationschool-post-classes?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/educationschool-post-classes?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<EducationSchoolPostClassesResponse> EducationSchoolPostClassesAsync()
    {
        var p = new EducationSchoolPostClassesParameter();
        return await this.SendAsync<EducationSchoolPostClassesParameter, EducationSchoolPostClassesResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/educationschool-post-classes?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<EducationSchoolPostClassesResponse> EducationSchoolPostClassesAsync(CancellationToken cancellationToken)
    {
        var p = new EducationSchoolPostClassesParameter();
        return await this.SendAsync<EducationSchoolPostClassesParameter, EducationSchoolPostClassesResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/educationschool-post-classes?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<EducationSchoolPostClassesResponse> EducationSchoolPostClassesAsync(EducationSchoolPostClassesParameter parameter)
    {
        return await this.SendAsync<EducationSchoolPostClassesParameter, EducationSchoolPostClassesResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/educationschool-post-classes?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<EducationSchoolPostClassesResponse> EducationSchoolPostClassesAsync(EducationSchoolPostClassesParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<EducationSchoolPostClassesParameter, EducationSchoolPostClassesResponse>(parameter, cancellationToken);
    }
}
