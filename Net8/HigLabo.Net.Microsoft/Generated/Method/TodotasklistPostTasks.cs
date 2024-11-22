﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/todotasklist-post-tasks?view=graph-rest-1.0
/// </summary>
public partial class TodotasklistPostTasksParameter : IRestApiParameter
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? TodoTaskListId { get; set; }
        public string? IdOrUserPrincipalName { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Me_Todo_Lists_TodoTaskListId_Tasks: return $"/me/todo/lists/{TodoTaskListId}/tasks";
                case ApiPath.Users_IdOruserPrincipalName_Todo_Lists_TodoTaskListId_Tasks: return $"/users/{IdOrUserPrincipalName}/todo/lists/{TodoTaskListId}/tasks";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum TodotasklistPostTasksParameterImportance
    {
        Low,
        Normal,
        High,
    }
    public enum TodotasklistPostTasksParameterTaskStatus
    {
        NotStarted,
        InProgress,
        Completed,
        WaitingOnOthers,
        Deferred,
    }
    public enum TodoTaskImportance
    {
        Low,
        Normal,
        High,
    }
    public enum TodoTaskTaskStatus
    {
        NotStarted,
        InProgress,
        Completed,
        WaitingOnOthers,
        Deferred,
    }
    public enum ApiPath
    {
        Me_Todo_Lists_TodoTaskListId_Tasks,
        Users_IdOruserPrincipalName_Todo_Lists_TodoTaskListId_Tasks,
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
    public ItemBody? Body { get; set; }
    public String[]? Categories { get; set; }
    public DateTimeTimeZone? CompletedDateTime { get; set; }
    public DateTimeTimeZone? DueDateTime { get; set; }
    public TodotasklistPostTasksParameterImportance Importance { get; set; }
    public bool? IsReminderOn { get; set; }
    public PatternedRecurrence? Recurrence { get; set; }
    public DateTimeTimeZone? ReminderDateTime { get; set; }
    public DateTimeTimeZone? StartDateTime { get; set; }
    public TodotasklistPostTasksParameterTaskStatus Status { get; set; }
    public string? Title { get; set; }
    public DateTimeOffset? CreatedDateTime { get; set; }
    public DateTimeOffset? LastModifiedDateTime { get; set; }
    public DateTimeOffset? BodyLastModifiedDateTime { get; set; }
    public bool? HasAttachments { get; set; }
    public TaskFileAttachment[]? Attachments { get; set; }
    public ChecklistItem[]? ChecklistItems { get; set; }
    public Extension[]? Extensions { get; set; }
    public LinkedResource[]? LinkedResources { get; set; }
}
public partial class TodotasklistPostTasksResponse : RestApiResponse
{
    public enum TodoTaskImportance
    {
        Low,
        Normal,
        High,
    }
    public enum TodoTaskTaskStatus
    {
        NotStarted,
        InProgress,
        Completed,
        WaitingOnOthers,
        Deferred,
    }

    public ItemBody? Body { get; set; }
    public DateTimeOffset? BodyLastModifiedDateTime { get; set; }
    public String[]? Categories { get; set; }
    public DateTimeTimeZone? CompletedDateTime { get; set; }
    public DateTimeOffset? CreatedDateTime { get; set; }
    public DateTimeTimeZone? DueDateTime { get; set; }
    public bool? HasAttachments { get; set; }
    public string? Id { get; set; }
    public TodoTaskImportance Importance { get; set; }
    public bool? IsReminderOn { get; set; }
    public DateTimeOffset? LastModifiedDateTime { get; set; }
    public PatternedRecurrence? Recurrence { get; set; }
    public DateTimeTimeZone? ReminderDateTime { get; set; }
    public DateTimeTimeZone? StartDateTime { get; set; }
    public TodoTaskTaskStatus Status { get; set; }
    public string? Title { get; set; }
    public TaskFileAttachment[]? Attachments { get; set; }
    public ChecklistItem[]? ChecklistItems { get; set; }
    public Extension[]? Extensions { get; set; }
    public LinkedResource[]? LinkedResources { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/todotasklist-post-tasks?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/todotasklist-post-tasks?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TodotasklistPostTasksResponse> TodotasklistPostTasksAsync()
    {
        var p = new TodotasklistPostTasksParameter();
        return await this.SendAsync<TodotasklistPostTasksParameter, TodotasklistPostTasksResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/todotasklist-post-tasks?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TodotasklistPostTasksResponse> TodotasklistPostTasksAsync(CancellationToken cancellationToken)
    {
        var p = new TodotasklistPostTasksParameter();
        return await this.SendAsync<TodotasklistPostTasksParameter, TodotasklistPostTasksResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/todotasklist-post-tasks?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TodotasklistPostTasksResponse> TodotasklistPostTasksAsync(TodotasklistPostTasksParameter parameter)
    {
        return await this.SendAsync<TodotasklistPostTasksParameter, TodotasklistPostTasksResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/todotasklist-post-tasks?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<TodotasklistPostTasksResponse> TodotasklistPostTasksAsync(TodotasklistPostTasksParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<TodotasklistPostTasksParameter, TodotasklistPostTasksResponse>(parameter, cancellationToken);
    }
}
