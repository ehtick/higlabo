﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Slack;

public partial class DialogOpenParameter : IRestApiParameter
{
    string IRestApiParameter.ApiPath { get; } = "dialog.open";
    string IRestApiParameter.HttpMethod { get; } = "POST";
    public string? Dialog { get; set; }
    public string? Trigger_Id { get; set; }
}
public partial class DialogOpenResponse : RestApiResponse
{
}
/// <summary>
/// https://api.slack.com/methods/dialog.open
/// </summary>
public partial class SlackClient
{
    /// <summary>
    /// https://api.slack.com/methods/dialog.open
    /// </summary>
    public async ValueTask<DialogOpenResponse> DialogOpenAsync(string? dialog, string? trigger_Id)
    {
        var p = new DialogOpenParameter();
        p.Dialog = dialog;
        p.Trigger_Id = trigger_Id;
        return await this.SendAsync<DialogOpenParameter, DialogOpenResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/dialog.open
    /// </summary>
    public async ValueTask<DialogOpenResponse> DialogOpenAsync(string? dialog, string? trigger_Id, CancellationToken cancellationToken)
    {
        var p = new DialogOpenParameter();
        p.Dialog = dialog;
        p.Trigger_Id = trigger_Id;
        return await this.SendAsync<DialogOpenParameter, DialogOpenResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://api.slack.com/methods/dialog.open
    /// </summary>
    public async ValueTask<DialogOpenResponse> DialogOpenAsync(DialogOpenParameter parameter)
    {
        return await this.SendAsync<DialogOpenParameter, DialogOpenResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://api.slack.com/methods/dialog.open
    /// </summary>
    public async ValueTask<DialogOpenResponse> DialogOpenAsync(DialogOpenParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<DialogOpenParameter, DialogOpenResponse>(parameter, cancellationToken);
    }
}
