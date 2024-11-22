﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/workbookcommentreply-get?view=graph-rest-1.0
/// </summary>
public partial class WorkbookCommentReplyGetParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? ItemsId { get; set; }
        public string? CommentsId { get; set; }
        public string? RepliesId { get; set; }
        public string? RootItemPath { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Me_Drive_Items_Id_Workbook_Comments_Id_Replies_Id: return $"/me/drive/items/{ItemsId}/workbook/comments/{CommentsId}/replies/{RepliesId}";
                case ApiPath.Me_Drive_Root_ItemPath_Workbook_Comments_Id_Replies_Id: return $"/me/drive/root:/{RootItemPath}/workbook/comments/{CommentsId}/replies/{RepliesId}";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Me_Drive_Items_Id_Workbook_Comments_Id_Replies_Id,
        Me_Drive_Root_ItemPath_Workbook_Comments_Id_Replies_Id,
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
public partial class WorkbookCommentReplyGetResponse : RestApiResponse
{
    public string? Content { get; set; }
    public string? ContentType { get; set; }
    public string? Id { get; set; }
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/workbookcommentreply-get?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/workbookcommentreply-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorkbookCommentReplyGetResponse> WorkbookCommentReplyGetAsync()
    {
        var p = new WorkbookCommentReplyGetParameter();
        return await this.SendAsync<WorkbookCommentReplyGetParameter, WorkbookCommentReplyGetResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/workbookcommentreply-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorkbookCommentReplyGetResponse> WorkbookCommentReplyGetAsync(CancellationToken cancellationToken)
    {
        var p = new WorkbookCommentReplyGetParameter();
        return await this.SendAsync<WorkbookCommentReplyGetParameter, WorkbookCommentReplyGetResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/workbookcommentreply-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorkbookCommentReplyGetResponse> WorkbookCommentReplyGetAsync(WorkbookCommentReplyGetParameter parameter)
    {
        return await this.SendAsync<WorkbookCommentReplyGetParameter, WorkbookCommentReplyGetResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/workbookcommentreply-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<WorkbookCommentReplyGetResponse> WorkbookCommentReplyGetAsync(WorkbookCommentReplyGetParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<WorkbookCommentReplyGetParameter, WorkbookCommentReplyGetResponse>(parameter, cancellationToken);
    }
}
