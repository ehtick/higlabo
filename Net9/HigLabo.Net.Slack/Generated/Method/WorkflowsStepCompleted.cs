﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Slack;

public partial class WorkflowsStepCompletedParameter : IRestApiParameter
{
    string IRestApiParameter.ApiPath { get; } = "workflows.stepCompleted";
    string IRestApiParameter.HttpMethod { get; } = "POST";
    public string? Workflow_Step_Execute_Id { get; set; }
    public object? Outputs { get; set; }
}
public partial class WorkflowsStepCompletedResponse : RestApiResponse
{
}
/// <summary>
/// https://api.slack.com/methods/workflows.stepCompleted
/// </summary>
public partial class SlackClient
{
    /// <summary>
    /// https://api.slack.com/methods/workflows.stepCompleted
    /// </summary>
    public async ValueTask<WorkflowsStepCompletedResponse> WorkflowsStepCompletedAsync(string? workflow_Step_Execute_Id)
    {
        var p = new WorkflowsStepCompletedParameter();
        p.Workflow_Step_Execute_Id = workflow_Step_Execute_Id;
        return await this.SendAsync<WorkflowsStepCompletedParameter, WorkflowsStepCompletedResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/workflows.stepCompleted
    /// </summary>
    public async ValueTask<WorkflowsStepCompletedResponse> WorkflowsStepCompletedAsync(string? workflow_Step_Execute_Id, CancellationToken cancellationToken)
    {
        var p = new WorkflowsStepCompletedParameter();
        p.Workflow_Step_Execute_Id = workflow_Step_Execute_Id;
        return await this.SendAsync<WorkflowsStepCompletedParameter, WorkflowsStepCompletedResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://api.slack.com/methods/workflows.stepCompleted
    /// </summary>
    public async ValueTask<WorkflowsStepCompletedResponse> WorkflowsStepCompletedAsync(WorkflowsStepCompletedParameter parameter)
    {
        return await this.SendAsync<WorkflowsStepCompletedParameter, WorkflowsStepCompletedResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/workflows.stepCompleted
    /// </summary>
    public async ValueTask<WorkflowsStepCompletedResponse> WorkflowsStepCompletedAsync(WorkflowsStepCompletedParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<WorkflowsStepCompletedParameter, WorkflowsStepCompletedResponse>(parameter, cancellationToken);
    }
}
