﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/educationclass-post-assignment?view=graph-rest-1.0
/// </summary>
public partial class EducationclassPostAssignmentParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? ClassId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Education_Classes_ClassId_Assignments: return $"/education/classes/{ClassId}/assignments";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum EducationAssignmentEducationAddToCalendarOptions
    {
        None,
        StudentsAndPublisher,
        StudentsAndTeamOwners,
        UnknownFutureValue,
        StudentsOnly,
    }
    public enum EducationAssignmentstring
    {
        Draft,
        Scheduled,
        Published,
        Assigned,
    }
    public enum ApiPath
    {
        Education_Classes_ClassId_Assignments,
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
    public string? AddedStudentAction { get; set; }
    public EducationAssignmentEducationAddToCalendarOptions AddToCalendarAction { get; set; }
    public bool? AllowLateSubmissions { get; set; }
    public bool? AllowStudentsToAddResourcesToSubmission { get; set; }
    public DateTimeOffset? AssignDateTime { get; set; }
    public EducationAssignmentRecipient? AssignTo { get; set; }
    public DateTimeOffset? AssignedDateTime { get; set; }
    public string? ClassId { get; set; }
    public DateTimeOffset? CloseDateTime { get; set; }
    public IdentitySet? CreatedBy { get; set; }
    public DateTimeOffset? CreatedDateTime { get; set; }
    public string? DisplayName { get; set; }
    public DateTimeOffset? DueDateTime { get; set; }
    public string? FeedbackResourcesFolderUrl { get; set; }
    public EducationAssignmentGradeType? Grading { get; set; }
    public string? Id { get; set; }
    public ItemBody? Instructions { get; set; }
    public IdentitySet? LastModifiedBy { get; set; }
    public DateTimeOffset? LastModifiedDateTime { get; set; }
    public string? NotificationChannelUrl { get; set; }
    public string? ResourcesFolderUrl { get; set; }
    public EducationAssignmentstring Status { get; set; }
    public string? WebUrl { get; set; }
    public EducationCategory[]? Categories { get; set; }
    public EducationAssignmentResource[]? Resources { get; set; }
    public EducationRubric? Rubric { get; set; }
    public EducationSubmission[]? Submissions { get; set; }
}
public partial class EducationclassPostAssignmentResponse : RestApiResponse
{
    public enum EducationAssignmentEducationAddToCalendarOptions
    {
        None,
        StudentsAndPublisher,
        StudentsAndTeamOwners,
        UnknownFutureValue,
        StudentsOnly,
    }
    public enum EducationAssignmentstring
    {
        Draft,
        Scheduled,
        Published,
        Assigned,
    }

    public string? AddedStudentAction { get; set; }
    public EducationAssignmentEducationAddToCalendarOptions AddToCalendarAction { get; set; }
    public bool? AllowLateSubmissions { get; set; }
    public bool? AllowStudentsToAddResourcesToSubmission { get; set; }
    public DateTimeOffset? AssignDateTime { get; set; }
    public EducationAssignmentRecipient? AssignTo { get; set; }
    public DateTimeOffset? AssignedDateTime { get; set; }
    public string? ClassId { get; set; }
    public DateTimeOffset? CloseDateTime { get; set; }
    public IdentitySet? CreatedBy { get; set; }
    public DateTimeOffset? CreatedDateTime { get; set; }
    public string? DisplayName { get; set; }
    public DateTimeOffset? DueDateTime { get; set; }
    public string? FeedbackResourcesFolderUrl { get; set; }
    public EducationAssignmentGradeType? Grading { get; set; }
    public string? Id { get; set; }
    public ItemBody? Instructions { get; set; }
    public IdentitySet? LastModifiedBy { get; set; }
    public DateTimeOffset? LastModifiedDateTime { get; set; }
    public string? NotificationChannelUrl { get; set; }
    public string? ResourcesFolderUrl { get; set; }
    public EducationAssignmentstring Status { get; set; }
    public string? WebUrl { get; set; }
    public EducationCategory[]? Categories { get; set; }
    public EducationAssignmentResource[]? Resources { get; set; }
    public EducationRubric? Rubric { get; set; }
    public EducationSubmission[]? Submissions { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/educationclass-post-assignment?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/educationclass-post-assignment?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<EducationclassPostAssignmentResponse> EducationclassPostAssignmentAsync()
    {
        var p = new EducationclassPostAssignmentParameter();
        return await this.SendAsync<EducationclassPostAssignmentParameter, EducationclassPostAssignmentResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/educationclass-post-assignment?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<EducationclassPostAssignmentResponse> EducationclassPostAssignmentAsync(CancellationToken cancellationToken)
    {
        var p = new EducationclassPostAssignmentParameter();
        return await this.SendAsync<EducationclassPostAssignmentParameter, EducationclassPostAssignmentResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/educationclass-post-assignment?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<EducationclassPostAssignmentResponse> EducationclassPostAssignmentAsync(EducationclassPostAssignmentParameter parameter)
    {
        return await this.SendAsync<EducationclassPostAssignmentParameter, EducationclassPostAssignmentResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/educationclass-post-assignment?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<EducationclassPostAssignmentResponse> EducationclassPostAssignmentAsync(EducationclassPostAssignmentParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<EducationclassPostAssignmentParameter, EducationclassPostAssignmentResponse>(parameter, cancellationToken);
    }
}
