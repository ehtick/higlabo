﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/todotask-list-checklistitems?view=graph-rest-1.0
    /// </summary>
    public partial class TodotaskListChecklistitemsParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? TodoTaskListId { get; set; }
            public string? TodoTaskId { get; set; }
            public string? IdOrUserPrincipalName { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Me_Todo_Lists_TodoTaskListId_Tasks_TodoTaskId_ChecklistItems: return $"/me/todo/lists/{TodoTaskListId}/tasks/{TodoTaskId}/checklistItems";
                    case ApiPath.Users_IdOrUserPrincipalName_Todo_Lists_TodoTaskListId_Tasks_TodoTaskId_ChecklistItems: return $"/users/{IdOrUserPrincipalName}/todo/lists/{TodoTaskListId}/tasks/{TodoTaskId}/checklistItems";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
            CheckedDateTime,
            CreatedDateTime,
            DisplayName,
            Id,
            IsChecked,
        }
        public enum ApiPath
        {
            Me_Todo_Lists_TodoTaskListId_Tasks_TodoTaskId_ChecklistItems,
            Users_IdOrUserPrincipalName_Todo_Lists_TodoTaskListId_Tasks_TodoTaskId_ChecklistItems,
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
    public partial class TodotaskListChecklistitemsResponse : RestApiResponse
    {
        public ChecklistItem[]? Value { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/todotask-list-checklistitems?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/todotask-list-checklistitems?view=graph-rest-1.0
        /// </summary>
        public async Task<TodotaskListChecklistitemsResponse> TodotaskListChecklistitemsAsync()
        {
            var p = new TodotaskListChecklistitemsParameter();
            return await this.SendAsync<TodotaskListChecklistitemsParameter, TodotaskListChecklistitemsResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/todotask-list-checklistitems?view=graph-rest-1.0
        /// </summary>
        public async Task<TodotaskListChecklistitemsResponse> TodotaskListChecklistitemsAsync(CancellationToken cancellationToken)
        {
            var p = new TodotaskListChecklistitemsParameter();
            return await this.SendAsync<TodotaskListChecklistitemsParameter, TodotaskListChecklistitemsResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/todotask-list-checklistitems?view=graph-rest-1.0
        /// </summary>
        public async Task<TodotaskListChecklistitemsResponse> TodotaskListChecklistitemsAsync(TodotaskListChecklistitemsParameter parameter)
        {
            return await this.SendAsync<TodotaskListChecklistitemsParameter, TodotaskListChecklistitemsResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/todotask-list-checklistitems?view=graph-rest-1.0
        /// </summary>
        public async Task<TodotaskListChecklistitemsResponse> TodotaskListChecklistitemsAsync(TodotaskListChecklistitemsParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<TodotaskListChecklistitemsParameter, TodotaskListChecklistitemsResponse>(parameter, cancellationToken);
        }
    }
}
