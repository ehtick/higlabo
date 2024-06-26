﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/plannerbucket-list-tasks?view=graph-rest-1.0
    /// </summary>
    public partial class PlannerbucketListTasksParameter : IRestApiParameter, IQueryParameterProperty
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? Id { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Planner_Buckets_Id_Tasks: return $"/planner/buckets/{Id}/tasks";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum Field
        {
            ActiveChecklistItemCount,
            AppliedCategories,
            AssigneePriority,
            Assignments,
            BucketId,
            ChecklistItemCount,
            CompletedBy,
            CompletedDateTime,
            ConversationThreadId,
            CreatedBy,
            CreatedDateTime,
            DueDateTime,
            HasDescription,
            Id,
            OrderHint,
            PercentComplete,
            PlanId,
            PreviewType,
            Priority,
            ReferenceCount,
            StartDateTime,
            Title,
            AssignedToTaskBoardFormat,
            BucketTaskBoardFormat,
            Details,
            ProgressTaskBoardFormat,
        }
        public enum ApiPath
        {
            Planner_Buckets_Id_Tasks,
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
    public partial class PlannerbucketListTasksResponse : RestApiResponse
    {
        public PlannerTask[]? Value { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/plannerbucket-list-tasks?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/plannerbucket-list-tasks?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<PlannerbucketListTasksResponse> PlannerbucketListTasksAsync()
        {
            var p = new PlannerbucketListTasksParameter();
            return await this.SendAsync<PlannerbucketListTasksParameter, PlannerbucketListTasksResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/plannerbucket-list-tasks?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<PlannerbucketListTasksResponse> PlannerbucketListTasksAsync(CancellationToken cancellationToken)
        {
            var p = new PlannerbucketListTasksParameter();
            return await this.SendAsync<PlannerbucketListTasksParameter, PlannerbucketListTasksResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/plannerbucket-list-tasks?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<PlannerbucketListTasksResponse> PlannerbucketListTasksAsync(PlannerbucketListTasksParameter parameter)
        {
            return await this.SendAsync<PlannerbucketListTasksParameter, PlannerbucketListTasksResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/plannerbucket-list-tasks?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<PlannerbucketListTasksResponse> PlannerbucketListTasksAsync(PlannerbucketListTasksParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<PlannerbucketListTasksParameter, PlannerbucketListTasksResponse>(parameter, cancellationToken);
        }
    }
}
