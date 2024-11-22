﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/singlevaluelegacyextendedproperty-get?view=graph-rest-1.0
/// </summary>
public partial class SinglevaluelegacyextendedpropertyGetParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? Id { get; set; }
        public string? IdOrUserPrincipalName { get; set; }
        public string? MailFoldersId { get; set; }
        public string? MessagesId { get; set; }
        public string? ContactFoldersId { get; set; }
        public string? ContactsId { get; set; }
        public string? UsersIdOrUserPrincipalName { get; set; }
        public string? GroupsId { get; set; }
        public string? EventsId { get; set; }
        public string? ThreadsId { get; set; }
        public string? PostsId { get; set; }
        public string? ConversationsId { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Me_Messages_Id: return $"/me/messages/{Id}";
                case ApiPath.Users_IdOruserPrincipalName_Messages_Id: return $"/users/{IdOrUserPrincipalName}/messages/{Id}";
                case ApiPath.Me_MailFolders_Id_Messages_Id: return $"/me/mailFolders/{MailFoldersId}/messages/{MessagesId}";
                case ApiPath.Me_MailFolders_Id: return $"/me/mailFolders/{Id}";
                case ApiPath.Users_IdOruserPrincipalName_MailFolders_Id: return $"/users/{IdOrUserPrincipalName}/mailFolders/{Id}";
                case ApiPath.Me_Events_Id: return $"/me/events/{Id}";
                case ApiPath.Users_IdOruserPrincipalName_Events_Id: return $"/users/{IdOrUserPrincipalName}/events/{Id}";
                case ApiPath.Me_Calendars_Id: return $"/me/calendars/{Id}";
                case ApiPath.Users_IdOruserPrincipalName_Calendars_Id: return $"/users/{IdOrUserPrincipalName}/calendars/{Id}";
                case ApiPath.Me_Contacts_Id: return $"/me/contacts/{Id}";
                case ApiPath.Users_IdOruserPrincipalName_Contacts_Id: return $"/users/{IdOrUserPrincipalName}/contacts/{Id}";
                case ApiPath.Me_ContactFolders_Id_Contacts_Id: return $"/me/contactFolders/{ContactFoldersId}/contacts/{ContactsId}";
                case ApiPath.Users_IdOruserPrincipalName_ContactFolders_Id_Contacts_Id: return $"/users/{UsersIdOrUserPrincipalName}/contactFolders/{ContactFoldersId}/contacts/{ContactsId}";
                case ApiPath.Me_Contactfolders_Id: return $"/me/contactfolders/{Id}";
                case ApiPath.Users_IdOruserPrincipalName_ContactFolders_Id: return $"/users/{IdOrUserPrincipalName}/contactFolders/{Id}";
                case ApiPath.Groups_Id_Events_Id: return $"/groups/{GroupsId}/events/{EventsId}";
                case ApiPath.Groups_Id_Threads_Id_Posts_Id: return $"/groups/{GroupsId}/threads/{ThreadsId}/posts/{PostsId}";
                case ApiPath.Groups_Id_Conversations_Id_Threads_Id_Posts_Id: return $"/groups/{GroupsId}/conversations/{ConversationsId}/threads/{ThreadsId}/posts/{PostsId}";
                case ApiPath.Me_Messages: return $"/me/messages";
                case ApiPath.Users_IdOruserPrincipalName_Messages: return $"/users/{IdOrUserPrincipalName}/messages";
                case ApiPath.Me_MailFolders_Id_Messages: return $"/me/mailFolders/{Id}/messages";
                case ApiPath.Me_MailFolders: return $"/me/mailFolders";
                case ApiPath.Users_IdOruserPrincipalName_MailFolders: return $"/users/{IdOrUserPrincipalName}/mailFolders";
                case ApiPath.Me_Events: return $"/me/events";
                case ApiPath.Users_IdOruserPrincipalName_Events: return $"/users/{IdOrUserPrincipalName}/events";
                case ApiPath.Me_Calendars: return $"/me/calendars";
                case ApiPath.Users_IdOruserPrincipalName_Calendars: return $"/users/{IdOrUserPrincipalName}/calendars";
                case ApiPath.Me_Contacts: return $"/me/contacts";
                case ApiPath.Users_IdOruserPrincipalName_Contacts: return $"/users/{IdOrUserPrincipalName}/contacts";
                case ApiPath.Me_ContactFolders_Id_Contacts: return $"/me/contactFolders/{Id}/contacts";
                case ApiPath.Users_IdOruserPrincipalName_ContactFolders_Id_Contacts: return $"/users/{IdOrUserPrincipalName}/contactFolders/{Id}/contacts";
                case ApiPath.Me_Contactfolders: return $"/me/contactfolders";
                case ApiPath.Users_IdOruserPrincipalName_ContactFolders: return $"/users/{IdOrUserPrincipalName}/contactFolders";
                case ApiPath.Groups_Id_Events: return $"/groups/{Id}/events";
                case ApiPath.Groups_Id_Threads_Id_Posts: return $"/groups/{GroupsId}/threads/{ThreadsId}/posts";
                case ApiPath.Groups_Id_Conversations_Id_Threads_Id_Posts: return $"/groups/{GroupsId}/conversations/{ConversationsId}/threads/{ThreadsId}/posts";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Me_Messages_Id,
        Users_IdOruserPrincipalName_Messages_Id,
        Me_MailFolders_Id_Messages_Id,
        Me_MailFolders_Id,
        Users_IdOruserPrincipalName_MailFolders_Id,
        Me_Events_Id,
        Users_IdOruserPrincipalName_Events_Id,
        Me_Calendars_Id,
        Users_IdOruserPrincipalName_Calendars_Id,
        Me_Contacts_Id,
        Users_IdOruserPrincipalName_Contacts_Id,
        Me_ContactFolders_Id_Contacts_Id,
        Users_IdOruserPrincipalName_ContactFolders_Id_Contacts_Id,
        Me_Contactfolders_Id,
        Users_IdOruserPrincipalName_ContactFolders_Id,
        Groups_Id_Events_Id,
        Groups_Id_Threads_Id_Posts_Id,
        Groups_Id_Conversations_Id_Threads_Id_Posts_Id,
        Me_Messages,
        Users_IdOruserPrincipalName_Messages,
        Me_MailFolders_Id_Messages,
        Me_MailFolders,
        Users_IdOruserPrincipalName_MailFolders,
        Me_Events,
        Users_IdOruserPrincipalName_Events,
        Me_Calendars,
        Users_IdOruserPrincipalName_Calendars,
        Me_Contacts,
        Users_IdOruserPrincipalName_Contacts,
        Me_ContactFolders_Id_Contacts,
        Users_IdOruserPrincipalName_ContactFolders_Id_Contacts,
        Me_Contactfolders,
        Users_IdOruserPrincipalName_ContactFolders,
        Groups_Id_Events,
        Groups_Id_Threads_Id_Posts,
        Groups_Id_Conversations_Id_Threads_Id_Posts,
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
public partial class SinglevaluelegacyextendedpropertyGetResponse : RestApiResponse
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/singlevaluelegacyextendedproperty-get?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/singlevaluelegacyextendedproperty-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<SinglevaluelegacyextendedpropertyGetResponse> SinglevaluelegacyextendedpropertyGetAsync()
    {
        var p = new SinglevaluelegacyextendedpropertyGetParameter();
        return await this.SendAsync<SinglevaluelegacyextendedpropertyGetParameter, SinglevaluelegacyextendedpropertyGetResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/singlevaluelegacyextendedproperty-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<SinglevaluelegacyextendedpropertyGetResponse> SinglevaluelegacyextendedpropertyGetAsync(CancellationToken cancellationToken)
    {
        var p = new SinglevaluelegacyextendedpropertyGetParameter();
        return await this.SendAsync<SinglevaluelegacyextendedpropertyGetParameter, SinglevaluelegacyextendedpropertyGetResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/singlevaluelegacyextendedproperty-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<SinglevaluelegacyextendedpropertyGetResponse> SinglevaluelegacyextendedpropertyGetAsync(SinglevaluelegacyextendedpropertyGetParameter parameter)
    {
        return await this.SendAsync<SinglevaluelegacyextendedpropertyGetParameter, SinglevaluelegacyextendedpropertyGetResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/singlevaluelegacyextendedproperty-get?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<SinglevaluelegacyextendedpropertyGetResponse> SinglevaluelegacyextendedpropertyGetAsync(SinglevaluelegacyextendedpropertyGetParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<SinglevaluelegacyextendedpropertyGetParameter, SinglevaluelegacyextendedpropertyGetResponse>(parameter, cancellationToken);
    }
}
